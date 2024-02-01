## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,2E68A123040
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
       mov       ecx,3A1
       mov       rdx,7FF9DB7B6A60
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF9DB7B6A60
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A1
       mov       rdx,7FF9DB7B6A60
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FF9CF6B9B88]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6B9C00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3BD360]
       mov       rdi,rax
       mov       rcx,2DBCC408C40
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9CF3BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF209CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF209CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FF9CEFF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3BD090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CF3BD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1A5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF9CF077918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,29594C01048
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
       mov       ecx,3A1
       mov       rdx,7FF9DB7B6A60
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF9DB7B6A60
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A1
       mov       rdx,7FF9DB7B6A60
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FF9CF6DBB88]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6DBC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3DD360]
       mov       rdi,rax
       mov       rcx,1A00C000048
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9CF3DD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF229CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF229CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3DD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FF9CF013510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DD090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CF3DD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1C5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF9CF097918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,20E45081048
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
       mov       ecx,3A1
       mov       rdx,7FF9DB7A6A60
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF9DB7A6A60
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A1
       mov       rdx,7FF9DB7A6A60
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FF9CF6BBB88]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6BBC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3BD360]
       mov       rdi,rax
       mov       rcx,2C265400048
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9CF3BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF209CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF209CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FF9CEFF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3BD090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CF3BD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1A5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF9CF077918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,23047CD1048
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
       mov       ecx,3A1
       mov       rdx,7FF9DB7C6A60
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF9DB7C6A60
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A1
       mov       rdx,7FF9DB7C6A60
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FF9CF6DB888]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6DB900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3DD360]
       mov       rdi,rax
       mov       rcx,1D87DC08C40
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9CF3DD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF229CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF229CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3DD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FF9CF013510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DD090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CF3DD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1C5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF9CF097918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,1F33DFE1048
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
       mov       ecx,3A1
       mov       rdx,7FF9DB796A60
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF9DB796A60
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A1
       mov       rdx,7FF9DB796A60
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FF9CF6D9888]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6D9900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3DD360]
       mov       rdi,rax
       mov       rcx,19AC5000048
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9CF3DD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF229CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF229CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3DD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FF9CF013510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DD090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CF3DD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1C5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF9CF097918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,1E6D6B11048
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
       mov       ecx,3A1
       mov       rdx,7FF9DB7D6A60
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF9DB7D6A60
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A1
       mov       rdx,7FF9DB7D6A60
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FF9CF6EBB88]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6EBC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3ED360]
       mov       rdi,rax
       mov       rcx,284BC400048
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9CF3ED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF239CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF239CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3ED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FF9CF023510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3ED090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CF3ED600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1D5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF9CF0A7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,26A81E91048
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
       mov       ecx,3A1
       mov       rdx,7FF9DB7B6A60
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF9DB7B6A60
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A1
       mov       rdx,7FF9DB7B6A60
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FF9CF6D9888]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6D9900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3DD360]
       mov       rdi,rax
       mov       rcx,1C1D2402040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9CF3DD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF229CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF229CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3DD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FF9CF013510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DD090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CF3DD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1C5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF9CF097918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       je        near ptr M01_L20
       je        near ptr M01_L20
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
       je        near ptr M01_L24
       je        near ptr M01_L24
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
       mov       rdx,7FF9DBC2DC28
       mov       rdx,7FF9DBC2DC28
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
       mov       rdx,7FF9DBC2DC28
       mov       rdx,7FF9DBC2DC28
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
       mov       rdx,7FF9DBC2DE98
       mov       rdx,7FF9DBC2DE98
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
       je        near ptr M01_L28
       je        near ptr M01_L28
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
       mov       rdx,7FF9DBC2DC28
       mov       rdx,7FF9DBC2DC28
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
       mov       rdx,7FF9DBC2DC50
       mov       rdx,7FF9DBC2DC50
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
       mov       rdx,7FF9DBC2DC70
       mov       rdx,7FF9DBC2DC70
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
       mov       r11,7FF9DB510970
       mov       r11,7FF9DB510970
       call      qword ptr [7FF9DB510970]
       call      qword ptr [7FF9DB510970]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L19
       je        near ptr M01_L19
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
       mov       rdx,7FF9DBC2DC88
       mov       rdx,7FF9DBC2DC88
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
       lea       ecx,[rsi+2]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       cmp       ecx,1
       ja        short M01_L16
       ja        short M01_L16
       mov       rcx,r15
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L18
       jmp       short M01_L18
M01_L16:
       inc       dword ptr [r15+14]
M01_L16:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L17
       jbe       short M01_L17
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
       jmp       short M01_L18
M01_L17:
       mov       rcx,r15
M01_L17:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       mov       rcx,rbx
M01_L18:
       mov       rcx,rbx
       mov       r11,7FF9DB510970
       mov       r11,7FF9DB510970
       call      qword ptr [7FF9DB510970]
       call      qword ptr [7FF9DB510970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FF9DB510978
       mov       r11,7FF9DB510978
       call      qword ptr [7FF9DB510978]
       call      qword ptr [7FF9DB510978]
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
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,203AC471BE0
       mov       rcx,203AC471BE0
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,2035C473090
       mov       rdx,2035C473090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,2035C473020
       mov       rdx,2035C473020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L21
       je        short M01_L21
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L21
       je        short M01_L21
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       mov       eax,1
M01_L21:
       mov       eax,1
M01_L22:
       test      eax,eax
M01_L22:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L23
       jne       near ptr M01_L23
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7C6A60
       mov       rdx,7FF9DB7C6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB7C6A60
       mov       rdx,7FF9DB7C6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7C6A60
       mov       rdx,7FF9DB7C6A60
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
M01_L23:
       cmp       [rcx],ecx
M01_L23:
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
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,203AC471BE8
       mov       rax,203AC471BE8
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L25
       je        short M01_L25
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L26
       jmp       short M01_L26
M01_L25:
       mov       eax,1
M01_L25:
       mov       eax,1
M01_L26:
       test      eax,eax
M01_L26:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L27
       jne       near ptr M01_L27
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7C6A60
       mov       rdx,7FF9DB7C6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB7C6A60
       mov       rdx,7FF9DB7C6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7C6A60
       mov       rdx,7FF9DB7C6A60
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
M01_L27:
       mov       edx,3
M01_L27:
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
M01_L28:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L28:
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
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FF9DB510978
       mov       r11,7FF9DB510978
       call      qword ptr [7FF9DB510978]
       call      qword ptr [7FF9DB510978]
M01_L29:
       nop
M01_L29:
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
; Total bytes of code 2634
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CF6FD8B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6FF210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3ED378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,2643B000338
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9CF0699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,2642D002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9CF0699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L28
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L28
M01_L02:
       mov       rcx,2642D002028
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
       je        near ptr M01_L30
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FF9CEEF8D08]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9CF3ED198]
       mov       r15,rax
       mov       rcx,2642D009820
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FF9CF3ED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF239CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF239CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3ED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FF9CF023510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3ED090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF3ED600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF0A7900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF9CF6EC208
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
       mov       rdx,7FF9CF6EC208
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
       mov       rdx,7FF9CF6EC450
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L31
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
       mov       rdx,7FF9CF6EC208
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
       mov       rdx,7FF9CF6EC230
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FF9CF347CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FF9CF6EC250
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FF9CEDE0AC0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L25
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FF9CF6EC268
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       ja        short M01_L22
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF6FD840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L24
M01_L22:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L23
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L24
M01_L23:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF0A7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FF9CEDE0AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FF9CEDE0AC8
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
M01_L26:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CF1D1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF1D1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FF9CF3ED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF239CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF239CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3ED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9CF023510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3ED078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1FD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FF9CEDD4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF1FD960]
       int       3
M01_L31:
       call      qword ptr [7FF9CEF8B630]
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
       je        short M01_L32
       mov       rcx,[rbp-48]
       mov       r11,7FF9CEDE0AC8
       call      qword ptr [r11]
M01_L32:
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
; Total bytes of code 1471
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       je        near ptr M01_L20
       je        near ptr M01_L20
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
       je        near ptr M01_L24
       je        near ptr M01_L24
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
       mov       rdx,7FF9DBC0DC28
       mov       rdx,7FF9DBC0DC28
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
       mov       rdx,7FF9DBC0DC28
       mov       rdx,7FF9DBC0DC28
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
       mov       rdx,7FF9DBC0DE98
       mov       rdx,7FF9DBC0DE98
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
       je        near ptr M01_L28
       je        near ptr M01_L28
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
       mov       rdx,7FF9DBC0DC28
       mov       rdx,7FF9DBC0DC28
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
       mov       rdx,7FF9DBC0DC50
       mov       rdx,7FF9DBC0DC50
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
       mov       rdx,7FF9DBC0DC70
       mov       rdx,7FF9DBC0DC70
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
       mov       r11,7FF9DB4F0970
       mov       r11,7FF9DB4F0970
       call      qword ptr [7FF9DB4F0970]
       call      qword ptr [7FF9DB4F0970]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L19
       je        near ptr M01_L19
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
       mov       rdx,7FF9DBC0DC88
       mov       rdx,7FF9DBC0DC88
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
       lea       ecx,[rsi+2]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       cmp       ecx,1
       ja        short M01_L16
       ja        short M01_L16
       mov       rcx,r15
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L18
       jmp       short M01_L18
