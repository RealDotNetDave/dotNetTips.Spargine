## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(this.Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+2AC]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+18]
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
       mov       rcx,2934A569B48
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
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(this.Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+2AC]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+18]
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
       mov       rcx,22659C29B48
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
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(this.Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+2AC]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+18]
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
       mov       rcx,2663F211768
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
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(this.Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+2AC]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+18]
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
       mov       rcx,21EAE147B50
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
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(this.Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+2AC]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+18]
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
       mov       rcx,27177589B48
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
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(this.Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+2AC]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+18]
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
       mov       rcx,1CD7A3D9B48
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
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(this.Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+2AC]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+18]
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
       mov       rcx,1C78B4C7B50
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
       mov       ecx,3A5
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B378E8
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(this.Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+2AC]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+18]
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
       mov       rcx,20CBC4B9B48
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
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperRefArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+268]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+18]
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
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB52CD33C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB52C6E7E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB52C6E7E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L21
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
       je        near ptr M02_L25
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB52EAC800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L08
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFB52EAC800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,7FFB52EACAA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L29
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFB52EAC800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFB52EAC840
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rdi
       mov       rdx,7FFB52EAC860
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFB528607C8
       call      qword ptr [7FFB52E307C8]
       test      eax,eax
       je        near ptr M02_L20
M02_L13:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFB52EAC890
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L16
       cmp       esi,0FFFFFFFE
       jne       short M02_L17
M02_L16:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L19
M02_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L18
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L19
M02_L18:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L19:
       mov       rcx,rbx
       mov       r11,7FFB528607C8
       call      qword ptr [7FFB52E307C8]
       test      eax,eax
       jne       near ptr M02_L13
M02_L20:
       mov       rcx,rbx
       mov       r11,7FFB528607D0
       call      qword ptr [7FFB52E307D0]
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
M02_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rbx,rax
       mov       rcx,20FB9BA1688
       mov       rcx,[rcx]
       mov       rdx,20F99BA3090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M02_L22
       cmp       dword ptr [rcx+8],0
       je        short M02_L22
       xor       eax,eax
       jmp       short M02_L23
M02_L22:
       mov       eax,1
M02_L23:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L24:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rax,20FB9BA1B88
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short M02_L26
       xor       eax,eax
       jmp       short M02_L27
M02_L26:
       mov       eax,1
M02_L27:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L29:
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
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M02_L30
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB528607D0
       call      qword ptr [7FFB52E307D0]
M02_L30:
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
; Total bytes of code 1316
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperRefArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+268]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+18]
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
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB52CF33C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB52C8E7E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB52C8E7E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L21
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
       je        near ptr M02_L25
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB52ECC800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L08
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFB52ECC800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,7FFB52ECCAA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L29
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFB52ECC800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFB52ECC840
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rdi
       mov       rdx,7FFB52ECC860
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFB528807C8
       call      qword ptr [7FFB52E507C8]
       test      eax,eax
       je        near ptr M02_L20
M02_L13:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFB52ECC890
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L16
       cmp       esi,0FFFFFFFE
       jne       short M02_L17
M02_L16:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L19
M02_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L18
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L19
M02_L18:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L19:
       mov       rcx,rbx
       mov       r11,7FFB528807C8
       call      qword ptr [7FFB52E507C8]
       test      eax,eax
       jne       near ptr M02_L13
M02_L20:
       mov       rcx,rbx
       mov       r11,7FFB528807D0
       call      qword ptr [7FFB52E507D0]
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
M02_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rbx,rax
       mov       rcx,2685F531688
       mov       rcx,[rcx]
       mov       rdx,2683F533090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M02_L22
       cmp       dword ptr [rcx+8],0
       je        short M02_L22
       xor       eax,eax
       jmp       short M02_L23
M02_L22:
       mov       eax,1
M02_L23:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B478E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B478E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B478E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L24:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rax,2685F531B88
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short M02_L26
       xor       eax,eax
       jmp       short M02_L27
M02_L26:
       mov       eax,1
M02_L27:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B478E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B478E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B478E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L29:
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
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M02_L30
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB528807D0
       call      qword ptr [7FFB52E507D0]
M02_L30:
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
; Total bytes of code 1316
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperRefArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+268]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+18]
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
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB52CE33C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB52C7E7E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB52C7E7E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L21
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
       je        near ptr M02_L25
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L08
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,7FFB52EBCAA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L29
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC840
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC860
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFB528707C8
       call      qword ptr [7FFB52E407C8]
       test      eax,eax
       je        near ptr M02_L20
