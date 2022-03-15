## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<PersonProper>.Create(this.Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+1A0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       esi,edx
       mov       rax,1F0D6643020
       mov       rbx,[rax]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
M01_L00:
       call      dotNetTips.Spargine.Core.Properties.Resources.get_NumberNotInRange()
       mov       rdx,rax
       test      rbx,rbx
       je        short M01_L01
       cmp       dword ptr [rbx+8],0
       jbe       short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rbx,rdx
M01_L02:
       mov       rcx,1F0B6642748
       mov       rcx,[rcx]
       mov       rdx,rbx
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L03:
       mov       rcx,rdi
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
; Total bytes of code 127
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<PersonProper>.Create(this.Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+1A0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       esi,edx
       mov       rax,2133AF63020
       mov       rbx,[rax]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
M01_L00:
       call      dotNetTips.Spargine.Core.Properties.Resources.get_NumberNotInRange()
       mov       rdx,rax
       test      rbx,rbx
       je        short M01_L01
       cmp       dword ptr [rbx+8],0
       jbe       short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rbx,rdx
M01_L02:
       mov       rcx,2131AF61F30
       mov       rcx,[rcx]
       mov       rdx,rbx
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L03:
       mov       rcx,rdi
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
; Total bytes of code 127
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<PersonProper>.Create(this.Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+1A0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       esi,edx
       mov       rax,1D690723020
       mov       rbx,[rax]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
M01_L00:
       call      dotNetTips.Spargine.Core.Properties.Resources.get_NumberNotInRange()
       mov       rdx,rax
       test      rbx,rbx
       je        short M01_L01
       cmp       dword ptr [rbx+8],0
       jbe       short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rbx,rdx
M01_L02:
       mov       rcx,1D670721F30
       mov       rcx,[rcx]
       mov       rdx,rbx
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L03:
       mov       rcx,rdi
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
; Total bytes of code 127
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<PersonProper>.Create(this.Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+1A0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       esi,edx
       mov       rax,21646A93020
       mov       rbx,[rax]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
M01_L00:
       call      dotNetTips.Spargine.Core.Properties.Resources.get_NumberNotInRange()
       mov       rdx,rax
       test      rbx,rbx
       je        short M01_L01
       cmp       dword ptr [rbx+8],0
       jbe       short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rbx,rdx
M01_L02:
       mov       rcx,21646A94340
       mov       rcx,[rcx]
       mov       rdx,rbx
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L03:
       mov       rcx,rdi
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
; Total bytes of code 127
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<PersonProper>.Create(this.Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+1A0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       esi,edx
       mov       rax,1E792C83020
       mov       rbx,[rax]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
M01_L00:
       call      dotNetTips.Spargine.Core.Properties.Resources.get_NumberNotInRange()
       mov       rdx,rax
       test      rbx,rbx
       je        short M01_L01
       cmp       dword ptr [rbx+8],0
       jbe       short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rbx,rdx
M01_L02:
       mov       rcx,1E772C81F30
       mov       rcx,[rcx]
       mov       rdx,rbx
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L03:
       mov       rcx,rdi
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
; Total bytes of code 127
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<PersonProper>.Create(this.Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+1A0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       esi,edx
       mov       rax,188A17B1028
       mov       rbx,[rax]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
M01_L00:
       call      dotNetTips.Spargine.Core.Properties.Resources.get_NumberNotInRange()
       mov       rdx,rax
       test      rbx,rbx
       je        short M01_L01
       cmp       dword ptr [rbx+8],0
       jbe       short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rbx,rdx
M01_L02:
       mov       rcx,188A17B2B60
       mov       rcx,[rcx]
       mov       rdx,rbx
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L03:
       mov       rcx,rdi
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
; Total bytes of code 127
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<PersonProper>.Create(this.Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+1A0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       esi,edx
       mov       rax,2E216623020
       mov       rbx,[rax]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
M01_L00:
       call      dotNetTips.Spargine.Core.Properties.Resources.get_NumberNotInRange()
       mov       rdx,rax
       test      rbx,rbx
       je        short M01_L01
       cmp       dword ptr [rbx+8],0
       jbe       short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rbx,rdx
M01_L02:
       mov       rcx,2E1F6621F30
       mov       rcx,[rcx]
       mov       rdx,rbx
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L03:
       mov       rcx,rdi
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
; Total bytes of code 127
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<PersonProper>.Create(this.Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+1A0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       esi,edx
       mov       rax,264F3E13020
       mov       rbx,[rax]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
M01_L00:
       call      dotNetTips.Spargine.Core.Properties.Resources.get_NumberNotInRange()
       mov       rdx,rax
       test      rbx,rbx
       je        short M01_L01
       cmp       dword ptr [rbx+8],0
       jbe       short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rbx,rdx
M01_L02:
       mov       rcx,264D3E11F30
       mov       rcx,[rcx]
       mov       rdx,rbx
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L03:
       mov       rcx,rdi
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
; Total bytes of code 127
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.PersonProperList, ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+158]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rsi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6110
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6110
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FF85D6F63B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L23
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6110
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6150
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6170
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D260310
       call      qword ptr [7FF85D610310]
       test      eax,eax
       je        near ptr M01_L22
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF85D6F61A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       rbx,rax
       cmp       edi,0FFFFFFFF
       je        short M01_L16
       cmp       edi,0FFFFFFFE
       jne       short M01_L19
M01_L16:
       mov       rcx,[r15+38]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6458
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       rdx,r14
       mov       r8,rbx
       call      dotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       jmp       short M01_L21
M01_L19:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L20
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L21:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D260310
       call      qword ptr [7FF85D610310]
       test      eax,eax
       jne       near ptr M01_L13
M01_L22:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D260318
       call      qword ptr [7FF85D610318]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L24
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D260318
       call      qword ptr [7FF85D610318]
M01_L24:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 689
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.PersonProperList, ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+158]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rsi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF85D6E6110
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF85D6E6110
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FF85D6E63B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L23
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF85D6E6110
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF85D6E6150
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF85D6E6170
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D250310
       call      qword ptr [7FF85D600310]
       test      eax,eax
       je        near ptr M01_L22
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF85D6E61A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       rbx,rax
       cmp       edi,0FFFFFFFF
       je        short M01_L16
       cmp       edi,0FFFFFFFE
       jne       short M01_L19
M01_L16:
       mov       rcx,[r15+38]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FF85D6E6458
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       rdx,r14
       mov       r8,rbx
       call      dotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       jmp       short M01_L21
M01_L19:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L20
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L21:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D250310
       call      qword ptr [7FF85D600310]
       test      eax,eax
       jne       near ptr M01_L13
M01_L22:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D250318
       call      qword ptr [7FF85D600318]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L24
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D250318
       call      qword ptr [7FF85D600318]
M01_L24:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 689
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.PersonProperList, ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+158]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rsi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6110
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6110
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FF85D6F63B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L23
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6110
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6150
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6170
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D260310
       call      qword ptr [7FF85D610310]
       test      eax,eax
       je        near ptr M01_L22
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF85D6F61A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       rbx,rax
       cmp       edi,0FFFFFFFF
       je        short M01_L16
       cmp       edi,0FFFFFFFE
       jne       short M01_L19
M01_L16:
       mov       rcx,[r15+38]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6458
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       rdx,r14
       mov       r8,rbx
       call      dotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       jmp       short M01_L21
M01_L19:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L20
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L21:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D260310
       call      qword ptr [7FF85D610310]
       test      eax,eax
       jne       near ptr M01_L13
M01_L22:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D260318
       call      qword ptr [7FF85D610318]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L24
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D260318
       call      qword ptr [7FF85D610318]
M01_L24:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 689
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.PersonProperList, ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+158]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rsi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF85D6D6388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF85D6D6388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FF85D6D6628
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L23
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF85D6D6388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF85D6D63C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF85D6D63E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D240310
       call      qword ptr [7FF85D5F0310]
       test      eax,eax
       je        near ptr M01_L22
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF85D6D6418
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       rbx,rax
       cmp       edi,0FFFFFFFF
       je        short M01_L16
       cmp       edi,0FFFFFFFE
       jne       short M01_L19
M01_L16:
       mov       rcx,[r15+38]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FF85D6D66D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       rdx,r14
       mov       r8,rbx
       call      dotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       jmp       short M01_L21
M01_L19:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L20
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L21:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D240310
       call      qword ptr [7FF85D5F0310]
       test      eax,eax
       jne       near ptr M01_L13
M01_L22:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D240318
       call      qword ptr [7FF85D5F0318]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L24
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D240318
       call      qword ptr [7FF85D5F0318]
M01_L24:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 689
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.PersonProperList, ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+158]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rsi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6628
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L23
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF85D6F63C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF85D6F63E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D260310
       call      qword ptr [7FF85D610310]
       test      eax,eax
       je        near ptr M01_L22
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6418
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       rbx,rax
       cmp       edi,0FFFFFFFF
       je        short M01_L16
       cmp       edi,0FFFFFFFE
       jne       short M01_L19
M01_L16:
       mov       rcx,[r15+38]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FF85D6F66D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       rdx,r14
       mov       r8,rbx
       call      dotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       jmp       short M01_L21
M01_L19:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L20
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L21:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D260310
       call      qword ptr [7FF85D610310]
       test      eax,eax
       jne       near ptr M01_L13
M01_L22:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D260318
       call      qword ptr [7FF85D610318]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L24
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D260318
       call      qword ptr [7FF85D610318]
M01_L24:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 689
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.PersonProperList, ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+158]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rsi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF85D706198
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF85D706198
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FF85D706438
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L23
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF85D706198
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF85D7061D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF85D7061F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D270310
       call      qword ptr [7FF85D620310]
       test      eax,eax
       je        near ptr M01_L22
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF85D706228
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       rbx,rax
       cmp       edi,0FFFFFFFF
       je        short M01_L16
       cmp       edi,0FFFFFFFE
       jne       short M01_L19
M01_L16:
       mov       rcx,[r15+38]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FF85D7064E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       rdx,r14
       mov       r8,rbx
       call      dotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       jmp       short M01_L21
M01_L19:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L20
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L21:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D270310
       call      qword ptr [7FF85D620310]
       test      eax,eax
       jne       near ptr M01_L13
M01_L22:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D270318
       call      qword ptr [7FF85D620318]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L24
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D270318
       call      qword ptr [7FF85D620318]
M01_L24:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 689
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.PersonProperList, ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+158]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rsi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6628
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L23
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF85D6F63C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF85D6F63E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D260310
       call      qword ptr [7FF85D610310]
       test      eax,eax
       je        near ptr M01_L22
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6418
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       rbx,rax
       cmp       edi,0FFFFFFFF
       je        short M01_L16
       cmp       edi,0FFFFFFFE
       jne       short M01_L19