M01_L16:
       inc       dword ptr [r15+14]
M01_L16:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L17
       jbe       short M01_L17
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
       jmp       short M01_L18
M01_L17:
       mov       rcx,r15
M01_L17:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       mov       rcx,rbx
M01_L18:
       mov       rcx,rbx
       mov       r11,7FF9DB4F0970
       mov       r11,7FF9DB4F0970
       call      qword ptr [7FF9DB4F0970]
       call      qword ptr [7FF9DB4F0970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FF9DB4F0978
       mov       r11,7FF9DB4F0978
       call      qword ptr [7FF9DB4F0978]
       call      qword ptr [7FF9DB4F0978]
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
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,2C45C9B1BE0
       mov       rcx,2C45C9B1BE0
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,2C3FC9B3090
       mov       rdx,2C3FC9B3090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,2C3FC9B3020
       mov       rdx,2C3FC9B3020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L21
       je        short M01_L21
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L21
       je        short M01_L21
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       mov       eax,1
M01_L21:
       mov       eax,1
M01_L22:
       test      eax,eax
M01_L22:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L23
       jne       near ptr M01_L23
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7A6A60
       mov       rdx,7FF9DB7A6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB7A6A60
       mov       rdx,7FF9DB7A6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7A6A60
       mov       rdx,7FF9DB7A6A60
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
M01_L23:
       cmp       [rcx],ecx
M01_L23:
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
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,2C45C9B1BE8
       mov       rax,2C45C9B1BE8
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L25
       je        short M01_L25
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L26
       jmp       short M01_L26
M01_L25:
       mov       eax,1
M01_L25:
       mov       eax,1
M01_L26:
       test      eax,eax
M01_L26:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L27
       jne       near ptr M01_L27
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7A6A60
       mov       rdx,7FF9DB7A6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB7A6A60
       mov       rdx,7FF9DB7A6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7A6A60
       mov       rdx,7FF9DB7A6A60
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
M01_L27:
       mov       edx,3
M01_L27:
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
M01_L28:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L28:
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
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FF9DB4F0978
       mov       r11,7FF9DB4F0978
       call      qword ptr [7FF9DB4F0978]
       call      qword ptr [7FF9DB4F0978]
M01_L29:
       nop
M01_L29:
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
; Total bytes of code 2634
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CF6EB8B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6ED210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3ED378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,2EA9F000338
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9CF0699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,2EA99002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9CF0699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L28
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L28
M01_L02:
       mov       rcx,2EA99002028
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
       je        near ptr M01_L30
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FF9CEEF8D08]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9CF3ED198]
       mov       r15,rax
       mov       rcx,2EAA9000C28
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FF9CF3ED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF239CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF239CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3ED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FF9CF023510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3ED090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF3ED600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF0A7900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF9CF6CEFC0
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
       mov       rdx,7FF9CF6CEFC0
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
       mov       rdx,7FF9CF6CF208
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L31
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
       mov       rdx,7FF9CF6CEFC0
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
       mov       rdx,7FF9CF6CEFE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FF9CF347CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FF9CF6CF008
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FF9CEDE0AC0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L25
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FF9CF6CF020
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       ja        short M01_L22
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF6EB840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L24
M01_L22:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L23
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L24
M01_L23:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF0A7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FF9CEDE0AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FF9CEDE0AC8
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
M01_L26:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CF1D1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF1D1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FF9CF3ED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF239CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF239CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3ED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9CF023510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3ED078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1FD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FF9CEDD4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF1FD960]
       int       3
M01_L31:
       call      qword ptr [7FF9CEF8B630]
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
       je        short M01_L32
       mov       rcx,[rbp-48]
       mov       r11,7FF9CEDE0AC8
       call      qword ptr [r11]
M01_L32:
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
; Total bytes of code 1471
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       je        near ptr M01_L20
       je        near ptr M01_L20
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
       je        near ptr M01_L24
       je        near ptr M01_L24
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
       mov       rdx,7FF9DBC0DC28
       mov       rdx,7FF9DBC0DC28
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
       mov       rdx,7FF9DBC0DC28
       mov       rdx,7FF9DBC0DC28
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
       mov       rdx,7FF9DBC0DE98
       mov       rdx,7FF9DBC0DE98
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
       je        near ptr M01_L28
       je        near ptr M01_L28
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
       mov       rdx,7FF9DBC0DC28
       mov       rdx,7FF9DBC0DC28
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
       mov       rdx,7FF9DBC0DC50
       mov       rdx,7FF9DBC0DC50
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
       mov       rdx,7FF9DBC0DC70
       mov       rdx,7FF9DBC0DC70
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
       mov       r11,7FF9DB4F0970
       mov       r11,7FF9DB4F0970
       call      qword ptr [7FF9DB4F0970]
       call      qword ptr [7FF9DB4F0970]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L19
       je        near ptr M01_L19
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
       mov       rdx,7FF9DBC0DC88
       mov       rdx,7FF9DBC0DC88
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
       lea       ecx,[rsi+2]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       cmp       ecx,1
       ja        short M01_L16
       ja        short M01_L16
       mov       rcx,r15
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L18
       jmp       short M01_L18
M01_L16:
       inc       dword ptr [r15+14]
M01_L16:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L17
       jbe       short M01_L17
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
       jmp       short M01_L18
M01_L17:
       mov       rcx,r15
M01_L17:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       mov       rcx,rbx
M01_L18:
       mov       rcx,rbx
       mov       r11,7FF9DB4F0970
       mov       r11,7FF9DB4F0970
       call      qword ptr [7FF9DB4F0970]
       call      qword ptr [7FF9DB4F0970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FF9DB4F0978
       mov       r11,7FF9DB4F0978
       call      qword ptr [7FF9DB4F0978]
       call      qword ptr [7FF9DB4F0978]
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
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,1E168AD1BE0
       mov       rcx,1E168AD1BE0
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,1E188AD3090
       mov       rdx,1E188AD3090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,1E188AD3020
       mov       rdx,1E188AD3020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L21
       je        short M01_L21
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L21
       je        short M01_L21
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       mov       eax,1
M01_L21:
       mov       eax,1
M01_L22:
       test      eax,eax
M01_L22:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L23
       jne       near ptr M01_L23
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7A6A60
       mov       rdx,7FF9DB7A6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB7A6A60
       mov       rdx,7FF9DB7A6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7A6A60
       mov       rdx,7FF9DB7A6A60
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
M01_L23:
       cmp       [rcx],ecx
M01_L23:
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
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,1E168AD1BE8
       mov       rax,1E168AD1BE8
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L25
       je        short M01_L25
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L26
       jmp       short M01_L26
M01_L25:
       mov       eax,1
M01_L25:
       mov       eax,1
M01_L26:
       test      eax,eax
M01_L26:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L27
       jne       near ptr M01_L27
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7A6A60
       mov       rdx,7FF9DB7A6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB7A6A60
       mov       rdx,7FF9DB7A6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7A6A60
       mov       rdx,7FF9DB7A6A60
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
M01_L27:
       mov       edx,3
M01_L27:
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
M01_L28:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L28:
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
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FF9DB4F0978
       mov       r11,7FF9DB4F0978
       call      qword ptr [7FF9DB4F0978]
       call      qword ptr [7FF9DB4F0978]
M01_L29:
       nop
M01_L29:
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
; Total bytes of code 2634
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CF6EB8B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6ED210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3ED378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,192AF800338
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9CF0699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,192AD802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9CF0699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L28
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L28
M01_L02:
       mov       rcx,192AD802028
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
       je        near ptr M01_L30
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FF9CEEF8D08]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9CF3ED198]
       mov       r15,rax
       mov       rcx,192AF801C40
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FF9CF3ED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF239CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF239CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3ED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FF9CF023510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3ED090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF3ED600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF0A7900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF9CF6DE2B8
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
       mov       rdx,7FF9CF6DE2B8
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
       mov       rdx,7FF9CF6DE500
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L31
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
       mov       rdx,7FF9CF6DE2B8
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
       mov       rdx,7FF9CF6DE2E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FF9CF347CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FF9CF6DE300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FF9CEDE0AC0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L25
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FF9CF6DE318
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       ja        short M01_L22
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF6EB840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L24
M01_L22:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L23
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L24
M01_L23:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF0A7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FF9CEDE0AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FF9CEDE0AC8
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
M01_L26:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CF1D1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF1D1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FF9CF3ED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF239CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF239CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3ED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9CF023510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3ED078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1FD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FF9CEDD4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF1FD960]
       int       3
M01_L31:
       call      qword ptr [7FF9CEF8B630]
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
       je        short M01_L32
       mov       rcx,[rbp-48]
       mov       r11,7FF9CEDE0AC8
       call      qword ptr [r11]