M02_L13:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC890
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L16
       cmp       esi,0FFFFFFFE
       jne       short M02_L17
M02_L16:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L19
M02_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L18
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L19
M02_L18:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L19:
       mov       rcx,rbx
       mov       r11,7FFB528707C8
       call      qword ptr [7FFB52E407C8]
       test      eax,eax
       jne       near ptr M02_L13
M02_L20:
       mov       rcx,rbx
       mov       r11,7FFB528707D0
       call      qword ptr [7FFB52E407D0]
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
M02_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rbx,rax
       mov       rcx,19E6FE58A88
       mov       rcx,[rcx]
       mov       rdx,19E6FE51098
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M02_L22
       cmp       dword ptr [rcx+8],0
       je        short M02_L22
       xor       eax,eax
       jmp       short M02_L23
M02_L22:
       mov       eax,1
M02_L23:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L24:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rax,19E6FE58F88
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short M02_L26
       xor       eax,eax
       jmp       short M02_L27
M02_L26:
       mov       eax,1
M02_L27:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L29:
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
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M02_L30
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB528707D0
       call      qword ptr [7FFB52E407D0]
M02_L30:
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
; Total bytes of code 1316
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperRefArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+268]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+18]
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
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB52CE33C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB52C7E7E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB52C7E7E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L21
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
       je        near ptr M02_L25
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L08
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,7FFB52EBCAA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L29
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC840
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC860
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFB528707C8
       call      qword ptr [7FFB52E407C8]
       test      eax,eax
       je        near ptr M02_L20
M02_L13:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC890
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L16
       cmp       esi,0FFFFFFFE
       jne       short M02_L17
M02_L16:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L19
M02_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L18
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L19
M02_L18:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L19:
       mov       rcx,rbx
       mov       r11,7FFB528707C8
       call      qword ptr [7FFB52E407C8]
       test      eax,eax
       jne       near ptr M02_L13
M02_L20:
       mov       rcx,rbx
       mov       r11,7FFB528707D0
       call      qword ptr [7FFB52E407D0]
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
M02_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rbx,rax
       mov       rcx,2324E46B298
       mov       rcx,[rcx]
       mov       rdx,2324E463090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M02_L22
       cmp       dword ptr [rcx+8],0
       je        short M02_L22
       xor       eax,eax
       jmp       short M02_L23
M02_L22:
       mov       eax,1
M02_L23:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L24:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rax,2324E46B798
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short M02_L26
       xor       eax,eax
       jmp       short M02_L27
M02_L26:
       mov       eax,1
M02_L27:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L29:
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
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M02_L30
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB528707D0
       call      qword ptr [7FFB52E407D0]
M02_L30:
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
; Total bytes of code 1316
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperRefArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+268]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+18]
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
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB52CE33C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB52C7E7E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB52C7E7E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L21
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
       je        near ptr M02_L25
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L08
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,7FFB52EBCAA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L29
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC840
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC860
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFB528707C8
       call      qword ptr [7FFB52E407C8]
       test      eax,eax
       je        near ptr M02_L20
M02_L13:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC890
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L16
       cmp       esi,0FFFFFFFE
       jne       short M02_L17
M02_L16:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L19
M02_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L18
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L19
M02_L18:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L19:
       mov       rcx,rbx
       mov       r11,7FFB528707C8
       call      qword ptr [7FFB52E407C8]
       test      eax,eax
       jne       near ptr M02_L13
M02_L20:
       mov       rcx,rbx
       mov       r11,7FFB528707D0
       call      qword ptr [7FFB52E407D0]
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
M02_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rbx,rax
       mov       rcx,2B715831688
       mov       rcx,[rcx]
       mov       rdx,2B725833090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M02_L22
       cmp       dword ptr [rcx+8],0
       je        short M02_L22
       xor       eax,eax
       jmp       short M02_L23
M02_L22:
       mov       eax,1
M02_L23:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L24:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rax,2B715831B88
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short M02_L26
       xor       eax,eax
       jmp       short M02_L27
M02_L26:
       mov       eax,1
M02_L27:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L29:
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
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M02_L30
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB528707D0
       call      qword ptr [7FFB52E407D0]
