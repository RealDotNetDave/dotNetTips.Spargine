## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+134]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       test      edi,edi
       jle       short M01_L00
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       edi,1
       jmp       short M01_L03
M01_L02:
       test      edx,edx
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       mov       rdx,173BE251738
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L03:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       edx,edi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 110
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+134]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       test      edi,edi
       jle       short M01_L00
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       edi,1
       jmp       short M01_L03
M01_L02:
       test      edx,edx
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       mov       rdx,21CF6611738
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L03:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       edx,edi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 110
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+134]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       test      edi,edi
       jle       short M01_L00
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       edi,1
       jmp       short M01_L03
M01_L02:
       test      edx,edx
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       mov       rdx,13AD0BB1738
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L03:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       edx,edi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 110
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+134]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       test      edi,edi
       jle       short M01_L00
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       edi,1
       jmp       short M01_L03
M01_L02:
       test      edx,edx
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       mov       rdx,15EEE591738
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L03:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       edx,edi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 110
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+134]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       test      edi,edi
       jle       short M01_L00
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       edi,1
       jmp       short M01_L03
M01_L02:
       test      edx,edx
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       mov       rdx,2BC5E4A1738
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L03:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       edx,edi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 110
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+134]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       test      edi,edi
       jle       short M01_L00
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       edi,1
       jmp       short M01_L03
M01_L02:
       test      edx,edx
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       mov       rdx,29EF9C65B40
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L03:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       edx,edi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 110
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+134]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       test      edi,edi
       jle       short M01_L00
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       edi,1
       jmp       short M01_L03
M01_L02:
       test      edx,edx
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       mov       rdx,23109961738
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L03:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       edx,edi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 110
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+134]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       test      edi,edi
       jle       short M01_L00
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       edi,1
       jmp       short M01_L03
M01_L02:
       test      edx,edx
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       mov       rdx,20323D19B18
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L03:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       edx,edi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 110
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,17D5E463020
       mov       rbx,[rax]
       mov       rax,17D3E4615C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFED0BE0558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
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
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFED0DB1780
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       r8,17D5E463020
       mov       r8,[r8]
       mov       r9,17D5E46AA58
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,17D5E46AFF8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L02:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFED0DB19D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L11
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFED0DB19D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L06:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       rdx,7FFED0DB1C78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L08:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L24
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFED0DB19D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L11:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdi
       mov       rdx,7FFED0DB1A18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L13:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFED0DB1A38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFED0770678
       call      qword ptr [7FFED0CE0678]
       test      eax,eax
       je        near ptr M02_L23
M02_L16:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rdi
       mov       rdx,7FFED0DB1A68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L19
       cmp       esi,0FFFFFFFE
       jne       short M02_L20
M02_L19:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L22
M02_L20:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L21
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L22
M02_L21:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L22:
       mov       rcx,rbx
       mov       r11,7FFED0770678
       call      qword ptr [7FFED0CE0678]
       test      eax,eax
       jne       near ptr M02_L16
M02_L23:
       mov       rcx,rbx
       mov       r11,7FFED0770680
       call      qword ptr [7FFED0CE0680]
       mov       rax,r15
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
M02_L24:
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
       je        short M02_L25
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFED0770680
       call      qword ptr [7FFED0CE0680]
M02_L25:
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
; Total bytes of code 800
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1A0ECFD3020
       mov       rbx,[rax]
       mov       rax,1A0ECFD59D0
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFED0C00558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
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
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1780
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       r8,1A0ECFD3020
       mov       r8,[r8]
       mov       r9,1A10CFD1660
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,1A10CFD1C00
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L02:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFED0DD19D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L11
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFED0DD19D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L06:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1C78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L08:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L24
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFED0DD19D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L11:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1A18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L13:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1A38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFED0790678
       call      qword ptr [7FFED0D00678]
       test      eax,eax
       je        near ptr M02_L23
M02_L16:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1A68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L19
       cmp       esi,0FFFFFFFE
       jne       short M02_L20
