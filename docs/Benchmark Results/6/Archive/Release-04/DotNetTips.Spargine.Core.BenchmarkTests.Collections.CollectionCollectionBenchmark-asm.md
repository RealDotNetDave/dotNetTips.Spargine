## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rcx,1A9F4BC9BD0
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
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9B75440
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FFF7F509888]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F509900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F27BD68]
       mov       rdi,rax
       mov       rcx,1E6D7008BE8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFF7F27BEA0]
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
       call      qword ptr [7FFF7F27B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F27BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F27D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F04FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFF7EEC3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F27BAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7F27D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7F075750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFF7EF57918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rcx,155A6209BD0
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
       mov       rdx,7FF7B9B65440
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF7B9B65440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9B65440
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FFF7F519B88]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F519C00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F28BD68]
       mov       rdi,rax
       mov       rcx,23FE3C08BE8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFF7F28BEA0]
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
       call      qword ptr [7FFF7F28B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F28BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F28D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F05FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFF7EED3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F28BAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7F28D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7F085750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFF7EF67918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rcx,2CEE21417F0
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
       mov       rdx,7FF7B9BA5440
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF7B9BA5440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9BA5440
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FFF7F4F7888]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F4F7900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F26BD68]
       mov       rdi,rax
       mov       rcx,296CC806BF0
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFF7F26BEA0]
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
       call      qword ptr [7FFF7F26B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFF7EEB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F26BAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7F065750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFF7EF47918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rcx,1DE47DB9BD0
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
       mov       rdx,7FF7B9BA5440
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF7B9BA5440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9BA5440
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FFF7F4E9888]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F4E9900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F25BD68]
       mov       rdi,rax
       mov       rcx,16963808BE8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFF7F25BEA0]
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
       call      qword ptr [7FFF7F25B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F25BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F25D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F02FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFF7EEA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F25BAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7F25D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7F055750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFF7EF37918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rcx,182C5DD9BD0
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
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9B75440
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FFF7F4F9888]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F4F9900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F26BD68]
       mov       rdi,rax
       mov       rcx,24BF1008BE8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFF7F26BEA0]
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
       call      qword ptr [7FFF7F26B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFF7EEB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F26BAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7F065750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFF7EF47918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rcx,2091F3657C8
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
       mov       rdx,7FF7B9BA5440
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF7B9BA5440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9BA5440
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FFF7F4F9888]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F4F9900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F26BD68]
       mov       rdi,rax
       mov       rcx,1C3E8408BE8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFF7F26BEA0]
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
       call      qword ptr [7FFF7F26B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFF7EEB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F26BAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7F065750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFF7EF47918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rcx,20657119BD0
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
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9B95440
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FFF7F4E9888]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F4E9900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F25BD68]
       mov       rdi,rax
       mov       rcx,1CCD5C08BE8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFF7F25BEA0]
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
       call      qword ptr [7FFF7F25B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F25BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F25D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F02FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFF7EEA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F25BAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7F25D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7F055750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFF7EF37918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rcx,1984A8A17F0
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
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9B75440
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FFF7F527888]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F527900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F29BD68]
       mov       rdi,rax
       mov       rcx,27EFD808BE8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFF7F29BEA0]
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
       call      qword ptr [7FFF7F29B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F29BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F29D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F06FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFF7EEE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F29BAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7F29D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7F095750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFF7EF77918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rcx,1BFFA575BF8
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
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9B75440
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FFF7F4E9B88]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F4E9C00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F25BD68]
       mov       rdi,rax
       mov       rcx,1F082008BE8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFF7F25BEA0]
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
       call      qword ptr [7FFF7F25B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F25BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F25D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F02FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFF7EEA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F25BAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7F25D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7F055750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFF7EF37918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF7B9F75CA0
       mov       rdx,7FF7B9F75CA0
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
       mov       rdx,7FF7B9F75CA0
       mov       rdx,7FF7B9F75CA0
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
       mov       rdx,7FF7B9F75F28
       mov       rdx,7FF7B9F75F28
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
       mov       rdx,7FF7B9F75CA0
       mov       rdx,7FF7B9F75CA0
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
       mov       rdx,7FF7B9F75CE0
       mov       rdx,7FF7B9F75CE0
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
       mov       rdx,7FF7B9F75D00
       mov       rdx,7FF7B9F75D00
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
       mov       r11,7FF7B98C0888
       mov       r11,7FF7B98C0888
       call      qword ptr [7FF7B98C0888]
       call      qword ptr [7FF7B98C0888]
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
       mov       rdx,7FF7B9F75D18
       mov       rdx,7FF7B9F75D18
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
       mov       r11,7FF7B98C0888
       mov       r11,7FF7B98C0888
       call      qword ptr [7FF7B98C0888]
       call      qword ptr [7FF7B98C0888]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FF7B98C0890
       mov       r11,7FF7B98C0890
       call      qword ptr [7FF7B98C0890]
       call      qword ptr [7FF7B98C0890]
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
       mov       rcx,1C8EAEBA708
       mov       rcx,1C8EAEBA708
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,1C8EAEB3090
       mov       rdx,1C8EAEB3090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,1C8EAEB3020
       mov       rdx,1C8EAEB3020
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
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
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
       mov       rax,1C8EAEBA710
       mov       rax,1C8EAEBA710
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
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
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
       mov       r11,7FF7B98C0890
       mov       r11,7FF7B98C0890
       call      qword ptr [7FF7B98C0890]
       call      qword ptr [7FF7B98C0890]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F5278B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F529240]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F29BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,186FE0116F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EF299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,186FE002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EF299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,186FE002028
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
       call      qword ptr [7FFF7EDB8CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF7F29BBE8]
       mov       r15,rax
       mov       rcx,186FE011700
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFF7F29BEA0]
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
       call      qword ptr [7FFF7F29B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F29BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F29D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F06FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFF7EEE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F29BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7F29D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F095750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFF7EF77900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFF7F509CE8
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
       mov       rdx,7FFF7F509CE8
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
       mov       rdx,7FFF7F509F48
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
       mov       rcx,7FFF7F5269A8
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFF7F509CE8
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
       mov       rdx,7FFF7F509D28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFF7F213318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFF7F509D48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFF7ECA0880
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
       mov       rdx,7FFF7F509D60
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
       call      qword ptr [7FFF7F527840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFF7EF77A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFF7ECA0880
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFF7ECA0888
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
       call      qword ptr [7FFF7F091C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F091C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFF7F29BEA0]
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
       call      qword ptr [7FFF7F29B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F29BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F29D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F06FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F29BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F06FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFF7EC94000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7F06FF90]
       int       3
M01_L32:
       call      qword ptr [7FFF7EE4B630]
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
       mov       r11,7FFF7ECA0888
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF7B9F75CA0
       mov       rdx,7FF7B9F75CA0
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
       mov       rdx,7FF7B9F75CA0
       mov       rdx,7FF7B9F75CA0
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
       mov       rdx,7FF7B9F75F28
       mov       rdx,7FF7B9F75F28
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
       mov       rdx,7FF7B9F75CA0
       mov       rdx,7FF7B9F75CA0
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
       mov       rdx,7FF7B9F75CE0
       mov       rdx,7FF7B9F75CE0
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
       mov       rdx,7FF7B9F75D00
       mov       rdx,7FF7B9F75D00
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
       mov       r11,7FF7B98C0888
       mov       r11,7FF7B98C0888
       call      qword ptr [7FF7B98C0888]
       call      qword ptr [7FF7B98C0888]
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
       mov       rdx,7FF7B9F75D18
       mov       rdx,7FF7B9F75D18
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
       mov       r11,7FF7B98C0888
       mov       r11,7FF7B98C0888
       call      qword ptr [7FF7B98C0888]
       call      qword ptr [7FF7B98C0888]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FF7B98C0890
       mov       r11,7FF7B98C0890
       call      qword ptr [7FF7B98C0890]
       call      qword ptr [7FF7B98C0890]
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
       mov       rcx,1D2F2B0A708
       mov       rcx,1D2F2B0A708
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,1D2F2B03090
       mov       rdx,1D2F2B03090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,1D2F2B03020
       mov       rdx,1D2F2B03020
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
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
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
       mov       rax,1D2F2B0A710
       mov       rax,1D2F2B0A710
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
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
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
       mov       r11,7FF7B98C0890
       mov       r11,7FF7B98C0890
       call      qword ptr [7FF7B98C0890]
       call      qword ptr [7FF7B98C0890]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F519BB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F51B4E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F28BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,20CC4409B18
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EF199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,20CC8402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EF199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,20CC8402028
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
       call      qword ptr [7FFF7EDA8CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF7F28BBE8]
       mov       r15,rax
       mov       rcx,20CC4409B20
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFF7F28BEA0]
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
       call      qword ptr [7FFF7F28B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F28BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F28D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F05FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFF7EED3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F28BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7F28D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F085750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFF7EF67900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFF7F4F9CE8
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
       mov       rdx,7FFF7F4F9CE8
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
       mov       rdx,7FFF7F4F9F48
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
       mov       rcx,7FFF7F518CA8
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFF7F4F9CE8
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
       mov       rdx,7FFF7F4F9D28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFF7F203318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFF7F4F9D48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFF7EC90870
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
       mov       rdx,7FFF7F4F9D60
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
       call      qword ptr [7FFF7F519B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFF7EF67A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFF7EC90870
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFF7EC90878
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
       call      qword ptr [7FFF7F081C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFF7F28BEA0]
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
       call      qword ptr [7FFF7F28B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F28BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F28D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F05FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EED3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F28BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F05FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFF7EC84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7F05FF90]
       int       3
M01_L32:
       call      qword ptr [7FFF7EE3B630]
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
       mov       r11,7FFF7EC90878
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF7B9F95CA0
       mov       rdx,7FF7B9F95CA0
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
       mov       rdx,7FF7B9F95CA0
       mov       rdx,7FF7B9F95CA0
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
       mov       rdx,7FF7B9F95F28
       mov       rdx,7FF7B9F95F28
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
       mov       rdx,7FF7B9F95CA0
       mov       rdx,7FF7B9F95CA0
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
       mov       rdx,7FF7B9F95CE0
       mov       rdx,7FF7B9F95CE0
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
       mov       rdx,7FF7B9F95D00
       mov       rdx,7FF7B9F95D00
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
       mov       r11,7FF7B98E0888
       mov       r11,7FF7B98E0888
       call      qword ptr [7FF7B98E0888]
       call      qword ptr [7FF7B98E0888]
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
       mov       rdx,7FF7B9F95D18
       mov       rdx,7FF7B9F95D18
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
       mov       r11,7FF7B98E0888
       mov       r11,7FF7B98E0888
       call      qword ptr [7FF7B98E0888]
       call      qword ptr [7FF7B98E0888]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FF7B98E0890
       mov       r11,7FF7B98E0890
       call      qword ptr [7FF7B98E0890]
       call      qword ptr [7FF7B98E0890]
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
       mov       rcx,2747415A708
       mov       rcx,2747415A708
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,27474153090
       mov       rdx,27474153090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,27474153020
       mov       rdx,27474153020
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
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
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
       mov       rax,2747415A710
       mov       rax,2747415A710
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
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
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
       mov       r11,7FF7B98E0890
       mov       r11,7FF7B98E0890
       call      qword ptr [7FF7B98E0890]
       call      qword ptr [7FF7B98E0890]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F4E98B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F4EB240]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F25BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,177568116F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EEE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,17756802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EEE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,17756802028
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
       call      qword ptr [7FFF7ED78CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF7F25BBE8]
       mov       r15,rax
       mov       rcx,17756811700
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFF7F25BEA0]
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
       call      qword ptr [7FFF7F25B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F25BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F25D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F02FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFF7EEA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F25BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7F25D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F055750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFF7EF37900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFF7F4C9CE8
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
       mov       rdx,7FFF7F4C9CE8
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
       mov       rdx,7FFF7F4C9F48
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
       mov       rcx,7FFF7F4E89A8
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFF7F4C9CE8
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
       mov       rdx,7FFF7F4C9D28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFF7F1D3318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFF7F4C9D48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFF7EC60870
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
       mov       rdx,7FFF7F4C9D60
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
       call      qword ptr [7FFF7F4E9840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFF7EF37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFF7EC60870
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFF7EC60878
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
       call      qword ptr [7FFF7F051C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F051C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFF7F25BEA0]
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
       call      qword ptr [7FFF7F25B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F25BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F25D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F02FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F25BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F02FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFF7EC54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7F02FF90]
       int       3
M01_L32:
       call      qword ptr [7FFF7EE0B630]
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
       mov       r11,7FFF7EC60878
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF7B9F95CA0
       mov       rdx,7FF7B9F95CA0
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
       mov       rdx,7FF7B9F95CA0
       mov       rdx,7FF7B9F95CA0
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
       mov       rdx,7FF7B9F95F28
       mov       rdx,7FF7B9F95F28
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
       mov       rdx,7FF7B9F95CA0
       mov       rdx,7FF7B9F95CA0
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
       mov       rdx,7FF7B9F95CE0
       mov       rdx,7FF7B9F95CE0
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
       mov       rdx,7FF7B9F95D00
       mov       rdx,7FF7B9F95D00
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
       mov       r11,7FF7B98E0888
       mov       r11,7FF7B98E0888
       call      qword ptr [7FF7B98E0888]
       call      qword ptr [7FF7B98E0888]
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
       mov       rdx,7FF7B9F95D18
       mov       rdx,7FF7B9F95D18
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
       mov       r11,7FF7B98E0888
       mov       r11,7FF7B98E0888
       call      qword ptr [7FF7B98E0888]
       call      qword ptr [7FF7B98E0888]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FF7B98E0890
       mov       r11,7FF7B98E0890
       call      qword ptr [7FF7B98E0890]
       call      qword ptr [7FF7B98E0890]
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
       mov       rcx,1A43E4E1B10
       mov       rcx,1A43E4E1B10
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,1A41E4E3090
       mov       rdx,1A41E4E3090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,1A41E4E3020
       mov       rdx,1A41E4E3020
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
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
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
       mov       rax,1A43E4E1B18
       mov       rax,1A43E4E1B18
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
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
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
       mov       r11,7FF7B98E0890
       mov       r11,7FF7B98E0890
       call      qword ptr [7FF7B98E0890]
       call      qword ptr [7FF7B98E0890]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F4F98B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F4FB240]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F26BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,140D84116F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EEF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,140D8402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EEF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,140D8402028
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
       call      qword ptr [7FFF7ED88CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF7F26BBE8]
       mov       r15,rax
       mov       rcx,140D8411700
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFF7F26BEA0]
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
       call      qword ptr [7FFF7F26B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFF7EEB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F26BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F065750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFF7EF47900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFF7F4D9CE8
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
       mov       rdx,7FFF7F4D9CE8
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
       mov       rdx,7FFF7F4D9F48
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
       mov       rcx,7FFF7F4F89A8
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFF7F4D9CE8
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
       mov       rdx,7FFF7F4D9D28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFF7F1E3318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFF7F4D9D48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFF7EC70870
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
       mov       rdx,7FFF7F4D9D60
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
       call      qword ptr [7FFF7F4F9840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFF7EF47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFF7EC70870
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFF7EC70878
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
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFF7F26BEA0]
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
       call      qword ptr [7FFF7F26B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFF7EC64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7F03FF90]
       int       3
M01_L32:
       call      qword ptr [7FFF7EE1B630]
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
       mov       r11,7FFF7EC70878
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF7B9F75CA0
       mov       rdx,7FF7B9F75CA0
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
       mov       rdx,7FF7B9F75CA0
       mov       rdx,7FF7B9F75CA0
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
       mov       rdx,7FF7B9F75F28
       mov       rdx,7FF7B9F75F28
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
       mov       rdx,7FF7B9F75CA0
       mov       rdx,7FF7B9F75CA0
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
       mov       rdx,7FF7B9F75CE0
       mov       rdx,7FF7B9F75CE0
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
       mov       rdx,7FF7B9F75D00
       mov       rdx,7FF7B9F75D00
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
       mov       r11,7FF7B98C0888
       mov       r11,7FF7B98C0888
       call      qword ptr [7FF7B98C0888]
       call      qword ptr [7FF7B98C0888]
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
       mov       rdx,7FF7B9F75D18
       mov       rdx,7FF7B9F75D18
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
       mov       r11,7FF7B98C0888
       mov       r11,7FF7B98C0888
       call      qword ptr [7FF7B98C0888]
       call      qword ptr [7FF7B98C0888]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FF7B98C0890
       mov       r11,7FF7B98C0890
       call      qword ptr [7FF7B98C0890]
       call      qword ptr [7FF7B98C0890]
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
       mov       rcx,1D4C9ADA708
       mov       rcx,1D4C9ADA708
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,1D4C9AD3090
       mov       rdx,1D4C9AD3090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,1D4C9AD3020
       mov       rdx,1D4C9AD3020
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
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
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
       mov       rax,1D4C9ADA710
       mov       rax,1D4C9ADA710
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
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
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
       mov       r11,7FF7B98C0890
       mov       r11,7FF7B98C0890
       call      qword ptr [7FF7B98C0890]
       call      qword ptr [7FF7B98C0890]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F4F98B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F4FB240]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F26BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,1853A809B18
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EEF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,1853E802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EEF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,1853E802028
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
       call      qword ptr [7FFF7ED88CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF7F26BBE8]
       mov       r15,rax
       mov       rcx,1853A809B20
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFF7F26BEA0]
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
       call      qword ptr [7FFF7F26B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFF7EEB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F26BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F065750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFF7EF47900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFF7F4D9CE8
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
       mov       rdx,7FFF7F4D9CE8
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
       mov       rdx,7FFF7F4D9F48
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
       mov       rcx,7FFF7F4F89A8
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFF7F4D9CE8
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
       mov       rdx,7FFF7F4D9D28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFF7F1E3318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFF7F4D9D48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFF7EC70870
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
       mov       rdx,7FFF7F4D9D60
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
       call      qword ptr [7FFF7F4F9840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFF7EF47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFF7EC70870
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFF7EC70878
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
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFF7F26BEA0]
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
       call      qword ptr [7FFF7F26B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFF7EC64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7F03FF90]
       int       3
M01_L32:
       call      qword ptr [7FFF7EE1B630]
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
       mov       r11,7FFF7EC70878
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF7B9F75CA0
       mov       rdx,7FF7B9F75CA0
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
       mov       rdx,7FF7B9F75CA0
       mov       rdx,7FF7B9F75CA0
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
       mov       rdx,7FF7B9F75F28
       mov       rdx,7FF7B9F75F28
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
       mov       rdx,7FF7B9F75CA0
       mov       rdx,7FF7B9F75CA0
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
       mov       rdx,7FF7B9F75CE0
       mov       rdx,7FF7B9F75CE0
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
       mov       rdx,7FF7B9F75D00
       mov       rdx,7FF7B9F75D00
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
       mov       r11,7FF7B98C0888
       mov       r11,7FF7B98C0888
       call      qword ptr [7FF7B98C0888]
       call      qword ptr [7FF7B98C0888]
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
       mov       rdx,7FF7B9F75D18
       mov       rdx,7FF7B9F75D18
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
       mov       r11,7FF7B98C0888
       mov       r11,7FF7B98C0888
       call      qword ptr [7FF7B98C0888]
       call      qword ptr [7FF7B98C0888]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FF7B98C0890
       mov       r11,7FF7B98C0890
       call      qword ptr [7FF7B98C0890]
       call      qword ptr [7FF7B98C0890]
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
       mov       rcx,2C30A50A708
       mov       rcx,2C30A50A708
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,2C30A503090
       mov       rdx,2C30A503090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,2C30A503020
       mov       rdx,2C30A503020
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
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
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
       mov       rax,2C30A50A710
       mov       rax,2C30A50A710
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
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
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
       mov       r11,7FF7B98C0890
       mov       r11,7FF7B98C0890
       call      qword ptr [7FF7B98C0890]
       call      qword ptr [7FF7B98C0890]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F509BB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F50B4E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F27BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,28267808B00
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EF099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,2825F802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EF099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,2825F802028
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
       call      qword ptr [7FFF7ED98CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF7F27BBE8]
       mov       r15,rax
       mov       rcx,28267808B08
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFF7F27BEA0]
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
       call      qword ptr [7FFF7F27B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F27BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F27D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F04FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFF7EEC3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F27BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7F27D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F075750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFF7EF57900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFF7F4E9CE8
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
       mov       rdx,7FFF7F4E9CE8
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
       mov       rdx,7FFF7F4E9F48
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
       mov       rcx,7FFF7F508CA8
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFF7F4E9CE8
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
       mov       rdx,7FFF7F4E9D28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFF7F1F3318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFF7F4E9D48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFF7EC80870
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
       mov       rdx,7FFF7F4E9D60
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
       call      qword ptr [7FFF7F509B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFF7EF57A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFF7EC80870
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFF7EC80878
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
       call      qword ptr [7FFF7F071C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F071C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFF7F27BEA0]
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
       call      qword ptr [7FFF7F27B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F27BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F27D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F04FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEC3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F27BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F04FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFF7EC74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7F04FF90]
       int       3
M01_L32:
       call      qword ptr [7FFF7EE2B630]
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
       mov       r11,7FFF7EC80878
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF7B9F75CA0
       mov       rdx,7FF7B9F75CA0
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
       mov       rdx,7FF7B9F75CA0
       mov       rdx,7FF7B9F75CA0
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
       mov       rdx,7FF7B9F75F28
       mov       rdx,7FF7B9F75F28
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
       mov       rdx,7FF7B9F75CA0
       mov       rdx,7FF7B9F75CA0
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
       mov       rdx,7FF7B9F75CE0
       mov       rdx,7FF7B9F75CE0
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
       mov       rdx,7FF7B9F75D00
       mov       rdx,7FF7B9F75D00
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
       mov       r11,7FF7B98C0888
       mov       r11,7FF7B98C0888
       call      qword ptr [7FF7B98C0888]
       call      qword ptr [7FF7B98C0888]
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
       mov       rdx,7FF7B9F75D18
       mov       rdx,7FF7B9F75D18
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
       mov       r11,7FF7B98C0888
       mov       r11,7FF7B98C0888
       call      qword ptr [7FF7B98C0888]
       call      qword ptr [7FF7B98C0888]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FF7B98C0890
       mov       r11,7FF7B98C0890
       call      qword ptr [7FF7B98C0890]
       call      qword ptr [7FF7B98C0890]
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
       mov       rcx,2A37DA1A708
       mov       rcx,2A37DA1A708
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,2A37DA13090
       mov       rdx,2A37DA13090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,2A37DA13020
       mov       rdx,2A37DA13020
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
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
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
       mov       rax,2A37DA1A710
       mov       rax,2A37DA1A710
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
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
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
       mov       r11,7FF7B98C0890
       mov       r11,7FF7B98C0890
       call      qword ptr [7FF7B98C0890]
       call      qword ptr [7FF7B98C0890]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F4F9BB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F4FB4E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F26BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,1F16CC08B00
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EEF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,1F164C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EEF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,1F164C02028
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
       call      qword ptr [7FFF7ED88CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF7F26BBE8]
       mov       r15,rax
       mov       rcx,1F16CC08B08
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFF7F26BEA0]
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
       call      qword ptr [7FFF7F26B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFF7EEB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F26BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F065750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFF7EF47900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFF7F4D9CE8
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
       mov       rdx,7FFF7F4D9CE8
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
       mov       rdx,7FFF7F4D9F48
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
       mov       rcx,7FFF7F4F8CA8
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFF7F4D9CE8
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
       mov       rdx,7FFF7F4D9D28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFF7F1E3318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFF7F4D9D48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFF7EC70870
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
       mov       rdx,7FFF7F4D9D60
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
       call      qword ptr [7FFF7F4F9B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFF7EF47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFF7EC70870
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFF7EC70878
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
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFF7F26BEA0]
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
       call      qword ptr [7FFF7F26B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFF7EC64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7F03FF90]
       int       3
M01_L32:
       call      qword ptr [7FFF7EE1B630]
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
       mov       r11,7FFF7EC70878
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF7B9F85CA0
       mov       rdx,7FF7B9F85CA0
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
       mov       rdx,7FF7B9F85CA0
       mov       rdx,7FF7B9F85CA0
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
       mov       rdx,7FF7B9F85F28
       mov       rdx,7FF7B9F85F28
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
       mov       rdx,7FF7B9F85CA0
       mov       rdx,7FF7B9F85CA0
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
       mov       rdx,7FF7B9F85CE0
       mov       rdx,7FF7B9F85CE0
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
       mov       rdx,7FF7B9F85D00
       mov       rdx,7FF7B9F85D00
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
       mov       r11,7FF7B98D0888
       mov       r11,7FF7B98D0888
       call      qword ptr [7FF7B98D0888]
       call      qword ptr [7FF7B98D0888]
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
       mov       rdx,7FF7B9F85D18
       mov       rdx,7FF7B9F85D18
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
       mov       r11,7FF7B98D0888
       mov       r11,7FF7B98D0888
       call      qword ptr [7FF7B98D0888]
       call      qword ptr [7FF7B98D0888]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FF7B98D0890
       mov       r11,7FF7B98D0890
       call      qword ptr [7FF7B98D0890]
       call      qword ptr [7FF7B98D0890]
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
       mov       rcx,1DC2CC2A708
       mov       rcx,1DC2CC2A708
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,1DC2CC23090
       mov       rdx,1DC2CC23090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,1DC2CC23020
       mov       rdx,1DC2CC23020
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
       mov       rdx,7FF7B9B85440
       mov       rdx,7FF7B9B85440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B85440
       mov       rdx,7FF7B9B85440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B85440
       mov       rdx,7FF7B9B85440
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
       mov       rax,1DC2CC2A710
       mov       rax,1DC2CC2A710
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
       mov       rdx,7FF7B9B85440
       mov       rdx,7FF7B9B85440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B85440
       mov       rdx,7FF7B9B85440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B85440
       mov       rdx,7FF7B9B85440
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
       mov       r11,7FF7B98D0890
       mov       r11,7FF7B98D0890
       call      qword ptr [7FF7B98D0890]
       call      qword ptr [7FF7B98D0890]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F4E9BB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F4EB4E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F25BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,1665B4116F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EEE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,1665B402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EEE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,1665B402028
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
       call      qword ptr [7FFF7ED78CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF7F25BBE8]
       mov       r15,rax
       mov       rcx,1665B411700
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFF7F25BEA0]
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
       call      qword ptr [7FFF7F25B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F25BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F25D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F02FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFF7EEA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F25BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7F25D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F055750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFF7EF37900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFF7F4C9CE8
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
       mov       rdx,7FFF7F4C9CE8
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
       mov       rdx,7FFF7F4C9F48
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
       mov       rcx,7FFF7F4E8CA8
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFF7F4C9CE8
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
       mov       rdx,7FFF7F4C9D28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFF7F1D3318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFF7F4C9D48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFF7EC60870
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
       mov       rdx,7FFF7F4C9D60
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
       call      qword ptr [7FFF7F4E9B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFF7EF37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFF7EC60870
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFF7EC60878
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
       call      qword ptr [7FFF7F051C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F051C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFF7F25BEA0]
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
       call      qword ptr [7FFF7F25B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F25BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F25D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F02FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F25BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F02FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFF7EC54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7F02FF90]
       int       3
M01_L32:
       call      qword ptr [7FFF7EE0B630]
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
       mov       r11,7FFF7EC60878
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF7B9F75CA0
       mov       rdx,7FF7B9F75CA0
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
       mov       rdx,7FF7B9F75CA0
       mov       rdx,7FF7B9F75CA0
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
       mov       rdx,7FF7B9F75F28
       mov       rdx,7FF7B9F75F28
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
       mov       rdx,7FF7B9F75CA0
       mov       rdx,7FF7B9F75CA0
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
       mov       rdx,7FF7B9F75CE0
       mov       rdx,7FF7B9F75CE0
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
       mov       rdx,7FF7B9F75D00
       mov       rdx,7FF7B9F75D00
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
       mov       r11,7FF7B98C0888
       mov       r11,7FF7B98C0888
       call      qword ptr [7FF7B98C0888]
       call      qword ptr [7FF7B98C0888]
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
       mov       rdx,7FF7B9F75D18
       mov       rdx,7FF7B9F75D18
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
       mov       r11,7FF7B98C0888
       mov       r11,7FF7B98C0888
       call      qword ptr [7FF7B98C0888]
       call      qword ptr [7FF7B98C0888]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FF7B98C0890
       mov       r11,7FF7B98C0890
       call      qword ptr [7FF7B98C0890]
       call      qword ptr [7FF7B98C0890]
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
       mov       rcx,28D3388A708
       mov       rcx,28D3388A708
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,28D33883090
       mov       rdx,28D33883090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,28D33883020
       mov       rdx,28D33883020
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
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
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
       mov       rax,28D3388A710
       mov       rax,28D3388A710
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
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
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
       mov       r11,7FF7B98C0890
       mov       r11,7FF7B98C0890
       call      qword ptr [7FF7B98C0890]
       call      qword ptr [7FF7B98C0890]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F5198B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F51B240]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F28BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,1CFB98116F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EF199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,1CFB9802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EF199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,1CFB9802028
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
       call      qword ptr [7FFF7EDA8CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF7F28BBE8]
       mov       r15,rax
       mov       rcx,1CFB9811700
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFF7F28BEA0]
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
       call      qword ptr [7FFF7F28B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F28BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F28D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F05FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFF7EED3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F28BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7F28D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F085750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFF7EF67900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFF7F4F9D08
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
       mov       rdx,7FFF7F4F9D08
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
       mov       rdx,7FFF7F4F9F68
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
       mov       rcx,7FFF7F5189A8
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFF7F4F9D08
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
       mov       rdx,7FFF7F4F9D48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFF7F203318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFF7F4F9D68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFF7EC90870
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
       mov       rdx,7FFF7F4F9D80
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
       call      qword ptr [7FFF7F519840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFF7EF67A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFF7EC90870
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFF7EC90878
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
       call      qword ptr [7FFF7F081C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFF7F28BEA0]
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
       call      qword ptr [7FFF7F28B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F28BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F28D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F05FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EED3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F28BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F05FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFF7EC84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7F05FF90]
       int       3
M01_L32:
       call      qword ptr [7FFF7EE3B630]
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
       mov       r11,7FFF7EC90878
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF7B9F75CA0
       mov       rdx,7FF7B9F75CA0
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
       mov       rdx,7FF7B9F75CA0
       mov       rdx,7FF7B9F75CA0
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
       mov       rdx,7FF7B9F75F28
       mov       rdx,7FF7B9F75F28
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
       mov       rdx,7FF7B9F75CA0
       mov       rdx,7FF7B9F75CA0
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
       mov       rdx,7FF7B9F75CE0
       mov       rdx,7FF7B9F75CE0
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
       mov       rdx,7FF7B9F75D00
       mov       rdx,7FF7B9F75D00
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
       mov       r11,7FF7B98C0888
       mov       r11,7FF7B98C0888
       call      qword ptr [7FF7B98C0888]
       call      qword ptr [7FF7B98C0888]
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
       mov       rdx,7FF7B9F75D18
       mov       rdx,7FF7B9F75D18
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
       mov       r11,7FF7B98C0888
       mov       r11,7FF7B98C0888
       call      qword ptr [7FF7B98C0888]
       call      qword ptr [7FF7B98C0888]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FF7B98C0890
       mov       r11,7FF7B98C0890
       call      qword ptr [7FF7B98C0890]
       call      qword ptr [7FF7B98C0890]
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
       mov       rcx,16C3468A708
       mov       rcx,16C3468A708
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,16C34683090
       mov       rdx,16C34683090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,16C34683020
       mov       rdx,16C34683020
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
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
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
       mov       rax,16C3468A710
       mov       rax,16C3468A710
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
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
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
       mov       r11,7FF7B98C0890
       mov       r11,7FF7B98C0890
       call      qword ptr [7FF7B98C0890]
       call      qword ptr [7FF7B98C0890]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F4E7BB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F4E94E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F25BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,152F6411EF8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EEE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,152F6402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EEE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,152F6402028
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
       call      qword ptr [7FFF7ED78CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF7F25BBE8]
       mov       r15,rax
       mov       rcx,152F6411F00
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFF7F25BEA0]
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
       call      qword ptr [7FFF7F25B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F25BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F25D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F02FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFF7EEA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F25BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7F25D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F055750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFF7EF37900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFF7F4C9CE8
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
       mov       rdx,7FFF7F4C9CE8
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
       mov       rdx,7FFF7F4C9F48
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
       mov       rcx,7FFF7F4E6CA8
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFF7F4C9CE8
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
       mov       rdx,7FFF7F4C9D28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFF7F1D3318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFF7F4C9D48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFF7EC60880
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
       mov       rdx,7FFF7F4C9D60
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
       call      qword ptr [7FFF7F4E7B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFF7EF37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFF7EC60880
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFF7EC60888
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
       call      qword ptr [7FFF7F051C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F051C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFF7F25BEA0]
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
       call      qword ptr [7FFF7F25B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F25BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F25D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F02FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F25BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F02FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFF7EC54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7F02FF90]
       int       3
M01_L32:
       call      qword ptr [7FFF7EE0B630]
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
       mov       r11,7FFF7EC60888
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF7B9F75CA0
       mov       rdx,7FF7B9F75CA0
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
       mov       rdx,7FF7B9F75CA0
       mov       rdx,7FF7B9F75CA0
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
       mov       rdx,7FF7B9F75F28
       mov       rdx,7FF7B9F75F28
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
       mov       rdx,7FF7B9F75CA0
       mov       rdx,7FF7B9F75CA0
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
       mov       rdx,7FF7B9F75CE0
       mov       rdx,7FF7B9F75CE0
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
       mov       rdx,7FF7B9F75D00
       mov       rdx,7FF7B9F75D00
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
       mov       r11,7FF7B98C0888
       mov       r11,7FF7B98C0888
       call      qword ptr [7FF7B98C0888]
       call      qword ptr [7FF7B98C0888]
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
       mov       rdx,7FF7B9F75D18
       mov       rdx,7FF7B9F75D18
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
       mov       r11,7FF7B98C0888
       mov       r11,7FF7B98C0888
       call      qword ptr [7FF7B98C0888]
       call      qword ptr [7FF7B98C0888]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FF7B98C0890
       mov       r11,7FF7B98C0890
       call      qword ptr [7FF7B98C0890]
       call      qword ptr [7FF7B98C0890]
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
       mov       rcx,28F5FFDA708
       mov       rcx,28F5FFDA708
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,28F5FFD3090
       mov       rdx,28F5FFD3090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,28F5FFD3020
       mov       rdx,28F5FFD3020
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
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
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
       mov       rax,28F5FFDA710
       mov       rax,28F5FFDA710
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
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B75440
       mov       rdx,7FF7B9B75440
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
       mov       r11,7FF7B98C0890
       mov       r11,7FF7B98C0890
       call      qword ptr [7FF7B98C0890]
       call      qword ptr [7FF7B98C0890]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F5098B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F50B240]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F27BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,206A4412710
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EF099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,206A4402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EF099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,206A4402028
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
       call      qword ptr [7FFF7ED98CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF7F27BBE8]
       mov       r15,rax
       mov       rcx,206A4412718
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFF7F27BEA0]
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
       call      qword ptr [7FFF7F27B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F27BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F27D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F04FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFF7EEC3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F27BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7F27D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F075750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFF7EF57900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFF7F4E9CE8
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
       mov       rdx,7FFF7F4E9CE8
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
       mov       rdx,7FFF7F4E9F48
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
       mov       rcx,7FFF7F5089A8
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFF7F4E9CE8
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
       mov       rdx,7FFF7F4E9D28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFF7F1F3318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFF7F4E9D48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFF7EC80870
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
       mov       rdx,7FFF7F4E9D60
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
       call      qword ptr [7FFF7F509840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFF7EF57A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFF7EC80870
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFF7EC80878
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
       call      qword ptr [7FFF7F071C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F071C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFF7F27BEA0]
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
       call      qword ptr [7FFF7F27B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F27BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F27D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F04FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEC3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F27BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F04FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFF7EC74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7F04FF90]
       int       3
M01_L32:
       call      qword ptr [7FFF7EE2B630]
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
       mov       r11,7FFF7EC80878
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF7B9F95CA0
       mov       rdx,7FF7B9F95CA0
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
       mov       rdx,7FF7B9F95CA0
       mov       rdx,7FF7B9F95CA0
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
       mov       rdx,7FF7B9F95F28
       mov       rdx,7FF7B9F95F28
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
       mov       rdx,7FF7B9F95CA0
       mov       rdx,7FF7B9F95CA0
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
       mov       rdx,7FF7B9F95CE0
       mov       rdx,7FF7B9F95CE0
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
       mov       rdx,7FF7B9F95D00
       mov       rdx,7FF7B9F95D00
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
       mov       r11,7FF7B98E0888
       mov       r11,7FF7B98E0888
       call      qword ptr [7FF7B98E0888]
       call      qword ptr [7FF7B98E0888]
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
       mov       rdx,7FF7B9F95D18
       mov       rdx,7FF7B9F95D18
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
       mov       r11,7FF7B98E0888
       mov       r11,7FF7B98E0888
       call      qword ptr [7FF7B98E0888]
       call      qword ptr [7FF7B98E0888]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FF7B98E0890
       mov       r11,7FF7B98E0890
       call      qword ptr [7FF7B98E0890]
       call      qword ptr [7FF7B98E0890]
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
       mov       rcx,299D22C2B28
       mov       rcx,299D22C2B28
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,299B22C3090
       mov       rdx,299B22C3090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,299B22C3020
       mov       rdx,299B22C3020
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
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
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
       mov       rax,299D22C2B30
       mov       rax,299D22C2B30
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
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
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
       mov       r11,7FF7B98E0890
       mov       r11,7FF7B98E0890
       call      qword ptr [7FF7B98E0890]
       call      qword ptr [7FF7B98E0890]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F4E98B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F4EB240]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F25BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,1B88E8116F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EEE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,1B88E802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EEE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,1B88E802028
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
       call      qword ptr [7FFF7ED78CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF7F25BBE8]
       mov       r15,rax
       mov       rcx,1B88E811700
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFF7F25BEA0]
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
       call      qword ptr [7FFF7F25B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F25BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F25D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F02FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFF7EEA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F25BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7F25D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F055750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFF7EF37900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFF7F4C9CE8
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
       mov       rdx,7FFF7F4C9CE8
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
       mov       rdx,7FFF7F4C9F48
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
       mov       rcx,7FFF7F4E89A8
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFF7F4C9CE8
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
       mov       rdx,7FFF7F4C9D28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFF7F1D3318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFF7F4C9D48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFF7EC60870
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
       mov       rdx,7FFF7F4C9D60
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
       call      qword ptr [7FFF7F4E9840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFF7EF37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFF7EC60870
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFF7EC60878
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
       call      qword ptr [7FFF7F051C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F051C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFF7F25BEA0]
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
       call      qword ptr [7FFF7F25B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F25BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F25D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F02FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F25BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F02FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFF7EC54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7F02FF90]
       int       3
M01_L32:
       call      qword ptr [7FFF7EE0B630]
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
       mov       r11,7FFF7EC60878
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF7B9FA5CA0
       mov       rdx,7FF7B9FA5CA0
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
       mov       rdx,7FF7B9FA5CA0
       mov       rdx,7FF7B9FA5CA0
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
       mov       rdx,7FF7B9FA5F28
       mov       rdx,7FF7B9FA5F28
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
       mov       rdx,7FF7B9FA5CA0
       mov       rdx,7FF7B9FA5CA0
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
       mov       rdx,7FF7B9FA5CE0
       mov       rdx,7FF7B9FA5CE0
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
       mov       rdx,7FF7B9FA5D00
       mov       rdx,7FF7B9FA5D00
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
       mov       r11,7FF7B98F0888
       mov       r11,7FF7B98F0888
       call      qword ptr [7FF7B98F0888]
       call      qword ptr [7FF7B98F0888]
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
       mov       rdx,7FF7B9FA5D18
       mov       rdx,7FF7B9FA5D18
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
       mov       r11,7FF7B98F0888
       mov       r11,7FF7B98F0888
       call      qword ptr [7FF7B98F0888]
       call      qword ptr [7FF7B98F0888]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FF7B98F0890
       mov       r11,7FF7B98F0890
       call      qword ptr [7FF7B98F0890]
       call      qword ptr [7FF7B98F0890]
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
       mov       rcx,169CB401B10
       mov       rcx,169CB401B10
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,1698B403090
       mov       rdx,1698B403090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,1698B403020
       mov       rdx,1698B403020
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
       mov       rdx,7FF7B9BA5440
       mov       rdx,7FF7B9BA5440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9BA5440
       mov       rdx,7FF7B9BA5440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9BA5440
       mov       rdx,7FF7B9BA5440
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
       mov       rax,169CB401B18
       mov       rax,169CB401B18
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
       mov       rdx,7FF7B9BA5440
       mov       rdx,7FF7B9BA5440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9BA5440
       mov       rdx,7FF7B9BA5440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9BA5440
       mov       rdx,7FF7B9BA5440
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
       mov       r11,7FF7B98F0890
       mov       r11,7FF7B98F0890
       call      qword ptr [7FF7B98F0890]
       call      qword ptr [7FF7B98F0890]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F507BB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F5094E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F27BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,21712408B00
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EF099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,2170A402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EF099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,2170A402028
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
       call      qword ptr [7FFF7ED98CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF7F27BBE8]
       mov       r15,rax
       mov       rcx,21712408B08
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFF7F27BEA0]
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
       call      qword ptr [7FFF7F27B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F27BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F27D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F04FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFF7EEC3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F27BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7F27D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F075750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFF7EF57900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFF7F4E9CE8
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
       mov       rdx,7FFF7F4E9CE8
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
       mov       rdx,7FFF7F4E9F48
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
       mov       rcx,7FFF7F506CA8
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFF7F4E9CE8
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
       mov       rdx,7FFF7F4E9D28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFF7F1F3318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFF7F4E9D48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFF7EC80870
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
       mov       rdx,7FFF7F4E9D60
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
       call      qword ptr [7FFF7F507B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFF7EF57A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFF7EC80870
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFF7EC80878
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
       call      qword ptr [7FFF7F071C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F071C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFF7F27BEA0]
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
       call      qword ptr [7FFF7F27B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F27BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F27D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F04FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEC3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F27BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F04FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFF7EC74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7F04FF90]
       int       3
M01_L32:
       call      qword ptr [7FFF7EE2B630]
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
       mov       r11,7FFF7EC80878
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF7B9F85CA0
       mov       rdx,7FF7B9F85CA0
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
       mov       rdx,7FF7B9F85CA0
       mov       rdx,7FF7B9F85CA0
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
       mov       rdx,7FF7B9F85F28
       mov       rdx,7FF7B9F85F28
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
       mov       rdx,7FF7B9F85CA0
       mov       rdx,7FF7B9F85CA0
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
       mov       rdx,7FF7B9F85CE0
       mov       rdx,7FF7B9F85CE0
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
       mov       rdx,7FF7B9F85D00
       mov       rdx,7FF7B9F85D00
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
       mov       r11,7FF7B98D0888
       mov       r11,7FF7B98D0888
       call      qword ptr [7FF7B98D0888]
       call      qword ptr [7FF7B98D0888]
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
       mov       rdx,7FF7B9F85D18
       mov       rdx,7FF7B9F85D18
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
       mov       r11,7FF7B98D0888
       mov       r11,7FF7B98D0888
       call      qword ptr [7FF7B98D0888]
       call      qword ptr [7FF7B98D0888]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FF7B98D0890
       mov       r11,7FF7B98D0890
       call      qword ptr [7FF7B98D0890]
       call      qword ptr [7FF7B98D0890]
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
       mov       rcx,205DA131B10
       mov       rcx,205DA131B10
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,2059A133090
       mov       rdx,2059A133090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,2059A133020
       mov       rdx,2059A133020
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
       mov       rdx,7FF7B9B85440
       mov       rdx,7FF7B9B85440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B85440
       mov       rdx,7FF7B9B85440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B85440
       mov       rdx,7FF7B9B85440
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
       mov       rax,205DA131B18
       mov       rax,205DA131B18
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
       mov       rdx,7FF7B9B85440
       mov       rdx,7FF7B9B85440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B85440
       mov       rdx,7FF7B9B85440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B85440
       mov       rdx,7FF7B9B85440
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
       mov       r11,7FF7B98D0890
       mov       r11,7FF7B98D0890
       call      qword ptr [7FF7B98D0890]
       call      qword ptr [7FF7B98D0890]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F5198B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F51B240]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F28BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,1D9958116F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EF199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,1D995802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EF199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,1D995802028
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
       call      qword ptr [7FFF7EDA8CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF7F28BBE8]
       mov       r15,rax
       mov       rcx,1D995811700
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFF7F28BEA0]
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
       call      qword ptr [7FFF7F28B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F28BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F28D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F05FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFF7EED3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F28BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7F28D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F085750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFF7EF67900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFF7F4F9CE8
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
       mov       rdx,7FFF7F4F9CE8
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
       mov       rdx,7FFF7F4F9F48
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
       mov       rcx,7FFF7F5189A8
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFF7F4F9CE8
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
       mov       rdx,7FFF7F4F9D28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFF7F203318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFF7F4F9D48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFF7EC90870
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
       mov       rdx,7FFF7F4F9D60
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
       call      qword ptr [7FFF7F519840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFF7EF67A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFF7EC90870
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFF7EC90878
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
       call      qword ptr [7FFF7F081C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFF7F28BEA0]
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
       call      qword ptr [7FFF7F28B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F28BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F28D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F05FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EED3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F28BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F05FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFF7EC84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7F05FF90]
       int       3
M01_L32:
       call      qword ptr [7FFF7EE3B630]
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
       mov       r11,7FFF7EC90878
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF7B9FA5CA0
       mov       rdx,7FF7B9FA5CA0
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
       mov       rdx,7FF7B9FA5CA0
       mov       rdx,7FF7B9FA5CA0
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
       mov       rdx,7FF7B9FA5F28
       mov       rdx,7FF7B9FA5F28
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
       mov       rdx,7FF7B9FA5CA0
       mov       rdx,7FF7B9FA5CA0
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
       mov       rdx,7FF7B9FA5CE0
       mov       rdx,7FF7B9FA5CE0
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
       mov       rdx,7FF7B9FA5D00
       mov       rdx,7FF7B9FA5D00
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
       mov       r11,7FF7B98F0888
       mov       r11,7FF7B98F0888
       call      qword ptr [7FF7B98F0888]
       call      qword ptr [7FF7B98F0888]
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
       mov       rdx,7FF7B9FA5D18
       mov       rdx,7FF7B9FA5D18
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
       mov       r11,7FF7B98F0888
       mov       r11,7FF7B98F0888
       call      qword ptr [7FF7B98F0888]
       call      qword ptr [7FF7B98F0888]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FF7B98F0890
       mov       r11,7FF7B98F0890
       call      qword ptr [7FF7B98F0890]
       call      qword ptr [7FF7B98F0890]
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
       mov       rcx,2487A3C6300
       mov       rcx,2487A3C6300
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,248FA3C3090
       mov       rdx,248FA3C3090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,248FA3C3020
       mov       rdx,248FA3C3020
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
       mov       rdx,7FF7B9BA5440
       mov       rdx,7FF7B9BA5440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9BA5440
       mov       rdx,7FF7B9BA5440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9BA5440
       mov       rdx,7FF7B9BA5440
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
       mov       rax,2487A3C6308
       mov       rax,2487A3C6308
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
       mov       rdx,7FF7B9BA5440
       mov       rdx,7FF7B9BA5440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9BA5440
       mov       rdx,7FF7B9BA5440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9BA5440
       mov       rdx,7FF7B9BA5440
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
       mov       r11,7FF7B98F0890
       mov       r11,7FF7B98F0890
       call      qword ptr [7FF7B98F0890]
       call      qword ptr [7FF7B98F0890]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F5098B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F50B240]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F27BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,23D8E408B00
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EF099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,23D82402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EF099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,23D82402028
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
       call      qword ptr [7FFF7ED98CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF7F27BBE8]
       mov       r15,rax
       mov       rcx,23D8E408B08
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFF7F27BEA0]
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
       call      qword ptr [7FFF7F27B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F27BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F27D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F04FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFF7EEC3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F27BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7F27D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F075750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFF7EF57900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFF7F4E9CE8
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
       mov       rdx,7FFF7F4E9CE8
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
       mov       rdx,7FFF7F4E9F48
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
       mov       rcx,7FFF7F5089A8
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFF7F4E9CE8
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
       mov       rdx,7FFF7F4E9D28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFF7F1F3318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFF7F4E9D48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFF7EC80870
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
       mov       rdx,7FFF7F4E9D60
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
       call      qword ptr [7FFF7F509840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFF7EF57A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFF7EC80870
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFF7EC80878
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
       call      qword ptr [7FFF7F071C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F071C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFF7F27BEA0]
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
       call      qword ptr [7FFF7F27B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F27BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F27D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F04FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEC3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F27BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F04FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFF7EC74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7F04FF90]
       int       3
M01_L32:
       call      qword ptr [7FFF7EE2B630]
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
       mov       r11,7FFF7EC80878
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF7B9F95CA0
       mov       rdx,7FF7B9F95CA0
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
       mov       rdx,7FF7B9F95CA0
       mov       rdx,7FF7B9F95CA0
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
       mov       rdx,7FF7B9F95F28
       mov       rdx,7FF7B9F95F28
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
       mov       rdx,7FF7B9F95CA0
       mov       rdx,7FF7B9F95CA0
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
       mov       rdx,7FF7B9F95CE0
       mov       rdx,7FF7B9F95CE0
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
       mov       rdx,7FF7B9F95D00
       mov       rdx,7FF7B9F95D00
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
       mov       r11,7FF7B98E0888
       mov       r11,7FF7B98E0888
       call      qword ptr [7FF7B98E0888]
       call      qword ptr [7FF7B98E0888]
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
       mov       rdx,7FF7B9F95D18
       mov       rdx,7FF7B9F95D18
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
       mov       r11,7FF7B98E0888
       mov       r11,7FF7B98E0888
       call      qword ptr [7FF7B98E0888]
       call      qword ptr [7FF7B98E0888]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FF7B98E0890
       mov       r11,7FF7B98E0890
       call      qword ptr [7FF7B98E0890]
       call      qword ptr [7FF7B98E0890]
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
       mov       rcx,1CD49EA6300
       mov       rcx,1CD49EA6300
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,1CD79EA3090
       mov       rdx,1CD79EA3090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,1CD79EA3020
       mov       rdx,1CD79EA3020
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
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
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
       mov       rax,1CD49EA6308
       mov       rax,1CD49EA6308
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
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
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
       mov       r11,7FF7B98E0890
       mov       r11,7FF7B98E0890
       call      qword ptr [7FF7B98E0890]
       call      qword ptr [7FF7B98E0890]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F4F9BB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F4FB4E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F26BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,20A48C116F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EEF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,20A48C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EEF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,20A48C02028
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
       call      qword ptr [7FFF7ED88CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF7F26BBE8]
       mov       r15,rax
       mov       rcx,20A48C11700
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFF7F26BEA0]
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
       call      qword ptr [7FFF7F26B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFF7EEB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F26BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F065750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFF7EF47900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFF7F4D9CE8
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
       mov       rdx,7FFF7F4D9CE8
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
       mov       rdx,7FFF7F4D9F48
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
       mov       rcx,7FFF7F4F8CA8
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFF7F4D9CE8
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
       mov       rdx,7FFF7F4D9D28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFF7F1E3318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFF7F4D9D48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFF7EC70870
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
       mov       rdx,7FFF7F4D9D60
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
       call      qword ptr [7FFF7F4F9B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFF7EF47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFF7EC70870
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFF7EC70878
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
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFF7F26BEA0]
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
       call      qword ptr [7FFF7F26B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFF7EC64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7F03FF90]
       int       3
M01_L32:
       call      qword ptr [7FFF7EE1B630]
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
       mov       r11,7FFF7EC70878
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF7B9F95CA0
       mov       rdx,7FF7B9F95CA0
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
       mov       rdx,7FF7B9F95CA0
       mov       rdx,7FF7B9F95CA0
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
       mov       rdx,7FF7B9F95F28
       mov       rdx,7FF7B9F95F28
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
       mov       rdx,7FF7B9F95CA0
       mov       rdx,7FF7B9F95CA0
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
       mov       rdx,7FF7B9F95CE0
       mov       rdx,7FF7B9F95CE0
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
       mov       rdx,7FF7B9F95D00
       mov       rdx,7FF7B9F95D00
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
       mov       r11,7FF7B98E0888
       mov       r11,7FF7B98E0888
       call      qword ptr [7FF7B98E0888]
       call      qword ptr [7FF7B98E0888]
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
       mov       rdx,7FF7B9F95D18
       mov       rdx,7FF7B9F95D18
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
       mov       r11,7FF7B98E0888
       mov       r11,7FF7B98E0888
       call      qword ptr [7FF7B98E0888]
       call      qword ptr [7FF7B98E0888]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FF7B98E0890
       mov       r11,7FF7B98E0890
       call      qword ptr [7FF7B98E0890]
       call      qword ptr [7FF7B98E0890]
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
       mov       rcx,2BEB182A708
       mov       rcx,2BEB182A708
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,2BEB1823090
       mov       rdx,2BEB1823090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,2BEB1823020
       mov       rdx,2BEB1823020
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
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
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
       mov       rax,2BEB182A710
       mov       rax,2BEB182A710
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
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B95440
       mov       rdx,7FF7B9B95440
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
       mov       r11,7FF7B98E0890
       mov       r11,7FF7B98E0890
       call      qword ptr [7FF7B98E0890]
       call      qword ptr [7FF7B98E0890]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F4F78B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F4F9240]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F26BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,20F76C09318
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EEF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,20F7EC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EEF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,20F7EC02028
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
       call      qword ptr [7FFF7ED88CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF7F26BBE8]
       mov       r15,rax
       mov       rcx,20F76C09320
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFF7F26BEA0]
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
       call      qword ptr [7FFF7F26B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFF7EEB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F26BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F065750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFF7EF47900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFF7F4D9CE8
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
       mov       rdx,7FFF7F4D9CE8
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
       mov       rdx,7FFF7F4D9F48
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
       mov       rcx,7FFF7F4F69A8
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFF7F4D9CE8
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
       mov       rdx,7FFF7F4D9D28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFF7F1E3318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFF7F4D9D48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFF7EC70870
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
       mov       rdx,7FFF7F4D9D60
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
       call      qword ptr [7FFF7F4F7840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFF7EF47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFF7EC70870
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFF7EC70878
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
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFF7F26BEA0]
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
       call      qword ptr [7FFF7F26B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFF7EC64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7F03FF90]
       int       3
M01_L32:
       call      qword ptr [7FFF7EE1B630]
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
       mov       r11,7FFF7EC70878
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF7B9F85CA0
       mov       rdx,7FF7B9F85CA0
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
       mov       rdx,7FF7B9F85CA0
       mov       rdx,7FF7B9F85CA0
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
       mov       rdx,7FF7B9F85F28
       mov       rdx,7FF7B9F85F28
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
       mov       rdx,7FF7B9F85CA0
       mov       rdx,7FF7B9F85CA0
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
       mov       rdx,7FF7B9F85CE0
       mov       rdx,7FF7B9F85CE0
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
       mov       rdx,7FF7B9F85D00
       mov       rdx,7FF7B9F85D00
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
       mov       r11,7FF7B98D0888
       mov       r11,7FF7B98D0888
       call      qword ptr [7FF7B98D0888]
       call      qword ptr [7FF7B98D0888]
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
       mov       rdx,7FF7B9F85D18
       mov       rdx,7FF7B9F85D18
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
       mov       r11,7FF7B98D0888
       mov       r11,7FF7B98D0888
       call      qword ptr [7FF7B98D0888]
       call      qword ptr [7FF7B98D0888]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FF7B98D0890
       mov       r11,7FF7B98D0890
       call      qword ptr [7FF7B98D0890]
       call      qword ptr [7FF7B98D0890]
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
       mov       rcx,1F834C1A708
       mov       rcx,1F834C1A708
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,1F834C13090
       mov       rdx,1F834C13090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,1F834C13020
       mov       rdx,1F834C13020
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
       mov       rdx,7FF7B9B85440
       mov       rdx,7FF7B9B85440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B85440
       mov       rdx,7FF7B9B85440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B85440
       mov       rdx,7FF7B9B85440
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
       mov       rax,1F834C1A710
       mov       rax,1F834C1A710
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
       mov       rdx,7FF7B9B85440
       mov       rdx,7FF7B9B85440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF7B9B85440
       mov       rdx,7FF7B9B85440
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FF7B9B85440
       mov       rdx,7FF7B9B85440
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
       mov       r11,7FF7B98D0890
       mov       r11,7FF7B98D0890
       call      qword ptr [7FF7B98D0890]
       call      qword ptr [7FF7B98D0890]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F4E78B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F4E9240]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F25BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,15DEAC116F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EEE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,15DEAC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EEE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,15DEAC02028
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
       call      qword ptr [7FFF7ED78CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF7F25BBE8]
       mov       r15,rax
       mov       rcx,15DEAC11700
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFF7F25BEA0]
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
       call      qword ptr [7FFF7F25B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F25BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F25D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F02FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFF7EEA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F25BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7F25D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F055750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFF7EF37900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFF7F4C9D08
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
       mov       rdx,7FFF7F4C9D08
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
       mov       rdx,7FFF7F4C9F68
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
       mov       rcx,7FFF7F4E69A8
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFF7F4C9D08
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
       mov       rdx,7FFF7F4C9D48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFF7F1D3318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFF7F4C9D68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFF7EC60870
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
       mov       rdx,7FFF7F4C9D80
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
       call      qword ptr [7FFF7F4E7840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFF7EF37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFF7EC60870
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFF7EC60878
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
       call      qword ptr [7FFF7F051C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F051C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFF7F25BEA0]
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
       call      qword ptr [7FFF7F25B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F25BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F25D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F02FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F25BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F02FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFF7EC54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7F02FF90]
       int       3
M01_L32:
       call      qword ptr [7FFF7EE0B630]
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
       mov       r11,7FFF7EC60878
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