M02_L30:
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
; Total bytes of code 1316
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperRefArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+268]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+18]
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
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB52CD33C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB52C6E7E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB52C6E7E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L21
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
       je        near ptr M02_L25
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB52EAC800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L08
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFB52EAC800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,7FFB52EACAA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L29
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFB52EAC800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFB52EAC840
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rdi
       mov       rdx,7FFB52EAC860
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFB528607C8
       call      qword ptr [7FFB52E307C8]
       test      eax,eax
       je        near ptr M02_L20
M02_L13:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFB52EAC890
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L16
       cmp       esi,0FFFFFFFE
       jne       short M02_L17
M02_L16:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L19
M02_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L18
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L19
M02_L18:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L19:
       mov       rcx,rbx
       mov       r11,7FFB528607C8
       call      qword ptr [7FFB52E307C8]
       test      eax,eax
       jne       near ptr M02_L13
M02_L20:
       mov       rcx,rbx
       mov       r11,7FFB528607D0
       call      qword ptr [7FFB52E307D0]
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
M02_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rbx,rax
       mov       rcx,2235BDC26A0
       mov       rcx,[rcx]
       mov       rdx,2234BDC3090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M02_L22
       cmp       dword ptr [rcx+8],0
       je        short M02_L22
       xor       eax,eax
       jmp       short M02_L23
M02_L22:
       mov       eax,1
M02_L23:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L24:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rax,2235BDC2BA0
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short M02_L26
       xor       eax,eax
       jmp       short M02_L27
M02_L26:
       mov       eax,1
M02_L27:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L29:
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
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M02_L30
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB528607D0
       call      qword ptr [7FFB52E307D0]
M02_L30:
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
; Total bytes of code 1316
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperRefArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+268]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+18]
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
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB52CDAF70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB52C6E7E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB52C6E7E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L21
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
       je        near ptr M02_L25
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC588
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L08
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC588
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC828
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L29
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC588
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC5C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC5E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFB528607D8
       call      qword ptr [7FFB52E307D8]
       test      eax,eax
       je        near ptr M02_L20
M02_L13:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC618
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L16
       cmp       esi,0FFFFFFFE
       jne       short M02_L17
M02_L16:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L19
M02_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L18
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L19
M02_L18:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L19:
       mov       rcx,rbx
       mov       r11,7FFB528607D8
       call      qword ptr [7FFB52E307D8]
       test      eax,eax
       jne       near ptr M02_L13
M02_L20:
       mov       rcx,rbx
       mov       r11,7FFB528607E0
       call      qword ptr [7FFB52E307E0]
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
M02_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rbx,rax
       mov       rcx,1DE33341688
       mov       rcx,[rcx]
       mov       rdx,1DE43343090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M02_L22
       cmp       dword ptr [rcx+8],0
       je        short M02_L22
       xor       eax,eax
       jmp       short M02_L23
M02_L22:
       mov       eax,1
M02_L23:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L24:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rax,1DE33341B88
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short M02_L26
       xor       eax,eax
       jmp       short M02_L27
M02_L26:
       mov       eax,1
M02_L27:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L29:
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
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M02_L30
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB528607E0
       call      qword ptr [7FFB52E307E0]
M02_L30:
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
; Total bytes of code 1316
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperRefArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+268]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+18]
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
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB52CDAF70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB52C6E7E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB52C6E7E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L21
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
       je        near ptr M02_L25
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC5B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L08
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC5B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC858
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L29
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC5B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC5F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC618
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFB528607D8
       call      qword ptr [7FFB52E307D8]
       test      eax,eax
       je        near ptr M02_L20
M02_L13:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC648
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L16
       cmp       esi,0FFFFFFFE
       jne       short M02_L17
M02_L16:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L19
M02_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L18
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L19
M02_L18:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L19:
       mov       rcx,rbx
       mov       r11,7FFB528607D8
       call      qword ptr [7FFB52E307D8]
       test      eax,eax
       jne       near ptr M02_L13
M02_L20:
       mov       rcx,rbx
       mov       r11,7FFB528607E0
       call      qword ptr [7FFB52E307E0]
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
M02_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rbx,rax
       mov       rcx,1F426271688
       mov       rcx,[rcx]
       mov       rdx,1F436273090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M02_L22
       cmp       dword ptr [rcx+8],0
       je        short M02_L22
       xor       eax,eax
       jmp       short M02_L23
M02_L22:
       mov       eax,1
M02_L23:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L24:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rax,1F426271B88
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short M02_L26
       xor       eax,eax
       jmp       short M02_L27
M02_L26:
       mov       eax,1