M02_L19:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L22
M02_L20:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L21
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L22
M02_L21:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L22:
       mov       rcx,rbx
       mov       r11,7FFED0790678
       call      qword ptr [7FFED0D00678]
       test      eax,eax
       jne       near ptr M02_L16
M02_L23:
       mov       rcx,rbx
       mov       r11,7FFED0790680
       call      qword ptr [7FFED0D00680]
       mov       rax,r15
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
M02_L24:
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
       je        short M02_L25
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFED0790680
       call      qword ptr [7FFED0D00680]
M02_L25:
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
; Total bytes of code 800
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1D314CF3020
       mov       rbx,[rax]
       mov       rax,1D314CF99A8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFED0C00558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
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
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1718
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       r8,1D314CF3020
       mov       r8,[r8]
       mov       r9,1D334CF1660
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,1D334CF1C00
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L02:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1970
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L11
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1970
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L06:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1C10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L08:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L24
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1970
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L11:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdi
       mov       rdx,7FFED0DD19B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L13:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFED0DD19D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFED0790678
       call      qword ptr [7FFED0D00678]
       test      eax,eax
       je        near ptr M02_L23
M02_L16:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1A00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L19
       cmp       esi,0FFFFFFFE
       jne       short M02_L20
M02_L19:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L22
M02_L20:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L21
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L22
M02_L21:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L22:
       mov       rcx,rbx
       mov       r11,7FFED0790678
       call      qword ptr [7FFED0D00678]
       test      eax,eax
       jne       near ptr M02_L16
M02_L23:
       mov       rcx,rbx
       mov       r11,7FFED0790680
       call      qword ptr [7FFED0D00680]
       mov       rax,r15
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
M02_L24:
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
       je        short M02_L25
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFED0790680
       call      qword ptr [7FFED0D00680]
M02_L25:
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
; Total bytes of code 800
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1BD01CD3020
       mov       rbx,[rax]
       mov       rax,1BD01CD39D8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFED0BF0558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
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
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFED0DC1780
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       r8,1BD01CD3020
       mov       r8,[r8]
       mov       r9,1BD01CD4288
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,1BD01CD4828
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L02:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFED0DC19D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L11
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFED0DC19D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L06:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       rdx,7FFED0DC1C78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L08:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L24
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFED0DC19D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L11:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdi
       mov       rdx,7FFED0DC1A18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L13:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFED0DC1A38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFED0780678
       call      qword ptr [7FFED0CF0678]
       test      eax,eax
       je        near ptr M02_L23
M02_L16:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rdi
       mov       rdx,7FFED0DC1A68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L19
       cmp       esi,0FFFFFFFE
       jne       short M02_L20
M02_L19:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L22
M02_L20:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L21
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L22
M02_L21:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L22:
       mov       rcx,rbx
       mov       r11,7FFED0780678
       call      qword ptr [7FFED0CF0678]
       test      eax,eax
       jne       near ptr M02_L16
M02_L23:
       mov       rcx,rbx
       mov       r11,7FFED0780680
       call      qword ptr [7FFED0CF0680]
       mov       rax,r15
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
M02_L24:
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
       je        short M02_L25
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFED0780680
       call      qword ptr [7FFED0CF0680]
M02_L25:
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
; Total bytes of code 800
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1F354F33020
       mov       rbx,[rax]
       mov       rax,1F364F315C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFED0C00558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
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
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1718
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       r8,1F354F33020
       mov       r8,[r8]
       mov       r9,1F374F31660
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,1F374F31C00
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L02:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1970
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L11
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1970
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L06:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1C10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L08:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L24
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1970
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L11:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdi
       mov       rdx,7FFED0DD19B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L13:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFED0DD19D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFED0790678
       call      qword ptr [7FFED0D00678]
       test      eax,eax
       je        near ptr M02_L23
M02_L16:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1A00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L19
       cmp       esi,0FFFFFFFE
       jne       short M02_L20