M01_L32:
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
; Total bytes of code 1471
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       je        near ptr M01_L20
       je        near ptr M01_L20
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
       je        near ptr M01_L24
       je        near ptr M01_L24
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
       mov       rdx,7FF9DBC0D870
       mov       rdx,7FF9DBC0D870
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
       mov       rdx,7FF9DBC0D870
       mov       rdx,7FF9DBC0D870
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
       mov       rdx,7FF9DBC0DAE0
       mov       rdx,7FF9DBC0DAE0
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
       je        near ptr M01_L28
       je        near ptr M01_L28
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
       mov       rdx,7FF9DBC0D870
       mov       rdx,7FF9DBC0D870
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
       mov       rdx,7FF9DBC0D898
       mov       rdx,7FF9DBC0D898
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
       mov       rdx,7FF9DBC0D8B8
       mov       rdx,7FF9DBC0D8B8
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
       mov       r11,7FF9DB4F0970
       mov       r11,7FF9DB4F0970
       call      qword ptr [7FF9DB4F0970]
       call      qword ptr [7FF9DB4F0970]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L19
       je        near ptr M01_L19
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
       mov       rdx,7FF9DBC0D8D0
       mov       rdx,7FF9DBC0D8D0
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
       lea       ecx,[rsi+2]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       cmp       ecx,1
       ja        short M01_L16
       ja        short M01_L16
       mov       rcx,r15
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L18
       jmp       short M01_L18
M01_L16:
       inc       dword ptr [r15+14]
M01_L16:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L17
       jbe       short M01_L17
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
       jmp       short M01_L18
M01_L17:
       mov       rcx,r15
M01_L17:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       mov       rcx,rbx
M01_L18:
       mov       rcx,rbx
       mov       r11,7FF9DB4F0970
       mov       r11,7FF9DB4F0970
       call      qword ptr [7FF9DB4F0970]
       call      qword ptr [7FF9DB4F0970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FF9DB4F0978
       mov       r11,7FF9DB4F0978
       call      qword ptr [7FF9DB4F0978]
       call      qword ptr [7FF9DB4F0978]
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
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,18BA1C71BE0
       mov       rcx,18BA1C71BE0
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,18BC1C73090
       mov       rdx,18BC1C73090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,18BC1C73020
       mov       rdx,18BC1C73020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L21
       je        short M01_L21
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L21
       je        short M01_L21
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       mov       eax,1
M01_L21:
       mov       eax,1
M01_L22:
       test      eax,eax
M01_L22:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L23
       jne       near ptr M01_L23
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7A6A60
       mov       rdx,7FF9DB7A6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB7A6A60
       mov       rdx,7FF9DB7A6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7A6A60
       mov       rdx,7FF9DB7A6A60
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
M01_L23:
       cmp       [rcx],ecx
M01_L23:
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
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,18BA1C71BE8
       mov       rax,18BA1C71BE8
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L25
       je        short M01_L25
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L26
       jmp       short M01_L26
M01_L25:
       mov       eax,1
M01_L25:
       mov       eax,1
M01_L26:
       test      eax,eax
M01_L26:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L27
       jne       near ptr M01_L27
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7A6A60
       mov       rdx,7FF9DB7A6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB7A6A60
       mov       rdx,7FF9DB7A6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7A6A60
       mov       rdx,7FF9DB7A6A60
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
M01_L27:
       mov       edx,3
M01_L27:
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
M01_L28:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L28:
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
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FF9DB4F0978
       mov       r11,7FF9DB4F0978
       call      qword ptr [7FF9DB4F0978]
       call      qword ptr [7FF9DB4F0978]
M01_L29:
       nop
M01_L29:
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
; Total bytes of code 2634
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CF6EB8B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6ED210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3ED378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,2E82D800338
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9CF0699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,2E827802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9CF0699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L28
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L28
M01_L02:
       mov       rcx,2E827802028
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
       je        near ptr M01_L30
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FF9CEEF8D08]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9CF3ED198]
       mov       r15,rax
       mov       rcx,2E827809820
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FF9CF3ED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF239CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF239CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3ED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FF9CF023510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3ED090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF3ED600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF0A7900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF9CF6DE5B8
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
       mov       rdx,7FF9CF6DE5B8
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
       mov       rdx,7FF9CF6DE800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L31
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
       mov       rdx,7FF9CF6DE5B8
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
       mov       rdx,7FF9CF6DE5E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FF9CF347CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FF9CF6DE600
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FF9CEDE0AC0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L25
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FF9CF6DE618
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       ja        short M01_L22
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF6EB840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L24
M01_L22:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L23
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L24
M01_L23:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF0A7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FF9CEDE0AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FF9CEDE0AC8
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
M01_L26:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CF1D1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF1D1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FF9CF3ED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF239CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF239CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3ED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9CF023510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3ED078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1FD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FF9CEDD4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF1FD960]
       int       3
M01_L31:
       call      qword ptr [7FF9CEF8B630]
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
       je        short M01_L32
       mov       rcx,[rbp-48]
       mov       r11,7FF9CEDE0AC8
       call      qword ptr [r11]
M01_L32:
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
; Total bytes of code 1471
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       je        near ptr M01_L20
       je        near ptr M01_L20
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
       je        near ptr M01_L24
       je        near ptr M01_L24
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
       mov       rdx,7FF9DBC3DC28
       mov       rdx,7FF9DBC3DC28
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
       mov       rdx,7FF9DBC3DC28
       mov       rdx,7FF9DBC3DC28
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
       mov       rdx,7FF9DBC3DE98
       mov       rdx,7FF9DBC3DE98
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
       je        near ptr M01_L28
       je        near ptr M01_L28
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
       mov       rdx,7FF9DBC3DC28
       mov       rdx,7FF9DBC3DC28
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
       mov       rdx,7FF9DBC3DC50
       mov       rdx,7FF9DBC3DC50
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
       mov       rdx,7FF9DBC3DC70
       mov       rdx,7FF9DBC3DC70
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
       mov       r11,7FF9DB520970
       mov       r11,7FF9DB520970
       call      qword ptr [7FF9DB520970]
       call      qword ptr [7FF9DB520970]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L19
       je        near ptr M01_L19
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
       mov       rdx,7FF9DBC3DC88
       mov       rdx,7FF9DBC3DC88
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
       lea       ecx,[rsi+2]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       cmp       ecx,1
       ja        short M01_L16
       ja        short M01_L16
       mov       rcx,r15
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L18
       jmp       short M01_L18
M01_L16:
       inc       dword ptr [r15+14]
M01_L16:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L17
       jbe       short M01_L17
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
       jmp       short M01_L18
M01_L17:
       mov       rcx,r15
M01_L17:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       mov       rcx,rbx
M01_L18:
       mov       rcx,rbx
       mov       r11,7FF9DB520970
       mov       r11,7FF9DB520970
       call      qword ptr [7FF9DB520970]
       call      qword ptr [7FF9DB520970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FF9DB520978
       mov       r11,7FF9DB520978
       call      qword ptr [7FF9DB520978]
       call      qword ptr [7FF9DB520978]
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
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,1F0D8221BE0
       mov       rcx,1F0D8221BE0
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,1F088223090
       mov       rdx,1F088223090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,1F088223020
       mov       rdx,1F088223020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L21
       je        short M01_L21
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L21
       je        short M01_L21
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       mov       eax,1
M01_L21:
       mov       eax,1
M01_L22:
       test      eax,eax
M01_L22:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L23
       jne       near ptr M01_L23
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7D6A60
       mov       rdx,7FF9DB7D6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB7D6A60
       mov       rdx,7FF9DB7D6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7D6A60
       mov       rdx,7FF9DB7D6A60
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
M01_L23:
       cmp       [rcx],ecx
M01_L23:
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
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,1F0D8221BE8
       mov       rax,1F0D8221BE8
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L25
       je        short M01_L25
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L26
       jmp       short M01_L26
M01_L25:
       mov       eax,1
M01_L25:
       mov       eax,1
M01_L26:
       test      eax,eax
M01_L26:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L27
       jne       near ptr M01_L27
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7D6A60
       mov       rdx,7FF9DB7D6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB7D6A60
       mov       rdx,7FF9DB7D6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7D6A60
       mov       rdx,7FF9DB7D6A60
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
M01_L27:
       mov       edx,3
M01_L27:
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
M01_L28:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L28:
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
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FF9DB520978
       mov       r11,7FF9DB520978
       call      qword ptr [7FF9DB520978]
       call      qword ptr [7FF9DB520978]
M01_L29:
       nop
M01_L29:
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
; Total bytes of code 2634
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CF6E9BB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6EB4B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3ED378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,1E970C08F30
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9CF0699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,1E970C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9CF0699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L28
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L28
M01_L02:
       mov       rcx,1E970C02028
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
       je        near ptr M01_L30
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FF9CEEF8D08]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9CF3ED198]
       mov       r15,rax
       mov       rcx,1E978C00C28
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FF9CF3ED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF239CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF239CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3ED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FF9CF023510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3ED090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF3ED600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF0A7900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF9CF6CEF10
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
       mov       rdx,7FF9CF6CEF10
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
       mov       rdx,7FF9CF6CF158
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L31
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
       mov       rdx,7FF9CF6CEF10
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
       mov       rdx,7FF9CF6CEF38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FF9CF347CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FF9CF6CEF58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FF9CEDE0AC0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L25
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FF9CF6CEF70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       ja        short M01_L22
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF6E9B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L24
M01_L22:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L23
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L24
M01_L23:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF0A7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FF9CEDE0AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FF9CEDE0AC8
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
M01_L26:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CF1D1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF1D1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FF9CF3ED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF239CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF239CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3ED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9CF023510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3ED078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1FD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FF9CEDD4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF1FD960]
       int       3