M01_L16:
       mov       rcx,[r15+38]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FF85D6F66D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       rdx,r14
       mov       r8,rbx
       call      dotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       jmp       short M01_L21
M01_L19:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L20
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L21:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D260310
       call      qword ptr [7FF85D610310]
       test      eax,eax
       jne       near ptr M01_L13
M01_L22:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D260318
       call      qword ptr [7FF85D610318]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L24
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D260318
       call      qword ptr [7FF85D610318]
M01_L24:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 689
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.PersonProperList, ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+158]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rsi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF85D6E6388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF85D6E6388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FF85D6E6628
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L23
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF85D6E6388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF85D6E63C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF85D6E63E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D250310
       call      qword ptr [7FF85D600310]
       test      eax,eax
       je        near ptr M01_L22
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF85D6E6418
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       rbx,rax
       cmp       edi,0FFFFFFFF
       je        short M01_L16
       cmp       edi,0FFFFFFFE
       jne       short M01_L19
M01_L16:
       mov       rcx,[r15+38]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FF85D6E66D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       rdx,r14
       mov       r8,rbx
       call      dotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       jmp       short M01_L21
M01_L19:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L20
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L21:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D250310
       call      qword ptr [7FF85D600310]
       test      eax,eax
       jne       near ptr M01_L13