M02_L19:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L22
M02_L20:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L21
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L22
M02_L21:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L22:
       mov       rcx,rbx
       mov       r11,7FFED0790678
       call      qword ptr [7FFED0D00678]
       test      eax,eax
       jne       near ptr M02_L16
M02_L23:
       mov       rcx,rbx
       mov       r11,7FFED0790680
       call      qword ptr [7FFED0D00680]
       mov       rax,r15
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
M02_L24:
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
       je        short M02_L25
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFED0790680
       call      qword ptr [7FFED0D00680]
M02_L25:
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
; Total bytes of code 800
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,216DFC63020
       mov       rbx,[rax]
       mov       rax,216BFC615C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFED0C00558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
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
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1718
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       r8,216DFC63020
       mov       r8,[r8]
       mov       r9,216DFC69A40
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,216DFC69FE0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L02:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1970
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L11
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1970
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L06:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1C10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L08:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L24
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1970
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L11:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdi
       mov       rdx,7FFED0DD19B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L13:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFED0DD19D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFED0790678
       call      qword ptr [7FFED0D00678]
       test      eax,eax
       je        near ptr M02_L23
M02_L16:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1A00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L19
       cmp       esi,0FFFFFFFE
       jne       short M02_L20
M02_L19:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L22
M02_L20:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L21
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L22
M02_L21:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L22:
       mov       rcx,rbx
       mov       r11,7FFED0790678
       call      qword ptr [7FFED0D00678]
       test      eax,eax
       jne       near ptr M02_L16
M02_L23:
       mov       rcx,rbx
       mov       r11,7FFED0790680
       call      qword ptr [7FFED0D00680]
       mov       rax,r15
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
M02_L24:
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
       je        short M02_L25
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFED0790680
       call      qword ptr [7FFED0D00680]
M02_L25:
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
; Total bytes of code 800
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1F8D3E53020
       mov       rbx,[rax]
       mov       rax,1F8D3E559D0
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFED0BF0558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
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
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFED0DC1730
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       r8,1F8D3E53020
       mov       r8,[r8]
       mov       r9,1F8F3E56650
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,1F8F3E56BF0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L02:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFED0DC1988
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L11
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFED0DC1988
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L06:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       rdx,7FFED0DC1C28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L08:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L24
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFED0DC1988
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L11:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdi
       mov       rdx,7FFED0DC19C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L13:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFED0DC19E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFED0780678
       call      qword ptr [7FFED0CF0678]
       test      eax,eax
       je        near ptr M02_L23
M02_L16:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rdi
       mov       rdx,7FFED0DC1A18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L19
       cmp       esi,0FFFFFFFE
       jne       short M02_L20
M02_L19:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L22
M02_L20:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L21
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L22
M02_L21:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L22:
       mov       rcx,rbx
       mov       r11,7FFED0780678
       call      qword ptr [7FFED0CF0678]
       test      eax,eax
       jne       near ptr M02_L16
M02_L23:
       mov       rcx,rbx
       mov       r11,7FFED0780680
       call      qword ptr [7FFED0CF0680]
       mov       rax,r15
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
M02_L24:
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
       je        short M02_L25
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFED0780680
       call      qword ptr [7FFED0CF0680]
M02_L25:
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
; Total bytes of code 800
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,11D144F3020
       mov       rbx,[rax]
       mov       rax,11CF44F15C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFED0C20558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
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
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFED0E01798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       r8,11D144F3020
       mov       r8,[r8]
       mov       r9,11D144FAA58
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,11D144FAFF8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L02:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFED0E019F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L11
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFED0E019F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L06:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       rdx,7FFED0E01C90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L08:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L24
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFED0E019F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L11:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdi
       mov       rdx,7FFED0E01A30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L13:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFED0E01A50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFED07B0678
       call      qword ptr [7FFED0D30678]
       test      eax,eax
       je        near ptr M02_L23