M01_L31:
       call      qword ptr [7FF9CEF8B630]
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
       je        short M01_L32
       mov       rcx,[rbp-48]
       mov       r11,7FF9CEDE0AC8
       call      qword ptr [r11]
M01_L32:
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
; Total bytes of code 1471
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       je        near ptr M01_L20
       je        near ptr M01_L20
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
       je        near ptr M01_L24
       je        near ptr M01_L24
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
       mov       rdx,7FF9DBBFDC28
       mov       rdx,7FF9DBBFDC28
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
       mov       rdx,7FF9DBBFDC28
       mov       rdx,7FF9DBBFDC28
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
       mov       rdx,7FF9DBBFDE98
       mov       rdx,7FF9DBBFDE98
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
       je        near ptr M01_L28
       je        near ptr M01_L28
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
       mov       rdx,7FF9DBBFDC28
       mov       rdx,7FF9DBBFDC28
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
       mov       rdx,7FF9DBBFDC50
       mov       rdx,7FF9DBBFDC50
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
       mov       rdx,7FF9DBBFDC70
       mov       rdx,7FF9DBBFDC70
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
       mov       r11,7FF9DB4E0970
       mov       r11,7FF9DB4E0970
       call      qword ptr [7FF9DB4E0970]
       call      qword ptr [7FF9DB4E0970]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L19
       je        near ptr M01_L19
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
       mov       rdx,7FF9DBBFDC88
       mov       rdx,7FF9DBBFDC88
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
       lea       ecx,[rsi+2]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       cmp       ecx,1
       ja        short M01_L16
       ja        short M01_L16
       mov       rcx,r15
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L18
       jmp       short M01_L18
M01_L16:
       inc       dword ptr [r15+14]
M01_L16:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L17
       jbe       short M01_L17
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
       jmp       short M01_L18
M01_L17:
       mov       rcx,r15
M01_L17:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       mov       rcx,rbx
M01_L18:
       mov       rcx,rbx
       mov       r11,7FF9DB4E0970
       mov       r11,7FF9DB4E0970
       call      qword ptr [7FF9DB4E0970]
       call      qword ptr [7FF9DB4E0970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FF9DB4E0978
       mov       r11,7FF9DB4E0978
       call      qword ptr [7FF9DB4E0978]
       call      qword ptr [7FF9DB4E0978]
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
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,1E2EE0D1BE0
       mov       rcx,1E2EE0D1BE0
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,1E25E0D3090
       mov       rdx,1E25E0D3090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,1E25E0D3020
       mov       rdx,1E25E0D3020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L21
       je        short M01_L21
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L21
       je        short M01_L21
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       mov       eax,1
M01_L21:
       mov       eax,1
M01_L22:
       test      eax,eax
M01_L22:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L23
       jne       near ptr M01_L23
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB796A60
       mov       rdx,7FF9DB796A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB796A60
       mov       rdx,7FF9DB796A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB796A60
       mov       rdx,7FF9DB796A60
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
M01_L23:
       cmp       [rcx],ecx
M01_L23:
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
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,1E2EE0D1BE8
       mov       rax,1E2EE0D1BE8
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L25
       je        short M01_L25
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L26
       jmp       short M01_L26
M01_L25:
       mov       eax,1
M01_L25:
       mov       eax,1
M01_L26:
       test      eax,eax
M01_L26:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L27
       jne       near ptr M01_L27
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB796A60
       mov       rdx,7FF9DB796A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB796A60
       mov       rdx,7FF9DB796A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB796A60
       mov       rdx,7FF9DB796A60
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
M01_L27:
       mov       edx,3
M01_L27:
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
M01_L28:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L28:
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
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FF9DB4E0978
       mov       r11,7FF9DB4E0978
       call      qword ptr [7FF9DB4E0978]
       call      qword ptr [7FF9DB4E0978]
M01_L29:
       nop
M01_L29:
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
; Total bytes of code 2634
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CF6FBBB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6FD4B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3FD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,11FFA808F30
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9CF0799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,11FFA802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9CF0799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L28
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L28
M01_L02:
       mov       rcx,11FFA802028
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
       je        near ptr M01_L30
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FF9CEF08D08]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9CF3FD198]
       mov       r15,rax
       mov       rcx,12004800C28
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FF9CF3FD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF249CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF249CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3FD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF20D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FF9CF033510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3FD090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF3FD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1E5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF0B7900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF9CF6EDFA0
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
       mov       rdx,7FF9CF6EDFA0
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
       mov       rdx,7FF9CF6EE1E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L31
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
       mov       rdx,7FF9CF6EDFA0
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
       mov       rdx,7FF9CF6EDFC8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FF9CF357CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FF9CF6EDFE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FF9CEDF0AC0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L25
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FF9CF6EE000
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       ja        short M01_L22
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF6FBB40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L24
M01_L22:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L23
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L24
M01_L23:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF0B7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FF9CEDF0AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FF9CEDF0AC8
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
M01_L26:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CF1E1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF1E1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FF9CF3FD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF249CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF249CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3FD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF20D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9CF033510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3FD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF20D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FF9CEDE4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF20D960]
       int       3
M01_L31:
       call      qword ptr [7FF9CEF9B630]
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
       je        short M01_L32
       mov       rcx,[rbp-48]
       mov       r11,7FF9CEDF0AC8
       call      qword ptr [r11]
M01_L32:
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
; Total bytes of code 1471
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       je        near ptr M01_L20
       je        near ptr M01_L20
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
       je        near ptr M01_L24
       je        near ptr M01_L24
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
       mov       rdx,7FF9DBC2DC28
       mov       rdx,7FF9DBC2DC28
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
       mov       rdx,7FF9DBC2DC28
       mov       rdx,7FF9DBC2DC28
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
       mov       rdx,7FF9DBC2DE98
       mov       rdx,7FF9DBC2DE98
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
       je        near ptr M01_L28
       je        near ptr M01_L28
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
       mov       rdx,7FF9DBC2DC28
       mov       rdx,7FF9DBC2DC28
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
       mov       rdx,7FF9DBC2DC50
       mov       rdx,7FF9DBC2DC50
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
       mov       rdx,7FF9DBC2DC70
       mov       rdx,7FF9DBC2DC70
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
       mov       r11,7FF9DB510970
       mov       r11,7FF9DB510970
       call      qword ptr [7FF9DB510970]
       call      qword ptr [7FF9DB510970]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L19
       je        near ptr M01_L19
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
       mov       rdx,7FF9DBC2DC88
       mov       rdx,7FF9DBC2DC88
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
       lea       ecx,[rsi+2]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       cmp       ecx,1
       ja        short M01_L16
       ja        short M01_L16
       mov       rcx,r15
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L18
       jmp       short M01_L18
M01_L16:
       inc       dword ptr [r15+14]
M01_L16:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L17
       jbe       short M01_L17
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
       jmp       short M01_L18
M01_L17:
       mov       rcx,r15
M01_L17:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       mov       rcx,rbx
M01_L18:
       mov       rcx,rbx
       mov       r11,7FF9DB510970
       mov       r11,7FF9DB510970
       call      qword ptr [7FF9DB510970]
       call      qword ptr [7FF9DB510970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FF9DB510978
       mov       r11,7FF9DB510978
       call      qword ptr [7FF9DB510978]
       call      qword ptr [7FF9DB510978]
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
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,1C5DE611BE0
       mov       rcx,1C5DE611BE0
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,1C54E613090
       mov       rdx,1C54E613090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,1C54E613020
       mov       rdx,1C54E613020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L21
       je        short M01_L21
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L21
       je        short M01_L21
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       mov       eax,1
M01_L21:
       mov       eax,1
M01_L22:
       test      eax,eax
M01_L22:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L23
       jne       near ptr M01_L23
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7C6A60
       mov       rdx,7FF9DB7C6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB7C6A60
       mov       rdx,7FF9DB7C6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7C6A60
       mov       rdx,7FF9DB7C6A60
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
M01_L23:
       cmp       [rcx],ecx
M01_L23:
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
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,1C5DE611BE8
       mov       rax,1C5DE611BE8
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L25
       je        short M01_L25
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L26
       jmp       short M01_L26
M01_L25:
       mov       eax,1
M01_L25:
       mov       eax,1
M01_L26:
       test      eax,eax
M01_L26:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L27
       jne       near ptr M01_L27
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7C6A60
       mov       rdx,7FF9DB7C6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB7C6A60
       mov       rdx,7FF9DB7C6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7C6A60
       mov       rdx,7FF9DB7C6A60
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
M01_L27:
       mov       edx,3
M01_L27:
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
M01_L28:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L28:
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
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FF9DB510978
       mov       r11,7FF9DB510978
       call      qword ptr [7FF9DB510978]
       call      qword ptr [7FF9DB510978]
M01_L29:
       nop
M01_L29:
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
; Total bytes of code 2634
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CF6CB8B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6CD210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3CD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,1C0E4C00338
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,1C0E6C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L28
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L28
M01_L02:
       mov       rcx,1C0E6C02028
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
       je        near ptr M01_L30
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FF9CEED8D08]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9CF3CD198]
       mov       r15,rax
       mov       rcx,1C0E4C01C40
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FF9CF3CD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF219CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF219CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3CD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FF9CF003510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3CD090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF3CD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF087900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF9CF6AF258
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
       mov       rdx,7FF9CF6AF258
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
       mov       rdx,7FF9CF6AF4A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L31
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
       mov       rdx,7FF9CF6AF258
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
       mov       rdx,7FF9CF6AF280
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FF9CF327CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FF9CF6AF2A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FF9CEDC0AC0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L25
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FF9CF6AF2B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       ja        short M01_L22
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF6CB840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L24
M01_L22:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L23
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L24
M01_L23:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF087A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FF9CEDC0AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FF9CEDC0AC8
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
M01_L26:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CF1B1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FF9CF3CD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF219CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF219CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3CD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9CF003510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1DD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF1DD960]
       int       3