M01_L22:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D250318
       call      qword ptr [7FF85D600318]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L24
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D250318
       call      qword ptr [7FF85D600318]
M01_L24:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 689
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+158]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       xor       r8d,r8d
       call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rsi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF85D716110
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF85D716110
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FF85D7163B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L23
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF85D716110
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF85D716150
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF85D716170
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D280310
       call      qword ptr [7FF85D630310]
       test      eax,eax
       je        near ptr M01_L22
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF85D7161A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       rbx,rax
       cmp       edi,0FFFFFFFF
       je        short M01_L16
       cmp       edi,0FFFFFFFE
       jne       short M01_L19
M01_L16:
       mov       rcx,[r15+38]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FF85D716458
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       rdx,r14
       mov       r8,rbx
       call      dotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       jmp       short M01_L21
M01_L19:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L20
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L21:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D280310
       call      qword ptr [7FF85D630310]
       test      eax,eax
       jne       near ptr M01_L13
M01_L22:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D280318
       call      qword ptr [7FF85D630318]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L24
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D280318
       call      qword ptr [7FF85D630318]
M01_L24:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 689
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+158]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       xor       r8d,r8d
       call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rsi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF85D6D6198
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF85D6D6198
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FF85D6D6438
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L23
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF85D6D6198
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF85D6D61D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF85D6D61F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D240310
       call      qword ptr [7FF85D5F0310]
       test      eax,eax
       je        near ptr M01_L22
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF85D6D6228
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       rbx,rax
       cmp       edi,0FFFFFFFF
       je        short M01_L16
       cmp       edi,0FFFFFFFE
       jne       short M01_L19