M02_L27:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L29:
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
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M02_L30
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB528607E0
       call      qword ptr [7FFB52E307E0]
M02_L30:
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
; Total bytes of code 1316
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperRefArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+268]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+18]
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
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB52CC33C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB52C5E7E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB52C5E7E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L21
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
       je        near ptr M02_L25
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB52E9C800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L08
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFB52E9C800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,7FFB52E9CAA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L29
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFB52E9C800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFB52E9C840
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rdi
       mov       rdx,7FFB52E9C860
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFB528507C8
       call      qword ptr [7FFB52E207C8]
       test      eax,eax
       je        near ptr M02_L20
M02_L13:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFB52E9C890
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L16
       cmp       esi,0FFFFFFFE
       jne       short M02_L17
M02_L16:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L19
M02_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L18
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L19
M02_L18:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L19:
       mov       rcx,rbx
       mov       r11,7FFB528507C8
       call      qword ptr [7FFB52E207C8]
       test      eax,eax
       jne       near ptr M02_L13
M02_L20:
       mov       rcx,rbx
       mov       r11,7FFB528507D0
       call      qword ptr [7FFB52E207D0]
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
M02_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rbx,rax
       mov       rcx,24A6CF91688
       mov       rcx,[rcx]
       mov       rdx,24A4CF93090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M02_L22
       cmp       dword ptr [rcx+8],0
       je        short M02_L22
       xor       eax,eax
       jmp       short M02_L23
M02_L22:
       mov       eax,1
M02_L23:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L24:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rax,24A6CF91B88
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short M02_L26
       xor       eax,eax
       jmp       short M02_L27
M02_L26:
       mov       eax,1
M02_L27:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L29:
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
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M02_L30
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB528507D0
       call      qword ptr [7FFB52E207D0]
M02_L30:
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
; Total bytes of code 1316
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperRefArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+268]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+18]
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
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB52CD33C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB52C6E7E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB52C6E7E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L21
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
       je        near ptr M02_L25
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB52EAC800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L08
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFB52EAC800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,7FFB52EACAA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L29
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFB52EAC800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFB52EAC840
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rdi
       mov       rdx,7FFB52EAC860
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFB528607C8
       call      qword ptr [7FFB52E307C8]
       test      eax,eax
       je        near ptr M02_L20
M02_L13:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFB52EAC890
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L16
       cmp       esi,0FFFFFFFE
       jne       short M02_L17
M02_L16:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L19
M02_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L18
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L19
M02_L18:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L19:
       mov       rcx,rbx
       mov       r11,7FFB528607C8
       call      qword ptr [7FFB52E307C8]
       test      eax,eax
       jne       near ptr M02_L13
M02_L20:
       mov       rcx,rbx
       mov       r11,7FFB528607D0
       call      qword ptr [7FFB52E307D0]
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
M02_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rbx,rax
       mov       rcx,207010AA280
       mov       rcx,[rcx]
       mov       rdx,207010A3090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M02_L22
       cmp       dword ptr [rcx+8],0
       je        short M02_L22
       xor       eax,eax
       jmp       short M02_L23
M02_L22:
       mov       eax,1
M02_L23:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L24:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rax,207010AA780
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short M02_L26
       xor       eax,eax
       jmp       short M02_L27
M02_L26:
       mov       eax,1
M02_L27:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L29:
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
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M02_L30
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB528607D0
       call      qword ptr [7FFB52E307D0]
M02_L30:
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
; Total bytes of code 1316
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperRefArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+268]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+18]
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
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB52CC33C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB52C5E7E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB52C5E7E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L21
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
       je        near ptr M02_L25
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB52E9C800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L08
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFB52E9C800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,7FFB52E9CAA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L29
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFB52E9C800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFB52E9C840
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rdi
       mov       rdx,7FFB52E9C860
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFB528507C8
       call      qword ptr [7FFB52E207C8]
       test      eax,eax
       je        near ptr M02_L20
M02_L13:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFB52E9C890
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L16
       cmp       esi,0FFFFFFFE
       jne       short M02_L17
M02_L16:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L19
M02_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L18
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L19
M02_L18:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L19:
       mov       rcx,rbx
       mov       r11,7FFB528507C8
       call      qword ptr [7FFB52E207C8]
       test      eax,eax
       jne       near ptr M02_L13