M02_L16:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rdi
       mov       rdx,7FFED0E01A80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L19
       cmp       esi,0FFFFFFFE
       jne       short M02_L20
M02_L19:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L22
M02_L20:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L21
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L22
M02_L21:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L22:
       mov       rcx,rbx
       mov       r11,7FFED07B0678
       call      qword ptr [7FFED0D30678]
       test      eax,eax
       jne       near ptr M02_L16
M02_L23:
       mov       rcx,rbx
       mov       r11,7FFED07B0680
       call      qword ptr [7FFED0D30680]
       mov       rax,r15
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
M02_L24:
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
       je        short M02_L25
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFED07B0680
       call      qword ptr [7FFED0D30680]
M02_L25:
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
; Total bytes of code 800
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,161180E3020
       mov       rbx,[rax]
       mov       rax,160F80E15C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFED0BF0558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
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
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFED0DC1718
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       r8,161180E3020
       mov       r8,[r8]
       mov       r9,161180EAA58
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,161180EAFF8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L02:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFED0DC1970
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L11
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFED0DC1970
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L06:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       rdx,7FFED0DC1C10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L08:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L24
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFED0DC1970
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L11:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdi
       mov       rdx,7FFED0DC19B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L13:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFED0DC19D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFED0780678
       call      qword ptr [7FFED0CF0678]
       test      eax,eax
       je        near ptr M02_L23
M02_L16:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rdi
       mov       rdx,7FFED0DC1A00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L19
       cmp       esi,0FFFFFFFE
       jne       short M02_L20
M02_L19:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L22
M02_L20:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L21
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L22
M02_L21:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L22:
       mov       rcx,rbx
       mov       r11,7FFED0780678
       call      qword ptr [7FFED0CF0678]
       test      eax,eax
       jne       near ptr M02_L16
M02_L23:
       mov       rcx,rbx
       mov       r11,7FFED0780680
       call      qword ptr [7FFED0CF0680]
       mov       rax,r15
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
M02_L24:
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
       je        short M02_L25
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFED0780680
       call      qword ptr [7FFED0CF0680]
M02_L25:
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
; Total bytes of code 800
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1D5A0743020
       mov       rbx,[rax]
       mov       rax,1D5807415C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFED0BE0558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
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
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFED0DB1780
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       r8,1D5A0743020
       mov       r8,[r8]
       mov       r9,1D5A0749A40
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,1D5A0749FE0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L02:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFED0DB19D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L11
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFED0DB19D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L06:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       rdx,7FFED0DB1C78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L08:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L24
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFED0DB19D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L11:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdi
       mov       rdx,7FFED0DB1A18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L13:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFED0DB1A38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFED0770678
       call      qword ptr [7FFED0CE0678]
       test      eax,eax
       je        near ptr M02_L23
M02_L16:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rdi
       mov       rdx,7FFED0DB1A68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L19
       cmp       esi,0FFFFFFFE
       jne       short M02_L20
M02_L19:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L22
M02_L20:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L21
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L22
M02_L21:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L22:
       mov       rcx,rbx
       mov       r11,7FFED0770678
       call      qword ptr [7FFED0CE0678]
       test      eax,eax
       jne       near ptr M02_L16
M02_L23:
       mov       rcx,rbx
       mov       r11,7FFED0770680
       call      qword ptr [7FFED0CE0680]
       mov       rax,r15
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
M02_L24:
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
       je        short M02_L25
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFED0770680
       call      qword ptr [7FFED0CE0680]
M02_L25:
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
; Total bytes of code 800
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,2BBE1FF3020
       mov       rbx,[rax]
       mov       rax,2BBE1FF59D0
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFED0BF0558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
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
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFED0DC1718
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       r8,2BBE1FF3020
       mov       r8,[r8]
       mov       r9,2BBE1FF7298
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,2BBE1FF7838
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L02:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFED0DC1970
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L11
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFED0DC1970
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L06:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       rdx,7FFED0DC1C10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L08:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L24
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFED0DC1970
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L11:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdi
       mov       rdx,7FFED0DC19B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L13:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFED0DC19D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFED0780678
       call      qword ptr [7FFED0CF0678]
       test      eax,eax
       je        near ptr M02_L23