M01_L16:
       mov       rcx,[r15+38]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FF85D6D64E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       rdx,r14
       mov       r8,rbx
       call      dotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       jmp       short M01_L21
M01_L19:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L20
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L21:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D240310
       call      qword ptr [7FF85D5F0310]
       test      eax,eax
       jne       near ptr M01_L13
M01_L22:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D240318
       call      qword ptr [7FF85D5F0318]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L24
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D240318
       call      qword ptr [7FF85D5F0318]
M01_L24:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 689
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+158]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       xor       r8d,r8d
       call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rsi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF85D706388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF85D706388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FF85D706628
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L23
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF85D706388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF85D7063C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF85D7063E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D270310
       call      qword ptr [7FF85D620310]
       test      eax,eax
       je        near ptr M01_L22
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF85D706418
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       rbx,rax
       cmp       edi,0FFFFFFFF
       je        short M01_L16
       cmp       edi,0FFFFFFFE
       jne       short M01_L19
M01_L16:
       mov       rcx,[r15+38]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FF85D7066D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       rdx,r14
       mov       r8,rbx
       call      dotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       jmp       short M01_L21
M01_L19:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L20
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L21:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D270310
       call      qword ptr [7FF85D620310]
       test      eax,eax
       jne       near ptr M01_L13
M01_L22:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D270318
       call      qword ptr [7FF85D620318]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L24
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D270318
       call      qword ptr [7FF85D620318]
M01_L24:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 689
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+158]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       xor       r8d,r8d
       call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rsi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF85D6D6388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF85D6D6388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FF85D6D6628
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L23
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF85D6D6388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF85D6D63C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF85D6D63E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D240310
       call      qword ptr [7FF85D5F0310]
       test      eax,eax
       je        near ptr M01_L22
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF85D6D6418
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       rbx,rax
       cmp       edi,0FFFFFFFF
       je        short M01_L16
       cmp       edi,0FFFFFFFE
       jne       short M01_L19
M01_L16:
       mov       rcx,[r15+38]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FF85D6D66D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       rdx,r14
       mov       r8,rbx
       call      dotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       jmp       short M01_L21