M01_L31:
       call      qword ptr [7FF9CEF6B630]
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
       je        short M01_L32
       mov       rcx,[rbp-48]
       mov       r11,7FF9CEDC0AC8
       call      qword ptr [r11]
M01_L32:
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
; Total bytes of code 1471
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       je        near ptr M01_L20
       je        near ptr M01_L20
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
       je        near ptr M01_L24
       je        near ptr M01_L24
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
       mov       rdx,7FF9DBC1DC28
       mov       rdx,7FF9DBC1DC28
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
       mov       rdx,7FF9DBC1DC28
       mov       rdx,7FF9DBC1DC28
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
       mov       rdx,7FF9DBC1DE98
       mov       rdx,7FF9DBC1DE98
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
       je        near ptr M01_L28
       je        near ptr M01_L28
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
       mov       rdx,7FF9DBC1DC28
       mov       rdx,7FF9DBC1DC28
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
       mov       rdx,7FF9DBC1DC50
       mov       rdx,7FF9DBC1DC50
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
       mov       rdx,7FF9DBC1DC70
       mov       rdx,7FF9DBC1DC70
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
       mov       r11,7FF9DB500970
       mov       r11,7FF9DB500970
       call      qword ptr [7FF9DB500970]
       call      qword ptr [7FF9DB500970]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L19
       je        near ptr M01_L19
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
       mov       rdx,7FF9DBC1DC88
       mov       rdx,7FF9DBC1DC88
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
       lea       ecx,[rsi+2]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       cmp       ecx,1
       ja        short M01_L16
       ja        short M01_L16
       mov       rcx,r15
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L18
       jmp       short M01_L18
M01_L16:
       inc       dword ptr [r15+14]
M01_L16:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L17
       jbe       short M01_L17
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
       jmp       short M01_L18
M01_L17:
       mov       rcx,r15
M01_L17:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       mov       rcx,rbx
M01_L18:
       mov       rcx,rbx
       mov       r11,7FF9DB500970
       mov       r11,7FF9DB500970
       call      qword ptr [7FF9DB500970]
       call      qword ptr [7FF9DB500970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FF9DB500978
       mov       r11,7FF9DB500978
       call      qword ptr [7FF9DB500978]
       call      qword ptr [7FF9DB500978]
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
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,16DFB2C1BE0
       mov       rcx,16DFB2C1BE0
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,16D8B2C3090
       mov       rdx,16D8B2C3090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,16D8B2C3020
       mov       rdx,16D8B2C3020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L21
       je        short M01_L21
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L21
       je        short M01_L21
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       mov       eax,1
M01_L21:
       mov       eax,1
M01_L22:
       test      eax,eax
M01_L22:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L23
       jne       near ptr M01_L23
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7B6A60
       mov       rdx,7FF9DB7B6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB7B6A60
       mov       rdx,7FF9DB7B6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7B6A60
       mov       rdx,7FF9DB7B6A60
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
M01_L23:
       cmp       [rcx],ecx
M01_L23:
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
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,16DFB2C1BE8
       mov       rax,16DFB2C1BE8
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L25
       je        short M01_L25
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L26
       jmp       short M01_L26
M01_L25:
       mov       eax,1
M01_L25:
       mov       eax,1
M01_L26:
       test      eax,eax
M01_L26:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L27
       jne       near ptr M01_L27
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7B6A60
       mov       rdx,7FF9DB7B6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB7B6A60
       mov       rdx,7FF9DB7B6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7B6A60
       mov       rdx,7FF9DB7B6A60
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
M01_L27:
       mov       edx,3
M01_L27:
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
M01_L28:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L28:
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
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FF9DB500978
       mov       r11,7FF9DB500978
       call      qword ptr [7FF9DB500978]
       call      qword ptr [7FF9DB500978]
M01_L29:
       nop
M01_L29:
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
; Total bytes of code 2634
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CF6DB8B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6DD210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3DD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,21DB8000338
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9CF0599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,21DB6002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9CF0599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L28
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L28
M01_L02:
       mov       rcx,21DB6002028
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
       je        near ptr M01_L30
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FF9CEEE8D08]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9CF3DD198]
       mov       r15,rax
       mov       rcx,21DC2000C28
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FF9CF3DD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF229CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF229CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3DD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FF9CF013510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3DD090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF3DD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1C5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF097900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF9CF6CE3E0
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
       mov       rdx,7FF9CF6CE3E0
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
       mov       rdx,7FF9CF6CE628
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L31
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
       mov       rdx,7FF9CF6CE3E0
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
       mov       rdx,7FF9CF6CE408
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FF9CF337CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FF9CF6CE428
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FF9CEDD0AB8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L25
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FF9CF6CE440
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       ja        short M01_L22
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF6DB840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L24
M01_L22:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L23
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L24
M01_L23:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF097A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FF9CEDD0AB8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FF9CEDD0AC0
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
M01_L26:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CF1C1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF1C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FF9CF3DD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF229CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF229CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3DD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9CF013510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3DD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1ED8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FF9CEDC4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF1ED960]
       int       3
M01_L31:
       call      qword ptr [7FF9CEF7B630]
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
       je        short M01_L32
       mov       rcx,[rbp-48]
       mov       r11,7FF9CEDD0AC0
       call      qword ptr [r11]
M01_L32:
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
; Total bytes of code 1471
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       je        near ptr M01_L20
       je        near ptr M01_L20
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
       je        near ptr M01_L24
       je        near ptr M01_L24
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
       mov       rdx,7FF9DBC1DC28
       mov       rdx,7FF9DBC1DC28
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
       mov       rdx,7FF9DBC1DC28
       mov       rdx,7FF9DBC1DC28
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
       mov       rdx,7FF9DBC1DE98
       mov       rdx,7FF9DBC1DE98
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
       je        near ptr M01_L28
       je        near ptr M01_L28
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
       mov       rdx,7FF9DBC1DC28
       mov       rdx,7FF9DBC1DC28
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
       mov       rdx,7FF9DBC1DC50
       mov       rdx,7FF9DBC1DC50
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
       mov       rdx,7FF9DBC1DC70
       mov       rdx,7FF9DBC1DC70
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
       mov       r11,7FF9DB500970
       mov       r11,7FF9DB500970
       call      qword ptr [7FF9DB500970]
       call      qword ptr [7FF9DB500970]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L19
       je        near ptr M01_L19
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
       mov       rdx,7FF9DBC1DC88
       mov       rdx,7FF9DBC1DC88
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
       lea       ecx,[rsi+2]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       cmp       ecx,1
       ja        short M01_L16
       ja        short M01_L16
       mov       rcx,r15
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L18
       jmp       short M01_L18
M01_L16:
       inc       dword ptr [r15+14]
M01_L16:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L17
       jbe       short M01_L17
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
       jmp       short M01_L18
M01_L17:
       mov       rcx,r15
