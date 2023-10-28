## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,2493DC65018
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
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFD677661A8
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FFD52AF9888]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52AF9900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFD527FD360]
       mov       rdi,rax
       mov       rcx,21309008C38
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFD527FD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527FD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5260D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFD52433510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527FD090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFD527FD558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFD525D5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFD524B7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,1CF48359C38
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
       mov       rdx,7FFD677561A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFD677561A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFD677561A8
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FFD52AF9888]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52AF9900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFD527FD360]
       mov       rdi,rax
       mov       rcx,1E77A000040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFD527FD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527FD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5260D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFD52433510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527FD090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFD527FD558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFD525D5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFD524B7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,28DDD2E5448
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
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFD677661A8
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FFD52AFB888]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52AFB900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFD527FD360]
       mov       rdi,rax
       mov       rcx,12B3B400040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFD527FD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527FD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5260D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFD52433510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527FD090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFD527FD558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFD525D5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFD524B7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,15D3CA11040
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
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFD677661A8
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FFD52AE9888]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52AE9900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFD527ED360]
       mov       rdi,rax
       mov       rcx,2442E400040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFD527ED498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52639A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52639A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527ED558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD525FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFD52423510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527ED090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFD527ED558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFD525C5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFD524A7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,1FA60B11040
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
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFD677661A8
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FFD52AEB888]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52AEB900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFD527ED360]
       mov       rdi,rax
       mov       rcx,27BDB400040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFD527ED498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52639A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52639A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527ED558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD525FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFD52423510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527ED090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFD527ED558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFD525C5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFD524A7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,266496B1040
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
       mov       rdx,7FFD677761A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFD677761A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFD677761A8
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FFD52B09888]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52B09900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFD5280D360]
       mov       rdi,rax
       mov       rcx,2E0A0008C38
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFD5280D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD5280BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD5280D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD5280D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5261D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFD52443510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD5280D090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFD5280D558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFD525E5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFD524C7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,26416A11040
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
       mov       rdx,7FFD677761A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFD677761A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFD677761A8
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FFD52B09888]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52B09900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFD5280D360]
       mov       rdi,rax
       mov       rcx,2BEDD400040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFD5280D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD5280BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD5280D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD5280D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5261D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFD52443510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD5280D090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFD5280D558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFD525E5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFD524C7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FFD67BDDC28
       mov       rdx,7FFD67BDDC28
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
       mov       rdx,7FFD67BDDC28
       mov       rdx,7FFD67BDDC28
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
       mov       rdx,7FFD67BDDE98
       mov       rdx,7FFD67BDDE98
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
       mov       rdx,7FFD67BDDC28
       mov       rdx,7FFD67BDDC28
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
       mov       rdx,7FFD67BDDC50
       mov       rdx,7FFD67BDDC50
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
       mov       rdx,7FFD67BDDC70
       mov       rdx,7FFD67BDDC70
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
       mov       r11,7FFD674D0970
       mov       r11,7FFD674D0970
       call      qword ptr [7FFD674D0970]
       call      qword ptr [7FFD674D0970]
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
       mov       rdx,7FFD67BDDC88
       mov       rdx,7FFD67BDDC88
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
       mov       r11,7FFD674D0970
       mov       r11,7FFD674D0970
       call      qword ptr [7FFD674D0970]
       call      qword ptr [7FFD674D0970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFD674D0978
       mov       r11,7FFD674D0978
       call      qword ptr [7FFD674D0978]
       call      qword ptr [7FFD674D0978]
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
       mov       rcx,2DA7B1A1BC8
       mov       rcx,2DA7B1A1BC8
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,2DA1B1A3090
       mov       rdx,2DA1B1A3090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,2DA1B1A3020
       mov       rdx,2DA1B1A3020
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677761A8
       mov       rdx,7FFD677761A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677761A8
       mov       rdx,7FFD677761A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677761A8
       mov       rdx,7FFD677761A8
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
       mov       rax,2DA7B1A1BD0
       mov       rax,2DA7B1A1BD0
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677761A8
       mov       rdx,7FFD677761A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677761A8
       mov       rdx,7FFD677761A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677761A8
       mov       rdx,7FFD677761A8
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
       mov       r11,7FFD674D0978
       mov       r11,7FFD674D0978
       call      qword ptr [7FFD674D0978]
       call      qword ptr [7FFD674D0978]
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52B098B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52B0B210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFD5280D378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,164FF400320
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,16507402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,16507402028
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
       call      qword ptr [7FFD52318D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFD5280D198]
       mov       r15,rax
       mov       rcx,16513400C10
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFD5280D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD5280BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD5280D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD5280D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5261D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFD52443510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD5280D090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFD5280D558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD525E5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFD524C7900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFD52AEE4A8
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
       mov       rdx,7FFD52AEE4A8
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
       mov       rdx,7FFD52AEE6F0
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
       mov       rdx,7FFD52AEE4A8
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
       mov       rdx,7FFD52AEE4D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFD52767CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFD52AEE4F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFD52200AB8
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
       mov       rdx,7FFD52AEE508
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
       call      qword ptr [7FFD52B09840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFD524C7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FFD52200AB8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFD52200AC0
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
       call      qword ptr [7FFD525E1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525E1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FFD5280D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD5280BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD5280D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD5280D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5261D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52443510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD5280D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD5261D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5261D960]
       int       3
M01_L31:
       call      qword ptr [7FFD523AB630]
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
       mov       r11,7FFD52200AC0
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FFD67BCDC28
       mov       rdx,7FFD67BCDC28
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
       mov       rdx,7FFD67BCDC28
       mov       rdx,7FFD67BCDC28
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
       mov       rdx,7FFD67BCDE98
       mov       rdx,7FFD67BCDE98
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
       mov       rdx,7FFD67BCDC28
       mov       rdx,7FFD67BCDC28
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
       mov       rdx,7FFD67BCDC50
       mov       rdx,7FFD67BCDC50
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
       mov       rdx,7FFD67BCDC70
       mov       rdx,7FFD67BCDC70
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
       mov       r11,7FFD674C0970
       mov       r11,7FFD674C0970
       call      qword ptr [7FFD674C0970]
       call      qword ptr [7FFD674C0970]
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
       mov       rdx,7FFD67BCDC88
       mov       rdx,7FFD67BCDC88
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
       mov       r11,7FFD674C0970
       mov       r11,7FFD674C0970
       call      qword ptr [7FFD674C0970]
       call      qword ptr [7FFD674C0970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFD674C0978
       mov       r11,7FFD674C0978
       call      qword ptr [7FFD674C0978]
       call      qword ptr [7FFD674C0978]
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
       mov       rcx,204BFE11BC8
       mov       rcx,204BFE11BC8
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,2045FE13090
       mov       rdx,2045FE13090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,2045FE13020
       mov       rdx,2045FE13020
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677661A8
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677661A8
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677661A8
       mov       rdx,7FFD677661A8
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
       mov       rax,204BFE11BD0
       mov       rax,204BFE11BD0
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677661A8
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677661A8
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677661A8
       mov       rdx,7FFD677661A8
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
       mov       r11,7FFD674C0978
       mov       r11,7FFD674C0978
       call      qword ptr [7FFD674C0978]
       call      qword ptr [7FFD674C0978]
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52B09BB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52B0B4B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFD5280D378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,273A8000320
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,273B0002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,273B0002028
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
       call      qword ptr [7FFD52318D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFD5280D198]
       mov       r15,rax
       mov       rcx,273BE000C10
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFD5280D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD5280BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD5280D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD5280D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5261D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFD52443510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD5280D090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFD5280D558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD525E5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFD524C7900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFD52AEE4B8
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
       mov       rdx,7FFD52AEE4B8
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
       mov       rdx,7FFD52AEE700
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
       mov       rdx,7FFD52AEE4B8
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
       mov       rdx,7FFD52AEE4E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFD52767CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFD52AEE500
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFD52200AC0
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
       mov       rdx,7FFD52AEE518
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
       call      qword ptr [7FFD52B09B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFD524C7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FFD52200AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFD52200AC8
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
       call      qword ptr [7FFD525E1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525E1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FFD5280D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD5280BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD5280D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD5280D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5261D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52443510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD5280D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD5261D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5261D960]
       int       3
M01_L31:
       call      qword ptr [7FFD523AB630]
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
       mov       r11,7FFD52200AC8
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FFD67BDDC28
       mov       rdx,7FFD67BDDC28
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
       mov       rdx,7FFD67BDDC28
       mov       rdx,7FFD67BDDC28
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
       mov       rdx,7FFD67BDDE98
       mov       rdx,7FFD67BDDE98
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
       mov       rdx,7FFD67BDDC28
       mov       rdx,7FFD67BDDC28
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
       mov       rdx,7FFD67BDDC50
       mov       rdx,7FFD67BDDC50
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
       mov       rdx,7FFD67BDDC70
       mov       rdx,7FFD67BDDC70
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
       mov       r11,7FFD674D0970
       mov       r11,7FFD674D0970
       call      qword ptr [7FFD674D0970]
       call      qword ptr [7FFD674D0970]
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
       mov       rdx,7FFD67BDDC88
       mov       rdx,7FFD67BDDC88
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
       mov       r11,7FFD674D0970
       mov       r11,7FFD674D0970
       call      qword ptr [7FFD674D0970]
       call      qword ptr [7FFD674D0970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFD674D0978
       mov       r11,7FFD674D0978
       call      qword ptr [7FFD674D0978]
       call      qword ptr [7FFD674D0978]
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
       mov       rcx,23C17C41BC8
       mov       rcx,23C17C41BC8
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,23BB7C43090
       mov       rdx,23BB7C43090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,23BB7C43020
       mov       rdx,23BB7C43020
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677761A8
       mov       rdx,7FFD677761A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677761A8
       mov       rdx,7FFD677761A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677761A8
       mov       rdx,7FFD677761A8
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
       mov       rax,23C17C41BD0
       mov       rax,23C17C41BD0
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677761A8
       mov       rdx,7FFD677761A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677761A8
       mov       rdx,7FFD677761A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677761A8
       mov       rdx,7FFD677761A8
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
       mov       r11,7FFD674D0978
       mov       r11,7FFD674D0978
       call      qword ptr [7FFD674D0978]
       call      qword ptr [7FFD674D0978]
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52AF98B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52AFB210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFD527FD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,21B17400320
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFD524799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,21B15402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFD524799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,21B15402028
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
       call      qword ptr [7FFD52308D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFD527FD198]
       mov       r15,rax
       mov       rcx,21B25400C10
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFD527FD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527FD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5260D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFD52433510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD527FD090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFD527FD558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD525D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFD524B7900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFD52ADE570
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
       mov       rdx,7FFD52ADE570
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
       mov       rdx,7FFD52ADE7B8
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
       mov       rdx,7FFD52ADE570
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
       mov       rdx,7FFD52ADE598
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFD52757CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFD52ADE5B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFD521F0AC0
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
       mov       rdx,7FFD52ADE5D0
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
       call      qword ptr [7FFD52AF9840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFD524B7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FFD521F0AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFD521F0AC8
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
       call      qword ptr [7FFD525D1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525D1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FFD527FD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527FD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5260D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52433510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD527FD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD5260D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FFD521E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5260D960]
       int       3
M01_L31:
       call      qword ptr [7FFD5239B630]
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
       mov       r11,7FFD521F0AC8
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FFD67BEDC28
       mov       rdx,7FFD67BEDC28
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
       mov       rdx,7FFD67BEDC28
       mov       rdx,7FFD67BEDC28
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
       mov       rdx,7FFD67BEDE98
       mov       rdx,7FFD67BEDE98
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
       mov       rdx,7FFD67BEDC28
       mov       rdx,7FFD67BEDC28
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
       mov       rdx,7FFD67BEDC50
       mov       rdx,7FFD67BEDC50
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
       mov       rdx,7FFD67BEDC70
       mov       rdx,7FFD67BEDC70
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
       mov       r11,7FFD674E0970
       mov       r11,7FFD674E0970
       call      qword ptr [7FFD674E0970]
       call      qword ptr [7FFD674E0970]
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
       mov       rdx,7FFD67BEDC88
       mov       rdx,7FFD67BEDC88
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
       mov       r11,7FFD674E0970
       mov       r11,7FFD674E0970
       call      qword ptr [7FFD674E0970]
       call      qword ptr [7FFD674E0970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFD674E0978
       mov       r11,7FFD674E0978
       call      qword ptr [7FFD674E0978]
       call      qword ptr [7FFD674E0978]
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
       mov       rcx,194C3081BC8
       mov       rcx,194C3081BC8
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,19443083090
       mov       rdx,19443083090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,19443083020
       mov       rdx,19443083020
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677861A8
       mov       rdx,7FFD677861A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677861A8
       mov       rdx,7FFD677861A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677861A8
       mov       rdx,7FFD677861A8
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
       mov       rax,194C3081BD0
       mov       rax,194C3081BD0
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677861A8
       mov       rdx,7FFD677861A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677861A8
       mov       rdx,7FFD677861A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677861A8
       mov       rdx,7FFD677861A8
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
       mov       r11,7FFD674E0978
       mov       r11,7FFD674E0978
       call      qword ptr [7FFD674E0978]
       call      qword ptr [7FFD674E0978]
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52AD98B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52ADB210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFD527DD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,2740F800320
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFD524599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,2740D802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFD524599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,2740D802028
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
       call      qword ptr [7FFD522E8D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFD527DD198]
       mov       r15,rax
       mov       rcx,2741F800C10
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFD527DD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52629A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52629A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527DD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD525ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFD52413510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD527DD090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFD527DD558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD525B5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFD52497900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFD52ABF000
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
       mov       rdx,7FFD52ABF000
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
       mov       rdx,7FFD52ABF248
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
       mov       rdx,7FFD52ABF000
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
       mov       rdx,7FFD52ABF028
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFD52737CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFD52ABF048
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFD521D0AC0
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
       mov       rdx,7FFD52ABF060
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
       call      qword ptr [7FFD52AD9840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFD52497A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FFD521D0AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFD521D0AC8
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
       call      qword ptr [7FFD525B1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FFD527DD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52629A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52629A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527DD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD525ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52413510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD527DD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD525ED8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FFD521C4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD525ED960]
       int       3
M01_L31:
       call      qword ptr [7FFD5237B630]
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
       mov       r11,7FFD521D0AC8
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FFD67BBDC28
       mov       rdx,7FFD67BBDC28
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
       mov       rdx,7FFD67BBDC28
       mov       rdx,7FFD67BBDC28
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
       mov       rdx,7FFD67BBDE98
       mov       rdx,7FFD67BBDE98
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
       mov       rdx,7FFD67BBDC28
       mov       rdx,7FFD67BBDC28
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
       mov       rdx,7FFD67BBDC50
       mov       rdx,7FFD67BBDC50
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
       mov       rdx,7FFD67BBDC70
       mov       rdx,7FFD67BBDC70
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
       mov       r11,7FFD674B0970
       mov       r11,7FFD674B0970
       call      qword ptr [7FFD674B0970]
       call      qword ptr [7FFD674B0970]
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
       mov       rdx,7FFD67BBDC88
       mov       rdx,7FFD67BBDC88
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
       mov       r11,7FFD674B0970
       mov       r11,7FFD674B0970
       call      qword ptr [7FFD674B0970]
       call      qword ptr [7FFD674B0970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFD674B0978
       mov       r11,7FFD674B0978
       call      qword ptr [7FFD674B0978]
       call      qword ptr [7FFD674B0978]
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
       mov       rcx,1A4F1021BC8
       mov       rcx,1A4F1021BC8
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,1A4A1023090
       mov       rdx,1A4A1023090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,1A4A1023020
       mov       rdx,1A4A1023020
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677561A8
       mov       rdx,7FFD677561A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677561A8
       mov       rdx,7FFD677561A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677561A8
       mov       rdx,7FFD677561A8
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
       mov       rax,1A4F1021BD0
       mov       rax,1A4F1021BD0
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677561A8
       mov       rdx,7FFD677561A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677561A8
       mov       rdx,7FFD677561A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677561A8
       mov       rdx,7FFD677561A8
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
       mov       r11,7FFD674B0978
       mov       r11,7FFD674B0978
       call      qword ptr [7FFD674B0978]
       call      qword ptr [7FFD674B0978]
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52AD98B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52ADB210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFD527DD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,1641EC00320
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFD524599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,1641AC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFD524599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,1641AC02028
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
       call      qword ptr [7FFD522E8D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFD527DD198]
       mov       r15,rax
       mov       rcx,16426C00C10
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFD527DD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52629A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52629A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527DD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD525ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFD52413510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD527DD090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFD527DD558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD525B5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFD52497900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFD52ABE4B8
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
       mov       rdx,7FFD52ABE4B8
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
       mov       rdx,7FFD52ABE700
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
       mov       rdx,7FFD52ABE4B8
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
       mov       rdx,7FFD52ABE4E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFD52737CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFD52ABE500
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFD521D0AC0
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
       mov       rdx,7FFD52ABE518
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
       call      qword ptr [7FFD52AD9840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFD52497A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FFD521D0AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFD521D0AC8
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
       call      qword ptr [7FFD525B1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FFD527DD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52629A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52629A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527DD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD525ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52413510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD527DD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD525ED8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FFD521C4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD525ED960]
       int       3
M01_L31:
       call      qword ptr [7FFD5237B630]
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
       mov       r11,7FFD521D0AC8
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FFD67BBDC28
       mov       rdx,7FFD67BBDC28
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
       mov       rdx,7FFD67BBDC28
       mov       rdx,7FFD67BBDC28
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
       mov       rdx,7FFD67BBDE98
       mov       rdx,7FFD67BBDE98
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
       mov       rdx,7FFD67BBDC28
       mov       rdx,7FFD67BBDC28
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
       mov       rdx,7FFD67BBDC50
       mov       rdx,7FFD67BBDC50
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
       mov       rdx,7FFD67BBDC70
       mov       rdx,7FFD67BBDC70
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
       mov       r11,7FFD674B0970
       mov       r11,7FFD674B0970
       call      qword ptr [7FFD674B0970]
       call      qword ptr [7FFD674B0970]
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
       mov       rdx,7FFD67BBDC88
       mov       rdx,7FFD67BBDC88
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
       mov       r11,7FFD674B0970
       mov       r11,7FFD674B0970
       call      qword ptr [7FFD674B0970]
       call      qword ptr [7FFD674B0970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFD674B0978
       mov       r11,7FFD674B0978
       call      qword ptr [7FFD674B0978]
       call      qword ptr [7FFD674B0978]
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
       mov       rcx,1B497D61BC8
       mov       rcx,1B497D61BC8
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,1B477D63090
       mov       rdx,1B477D63090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,1B477D63020
       mov       rdx,1B477D63020
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677561A8
       mov       rdx,7FFD677561A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677561A8
       mov       rdx,7FFD677561A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677561A8
       mov       rdx,7FFD677561A8
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
       mov       rax,1B497D61BD0
       mov       rax,1B497D61BD0
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677561A8
       mov       rdx,7FFD677561A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677561A8
       mov       rdx,7FFD677561A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677561A8
       mov       rdx,7FFD677561A8
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
       mov       r11,7FFD674B0978
       mov       r11,7FFD674B0978
       call      qword ptr [7FFD674B0978]
       call      qword ptr [7FFD674B0978]
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52B09BB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52B0B4B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFD5280D378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,21622800320
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,21620802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,21620802028
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
       call      qword ptr [7FFD52318D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFD5280D198]
       mov       r15,rax
       mov       rcx,21630800C10
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFD5280D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD5280BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD5280D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD5280D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5261D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFD52443510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD5280D090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFD5280D558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD525E5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFD524C7900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFD52AEE420
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
       mov       rdx,7FFD52AEE420
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
       mov       rdx,7FFD52AEE668
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
       mov       rdx,7FFD52AEE420
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
       mov       rdx,7FFD52AEE448
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFD52767CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFD52AEE468
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFD52200AC0
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
       mov       rdx,7FFD52AEE480
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
       call      qword ptr [7FFD52B09B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFD524C7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FFD52200AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFD52200AC8
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
       call      qword ptr [7FFD525E1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525E1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FFD5280D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD5280BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD5280D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD5280D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5261D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52443510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD5280D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD5261D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5261D960]
       int       3
M01_L31:
       call      qword ptr [7FFD523AB630]
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
       mov       r11,7FFD52200AC8
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FFD67BBDC28
       mov       rdx,7FFD67BBDC28
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
       mov       rdx,7FFD67BBDC28
       mov       rdx,7FFD67BBDC28
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
       mov       rdx,7FFD67BBDE98
       mov       rdx,7FFD67BBDE98
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
       mov       rdx,7FFD67BBDC28
       mov       rdx,7FFD67BBDC28
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
       mov       rdx,7FFD67BBDC50
       mov       rdx,7FFD67BBDC50
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
       mov       rdx,7FFD67BBDC70
       mov       rdx,7FFD67BBDC70
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
       mov       r11,7FFD674B0970
       mov       r11,7FFD674B0970
       call      qword ptr [7FFD674B0970]
       call      qword ptr [7FFD674B0970]
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
       mov       rdx,7FFD67BBDC88
       mov       rdx,7FFD67BBDC88
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
       mov       r11,7FFD674B0970
       mov       r11,7FFD674B0970
       call      qword ptr [7FFD674B0970]
       call      qword ptr [7FFD674B0970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFD674B0978
       mov       r11,7FFD674B0978
       call      qword ptr [7FFD674B0978]
       call      qword ptr [7FFD674B0978]
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
       mov       rcx,26111111BC8
       mov       rcx,26111111BC8
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,260B1113090
       mov       rdx,260B1113090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,260B1113020
       mov       rdx,260B1113020
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677561A8
       mov       rdx,7FFD677561A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677561A8
       mov       rdx,7FFD677561A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677561A8
       mov       rdx,7FFD677561A8
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
       mov       rax,26111111BD0
       mov       rax,26111111BD0
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677561A8
       mov       rdx,7FFD677561A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677561A8
       mov       rdx,7FFD677561A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677561A8
       mov       rdx,7FFD677561A8
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
       mov       r11,7FFD674B0978
       mov       r11,7FFD674B0978
       call      qword ptr [7FFD674B0978]
       call      qword ptr [7FFD674B0978]
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52AF98B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52AFB210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFD527FD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,2A445C08F18
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFD524799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,2A445C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFD524799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,2A445C02028
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
       call      qword ptr [7FFD52308D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFD527FD198]
       mov       r15,rax
       mov       rcx,2A44DC00C10
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFD527FD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527FD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5260D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFD52433510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD527FD090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFD527FD558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD525D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFD524B7900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFD52ADE5A0
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
       mov       rdx,7FFD52ADE5A0
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
       mov       rdx,7FFD52ADE7E8
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
       mov       rdx,7FFD52ADE5A0
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
       mov       rdx,7FFD52ADE5C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFD52757CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFD52ADE5E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFD521F0AC0
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
       mov       rdx,7FFD52ADE600
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
       call      qword ptr [7FFD52AF9840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFD524B7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FFD521F0AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFD521F0AC8
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
       call      qword ptr [7FFD525D1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525D1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FFD527FD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527FD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5260D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52433510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD527FD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD5260D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FFD521E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5260D960]
       int       3
M01_L31:
       call      qword ptr [7FFD5239B630]
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
       mov       r11,7FFD521F0AC8
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FFD67BCDC28
       mov       rdx,7FFD67BCDC28
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
       mov       rdx,7FFD67BCDC28
       mov       rdx,7FFD67BCDC28
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
       mov       rdx,7FFD67BCDE98
       mov       rdx,7FFD67BCDE98
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
       mov       rdx,7FFD67BCDC28
       mov       rdx,7FFD67BCDC28
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
       mov       rdx,7FFD67BCDC50
       mov       rdx,7FFD67BCDC50
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
       mov       rdx,7FFD67BCDC70
       mov       rdx,7FFD67BCDC70
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
       mov       r11,7FFD674C0970
       mov       r11,7FFD674C0970
       call      qword ptr [7FFD674C0970]
       call      qword ptr [7FFD674C0970]
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
       mov       rdx,7FFD67BCDC88
       mov       rdx,7FFD67BCDC88
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
       mov       r11,7FFD674C0970
       mov       r11,7FFD674C0970
       call      qword ptr [7FFD674C0970]
       call      qword ptr [7FFD674C0970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFD674C0978
       mov       r11,7FFD674C0978
       call      qword ptr [7FFD674C0978]
       call      qword ptr [7FFD674C0978]
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
       mov       rcx,237A0811BC8
       mov       rcx,237A0811BC8
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,23760813090
       mov       rdx,23760813090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,23760813020
       mov       rdx,23760813020
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677661A8
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677661A8
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677661A8
       mov       rdx,7FFD677661A8
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
       mov       rax,237A0811BD0
       mov       rax,237A0811BD0
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677661A8
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677661A8
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677661A8
       mov       rdx,7FFD677661A8
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
       mov       r11,7FFD674C0978
       mov       r11,7FFD674C0978
       call      qword ptr [7FFD674C0978]
       call      qword ptr [7FFD674C0978]
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52AF98B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52AFB210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFD527FD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,1DC25400320
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFD524799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,1DC27400098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFD524799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,1DC27400030
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
       call      qword ptr [7FFD52308D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFD527FD198]
       mov       r15,rax
       mov       rcx,1DC39400C10
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFD527FD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527FD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5260D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFD52433510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD527FD090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFD527FD558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD525D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFD524B7900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFD52ADE4B8
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
       mov       rdx,7FFD52ADE4B8
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
       mov       rdx,7FFD52ADE700
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
       mov       rdx,7FFD52ADE4B8
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
       mov       rdx,7FFD52ADE4E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFD52757CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFD52ADE500
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFD521F0AC0
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
       mov       rdx,7FFD52ADE518
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
       call      qword ptr [7FFD52AF9840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFD524B7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FFD521F0AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFD521F0AC8
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
       call      qword ptr [7FFD525D1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525D1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FFD527FD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527FD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5260D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52433510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD527FD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD5260D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FFD521E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5260D960]
       int       3
M01_L31:
       call      qword ptr [7FFD5239B630]
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
       mov       r11,7FFD521F0AC8
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FFD67BADC28
       mov       rdx,7FFD67BADC28
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
       mov       rdx,7FFD67BADC28
       mov       rdx,7FFD67BADC28
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
       mov       rdx,7FFD67BADE98
       mov       rdx,7FFD67BADE98
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
       mov       rdx,7FFD67BADC28
       mov       rdx,7FFD67BADC28
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
       mov       rdx,7FFD67BADC50
       mov       rdx,7FFD67BADC50
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
       mov       rdx,7FFD67BADC70
       mov       rdx,7FFD67BADC70
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
       mov       r11,7FFD674A0970
       mov       r11,7FFD674A0970
       call      qword ptr [7FFD674A0970]
       call      qword ptr [7FFD674A0970]
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
       mov       rdx,7FFD67BADC88
       mov       rdx,7FFD67BADC88
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
       mov       r11,7FFD674A0970
       mov       r11,7FFD674A0970
       call      qword ptr [7FFD674A0970]
       call      qword ptr [7FFD674A0970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFD674A0978
       mov       r11,7FFD674A0978
       call      qword ptr [7FFD674A0978]
       call      qword ptr [7FFD674A0978]
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
       mov       rcx,25325481BC8
       mov       rcx,25325481BC8
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,252B5483090
       mov       rdx,252B5483090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,252B5483020
       mov       rdx,252B5483020
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677461A8
       mov       rdx,7FFD677461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677461A8
       mov       rdx,7FFD677461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677461A8
       mov       rdx,7FFD677461A8
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
       mov       rax,25325481BD0
       mov       rax,25325481BD0
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677461A8
       mov       rdx,7FFD677461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677461A8
       mov       rdx,7FFD677461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677461A8
       mov       rdx,7FFD677461A8
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
       mov       r11,7FFD674A0978
       mov       r11,7FFD674A0978
       call      qword ptr [7FFD674A0978]
       call      qword ptr [7FFD674A0978]
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52B0D8B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52B0F210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFD5280D378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,21E8B800320
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,21E83802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,21E83802028
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
       call      qword ptr [7FFD52318D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFD5280D198]
       mov       r15,rax
       mov       rcx,21E8B801C28
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFD5280D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD5280BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD5280D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD5280D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5261D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFD52443510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD5280D090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFD5280D558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD525E5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFD524C7900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFD52AEE060
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
       mov       rdx,7FFD52AEE060
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
       mov       rdx,7FFD52AEE2A8
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
       mov       rdx,7FFD52AEE060
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
       mov       rdx,7FFD52AEE088
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFD52767CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFD52AEE0A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFD52200AC0
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
       mov       rdx,7FFD52AEE0C0
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
       call      qword ptr [7FFD52B0D840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFD524C7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FFD52200AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFD52200AC8
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
       call      qword ptr [7FFD525E1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525E1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FFD5280D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD5280BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD5280D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD5280D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5261D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52443510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD5280D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD5261D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5261D960]
       int       3
M01_L31:
       call      qword ptr [7FFD523AB630]
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
       mov       r11,7FFD52200AC8
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FFD67BADC28
       mov       rdx,7FFD67BADC28
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
       mov       rdx,7FFD67BADC28
       mov       rdx,7FFD67BADC28
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
       mov       rdx,7FFD67BADE98
       mov       rdx,7FFD67BADE98
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
       mov       rdx,7FFD67BADC28
       mov       rdx,7FFD67BADC28
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
       mov       rdx,7FFD67BADC50
       mov       rdx,7FFD67BADC50
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
       mov       rdx,7FFD67BADC70
       mov       rdx,7FFD67BADC70
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
       mov       r11,7FFD674A0970
       mov       r11,7FFD674A0970
       call      qword ptr [7FFD674A0970]
       call      qword ptr [7FFD674A0970]
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
       mov       rdx,7FFD67BADC88
       mov       rdx,7FFD67BADC88
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
       mov       r11,7FFD674A0970
       mov       r11,7FFD674A0970
       call      qword ptr [7FFD674A0970]
       call      qword ptr [7FFD674A0970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFD674A0978
       mov       r11,7FFD674A0978
       call      qword ptr [7FFD674A0978]
       call      qword ptr [7FFD674A0978]
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
       mov       rcx,13C99EDE350
       mov       rcx,13C99EDE350
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,13CB9ED3090
       mov       rdx,13CB9ED3090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,13CB9ED3020
       mov       rdx,13CB9ED3020
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677461A8
       mov       rdx,7FFD677461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677461A8
       mov       rdx,7FFD677461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677461A8
       mov       rdx,7FFD677461A8
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
       mov       rax,13C99EDE358
       mov       rax,13C99EDE358
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677461A8
       mov       rdx,7FFD677461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677461A8
       mov       rdx,7FFD677461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677461A8
       mov       rdx,7FFD677461A8
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
       mov       r11,7FFD674A0978
       mov       r11,7FFD674A0978
       call      qword ptr [7FFD674A0978]
       call      qword ptr [7FFD674A0978]
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52AF9BB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52AFB4B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFD527FD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,20446C08F18
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFD524799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,20446C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFD524799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,20446C02028
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
       call      qword ptr [7FFD52308D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFD527FD198]
       mov       r15,rax
       mov       rcx,20442C00C10
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFD527FD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527FD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5260D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFD52433510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD527FD090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFD527FD558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD525D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFD524B7900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFD52ADE4B8
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
       mov       rdx,7FFD52ADE4B8
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
       mov       rdx,7FFD52ADE700
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
       mov       rdx,7FFD52ADE4B8
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
       mov       rdx,7FFD52ADE4E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFD52757CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFD52ADE500
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFD521F0AC0
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
       mov       rdx,7FFD52ADE518
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
       call      qword ptr [7FFD52AF9B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFD524B7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FFD521F0AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFD521F0AC8
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
       call      qword ptr [7FFD525D1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525D1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FFD527FD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527FD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5260D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52433510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD527FD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD5260D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FFD521E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5260D960]
       int       3
M01_L31:
       call      qword ptr [7FFD5239B630]
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
       mov       r11,7FFD521F0AC8
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FFD67BCDC28
       mov       rdx,7FFD67BCDC28
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
       mov       rdx,7FFD67BCDC28
       mov       rdx,7FFD67BCDC28
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
       mov       rdx,7FFD67BCDE98
       mov       rdx,7FFD67BCDE98
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
       mov       rdx,7FFD67BCDC28
       mov       rdx,7FFD67BCDC28
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
       mov       rdx,7FFD67BCDC50
       mov       rdx,7FFD67BCDC50
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
       mov       rdx,7FFD67BCDC70
       mov       rdx,7FFD67BCDC70
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
       mov       r11,7FFD674C0970
       mov       r11,7FFD674C0970
       call      qword ptr [7FFD674C0970]
       call      qword ptr [7FFD674C0970]
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
       mov       rdx,7FFD67BCDC88
       mov       rdx,7FFD67BCDC88
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
       mov       r11,7FFD674C0970
       mov       r11,7FFD674C0970
       call      qword ptr [7FFD674C0970]
       call      qword ptr [7FFD674C0970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFD674C0978
       mov       r11,7FFD674C0978
       call      qword ptr [7FFD674C0978]
       call      qword ptr [7FFD674C0978]
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
       mov       rcx,21BA1791BC8
       mov       rcx,21BA1791BC8
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,21B11793090
       mov       rdx,21B11793090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,21B11793020
       mov       rdx,21B11793020
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677661A8
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677661A8
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677661A8
       mov       rdx,7FFD677661A8
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
       mov       rax,21BA1791BD0
       mov       rax,21BA1791BD0
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677661A8
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677661A8
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677661A8
       mov       rdx,7FFD677661A8
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
       mov       r11,7FFD674C0978
       mov       r11,7FFD674C0978
       call      qword ptr [7FFD674C0978]
       call      qword ptr [7FFD674C0978]
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52AC18B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52AC3210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFD527ED378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,15EDE800320
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFD524699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,15EE6802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFD524699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,15EE6802028
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
       call      qword ptr [7FFD522F8D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFD527ED198]
       mov       r15,rax
       mov       rcx,15EEE808BA8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFD527ED498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52639A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52639A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527ED558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD525FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFD52423510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD527ED090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFD527ED558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD525C5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFD524A7900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFD52A9D408
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
       mov       rdx,7FFD52A9D408
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
       mov       rdx,7FFD52A9D650
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
       mov       rcx,7FFD52AC09A8
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFD52A9D408
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
       mov       rdx,7FFD52A9D430
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFD52747CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFD52A9D450
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFD521E0960
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
       mov       rdx,7FFD52A9D468
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
       call      qword ptr [7FFD52AC1840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFD524A7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FFD521E0960
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFD521E0968
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
       call      qword ptr [7FFD525C1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FFD527ED498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52639A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52639A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527ED558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD525FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52423510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD527ED078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD525FD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FFD521D4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD525FD960]
       int       3
M01_L31:
       call      qword ptr [7FFD5238B630]
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
       mov       r11,7FFD521E0968
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FFD67BEDC28
       mov       rdx,7FFD67BEDC28
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
       mov       rdx,7FFD67BEDC28
       mov       rdx,7FFD67BEDC28
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
       mov       rdx,7FFD67BEDE98
       mov       rdx,7FFD67BEDE98
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
       mov       rdx,7FFD67BEDC28
       mov       rdx,7FFD67BEDC28
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
       mov       rdx,7FFD67BEDC50
       mov       rdx,7FFD67BEDC50
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
       mov       rdx,7FFD67BEDC70
       mov       rdx,7FFD67BEDC70
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
       mov       r11,7FFD674E0970
       mov       r11,7FFD674E0970
       call      qword ptr [7FFD674E0970]
       call      qword ptr [7FFD674E0970]
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
       mov       rdx,7FFD67BEDC88
       mov       rdx,7FFD67BEDC88
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
       mov       r11,7FFD674E0970
       mov       r11,7FFD674E0970
       call      qword ptr [7FFD674E0970]
       call      qword ptr [7FFD674E0970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFD674E0978
       mov       r11,7FFD674E0978
       call      qword ptr [7FFD674E0978]
       call      qword ptr [7FFD674E0978]
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
       mov       rcx,26F16021BC8
       mov       rcx,26F16021BC8
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,26E96023090
       mov       rdx,26E96023090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,26E96023020
       mov       rdx,26E96023020
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677861A8
       mov       rdx,7FFD677861A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677861A8
       mov       rdx,7FFD677861A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677861A8
       mov       rdx,7FFD677861A8
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
       mov       rax,26F16021BD0
       mov       rax,26F16021BD0
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677861A8
       mov       rdx,7FFD677861A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677861A8
       mov       rdx,7FFD677861A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677861A8
       mov       rdx,7FFD677861A8
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
       mov       r11,7FFD674E0978
       mov       r11,7FFD674E0978
       call      qword ptr [7FFD674E0978]
       call      qword ptr [7FFD674E0978]
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52B09BB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52B0B4B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFD5280D378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,17251000320
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,1724B002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,1724B002028
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
       call      qword ptr [7FFD52318D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFD5280D198]
       mov       r15,rax
       mov       rcx,1725B000C10
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFD5280D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD5280BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD5280D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD5280D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5261D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFD52443510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD5280D090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFD5280D558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD525E5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFD524C7900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFD52AEE4B8
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
       mov       rdx,7FFD52AEE4B8
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
       mov       rdx,7FFD52AEE700
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
       mov       rdx,7FFD52AEE4B8
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
       mov       rdx,7FFD52AEE4E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFD52767CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFD52AEE500
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFD52200AC0
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
       mov       rdx,7FFD52AEE518
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
       call      qword ptr [7FFD52B09B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFD524C7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FFD52200AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFD52200AC8
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
       call      qword ptr [7FFD525E1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525E1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FFD5280D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD5280BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD5280D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD5280D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5261D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52443510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD5280D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD5261D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5261D960]
       int       3
M01_L31:
       call      qword ptr [7FFD523AB630]
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
       mov       r11,7FFD52200AC8
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FFD67BCDC28
       mov       rdx,7FFD67BCDC28
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
       mov       rdx,7FFD67BCDC28
       mov       rdx,7FFD67BCDC28
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
       mov       rdx,7FFD67BCDE98
       mov       rdx,7FFD67BCDE98
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
       mov       rdx,7FFD67BCDC28
       mov       rdx,7FFD67BCDC28
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
       mov       rdx,7FFD67BCDC50
       mov       rdx,7FFD67BCDC50
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
       mov       rdx,7FFD67BCDC70
       mov       rdx,7FFD67BCDC70
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
       mov       r11,7FFD674C0970
       mov       r11,7FFD674C0970
       call      qword ptr [7FFD674C0970]
       call      qword ptr [7FFD674C0970]
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
       mov       rdx,7FFD67BCDC88
       mov       rdx,7FFD67BCDC88
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
       mov       r11,7FFD674C0970
       mov       r11,7FFD674C0970
       call      qword ptr [7FFD674C0970]
       call      qword ptr [7FFD674C0970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFD674C0978
       mov       r11,7FFD674C0978
       call      qword ptr [7FFD674C0978]
       call      qword ptr [7FFD674C0978]
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
       mov       rcx,22C62E71BC8
       mov       rcx,22C62E71BC8
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,22C02E73090
       mov       rdx,22C02E73090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,22C02E73020
       mov       rdx,22C02E73020
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677661A8
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677661A8
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677661A8
       mov       rdx,7FFD677661A8
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
       mov       rax,22C62E71BD0
       mov       rax,22C62E71BD0
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677661A8
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677661A8
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677661A8
       mov       rdx,7FFD677661A8
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
       mov       r11,7FFD674C0978
       mov       r11,7FFD674C0978
       call      qword ptr [7FFD674C0978]
       call      qword ptr [7FFD674C0978]
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52AD9BB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52ADB4B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFD527DD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,1F2A7008F18
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFD524599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,1F2A7002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFD524599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,1F2A7002028
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
       call      qword ptr [7FFD522E8D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFD527DD198]
       mov       r15,rax
       mov       rcx,1F2B1000C10
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFD527DD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52629A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52629A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527DD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD525ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFD52413510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD527DD090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFD527DD558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD525B5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFD52497900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFD52ABE958
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
       mov       rdx,7FFD52ABE958
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
       mov       rdx,7FFD52ABEBA0
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
       mov       rdx,7FFD52ABE958
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
       mov       rdx,7FFD52ABE980
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFD52737CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFD52ABE9A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFD521D0AC0
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
       mov       rdx,7FFD52ABE9B8
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
       call      qword ptr [7FFD52AD9B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFD52497A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FFD521D0AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFD521D0AC8
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
       call      qword ptr [7FFD525B1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FFD527DD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52629A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52629A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527DD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD525ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52413510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD527DD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD525ED8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FFD521C4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD525ED960]
       int       3
M01_L31:
       call      qword ptr [7FFD5237B630]
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
       mov       r11,7FFD521D0AC8
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FFD67BBDC28
       mov       rdx,7FFD67BBDC28
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
       mov       rdx,7FFD67BBDC28
       mov       rdx,7FFD67BBDC28
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
       mov       rdx,7FFD67BBDE98
       mov       rdx,7FFD67BBDE98
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
       mov       rdx,7FFD67BBDC28
       mov       rdx,7FFD67BBDC28
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
       mov       rdx,7FFD67BBDC50
       mov       rdx,7FFD67BBDC50
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
       mov       rdx,7FFD67BBDC70
       mov       rdx,7FFD67BBDC70
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
       mov       r11,7FFD674B0970
       mov       r11,7FFD674B0970
       call      qword ptr [7FFD674B0970]
       call      qword ptr [7FFD674B0970]
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
       mov       rdx,7FFD67BBDC88
       mov       rdx,7FFD67BBDC88
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
       mov       r11,7FFD674B0970
       mov       r11,7FFD674B0970
       call      qword ptr [7FFD674B0970]
       call      qword ptr [7FFD674B0970]
       test      eax,eax
       test      eax,eax
       jne       short M01_L13
       jne       short M01_L13
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFD674B0978
       mov       r11,7FFD674B0978
       call      qword ptr [7FFD674B0978]
       call      qword ptr [7FFD674B0978]
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
       mov       rcx,1F61F8F1BC8
       mov       rcx,1F61F8F1BC8
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,1F5DF8F3090
       mov       rdx,1F5DF8F3090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,1F5DF8F3020
       mov       rdx,1F5DF8F3020
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677561A8
       mov       rdx,7FFD677561A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677561A8
       mov       rdx,7FFD677561A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677561A8
       mov       rdx,7FFD677561A8
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
       mov       rax,1F61F8F1BD0
       mov       rax,1F61F8F1BD0
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
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677561A8
       mov       rdx,7FFD677561A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFD677561A8
       mov       rdx,7FFD677561A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFD677561A8
       mov       rdx,7FFD677561A8
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
       mov       r11,7FFD674B0978
       mov       r11,7FFD674B0978
       call      qword ptr [7FFD674B0978]
       call      qword ptr [7FFD674B0978]
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52AFB8B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52AFD210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFD527FD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L26
       lea       rcx,[r15+0C]
       mov       rdx,23A45800320
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFD524799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L27
       lea       rcx,[r15+16]
       mov       rdx,23A43802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFD524799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,23A43802028
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
       call      qword ptr [7FFD52308D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFD527FD198]
       mov       r15,rax
       mov       rcx,23A45801C28
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFD527FD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527FD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5260D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFD52433510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD527FD090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFD527FD558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD525D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFD524B7900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFD52AEE568
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
       mov       rdx,7FFD52AEE568
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
       mov       rdx,7FFD52AEE7B0
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
       mov       rdx,7FFD52AEE568
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
       mov       rdx,7FFD52AEE590
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFD52757CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFD52AEE5B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFD521F0AC0
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
       mov       rdx,7FFD52AEE5C8
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
       call      qword ptr [7FFD52AFB840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
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
       call      qword ptr [7FFD524B7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L24:
       mov       rcx,rbx
       mov       r11,7FFD521F0AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFD521F0AC8
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
       call      qword ptr [7FFD525D1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525D1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L29
       call      qword ptr [7FFD527FD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527FD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5260D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52433510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD527FD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD5260D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,2E7
       mov       rdx,7FFD521E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5260D960]
       int       3
M01_L31:
       call      qword ptr [7FFD5239B630]
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
       mov       r11,7FFD521F0AC8
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