M02_L16:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rdi
       mov       rdx,7FFED0DC1A00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L19
       cmp       esi,0FFFFFFFE
       jne       short M02_L20
M02_L19:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L22
M02_L20:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L21
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L22
M02_L21:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L22:
       mov       rcx,rbx
       mov       r11,7FFED0780678
       call      qword ptr [7FFED0CF0678]
       test      eax,eax
       jne       near ptr M02_L16
M02_L23:
       mov       rcx,rbx
       mov       r11,7FFED0780680
       call      qword ptr [7FFED0CF0680]
       mov       rax,r15
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
M02_L24:
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
       je        short M02_L25
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFED0780680
       call      qword ptr [7FFED0CF0680]
M02_L25:
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
; Total bytes of code 800
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1AB97BF1028
       mov       rbx,[rax]
       mov       rax,1AB67BF15C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFED0BE0558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
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
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFED0DB1718
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       r8,1AB97BF1028
       mov       r8,[r8]
       mov       r9,1AB67BF2E90
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,1AB67BF3430
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L02:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFED0DB1970
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L11
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFED0DB1970
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L06:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       rdx,7FFED0DB1C10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L08:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L24
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFED0DB1970
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L11:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdi
       mov       rdx,7FFED0DB19B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L13:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFED0DB19D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFED0770678
       call      qword ptr [7FFED0CE0678]
       test      eax,eax
       je        near ptr M02_L23
M02_L16:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rdi
       mov       rdx,7FFED0DB1A00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L19
       cmp       esi,0FFFFFFFE
       jne       short M02_L20
M02_L19:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L22
M02_L20:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L21
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L22
M02_L21:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L22:
       mov       rcx,rbx
       mov       r11,7FFED0770678
       call      qword ptr [7FFED0CE0678]
       test      eax,eax
       jne       near ptr M02_L16
M02_L23:
       mov       rcx,rbx
       mov       r11,7FFED0770680
       call      qword ptr [7FFED0CE0680]
       mov       rax,r15
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
M02_L24:
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
       je        short M02_L25
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFED0770680
       call      qword ptr [7FFED0CE0680]
M02_L25:
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
; Total bytes of code 800
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,2412A5F3020
       mov       rbx,[rax]
       mov       rax,2410A5F55A0
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFED0C00558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
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
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1718
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       r8,2412A5F3020
       mov       r8,[r8]
       mov       r9,2413A5F1660
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,2413A5F1C00
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L02:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1970
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L11
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1970
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L06:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1C10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L08:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L24
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1970
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L11:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdi
       mov       rdx,7FFED0DD19B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L13:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFED0DD19D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFED0790678
       call      qword ptr [7FFED0D00678]
       test      eax,eax
       je        near ptr M02_L23
M02_L16:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rdi
       mov       rdx,7FFED0DD1A00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L19
       cmp       esi,0FFFFFFFE
       jne       short M02_L20
M02_L19:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L22
M02_L20:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L21
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L22
M02_L21:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L22:
       mov       rcx,rbx
       mov       r11,7FFED0790678
       call      qword ptr [7FFED0D00678]
       test      eax,eax
       jne       near ptr M02_L16
M02_L23:
       mov       rcx,rbx
       mov       r11,7FFED0790680
       call      qword ptr [7FFED0D00680]
       mov       rax,r15
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
M02_L24:
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
       je        short M02_L25
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFED0790680
       call      qword ptr [7FFED0D00680]