M01_L17:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       mov       rcx,rbx
M01_L18:
       mov       rcx,rbx
       mov       r11,7FF9DB500970
       mov       r11,7FF9DB500970
       call      qword ptr [7FF9DB500970]
       call      qword ptr [7FF9DB500970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FF9DB500978
       mov       r11,7FF9DB500978
       call      qword ptr [7FF9DB500978]
       call      qword ptr [7FF9DB500978]
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
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,25E3CAA1BE0
       mov       rcx,25E3CAA1BE0
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,25DDCAA3090
       mov       rdx,25DDCAA3090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,25DDCAA3020
       mov       rdx,25DDCAA3020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L21
       je        short M01_L21
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L21
       je        short M01_L21
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       mov       eax,1
M01_L21:
       mov       eax,1
M01_L22:
       test      eax,eax
M01_L22:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L23
       jne       near ptr M01_L23
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7B6A60
       mov       rdx,7FF9DB7B6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB7B6A60
       mov       rdx,7FF9DB7B6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7B6A60
       mov       rdx,7FF9DB7B6A60
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
M01_L23:
       cmp       [rcx],ecx
M01_L23:
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
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,25E3CAA1BE8
       mov       rax,25E3CAA1BE8
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L25
       je        short M01_L25
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L26
       jmp       short M01_L26
M01_L25:
       mov       eax,1
M01_L25:
       mov       eax,1
M01_L26:
       test      eax,eax
M01_L26:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L27
       jne       near ptr M01_L27
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7B6A60
       mov       rdx,7FF9DB7B6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB7B6A60
       mov       rdx,7FF9DB7B6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7B6A60
       mov       rdx,7FF9DB7B6A60
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
M01_L27:
       mov       edx,3
M01_L27:
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
M01_L28:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L28:
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
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FF9DB500978
       mov       r11,7FF9DB500978
       call      qword ptr [7FF9DB500978]
       call      qword ptr [7FF9DB500978]
M01_L29:
       nop
M01_L29:
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
; Total bytes of code 2634
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CF6DB8B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6DD210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3DD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,24B6B000338
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9CF0599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,24B69002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9CF0599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L28
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L28
M01_L02:
       mov       rcx,24B69002028
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
       je        near ptr M01_L30
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FF9CEEE8D08]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9CF3DD198]
       mov       r15,rax
       mov       rcx,24B690117B8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FF9CF3DD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF229CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF229CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3DD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FF9CF013510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3DD090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF3DD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1C5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF097900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF9CF6CE190
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
       mov       rdx,7FF9CF6CE190
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
       mov       rdx,7FF9CF6CE3D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L31
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
       mov       rdx,7FF9CF6CE190
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
       mov       rdx,7FF9CF6CE1B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FF9CF337CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FF9CF6CE1D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FF9CEDD0AC0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L25
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FF9CF6CE1F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       ja        short M01_L22
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF6DB840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L24
M01_L22:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L23
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L24
M01_L23:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF097A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FF9CEDD0AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FF9CEDD0AC8
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
M01_L26:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CF1C1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF1C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FF9CF3DD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF229CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF229CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3DD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9CF013510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3DD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1ED8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FF9CEDC4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF1ED960]
       int       3
M01_L31:
       call      qword ptr [7FF9CEF7B630]
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
       je        short M01_L32
       mov       rcx,[rbp-48]
       mov       r11,7FF9CEDD0AC8
       call      qword ptr [r11]
M01_L32:
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
; Total bytes of code 1471
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       je        near ptr M01_L20
       je        near ptr M01_L20
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
       je        near ptr M01_L24
       je        near ptr M01_L24
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
       mov       rdx,7FF9DBC3DC28
       mov       rdx,7FF9DBC3DC28
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
       mov       rdx,7FF9DBC3DC28
       mov       rdx,7FF9DBC3DC28
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
       mov       rdx,7FF9DBC3DE98
       mov       rdx,7FF9DBC3DE98
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
       je        near ptr M01_L28
       je        near ptr M01_L28
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
       mov       rdx,7FF9DBC3DC28
       mov       rdx,7FF9DBC3DC28
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
       mov       rdx,7FF9DBC3DC50
       mov       rdx,7FF9DBC3DC50
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
       mov       rdx,7FF9DBC3DC70
       mov       rdx,7FF9DBC3DC70
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
       mov       r11,7FF9DB520970
       mov       r11,7FF9DB520970
       call      qword ptr [7FF9DB520970]
       call      qword ptr [7FF9DB520970]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L19
       je        near ptr M01_L19
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
       mov       rdx,7FF9DBC3DC88
       mov       rdx,7FF9DBC3DC88
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
       lea       ecx,[rsi+2]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       cmp       ecx,1
       ja        short M01_L16
       ja        short M01_L16
       mov       rcx,r15
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L18
       jmp       short M01_L18
M01_L16:
       inc       dword ptr [r15+14]
M01_L16:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L17
       jbe       short M01_L17
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
       jmp       short M01_L18
M01_L17:
       mov       rcx,r15
M01_L17:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       mov       rcx,rbx
M01_L18:
       mov       rcx,rbx
       mov       r11,7FF9DB520970
       mov       r11,7FF9DB520970
       call      qword ptr [7FF9DB520970]
       call      qword ptr [7FF9DB520970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FF9DB520978
       mov       r11,7FF9DB520978
       call      qword ptr [7FF9DB520978]
       call      qword ptr [7FF9DB520978]
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
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,206B3101BE0
       mov       rcx,206B3101BE0
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,206D3103090
       mov       rdx,206D3103090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,206D3103020
       mov       rdx,206D3103020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L21
       je        short M01_L21
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L21
       je        short M01_L21
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       mov       eax,1
M01_L21:
       mov       eax,1
M01_L22:
       test      eax,eax
M01_L22:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L23
       jne       near ptr M01_L23
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7D6A60
       mov       rdx,7FF9DB7D6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB7D6A60
       mov       rdx,7FF9DB7D6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7D6A60
       mov       rdx,7FF9DB7D6A60
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
M01_L23:
       cmp       [rcx],ecx
M01_L23:
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
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,206B3101BE8
       mov       rax,206B3101BE8
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L25
       je        short M01_L25
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L26
       jmp       short M01_L26
M01_L25:
       mov       eax,1
M01_L25:
       mov       eax,1
M01_L26:
       test      eax,eax
M01_L26:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L27
       jne       near ptr M01_L27
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7D6A60
       mov       rdx,7FF9DB7D6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB7D6A60
       mov       rdx,7FF9DB7D6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7D6A60
       mov       rdx,7FF9DB7D6A60
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
M01_L27:
       mov       edx,3
M01_L27:
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
M01_L28:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L28:
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
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FF9DB520978
       mov       r11,7FF9DB520978
       call      qword ptr [7FF9DB520978]
       call      qword ptr [7FF9DB520978]
M01_L29:
       nop
M01_L29:
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
; Total bytes of code 2634
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CF6C98B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6CB210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3CD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,27034800338
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,27036802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L28
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L28
M01_L02:
       mov       rcx,27036802028
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
       je        near ptr M01_L30
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FF9CEED8D08]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9CF3CD198]
       mov       r15,rax
       mov       rcx,27034801C40
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FF9CF3CD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF219CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF219CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3CD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FF9CF003510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3CD090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF3CD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF087900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF9CF6AEFE8
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
       mov       rdx,7FF9CF6AEFE8
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
       mov       rdx,7FF9CF6AF230
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L31
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
       mov       rdx,7FF9CF6AEFE8
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
       mov       rdx,7FF9CF6AF010
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FF9CF327CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FF9CF6AF030
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FF9CEDC0AC0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L25
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FF9CF6AF048
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       ja        short M01_L22
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF6C9840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L24
M01_L22:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L23
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L24
M01_L23:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF087A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FF9CEDC0AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FF9CEDC0AC8
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
M01_L26:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CF1B1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FF9CF3CD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF219CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF219CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3CD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9CF003510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1DD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF1DD960]
       int       3
M01_L31:
       call      qword ptr [7FF9CEF6B630]
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
       je        short M01_L32
       mov       rcx,[rbp-48]
       mov       r11,7FF9CEDC0AC8
       call      qword ptr [r11]
M01_L32:
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
; Total bytes of code 1471
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       je        near ptr M01_L20
       je        near ptr M01_L20
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
       je        near ptr M01_L24
       je        near ptr M01_L24
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
       mov       rdx,7FF9DBBFDC28
       mov       rdx,7FF9DBBFDC28
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
       mov       rdx,7FF9DBBFDC28
       mov       rdx,7FF9DBBFDC28
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
       mov       rdx,7FF9DBBFDE98
       mov       rdx,7FF9DBBFDE98
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
       je        near ptr M01_L28
       je        near ptr M01_L28
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
       mov       rdx,7FF9DBBFDC28
       mov       rdx,7FF9DBBFDC28
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
       mov       rdx,7FF9DBBFDC50
       mov       rdx,7FF9DBBFDC50
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
       mov       rdx,7FF9DBBFDC70
       mov       rdx,7FF9DBBFDC70
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
       mov       r11,7FF9DB4E0970
       mov       r11,7FF9DB4E0970
       call      qword ptr [7FF9DB4E0970]
       call      qword ptr [7FF9DB4E0970]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L19
       je        near ptr M01_L19
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
       mov       rdx,7FF9DBBFDC88
       mov       rdx,7FF9DBBFDC88
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
       lea       ecx,[rsi+2]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       cmp       ecx,1
       ja        short M01_L16
       ja        short M01_L16
       mov       rcx,r15
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L18
       jmp       short M01_L18
M01_L16:
       inc       dword ptr [r15+14]
M01_L16:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L17
       jbe       short M01_L17
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
       jmp       short M01_L18
M01_L17:
       mov       rcx,r15