M01_L19:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L20
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L21:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D240310
       call      qword ptr [7FF85D5F0310]
       test      eax,eax
       jne       near ptr M01_L13
M01_L22:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D240318
       call      qword ptr [7FF85D5F0318]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L24
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D240318
       call      qword ptr [7FF85D5F0318]
M01_L24:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 689
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+158]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       xor       r8d,r8d
       call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rsi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF85D716388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF85D716388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FF85D716628
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L23
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF85D716388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF85D7163C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF85D7163E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D280310
       call      qword ptr [7FF85D630310]
       test      eax,eax
       je        near ptr M01_L22
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF85D716418
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       rbx,rax
       cmp       edi,0FFFFFFFF
       je        short M01_L16
       cmp       edi,0FFFFFFFE
       jne       short M01_L19
M01_L16:
       mov       rcx,[r15+38]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FF85D7166D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       rdx,r14
       mov       r8,rbx
       call      dotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       jmp       short M01_L21
M01_L19:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L20
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L21:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D280310
       call      qword ptr [7FF85D630310]
       test      eax,eax
       jne       near ptr M01_L13
M01_L22:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D280318
       call      qword ptr [7FF85D630318]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L24
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D280318
       call      qword ptr [7FF85D630318]
M01_L24:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 689
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+158]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       xor       r8d,r8d
       call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rsi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6628
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L23
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF85D6F63C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF85D6F63E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D260310
       call      qword ptr [7FF85D610310]
       test      eax,eax
       je        near ptr M01_L22
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6418
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       rbx,rax
       cmp       edi,0FFFFFFFF
       je        short M01_L16
       cmp       edi,0FFFFFFFE
       jne       short M01_L19
M01_L16:
       mov       rcx,[r15+38]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FF85D6F66D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       rdx,r14
       mov       r8,rbx
       call      dotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       jmp       short M01_L21
M01_L19:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L20
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L21:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D260310
       call      qword ptr [7FF85D610310]
       test      eax,eax
       jne       near ptr M01_L13
M01_L22:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D260318
       call      qword ptr [7FF85D610318]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L24
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D260318
       call      qword ptr [7FF85D610318]
M01_L24:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 689
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+158]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       xor       r8d,r8d
       call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rsi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6110
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6110
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FF85D6F63B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L23
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6110
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6150
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6170
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D260310
       call      qword ptr [7FF85D610310]
       test      eax,eax
       je        near ptr M01_L22
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF85D6F61A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       rbx,rax
       cmp       edi,0FFFFFFFF
       je        short M01_L16
       cmp       edi,0FFFFFFFE
       jne       short M01_L19
M01_L16:
       mov       rcx,[r15+38]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FF85D6F6458
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       rdx,r14
       mov       r8,rbx
       call      dotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       jmp       short M01_L21
M01_L19:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L20
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L21:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D260310
       call      qword ptr [7FF85D610310]
       test      eax,eax
       jne       near ptr M01_L13
M01_L22:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D260318
       call      qword ptr [7FF85D610318]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L24
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D260318
       call      qword ptr [7FF85D610318]
M01_L24:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 689
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+158]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       xor       r8d,r8d
       call      dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rsi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF85D716388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF85D716388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FF85D716628
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L23
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FF85D716388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF85D7163C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FF85D7163E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D280310
       call      qword ptr [7FF85D630310]
       test      eax,eax
       je        near ptr M01_L22
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF85D716418
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       rbx,rax
       cmp       edi,0FFFFFFFF
       je        short M01_L16
       cmp       edi,0FFFFFFFE
       jne       short M01_L19
M01_L16:
       mov       rcx,[r15+38]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FF85D7166D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       rdx,r14
       mov       r8,rbx
       call      dotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       jmp       short M01_L21
M01_L19:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L20
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L21:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D280310
       call      qword ptr [7FF85D630310]
       test      eax,eax
       jne       near ptr M01_L13
M01_L22:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D280318
       call      qword ptr [7FF85D630318]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L24
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF85D280318
       call      qword ptr [7FF85D630318]
M01_L24:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 689
```