M02_L25:
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
; Total bytes of code 800
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1A838E21028
       mov       rbx,[rax]
       mov       rax,1A838E279B0
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFED0BE0558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
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
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFED0DB1780
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       r8,1A838E21028
       mov       r8,[r8]
       mov       r9,1A838E28260
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,1A838E28800
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L02:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFED0DB19D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L11
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFED0DB19D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L06:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       rdx,7FFED0DB1C78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L08:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L24
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFED0DB19D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L11:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdi
       mov       rdx,7FFED0DB1A18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L13:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFED0DB1A38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFED0770678
       call      qword ptr [7FFED0CE0678]
       test      eax,eax
       je        near ptr M02_L23
M02_L16:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rdi
       mov       rdx,7FFED0DB1A68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L19
       cmp       esi,0FFFFFFFE
       jne       short M02_L20
M02_L19:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L22
M02_L20:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L21
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L22
M02_L21:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L22:
       mov       rcx,rbx
       mov       r11,7FFED0770678
       call      qword ptr [7FFED0CE0678]
       test      eax,eax
       jne       near ptr M02_L16
M02_L23:
       mov       rcx,rbx
       mov       r11,7FFED0770680
       call      qword ptr [7FFED0CE0680]
       mov       rax,r15
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
M02_L24:
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
       je        short M02_L25
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFED0770680
       call      qword ptr [7FFED0CE0680]
M02_L25:
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
; Total bytes of code 800
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1A48D043020
       mov       rbx,[rax]
       mov       rax,1A46D0415C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFED0C10558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
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
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFED0DE1798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       r8,1A48D043020
       mov       r8,[r8]
       mov       r9,1A48D049A40
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,1A48D049FE0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L02:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFED0DE19F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L11
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFED0DE19F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L06:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       rdx,7FFED0DE1C90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L08:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L24
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFED0DE19F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L11:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdi
       mov       rdx,7FFED0DE1A30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L13:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFED0DE1A50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFED07A0678
       call      qword ptr [7FFED0D10678]
       test      eax,eax
       je        near ptr M02_L23
M02_L16:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rdi
       mov       rdx,7FFED0DE1A80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L19
       cmp       esi,0FFFFFFFE
       jne       short M02_L20
M02_L19:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L22
M02_L20:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L21
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L22
M02_L21:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L22:
       mov       rcx,rbx
       mov       r11,7FFED07A0678
       call      qword ptr [7FFED0D10678]
       test      eax,eax
       jne       near ptr M02_L16
M02_L23:
       mov       rcx,rbx
       mov       r11,7FFED07A0680
       call      qword ptr [7FFED0D10680]
       mov       rax,r15
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
M02_L24:
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
       je        short M02_L25
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFED07A0680
       call      qword ptr [7FFED0D10680]
M02_L25:
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
; Total bytes of code 800
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1E0C4B13020
       mov       rbx,[rax]
       mov       rax,1E0A4B115C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFED0C00558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
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
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFED0DE1798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       r8,1E0C4B13020
       mov       r8,[r8]
       mov       r9,1E0C4B1AA58
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,1E0C4B1AFF8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L02:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFED0DE19F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L11
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFED0DE19F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L06:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       rdx,7FFED0DE1C90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L08:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L24
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFED0DE19F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L11:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdi
       mov       rdx,7FFED0DE1A30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L13:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFED0DE1A50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFED0790678
       call      qword ptr [7FFED0D10678]
       test      eax,eax
       je        near ptr M02_L23
M02_L16:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rdi
       mov       rdx,7FFED0DE1A80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L19
       cmp       esi,0FFFFFFFE
       jne       short M02_L20
M02_L19:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L22
M02_L20:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L21
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L22
M02_L21:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L22:
       mov       rcx,rbx
       mov       r11,7FFED0790678
       call      qword ptr [7FFED0D10678]
       test      eax,eax
       jne       near ptr M02_L16
M02_L23:
       mov       rcx,rbx
       mov       r11,7FFED0790680
       call      qword ptr [7FFED0D10680]
       mov       rax,r15
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
M02_L24:
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
       je        short M02_L25
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFED0790680
       call      qword ptr [7FFED0D10680]
M02_L25:
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
; Total bytes of code 800
```