M01_L17:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       mov       rcx,rbx
M01_L18:
       mov       rcx,rbx
       mov       r11,7FF9DB4E0970
       mov       r11,7FF9DB4E0970
       call      qword ptr [7FF9DB4E0970]
       call      qword ptr [7FF9DB4E0970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FF9DB4E0978
       mov       r11,7FF9DB4E0978
       call      qword ptr [7FF9DB4E0978]
       call      qword ptr [7FF9DB4E0978]
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
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,1A62E6A1BE0
       mov       rcx,1A62E6A1BE0
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,1A64E6A1098
       mov       rdx,1A64E6A1098
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,1A64E6A1028
       mov       rdx,1A64E6A1028
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L21
       je        short M01_L21
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L21
       je        short M01_L21
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       mov       eax,1
M01_L21:
       mov       eax,1
M01_L22:
       test      eax,eax
M01_L22:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L23
       jne       near ptr M01_L23
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB796A60
       mov       rdx,7FF9DB796A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB796A60
       mov       rdx,7FF9DB796A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB796A60
       mov       rdx,7FF9DB796A60
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
M01_L23:
       cmp       [rcx],ecx
M01_L23:
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
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,1A62E6A1BE8
       mov       rax,1A62E6A1BE8
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L25
       je        short M01_L25
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L26
       jmp       short M01_L26
M01_L25:
       mov       eax,1
M01_L25:
       mov       eax,1
M01_L26:
       test      eax,eax
M01_L26:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L27
       jne       near ptr M01_L27
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB796A60
       mov       rdx,7FF9DB796A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB796A60
       mov       rdx,7FF9DB796A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB796A60
       mov       rdx,7FF9DB796A60
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
M01_L27:
       mov       edx,3
M01_L27:
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
M01_L28:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L28:
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
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FF9DB4E0978
       mov       r11,7FF9DB4E0978
       call      qword ptr [7FF9DB4E0978]
       call      qword ptr [7FF9DB4E0978]
M01_L29:
       nop
M01_L29:
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
; Total bytes of code 2634
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CF6EB8B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6ED210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3ED378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,1DC6AC02330
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9CF0699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,1DC66C00098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9CF0699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L28
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L28
M01_L02:
       mov       rcx,1DC66C00030
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
       je        near ptr M01_L30
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FF9CEEF8D08]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9CF3ED198]
       mov       r15,rax
       mov       rcx,1DC70C00C28
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FF9CF3ED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF239CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF239CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3ED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FF9CF023510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3ED090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF3ED600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF0A7900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF9CF6DE008
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
       mov       rdx,7FF9CF6DE008
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
       mov       rdx,7FF9CF6DE250
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L31
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
       mov       rdx,7FF9CF6DE008
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
       mov       rdx,7FF9CF6DE030
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FF9CF347CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FF9CF6DE050
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FF9CEDE0AC0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L25
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FF9CF6DE068
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       ja        short M01_L22
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF6EB840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L24
M01_L22:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L23
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L24
M01_L23:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF0A7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FF9CEDE0AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FF9CEDE0AC8
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
M01_L26:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CF1D1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF1D1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FF9CF3ED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF239CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF239CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3ED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9CF023510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3ED078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1FD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FF9CEDD4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF1FD960]
       int       3
M01_L31:
       call      qword ptr [7FF9CEF8B630]
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
       je        short M01_L32
       mov       rcx,[rbp-48]
       mov       r11,7FF9CEDE0AC8
       call      qword ptr [r11]
M01_L32:
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
; Total bytes of code 1471
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       je        near ptr M01_L20
       je        near ptr M01_L20
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
       je        near ptr M01_L24
       je        near ptr M01_L24
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
       mov       rdx,7FF9DBC0DC28
       mov       rdx,7FF9DBC0DC28
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
       mov       rdx,7FF9DBC0DC28
       mov       rdx,7FF9DBC0DC28
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
       mov       rdx,7FF9DBC0DE98
       mov       rdx,7FF9DBC0DE98
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
       je        near ptr M01_L28
       je        near ptr M01_L28
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
       mov       rdx,7FF9DBC0DC28
       mov       rdx,7FF9DBC0DC28
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
       mov       rdx,7FF9DBC0DC50
       mov       rdx,7FF9DBC0DC50
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
       mov       rdx,7FF9DBC0DC70
       mov       rdx,7FF9DBC0DC70
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
       mov       r11,7FF9DB4F0970
       mov       r11,7FF9DB4F0970
       call      qword ptr [7FF9DB4F0970]
       call      qword ptr [7FF9DB4F0970]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L19
       je        near ptr M01_L19
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
       mov       rdx,7FF9DBC0DC88
       mov       rdx,7FF9DBC0DC88
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
       lea       ecx,[rsi+2]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       cmp       ecx,1
       ja        short M01_L16
       ja        short M01_L16
       mov       rcx,r15
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L18
       jmp       short M01_L18
M01_L16:
       inc       dword ptr [r15+14]
M01_L16:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L17
       jbe       short M01_L17
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
       jmp       short M01_L18
M01_L17:
       mov       rcx,r15
M01_L17:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       mov       rcx,rbx
M01_L18:
       mov       rcx,rbx
       mov       r11,7FF9DB4F0970
       mov       r11,7FF9DB4F0970
       call      qword ptr [7FF9DB4F0970]
       call      qword ptr [7FF9DB4F0970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FF9DB4F0978
       mov       r11,7FF9DB4F0978
       call      qword ptr [7FF9DB4F0978]
       call      qword ptr [7FF9DB4F0978]
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
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,24D27CD1BE0
       mov       rcx,24D27CD1BE0
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,24CB7CD3090
       mov       rdx,24CB7CD3090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,24CB7CD3020
       mov       rdx,24CB7CD3020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L21
       je        short M01_L21
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L21
       je        short M01_L21
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       mov       eax,1
M01_L21:
       mov       eax,1
M01_L22:
       test      eax,eax
M01_L22:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L23
       jne       near ptr M01_L23
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7A6A60
       mov       rdx,7FF9DB7A6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB7A6A60
       mov       rdx,7FF9DB7A6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7A6A60
       mov       rdx,7FF9DB7A6A60
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
M01_L23:
       cmp       [rcx],ecx
M01_L23:
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
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,24D27CD1BE8
       mov       rax,24D27CD1BE8
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L25
       je        short M01_L25
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L26
       jmp       short M01_L26
M01_L25:
       mov       eax,1
M01_L25:
       mov       eax,1
M01_L26:
       test      eax,eax
M01_L26:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L27
       jne       near ptr M01_L27
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7A6A60
       mov       rdx,7FF9DB7A6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB7A6A60
       mov       rdx,7FF9DB7A6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7A6A60
       mov       rdx,7FF9DB7A6A60
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
M01_L27:
       mov       edx,3
M01_L27:
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
M01_L28:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L28:
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
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FF9DB4F0978
       mov       r11,7FF9DB4F0978
       call      qword ptr [7FF9DB4F0978]
       call      qword ptr [7FF9DB4F0978]
M01_L29:
       nop
M01_L29:
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
; Total bytes of code 2634
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CF6C9BB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6CB4B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3CD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,2D7E1800338
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,2D7E5802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L28
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L28
M01_L02:
       mov       rcx,2D7E5802028
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
       je        near ptr M01_L30
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FF9CEED8D08]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9CF3CD198]
       mov       r15,rax
       mov       rcx,2D7F1800C28
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FF9CF3CD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF219CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF219CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3CD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FF9CF003510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3CD090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF3CD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF087900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF9CF6AF040
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
       mov       rdx,7FF9CF6AF040
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
       mov       rdx,7FF9CF6AF288
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L31
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
       mov       rdx,7FF9CF6AF040
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
       mov       rdx,7FF9CF6AF068
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FF9CF327CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FF9CF6AF088
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FF9CEDC0AC0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L25
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FF9CF6AF0A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       ja        short M01_L22
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF6C9B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L24
M01_L22:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L23
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L24
M01_L23:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF087A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FF9CEDC0AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FF9CEDC0AC8
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
M01_L26:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CF1B1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FF9CF3CD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF219CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF219CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3CD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9CF003510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1DD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF1DD960]
       int       3
M01_L31:
       call      qword ptr [7FF9CEF6B630]
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
       je        short M01_L32
       mov       rcx,[rbp-48]
       mov       r11,7FF9CEDC0AC8
       call      qword ptr [r11]
M01_L32:
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
; Total bytes of code 1471
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       je        near ptr M01_L20
       je        near ptr M01_L20
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
       je        near ptr M01_L24
       je        near ptr M01_L24
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
       mov       rdx,7FF9DBBFD870
       mov       rdx,7FF9DBBFD870
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
       mov       rdx,7FF9DBBFD870
       mov       rdx,7FF9DBBFD870
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
       mov       rdx,7FF9DBBFDAE0
       mov       rdx,7FF9DBBFDAE0
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
       je        near ptr M01_L28
       je        near ptr M01_L28
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
       mov       rdx,7FF9DBBFD870
       mov       rdx,7FF9DBBFD870
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
       mov       rdx,7FF9DBBFD898
       mov       rdx,7FF9DBBFD898
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
       mov       rdx,7FF9DBBFD8B8
       mov       rdx,7FF9DBBFD8B8
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
       mov       r11,7FF9DB4E0970
       mov       r11,7FF9DB4E0970
       call      qword ptr [7FF9DB4E0970]
       call      qword ptr [7FF9DB4E0970]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L19
       je        near ptr M01_L19
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
       mov       rdx,7FF9DBBFD8D0
       mov       rdx,7FF9DBBFD8D0
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
       lea       ecx,[rsi+2]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       cmp       ecx,1
       ja        short M01_L16
       ja        short M01_L16
       mov       rcx,r15
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L18
       jmp       short M01_L18