M02_L20:
       mov       rcx,rbx
       mov       r11,7FFB528507D0
       call      qword ptr [7FFB52E207D0]
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
M02_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rbx,rax
       mov       rcx,1D97AEEA280
       mov       rcx,[rcx]
       mov       rdx,1D97AEE3090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M02_L22
       cmp       dword ptr [rcx+8],0
       je        short M02_L22
       xor       eax,eax
       jmp       short M02_L23
M02_L22:
       mov       eax,1
M02_L23:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L24:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rax,1D97AEEA780
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short M02_L26
       xor       eax,eax
       jmp       short M02_L27
M02_L26:
       mov       eax,1
M02_L27:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L29:
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
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M02_L30
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB528507D0
       call      qword ptr [7FFB52E207D0]
M02_L30:
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
; Total bytes of code 1316
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperRefArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+268]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+18]
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
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB52CB33C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB52C4E7E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB52C4E7E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L21
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
       je        near ptr M02_L25
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB52E8C800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L08
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFB52E8C800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,7FFB52E8CAA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L29
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFB52E8C800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFB52E8C840
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rdi
       mov       rdx,7FFB52E8C860
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFB528407C8
       call      qword ptr [7FFB52E107C8]
       test      eax,eax
       je        near ptr M02_L20
M02_L13:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFB52E8C890
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L16
       cmp       esi,0FFFFFFFE
       jne       short M02_L17
M02_L16:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L19
M02_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L18
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L19
M02_L18:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L19:
       mov       rcx,rbx
       mov       r11,7FFB528407C8
       call      qword ptr [7FFB52E107C8]
       test      eax,eax
       jne       near ptr M02_L13
M02_L20:
       mov       rcx,rbx
       mov       r11,7FFB528407D0
       call      qword ptr [7FFB52E107D0]
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
M02_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rbx,rax
       mov       rcx,1D132BD26A0
       mov       rcx,[rcx]
       mov       rdx,1D142BD3090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M02_L22
       cmp       dword ptr [rcx+8],0
       je        short M02_L22
       xor       eax,eax
       jmp       short M02_L23
M02_L22:
       mov       eax,1
M02_L23:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B078E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B078E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B078E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L24:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rax,1D132BD2BA0
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short M02_L26
       xor       eax,eax
       jmp       short M02_L27
M02_L26:
       mov       eax,1
M02_L27:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B078E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B078E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B078E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L29:
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
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M02_L30
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB528407D0
       call      qword ptr [7FFB52E107D0]
M02_L30:
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
; Total bytes of code 1316
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperRefArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+268]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+18]
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
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB52CC33C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB52C5E7E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB52C5E7E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L21
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
       je        near ptr M02_L25
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB52E9C800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L08
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFB52E9C800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,7FFB52E9CAA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L29
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFB52E9C800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFB52E9C840
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rdi
       mov       rdx,7FFB52E9C860
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFB528507C8
       call      qword ptr [7FFB52E207C8]
       test      eax,eax
       je        near ptr M02_L20
M02_L13:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFB52E9C890
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L16
       cmp       esi,0FFFFFFFE
       jne       short M02_L17
M02_L16:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L19
M02_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L18
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L19
M02_L18:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L19:
       mov       rcx,rbx
       mov       r11,7FFB528507C8
       call      qword ptr [7FFB52E207C8]
       test      eax,eax
       jne       near ptr M02_L13
M02_L20:
       mov       rcx,rbx
       mov       r11,7FFB528507D0
       call      qword ptr [7FFB52E207D0]
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
M02_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rbx,rax
       mov       rcx,21A084F1688
       mov       rcx,[rcx]
       mov       rdx,219F84F3090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M02_L22
       cmp       dword ptr [rcx+8],0
       je        short M02_L22
       xor       eax,eax
       jmp       short M02_L23
M02_L22:
       mov       eax,1
M02_L23:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L24:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rax,21A084F1B88
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short M02_L26
       xor       eax,eax
       jmp       short M02_L27
M02_L26:
       mov       eax,1
M02_L27:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L29:
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
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M02_L30
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB528507D0
       call      qword ptr [7FFB52E207D0]
M02_L30:
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
; Total bytes of code 1316
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperRefArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+268]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+18]
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
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB52CC33C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB52C5E7E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB52C5E7E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L21
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
       je        near ptr M02_L25
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB52E9C800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L08
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFB52E9C800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,7FFB52E9CAA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L29
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFB52E9C800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFB52E9C840
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rdi
       mov       rdx,7FFB52E9C860
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFB528507C8
       call      qword ptr [7FFB52E207C8]
       test      eax,eax
       je        near ptr M02_L20