M01_L16:
       inc       dword ptr [r15+14]
M01_L16:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L17
       jbe       short M01_L17
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
       jmp       short M01_L18
M01_L17:
       mov       rcx,r15
M01_L17:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       mov       rcx,rbx
M01_L18:
       mov       rcx,rbx
       mov       r11,7FF9DB4E0970
       mov       r11,7FF9DB4E0970
       call      qword ptr [7FF9DB4E0970]
       call      qword ptr [7FF9DB4E0970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FF9DB4E0978
       mov       r11,7FF9DB4E0978
       call      qword ptr [7FF9DB4E0978]
       call      qword ptr [7FF9DB4E0978]
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
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,231A7641BE0
       mov       rcx,231A7641BE0
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,231C7643090
       mov       rdx,231C7643090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,231C7643020
       mov       rdx,231C7643020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L21
       je        short M01_L21
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L21
       je        short M01_L21
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       mov       eax,1
M01_L21:
       mov       eax,1
M01_L22:
       test      eax,eax
M01_L22:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L23
       jne       near ptr M01_L23
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB796A60
       mov       rdx,7FF9DB796A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB796A60
       mov       rdx,7FF9DB796A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB796A60
       mov       rdx,7FF9DB796A60
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
M01_L23:
       cmp       [rcx],ecx
M01_L23:
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
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,231A7641BE8
       mov       rax,231A7641BE8
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L25
       je        short M01_L25
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L26
       jmp       short M01_L26
M01_L25:
       mov       eax,1
M01_L25:
       mov       eax,1
M01_L26:
       test      eax,eax
M01_L26:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L27
       jne       near ptr M01_L27
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB796A60
       mov       rdx,7FF9DB796A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB796A60
       mov       rdx,7FF9DB796A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB796A60
       mov       rdx,7FF9DB796A60
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
M01_L27:
       mov       edx,3
M01_L27:
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
M01_L28:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L28:
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
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FF9DB4E0978
       mov       r11,7FF9DB4E0978
       call      qword ptr [7FF9DB4E0978]
       call      qword ptr [7FF9DB4E0978]
M01_L29:
       nop
M01_L29:
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
; Total bytes of code 2634
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CF6B98B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6BB210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3BD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,20864C00338
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9CF0399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,20862C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9CF0399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L28
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L28
M01_L02:
       mov       rcx,20862C02028
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
       je        near ptr M01_L30
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FF9CEEC8D08]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9CF3BD198]
       mov       r15,rax
       mov       rcx,20866C00C28
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FF9CF3BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF209CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF209CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FF9CEFF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3BD090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF3BD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1A5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF077900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF9CF69EF10
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
       mov       rdx,7FF9CF69EF10
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
       mov       rdx,7FF9CF69F158
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L31
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
       mov       rdx,7FF9CF69EF10
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
       mov       rdx,7FF9CF69EF38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FF9CF317CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FF9CF69EF58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FF9CEDB0AC0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L25
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FF9CF69EF70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       ja        short M01_L22
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF6B9840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L24
M01_L22:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L23
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L24
M01_L23:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF077A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FF9CEDB0AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FF9CEDB0AC8
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
M01_L26:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CF1A1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF1A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FF9CF3BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF209CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF209CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9CEFF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FF9CEDA4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF1CD960]
       int       3
M01_L31:
       call      qword ptr [7FF9CEF5B630]
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
       je        short M01_L32
       mov       rcx,[rbp-48]
       mov       r11,7FF9CEDB0AC8
       call      qword ptr [r11]
M01_L32:
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
; Total bytes of code 1471
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       je        near ptr M01_L20
       je        near ptr M01_L20
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
       je        near ptr M01_L24
       je        near ptr M01_L24
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
       mov       rdx,7FF9DBC1DC28
       mov       rdx,7FF9DBC1DC28
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
       mov       rdx,7FF9DBC1DC28
       mov       rdx,7FF9DBC1DC28
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
       mov       rdx,7FF9DBC1DE98
       mov       rdx,7FF9DBC1DE98
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
       je        near ptr M01_L28
       je        near ptr M01_L28
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
       mov       rdx,7FF9DBC1DC28
       mov       rdx,7FF9DBC1DC28
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
       mov       rdx,7FF9DBC1DC50
       mov       rdx,7FF9DBC1DC50
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
       mov       rdx,7FF9DBC1DC70
       mov       rdx,7FF9DBC1DC70
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
       mov       r11,7FF9DB500970
       mov       r11,7FF9DB500970
       call      qword ptr [7FF9DB500970]
       call      qword ptr [7FF9DB500970]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L19
       je        near ptr M01_L19
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
       mov       rdx,7FF9DBC1DC88
       mov       rdx,7FF9DBC1DC88
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
       lea       ecx,[rsi+2]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       cmp       ecx,1
       ja        short M01_L16
       ja        short M01_L16
       mov       rcx,r15
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L18
       jmp       short M01_L18
M01_L16:
       inc       dword ptr [r15+14]
M01_L16:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L17
       jbe       short M01_L17
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
       jmp       short M01_L18
M01_L17:
       mov       rcx,r15
M01_L17:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       mov       rcx,rbx
M01_L18:
       mov       rcx,rbx
       mov       r11,7FF9DB500970
       mov       r11,7FF9DB500970
       call      qword ptr [7FF9DB500970]
       call      qword ptr [7FF9DB500970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FF9DB500978
       mov       r11,7FF9DB500978
       call      qword ptr [7FF9DB500978]
       call      qword ptr [7FF9DB500978]
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
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L20:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,22FA3FB1BE0
       mov       rcx,22FA3FB1BE0
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,22F43FB3090
       mov       rdx,22F43FB3090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,22F43FB3020
       mov       rdx,22F43FB3020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L21
       je        short M01_L21
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L21
       je        short M01_L21
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       mov       eax,1
M01_L21:
       mov       eax,1
M01_L22:
       test      eax,eax
M01_L22:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L23
       jne       near ptr M01_L23
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7B6A60
       mov       rdx,7FF9DB7B6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB7B6A60
       mov       rdx,7FF9DB7B6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7B6A60
       mov       rdx,7FF9DB7B6A60
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
M01_L23:
       cmp       [rcx],ecx
M01_L23:
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
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L24:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,22FA3FB1BE8
       mov       rax,22FA3FB1BE8
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L25
       je        short M01_L25
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L26
       jmp       short M01_L26
M01_L25:
       mov       eax,1
M01_L25:
       mov       eax,1
M01_L26:
       test      eax,eax
M01_L26:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L27
       jne       near ptr M01_L27
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7B6A60
       mov       rdx,7FF9DB7B6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FF9DB7B6A60
       mov       rdx,7FF9DB7B6A60
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3A1
       mov       ecx,3A1
       mov       rdx,7FF9DB7B6A60
       mov       rdx,7FF9DB7B6A60
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
M01_L27:
       mov       edx,3
M01_L27:
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
M01_L28:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L28:
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
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FF9DB500978
       mov       r11,7FF9DB500978
       call      qword ptr [7FF9DB500978]
       call      qword ptr [7FF9DB500978]
M01_L29:
       nop
M01_L29:
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
; Total bytes of code 2634
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CF6CBBB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6CD4B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3CD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,2ED0D800338
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,2ED0B802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L28
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L28
M01_L02:
       mov       rcx,2ED0B802028
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
       je        near ptr M01_L30
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FF9CEED8D08]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9CF3CD198]
       mov       r15,rax
       mov       rcx,2ED0D801C40
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FF9CF3CD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF219CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF219CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3CD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FF9CF003510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3CD090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF3CD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FF9CF087900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF9CF6BDD98
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
       mov       rdx,7FF9CF6BDD98
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
       mov       rdx,7FF9CF6BDFE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L31
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
       mov       rdx,7FF9CF6BDD98
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
       mov       rdx,7FF9CF6BDDC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FF9CF327CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FF9CF6BDDE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FF9CEDC0AC0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L25
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FF9CF6BDDF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       lea       ecx,[rsi+2]
       cmp       ecx,1
       ja        short M01_L22
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF6CBB40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L24
M01_L22:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L23
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L24
M01_L23:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FF9CF087A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FF9CEDC0AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FF9CEDC0AC8
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
M01_L26:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CF1B1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FF9CF3CD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF219CC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF219CC8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3CD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9CF003510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1DD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF1DD960]
       int       3
M01_L31:
       call      qword ptr [7FF9CEF6B630]
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
       je        short M01_L32
       mov       rcx,[rbp-48]
       mov       r11,7FF9CEDC0AC8
       call      qword ptr [r11]
M01_L32:
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
; Total bytes of code 1471
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