M02_L13:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFB52E9C890
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L16
       cmp       esi,0FFFFFFFE
       jne       short M02_L17
M02_L16:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L19
M02_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L18
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L19
M02_L18:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L19:
       mov       rcx,rbx
       mov       r11,7FFB528507C8
       call      qword ptr [7FFB52E207C8]
       test      eax,eax
       jne       near ptr M02_L13
M02_L20:
       mov       rcx,rbx
       mov       r11,7FFB528507D0
       call      qword ptr [7FFB52E207D0]
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
M02_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rbx,rax
       mov       rcx,26C66082EB8
       mov       rcx,[rcx]
       mov       rdx,26C86083090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M02_L22
       cmp       dword ptr [rcx+8],0
       je        short M02_L22
       xor       eax,eax
       jmp       short M02_L23
M02_L22:
       mov       eax,1
M02_L23:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L24:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rax,26C660833B8
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short M02_L26
       xor       eax,eax
       jmp       short M02_L27
M02_L26:
       mov       eax,1
M02_L27:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L29:
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
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M02_L30
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB528507D0
       call      qword ptr [7FFB52E207D0]
M02_L30:
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
; Total bytes of code 1316
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperRefArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+268]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+18]
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
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB52CDAF70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB52C6E7E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB52C6E7E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L21
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
       je        near ptr M02_L25
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC588
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L08
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC588
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC828
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L29
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC588
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC5C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC5E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFB528607D8
       call      qword ptr [7FFB52E307D8]
       test      eax,eax
       je        near ptr M02_L20
M02_L13:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC618
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L16
       cmp       esi,0FFFFFFFE
       jne       short M02_L17
M02_L16:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L19
M02_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L18
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L19
M02_L18:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L19:
       mov       rcx,rbx
       mov       r11,7FFB528607D8
       call      qword ptr [7FFB52E307D8]
       test      eax,eax
       jne       near ptr M02_L13
M02_L20:
       mov       rcx,rbx
       mov       r11,7FFB528607E0
       call      qword ptr [7FFB52E307E0]
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
M02_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rbx,rax
       mov       rcx,215B32C26A0
       mov       rcx,[rcx]
       mov       rdx,215A32C3090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M02_L22
       cmp       dword ptr [rcx+8],0
       je        short M02_L22
       xor       eax,eax
       jmp       short M02_L23
M02_L22:
       mov       eax,1
M02_L23:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L24:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rax,215B32C2BA0
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short M02_L26
       xor       eax,eax
       jmp       short M02_L27
M02_L26:
       mov       eax,1
M02_L27:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L29:
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
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M02_L30
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB528607E0
       call      qword ptr [7FFB52E307E0]
M02_L30:
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
; Total bytes of code 1316
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperRefArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+268]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+18]
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
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB52CDAF70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB52C6E7E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB52C6E7E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L21
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
       je        near ptr M02_L25
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC5B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M02_L08
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC5B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC858
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L29
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC5B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M02_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC5F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC618
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FFB528607D8
       call      qword ptr [7FFB52E307D8]
       test      eax,eax
       je        near ptr M02_L20
M02_L13:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rdi
       mov       rdx,7FFB52EBC648
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M02_L16
       cmp       esi,0FFFFFFFE
       jne       short M02_L17
M02_L16:
       mov       rcx,r15
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M02_L19
M02_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M02_L18
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L19
M02_L18:
       mov       rcx,r15
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L19:
       mov       rcx,rbx
       mov       r11,7FFB528607D8
       call      qword ptr [7FFB52E307D8]
       test      eax,eax
       jne       near ptr M02_L13
M02_L20:
       mov       rcx,rbx
       mov       r11,7FFB528607E0
       call      qword ptr [7FFB52E307E0]
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
M02_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rbx,rax
       mov       rcx,16594D29A68
       mov       rcx,[rcx]
       mov       rdx,16594D23090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M02_L22
       cmp       dword ptr [rcx+8],0
       je        short M02_L22
       xor       eax,eax
       jmp       short M02_L23
M02_L22:
       mov       eax,1
M02_L23:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L24:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rax,16594D29F68
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short M02_L26
       xor       eax,eax
       jmp       short M02_L27
M02_L26:
       mov       eax,1
M02_L27:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L29:
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
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M02_L30
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB528607E0
       call      qword ptr [7FFB52E307E0]
M02_L30:
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
; Total bytes of code 1316
```

