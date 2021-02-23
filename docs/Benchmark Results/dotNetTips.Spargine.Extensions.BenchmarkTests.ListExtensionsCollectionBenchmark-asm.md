## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeReadOnlyList()
; 			var result = base.PersonProperCollection.ToReadOnlyCollection().ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode(System.Collections.ObjectModel.ReadOnlyCollection`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1FB6BE63060
       mov       r8,[r8]
       mov       rdx,1FB5BE611A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF1758
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M01_L02
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 133
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M02_L00
       mov       rcx,[rbx+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1BA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,1FB6BE63060
       mov       r8,[r8]
       mov       rdx,1FB5BE611A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M02_L02
       mov       rcx,[rbx+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1D10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+20],0
       je        short M02_L04
       mov       rcx,[rbx+20]
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1F40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax+8]
       test      r14,r14
       jne       near ptr M02_L12
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1F40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       mov       r14,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r15,[rax]
       cmp       qword ptr [r14+8],40
       jle       short M02_L08
       mov       rcx,[r14+40]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FF2498
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      r15,r15
       je        near ptr M02_L19
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__13`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__13_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1F40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M02_L12:
       cmp       qword ptr [rbx+28],0
       je        short M02_L13
       mov       rcx,[rbx+28]
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M02_L15
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFB36FF22B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass13_0`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__1(Int32, System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L17
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFB36FF2358
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       mov       rdx,rdi
       mov       r9,rbx
       mov       r8d,1997
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L19:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 586
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeReadOnlyList()
; 			var result = base.PersonProperCollection.ToReadOnlyCollection().ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode(System.Collections.ObjectModel.ReadOnlyCollection`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,2329FD23060
       mov       r8,[r8]
       mov       rdx,2328FD211A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FD16D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M01_L02
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 133
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M02_L00
       mov       rcx,[rbx+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FD1B20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,2329FD23060
       mov       r8,[r8]
       mov       rdx,2328FD211A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M02_L02
       mov       rcx,[rbx+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FD1C90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+20],0
       je        short M02_L04
       mov       rcx,[rbx+20]
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FD1EC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax+8]
       test      r14,r14
       jne       near ptr M02_L12
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FD1EC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       mov       r14,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r15,[rax]
       cmp       qword ptr [r14+8],40
       jle       short M02_L08
       mov       rcx,[r14+40]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FD2418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      r15,r15
       je        near ptr M02_L19
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__13`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__13_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FD1EC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M02_L12:
       cmp       qword ptr [rbx+28],0
       je        short M02_L13
       mov       rcx,[rbx+28]
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFB36FD1F00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M02_L15
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFB36FD2230
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass13_0`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__1(Int32, System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L17
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFB36FD22D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       mov       rdx,rdi
       mov       r9,rbx
       mov       r8d,1997
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L19:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 586
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeReadOnlyList()
; 			var result = base.PersonProperCollection.ToReadOnlyCollection().ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode(System.Collections.ObjectModel.ReadOnlyCollection`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1BE144E3060
       mov       r8,[r8]
       mov       rdx,1BE044EDBC8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37001738
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M01_L02
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 133
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M02_L00
       mov       rcx,[rbx+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37001B80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,1BE144E3060
       mov       r8,[r8]
       mov       rdx,1BE044EDBC8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M02_L02
       mov       rcx,[rbx+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB37001CF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+20],0
       je        short M02_L04
       mov       rcx,[rbx+20]
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB37001F20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax+8]
       test      r14,r14
       jne       near ptr M02_L12
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB37001F20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       mov       r14,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r15,[rax]
       cmp       qword ptr [r14+8],40
       jle       short M02_L08
       mov       rcx,[r14+40]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37002478
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      r15,r15
       je        near ptr M02_L19
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__13`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__13_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB37001F20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M02_L12:
       cmp       qword ptr [rbx+28],0
       je        short M02_L13
       mov       rcx,[rbx+28]
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFB37001F60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M02_L15
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFB37002290
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass13_0`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__1(Int32, System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L17
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFB37002338
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       mov       rdx,rdi
       mov       r9,rbx
       mov       r8d,1997
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L19:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 586
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeReadOnlyList()
; 			var result = base.PersonProperCollection.ToReadOnlyCollection().ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode(System.Collections.ObjectModel.ReadOnlyCollection`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1C4E6981048
       mov       r8,[r8]
       mov       rdx,1C4F69811A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FE18C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M01_L02
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 133
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M02_L00
       mov       rcx,[rbx+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1D10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,1C4E6981048
       mov       r8,[r8]
       mov       rdx,1C4F69811A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M02_L02
       mov       rcx,[rbx+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1E80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+20],0
       je        short M02_L04
       mov       rcx,[rbx+20]
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FE20B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax+8]
       test      r14,r14
       jne       near ptr M02_L12
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FE20B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       mov       r14,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r15,[rax]
       cmp       qword ptr [r14+8],40
       jle       short M02_L08
       mov       rcx,[r14+40]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FE2608
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      r15,r15
       je        near ptr M02_L19
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__13`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__13_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FE20B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M02_L12:
       cmp       qword ptr [rbx+28],0
       je        short M02_L13
       mov       rcx,[rbx+28]
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFB36FE20F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M02_L15
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFB36FE2420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass13_0`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__1(Int32, System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L17
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFB36FE24C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       mov       rdx,rdi
       mov       r9,rbx
       mov       r8d,1997
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L19:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 586
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeReadOnlyList()
; 			var result = base.PersonProperCollection.ToReadOnlyCollection().ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode(System.Collections.ObjectModel.ReadOnlyCollection`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1717B103060
       mov       r8,[r8]
       mov       rdx,1719B1011A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB370116D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M01_L02
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 133
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M02_L00
       mov       rcx,[rbx+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37011B20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,1717B103060
       mov       r8,[r8]
       mov       rdx,1719B1011A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M02_L02
       mov       rcx,[rbx+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB37011C90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+20],0
       je        short M02_L04
       mov       rcx,[rbx+20]
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB37011EC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax+8]
       test      r14,r14
       jne       near ptr M02_L12
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB37011EC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       mov       r14,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r15,[rax]
       cmp       qword ptr [r14+8],40
       jle       short M02_L08
       mov       rcx,[r14+40]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37012418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      r15,r15
       je        near ptr M02_L19
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__13`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__13_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB37011EC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M02_L12:
       cmp       qword ptr [rbx+28],0
       je        short M02_L13
       mov       rcx,[rbx+28]
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFB37011F00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M02_L15
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFB37012230
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass13_0`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__1(Int32, System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L17
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFB370122D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       mov       rdx,rdi
       mov       r9,rbx
       mov       r8d,1997
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L19:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 586
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeReadOnlyList()
; 			var result = base.PersonProperCollection.ToReadOnlyCollection().ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode(System.Collections.ObjectModel.ReadOnlyCollection`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,22A14AC3060
       mov       r8,[r8]
       mov       rdx,22A04AC9158
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FE18C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M01_L02
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 133
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M02_L00
       mov       rcx,[rbx+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1D08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,22A14AC3060
       mov       r8,[r8]
       mov       rdx,22A04AC9158
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M02_L02
       mov       rcx,[rbx+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1E78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+20],0
       je        short M02_L04
       mov       rcx,[rbx+20]
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FE20A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax+8]
       test      r14,r14
       jne       near ptr M02_L12
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FE20A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       mov       r14,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r15,[rax]
       cmp       qword ptr [r14+8],40
       jle       short M02_L08
       mov       rcx,[r14+40]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FE2600
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      r15,r15
       je        near ptr M02_L19
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__13`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__13_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FE20A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M02_L12:
       cmp       qword ptr [rbx+28],0
       je        short M02_L13
       mov       rcx,[rbx+28]
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFB36FE20E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M02_L15
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFB36FE2418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass13_0`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__1(Int32, System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L17
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFB36FE24C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       mov       rdx,rdi
       mov       r9,rbx
       mov       r8d,1997
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L19:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 586
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeReadOnlyList()
; 			var result = base.PersonProperCollection.ToReadOnlyCollection().ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode(System.Collections.ObjectModel.ReadOnlyCollection`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,2CAADE03060
       mov       r8,[r8]
       mov       rdx,2CAADE22A28
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF1B48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M01_L02
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 133
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M02_L00
       mov       rcx,[rbx+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1F90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,2CAADE03060
       mov       r8,[r8]
       mov       rdx,2CAADE22A28
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M02_L02
       mov       rcx,[rbx+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FF2100
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+20],0
       je        short M02_L04
       mov       rcx,[rbx+20]
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FF2330
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax+8]
       test      r14,r14
       jne       near ptr M02_L12
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FF2330
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       mov       r14,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r15,[rax]
       cmp       qword ptr [r14+8],40
       jle       short M02_L08
       mov       rcx,[r14+40]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FF2888
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      r15,r15
       je        near ptr M02_L19
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__13`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__13_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FF2330
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M02_L12:
       cmp       qword ptr [rbx+28],0
       je        short M02_L13
       mov       rcx,[rbx+28]
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFB36FF2370
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M02_L15
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFB36FF26A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass13_0`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__1(Int32, System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L17
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFB36FF2748
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       mov       rdx,rdi
       mov       r9,rbx
       mov       r8d,1997
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L19:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 586
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeReadOnlyList()
; 			var result = base.PersonProperCollection.ToReadOnlyCollection().ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode(System.Collections.ObjectModel.ReadOnlyCollection`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1F5AEB73060
       mov       r8,[r8]
       mov       rdx,1F5BEB7DBC8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FE1B48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M01_L02
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 133
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M02_L00
       mov       rcx,[rbx+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1F90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,1F5AEB73060
       mov       r8,[r8]
       mov       rdx,1F5BEB7DBC8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M02_L02
       mov       rcx,[rbx+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FE2100
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+20],0
       je        short M02_L04
       mov       rcx,[rbx+20]
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FE2330
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax+8]
       test      r14,r14
       jne       near ptr M02_L12
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FE2330
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       mov       r14,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r15,[rax]
       cmp       qword ptr [r14+8],40
       jle       short M02_L08
       mov       rcx,[r14+40]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FE2888
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      r15,r15
       je        near ptr M02_L19
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__13`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__13_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FE2330
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M02_L12:
       cmp       qword ptr [rbx+28],0
       je        short M02_L13
       mov       rcx,[rbx+28]
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFB36FE2370
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M02_L15
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFB36FE26A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass13_0`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__1(Int32, System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L17
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFB36FE2748
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       mov       rdx,rdi
       mov       r9,rbx
       mov       r8d,1997
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L19:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 586
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeReadOnlyList()
; 			var result = base.PersonProperCollection.ToReadOnlyCollection().ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode(System.Collections.ObjectModel.ReadOnlyCollection`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,25FACF53060
       mov       r8,[r8]
       mov       rdx,25FCCF531B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37001968
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M01_L02
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 133
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M02_L00
       mov       rcx,[rbx+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37001DB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,25FACF53060
       mov       r8,[r8]
       mov       rdx,25FCCF531B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M02_L02
       mov       rcx,[rbx+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB37001F20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+20],0
       je        short M02_L04
       mov       rcx,[rbx+20]
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB37002150
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax+8]
       test      r14,r14
       jne       near ptr M02_L12
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB37002150
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       mov       r14,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r15,[rax]
       cmp       qword ptr [r14+8],40
       jle       short M02_L08
       mov       rcx,[r14+40]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB370026A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      r15,r15
       je        near ptr M02_L19
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__13`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__13_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB37002150
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M02_L12:
       cmp       qword ptr [rbx+28],0
       je        short M02_L13
       mov       rcx,[rbx+28]
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFB37002190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M02_L15
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFB370024C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass13_0`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__1(Int32, System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L17
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFB37002568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       mov       rdx,rdi
       mov       r9,rbx
       mov       r8d,1997
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L19:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 586
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ShuffleWithCount()
; 			var result = base.PersonProperCollection.Shuffle(base.Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       r8d,[rsi+0C0]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r8,26CC60D1048
       mov       r8,[r8]
       mov       rdx,26CA60D31B8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,26CC60D1048
       mov       rbp,[rax]
       test      edi,edi
       jle       short M01_L00
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L04
M01_L00:
       call      dotNetTips.Spargine.Core.Properties.Resources.get_NumberNotInRange()
       mov       rcx,rax
       test      rbp,rbp
       je        short M01_L01
       cmp       dword ptr [rbp+8],0
       ja        short M01_L02
M01_L01:
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
M01_L03:
       mov       rdx,26CC60D1438
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37010D30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFB37010D80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       rdx,rbx
       mov       r8d,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; Total bytes of code 229
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ShuffleWithCount()
; 			var result = base.PersonProperCollection.Shuffle(base.Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       r8d,[rsi+0C0]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r8,23D62263060
       mov       r8,[r8]
       mov       rdx,23D622635F0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,23D62263060
       mov       rbp,[rax]
       test      edi,edi
       jle       short M01_L00
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L04
M01_L00:
       call      dotNetTips.Spargine.Core.Properties.Resources.get_NumberNotInRange()
       mov       rcx,rax
       test      rbp,rbp
       je        short M01_L01
       cmp       dword ptr [rbp+8],0
       ja        short M01_L02
M01_L01:
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
M01_L03:
       mov       rdx,23D62263450
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0CD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0D20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       rdx,rbx
       mov       r8d,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; Total bytes of code 229
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ShuffleWithCount()
; 			var result = base.PersonProperCollection.Shuffle(base.Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       r8d,[rsi+0C0]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r8,201EE123060
       mov       r8,[r8]
       mov       rdx,201EE130018
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,201EE123060
       mov       rbp,[rax]
       test      edi,edi
       jle       short M01_L00
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L04
M01_L00:
       call      dotNetTips.Spargine.Core.Properties.Resources.get_NumberNotInRange()
       mov       rcx,rax
       test      rbp,rbp
       je        short M01_L01
       cmp       dword ptr [rbp+8],0
       ja        short M01_L02
M01_L01:
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
M01_L03:
       mov       rdx,201EE123450
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FD0D50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFB36FD0DA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       rdx,rbx
       mov       r8d,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; Total bytes of code 229
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ShuffleWithCount()
; 			var result = base.PersonProperCollection.Shuffle(base.Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       r8d,[rsi+0C0]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r8,202BDBA3060
       mov       r8,[r8]
       mov       rdx,202BDBB2030
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,202BDBA3060
       mov       rbp,[rax]
       test      edi,edi
       jle       short M01_L00
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L04
M01_L00:
       call      dotNetTips.Spargine.Core.Properties.Resources.get_NumberNotInRange()
       mov       rcx,rax
       test      rbp,rbp
       je        short M01_L01
       cmp       dword ptr [rbp+8],0
       ja        short M01_L02
M01_L01:
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
M01_L03:
       mov       rdx,202BDBA3450
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37000EC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFB37000F10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       rdx,rbx
       mov       r8d,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; Total bytes of code 229
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ShuffleWithCount()
; 			var result = base.PersonProperCollection.Shuffle(base.Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       r8d,[rsi+0C0]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r8,2DAECE83060
       mov       r8,[r8]
       mov       rdx,2DAECE835F0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,2DAECE83060
       mov       rbp,[rax]
       test      edi,edi
       jle       short M01_L00
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L04
M01_L00:
       call      dotNetTips.Spargine.Core.Properties.Resources.get_NumberNotInRange()
       mov       rcx,rax
       test      rbp,rbp
       je        short M01_L01
       cmp       dword ptr [rbp+8],0
       ja        short M01_L02
M01_L01:
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
M01_L03:
       mov       rdx,2DAECE83450
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1140
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       rdx,rbx
       mov       r8d,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; Total bytes of code 229
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ShuffleWithCount()
; 			var result = base.PersonProperCollection.Shuffle(base.Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       r8d,[rsi+0C0]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r8,1F260083060
       mov       r8,[r8]
       mov       rdx,1F2900811A0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,1F260083060
       mov       rbp,[rax]
       test      edi,edi
       jle       short M01_L00
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L04
M01_L00:
       call      dotNetTips.Spargine.Core.Properties.Resources.get_NumberNotInRange()
       mov       rcx,rax
       test      rbp,rbp
       je        short M01_L01
       cmp       dword ptr [rbp+8],0
       ja        short M01_L02
M01_L01:
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
M01_L03:
       mov       rdx,1F260083450
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37011140
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFB37011190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       rdx,rbx
       mov       r8d,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; Total bytes of code 229
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ShuffleWithCount()
; 			var result = base.PersonProperCollection.Shuffle(base.Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       r8d,[rsi+0C0]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r8,245D50A3060
       mov       r8,[r8]
       mov       rdx,245E50A11A0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,245D50A3060
       mov       rbp,[rax]
       test      edi,edi
       jle       short M01_L00
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L04
M01_L00:
       call      dotNetTips.Spargine.Core.Properties.Resources.get_NumberNotInRange()
       mov       rcx,rax
       test      rbp,rbp
       je        short M01_L01
       cmp       dword ptr [rbp+8],0
       ja        short M01_L02
M01_L01:
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
M01_L03:
       mov       rdx,245D50A3450
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37000CD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFB37000D20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       rdx,rbx
       mov       r8d,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; Total bytes of code 229
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ShuffleWithCount()
; 			var result = base.PersonProperCollection.Shuffle(base.Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       r8d,[rsi+0C0]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r8,21796E03060
       mov       r8,[r8]
       mov       rdx,21786E019D8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,21796E03060
       mov       rbp,[rax]
       test      edi,edi
       jle       short M01_L00
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L04
M01_L00:
       call      dotNetTips.Spargine.Core.Properties.Resources.get_NumberNotInRange()
       mov       rcx,rax
       test      rbp,rbp
       je        short M01_L01
       cmp       dword ptr [rbp+8],0
       ja        short M01_L02
M01_L01:
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
M01_L03:
       mov       rdx,21796E03450
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37010F60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFB37010FB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       rdx,rbx
       mov       r8d,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; Total bytes of code 229
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ShuffleWithCount()
; 			var result = base.PersonProperCollection.Shuffle(base.Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       r8d,[rsi+0C0]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r8,187B01B3060
       mov       r8,[r8]
       mov       rdx,187E01B11A0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,187B01B3060
       mov       rbp,[rax]
       test      edi,edi
       jle       short M01_L00
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L04
M01_L00:
       call      dotNetTips.Spargine.Core.Properties.Resources.get_NumberNotInRange()
       mov       rcx,rax
       test      rbp,rbp
       je        short M01_L01
       cmp       dword ptr [rbp+8],0
       ja        short M01_L02
M01_L01:
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
M01_L03:
       mov       rdx,187B01B3450
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37010F60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFB37010FB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       rdx,rbx
       mov       r8d,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; Total bytes of code 229
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToArray()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,16D45243060
       mov       r8,[r8]
       mov       rdx,16D4524BB78
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB370009F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,16D4524BB78
       mov       r8,[r8]
       mov       r9,16D45243060
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37000D28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F26080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToArray()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,26EC4983060
       mov       r8,[r8]
       mov       rdx,26EC4985BD8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37000A78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,26EC4985BD8
       mov       r8,[r8]
       mov       r9,26EC4983060
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37000DA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F26080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToArray()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,29122183060
       mov       r8,[r8]
       mov       rdx,29122183BC0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB370109F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,29122183BC0
       mov       r8,[r8]
       mov       r9,29122183060
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37010D28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F36080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToArray()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,18221E13060
       mov       r8,[r8]
       mov       rdx,18231E11770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0BE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,18231E11770
       mov       r8,[r8]
       mov       r9,18221E13060
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0F10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F06080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToArray()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,21EAB761048
       mov       r8,[r8]
       mov       rdx,21E8B761770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37000C88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,21E8B761770
       mov       r8,[r8]
       mov       r9,21EAB761048
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37000FB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F26080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToArray()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1AF30263060
       mov       r8,[r8]
       mov       rdx,1AF302705E8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0E68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,1AF302705E8
       mov       r8,[r8]
       mov       r9,1AF30263060
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FE1198
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F06080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToArray()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1DB494A1048
       mov       r8,[r8]
       mov       rdx,1DB494B05E8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0E68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,1DB494B05E8
       mov       r8,[r8]
       mov       r9,1DB494A1048
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FE1198
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F06080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToArray()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,22E4DDF3060
       mov       r8,[r8]
       mov       rdx,22E4DE02600
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0A78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,22E4DE02600
       mov       r8,[r8]
       mov       r9,22E4DDF3060
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0DA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F16080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToArray()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1A0A78F3060
       mov       r8,[r8]
       mov       rdx,1A0B78F1770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37000E68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,1A0B78F1770
       mov       r8,[r8]
       mov       r9,1A0A78F3060
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37001198
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F26080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.PersonProperCollection.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.CopyToList(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 82
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1EB69FE3060
       mov       r8,[r8]
       mov       rdx,1EB89FE11A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37011088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       r8,1EB69FE3060
       mov       r8,[r8]
       mov       rdx,1EB89FE11A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbp,[rsi+10]
       mov       r11,[rbp+10]
       test      r11,r11
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB370112F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L02:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1EB69FE3060
       mov       r9,[r9]
       mov       r8,1EB89FE11A0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB370114E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37011500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rdi
       mov       edx,r14d
       mov       r8,rbx
       call      qword ptr [r11]
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 268
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.PersonProperCollection.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.CopyToList(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 82
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,15A71903060
       mov       r8,[r8]
       mov       rdx,15AA19011A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB370110E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       r8,15A71903060
       mov       r8,[r8]
       mov       rdx,15AA19011A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbp,[rsi+10]
       mov       r11,[rbp+10]
       test      r11,r11
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB37011350
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L02:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,15A71903060
       mov       r9,[r9]
       mov       r8,15AA19011A0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB37011548
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37011560
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rdi
       mov       edx,r14d
       mov       r8,rbx
       call      qword ptr [r11]
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 268
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.PersonProperCollection.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.CopyToList(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 82
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,18D54283060
       mov       r8,[r8]
       mov       rdx,18D642811A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37011108
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       r8,18D54283060
       mov       r8,[r8]
       mov       rdx,18D642811A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbp,[rsi+10]
       mov       r11,[rbp+10]
       test      r11,r11
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB37011370
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L02:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,18D54283060
       mov       r9,[r9]
       mov       r8,18D642811A0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB37011568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37011580
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rdi
       mov       edx,r14d
       mov       r8,rbx
       call      qword ptr [r11]
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 268
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.PersonProperCollection.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.CopyToList(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 82
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,2A15B793060
       mov       r8,[r8]
       mov       rdx,2A16B7911A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37011270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       r8,2A15B793060
       mov       r8,[r8]
       mov       rdx,2A16B7911A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbp,[rsi+10]
       mov       r11,[rbp+10]
       test      r11,r11
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB370114D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L02:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,2A15B793060
       mov       r9,[r9]
       mov       r8,2A16B7911A0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB370116D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB370116E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rdi
       mov       edx,r14d
       mov       r8,rbx
       call      qword ptr [r11]
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 268
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.PersonProperCollection.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.CopyToList(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 82
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,2934B4E3060
       mov       r8,[r8]
       mov       rdx,2937B4E19D8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF10E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       r8,2934B4E3060
       mov       r8,[r8]
       mov       rdx,2937B4E19D8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbp,[rsi+10]
       mov       r11,[rbp+10]
       test      r11,r11
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1350
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L02:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,2934B4E3060
       mov       r9,[r9]
       mov       r8,2937B4E19D8
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1548
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1560
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rdi
       mov       edx,r14d
       mov       r8,rbx
       call      qword ptr [r11]
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 268
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.PersonProperCollection.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.CopyToList(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 82
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,17BAA9D3060
       mov       r8,[r8]
       mov       rdx,17BAA9D35F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF14F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       r8,17BAA9D3060
       mov       r8,[r8]
       mov       rdx,17BAA9D35F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbp,[rsi+10]
       mov       r11,[rbp+10]
       test      r11,r11
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1760
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L02:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,17BAA9D3060
       mov       r9,[r9]
       mov       r8,17BAA9D35F0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rdi
       mov       edx,r14d
       mov       r8,rbx
       call      qword ptr [r11]
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 268
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.PersonProperCollection.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.CopyToList(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 82
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1DBECF63060
       mov       r8,[r8]
       mov       rdx,1DC1CF611A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB370014F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       r8,1DBECF63060
       mov       r8,[r8]
       mov       rdx,1DC1CF611A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbp,[rsi+10]
       mov       r11,[rbp+10]
       test      r11,r11
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB37001760
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L02:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1DBECF63060
       mov       r9,[r9]
       mov       r8,1DC1CF611A0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB37001958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37001970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rdi
       mov       edx,r14d
       mov       r8,rbx
       call      qword ptr [r11]
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 268
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.PersonProperCollection.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.CopyToList(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 82
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1A4300E3060
       mov       r8,[r8]
       mov       rdx,1A4500F0418
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF14F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       r8,1A4300E3060
       mov       r8,[r8]
       mov       rdx,1A4500F0418
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbp,[rsi+10]
       mov       r11,[rbp+10]
       test      r11,r11
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1760
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L02:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1A4300E3060
       mov       r9,[r9]
       mov       r8,1A4500F0418
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rdi
       mov       edx,r14d
       mov       r8,rbx
       call      qword ptr [r11]
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 268
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.PersonProperCollection.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.CopyToList(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 82
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,25DF0DF1048
       mov       r8,[r8]
       mov       rdx,25DE0DF39F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37011318
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       r8,25DF0DF1048
       mov       r8,[r8]
       mov       rdx,25DE0DF39F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbp,[rsi+10]
       mov       r11,[rbp+10]
       test      r11,r11
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB37011580
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L02:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,25DF0DF1048
       mov       r9,[r9]
       mov       r8,25DE0DF39F0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB37011778
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37011790
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rdi
       mov       edx,r14d
       mov       r8,rbx
       call      qword ptr [r11]
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 268
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualArray()
; 			var result = base.PersonProperArrayFull.AreEqual(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M01_L07
M01_L02:
       cmp       qword ptr [rbp+18],0
       jne       short M01_L03
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L04
M01_L03:
       xor       edx,edx
       mov       [rbp+0FFD0],rdx
       mov       rdx,[rbp+18]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFD0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rdx,[rbp+0FFD0]
       mov       [rbp+0FFC8],rdx
M01_L04:
       mov       rdx,[rbp+0FFC8]
       mov       [rbp+0FFF0],rdx
       cmp       qword ptr [rbp+20],0
       jne       short M01_L05
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFB8],rdx
       jmp       short M01_L06
M01_L05:
       xor       edx,edx
       mov       [rbp+0FFC0],rdx
       mov       rdx,[rbp+20]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFC0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp+0FFC0]
       mov       [rbp+0FFB8],rcx
M01_L06:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFE8],rcx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       mov       [rbp+0FFB4],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       cmp       eax,[rbp+0FFB4]
       sete      cl
       movzx     ecx,cl
       mov       [rbp+0FFB0],ecx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       mov       [rbp+0FFAC],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       cmp       eax,[rbp+0FFAC]
       sete      al
       movzx     eax,al
       and       eax,[rbp+0FFB0]
       test      eax,eax
       jne       short M01_L08
M01_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L08:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFDC],ecx
       jmp       short M01_L10
M01_L09:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFDC]
       cmp       edx,[rcx+8]
       jae       short M01_L11
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+0FFA0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFDC]
       cmp       eax,[rdx+8]
       jae       short M01_L11
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFA0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFDC]
       inc       eax
       mov       [rbp+0FFDC],eax
M01_L10:
       mov       ecx,[rbp+0FFDC]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L09
       mov       eax,[rbp+0FFFC]
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 465
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualArray()
; 			var result = base.PersonProperArrayFull.AreEqual(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M01_L07
M01_L02:
       cmp       qword ptr [rbp+18],0
       jne       short M01_L03
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L04
M01_L03:
       xor       edx,edx
       mov       [rbp+0FFD0],rdx
       mov       rdx,[rbp+18]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFD0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rdx,[rbp+0FFD0]
       mov       [rbp+0FFC8],rdx
M01_L04:
       mov       rdx,[rbp+0FFC8]
       mov       [rbp+0FFF0],rdx
       cmp       qword ptr [rbp+20],0
       jne       short M01_L05
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFB8],rdx
       jmp       short M01_L06
M01_L05:
       xor       edx,edx
       mov       [rbp+0FFC0],rdx
       mov       rdx,[rbp+20]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFC0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp+0FFC0]
       mov       [rbp+0FFB8],rcx
M01_L06:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFE8],rcx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       mov       [rbp+0FFB4],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       cmp       eax,[rbp+0FFB4]
       sete      cl
       movzx     ecx,cl
       mov       [rbp+0FFB0],ecx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       mov       [rbp+0FFAC],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       cmp       eax,[rbp+0FFAC]
       sete      al
       movzx     eax,al
       and       eax,[rbp+0FFB0]
       test      eax,eax
       jne       short M01_L08
M01_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L08:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFDC],ecx
       jmp       short M01_L10
M01_L09:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFDC]
       cmp       edx,[rcx+8]
       jae       short M01_L11
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+0FFA0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFDC]
       cmp       eax,[rdx+8]
       jae       short M01_L11
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFA0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFDC]
       inc       eax
       mov       [rbp+0FFDC],eax
M01_L10:
       mov       ecx,[rbp+0FFDC]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L09
       mov       eax,[rbp+0FFFC]
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 465
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualArray()
; 			var result = base.PersonProperArrayFull.AreEqual(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M01_L07
M01_L02:
       cmp       qword ptr [rbp+18],0
       jne       short M01_L03
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L04
M01_L03:
       xor       edx,edx
       mov       [rbp+0FFD0],rdx
       mov       rdx,[rbp+18]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFD0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rdx,[rbp+0FFD0]
       mov       [rbp+0FFC8],rdx
M01_L04:
       mov       rdx,[rbp+0FFC8]
       mov       [rbp+0FFF0],rdx
       cmp       qword ptr [rbp+20],0
       jne       short M01_L05
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFB8],rdx
       jmp       short M01_L06
M01_L05:
       xor       edx,edx
       mov       [rbp+0FFC0],rdx
       mov       rdx,[rbp+20]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFC0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp+0FFC0]
       mov       [rbp+0FFB8],rcx
M01_L06:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFE8],rcx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       mov       [rbp+0FFB4],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       cmp       eax,[rbp+0FFB4]
       sete      cl
       movzx     ecx,cl
       mov       [rbp+0FFB0],ecx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       mov       [rbp+0FFAC],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       cmp       eax,[rbp+0FFAC]
       sete      al
       movzx     eax,al
       and       eax,[rbp+0FFB0]
       test      eax,eax
       jne       short M01_L08
M01_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L08:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFDC],ecx
       jmp       short M01_L10
M01_L09:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFDC]
       cmp       edx,[rcx+8]
       jae       short M01_L11
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+0FFA0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFDC]
       cmp       eax,[rdx+8]
       jae       short M01_L11
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFA0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFDC]
       inc       eax
       mov       [rbp+0FFDC],eax
M01_L10:
       mov       ecx,[rbp+0FFDC]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L09
       mov       eax,[rbp+0FFFC]
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 465
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualArray()
; 			var result = base.PersonProperArrayFull.AreEqual(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M01_L07
M01_L02:
       cmp       qword ptr [rbp+18],0
       jne       short M01_L03
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L04
M01_L03:
       xor       edx,edx
       mov       [rbp+0FFD0],rdx
       mov       rdx,[rbp+18]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFD0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rdx,[rbp+0FFD0]
       mov       [rbp+0FFC8],rdx
M01_L04:
       mov       rdx,[rbp+0FFC8]
       mov       [rbp+0FFF0],rdx
       cmp       qword ptr [rbp+20],0
       jne       short M01_L05
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFB8],rdx
       jmp       short M01_L06
M01_L05:
       xor       edx,edx
       mov       [rbp+0FFC0],rdx
       mov       rdx,[rbp+20]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFC0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp+0FFC0]
       mov       [rbp+0FFB8],rcx
M01_L06:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFE8],rcx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       mov       [rbp+0FFB4],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       cmp       eax,[rbp+0FFB4]
       sete      cl
       movzx     ecx,cl
       mov       [rbp+0FFB0],ecx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       mov       [rbp+0FFAC],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       cmp       eax,[rbp+0FFAC]
       sete      al
       movzx     eax,al
       and       eax,[rbp+0FFB0]
       test      eax,eax
       jne       short M01_L08
M01_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L08:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFDC],ecx
       jmp       short M01_L10
M01_L09:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFDC]
       cmp       edx,[rcx+8]
       jae       short M01_L11
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+0FFA0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFDC]
       cmp       eax,[rdx+8]
       jae       short M01_L11
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFA0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFDC]
       inc       eax
       mov       [rbp+0FFDC],eax
M01_L10:
       mov       ecx,[rbp+0FFDC]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L09
       mov       eax,[rbp+0FFFC]
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 465
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualArray()
; 			var result = base.PersonProperArrayFull.AreEqual(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M01_L07
M01_L02:
       cmp       qword ptr [rbp+18],0
       jne       short M01_L03
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L04
M01_L03:
       xor       edx,edx
       mov       [rbp+0FFD0],rdx
       mov       rdx,[rbp+18]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFD0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rdx,[rbp+0FFD0]
       mov       [rbp+0FFC8],rdx
M01_L04:
       mov       rdx,[rbp+0FFC8]
       mov       [rbp+0FFF0],rdx
       cmp       qword ptr [rbp+20],0
       jne       short M01_L05
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFB8],rdx
       jmp       short M01_L06
M01_L05:
       xor       edx,edx
       mov       [rbp+0FFC0],rdx
       mov       rdx,[rbp+20]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFC0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp+0FFC0]
       mov       [rbp+0FFB8],rcx
M01_L06:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFE8],rcx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       mov       [rbp+0FFB4],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       cmp       eax,[rbp+0FFB4]
       sete      cl
       movzx     ecx,cl
       mov       [rbp+0FFB0],ecx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       mov       [rbp+0FFAC],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       cmp       eax,[rbp+0FFAC]
       sete      al
       movzx     eax,al
       and       eax,[rbp+0FFB0]
       test      eax,eax
       jne       short M01_L08
M01_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L08:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFDC],ecx
       jmp       short M01_L10
M01_L09:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFDC]
       cmp       edx,[rcx+8]
       jae       short M01_L11
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+0FFA0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFDC]
       cmp       eax,[rdx+8]
       jae       short M01_L11
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFA0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFDC]
       inc       eax
       mov       [rbp+0FFDC],eax
M01_L10:
       mov       ecx,[rbp+0FFDC]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L09
       mov       eax,[rbp+0FFFC]
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 465
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualArray()
; 			var result = base.PersonProperArrayFull.AreEqual(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M01_L07
M01_L02:
       cmp       qword ptr [rbp+18],0
       jne       short M01_L03
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L04
M01_L03:
       xor       edx,edx
       mov       [rbp+0FFD0],rdx
       mov       rdx,[rbp+18]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFD0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rdx,[rbp+0FFD0]
       mov       [rbp+0FFC8],rdx
M01_L04:
       mov       rdx,[rbp+0FFC8]
       mov       [rbp+0FFF0],rdx
       cmp       qword ptr [rbp+20],0
       jne       short M01_L05
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFB8],rdx
       jmp       short M01_L06
M01_L05:
       xor       edx,edx
       mov       [rbp+0FFC0],rdx
       mov       rdx,[rbp+20]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFC0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp+0FFC0]
       mov       [rbp+0FFB8],rcx
M01_L06:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFE8],rcx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       mov       [rbp+0FFB4],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       cmp       eax,[rbp+0FFB4]
       sete      cl
       movzx     ecx,cl
       mov       [rbp+0FFB0],ecx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       mov       [rbp+0FFAC],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       cmp       eax,[rbp+0FFAC]
       sete      al
       movzx     eax,al
       and       eax,[rbp+0FFB0]
       test      eax,eax
       jne       short M01_L08
M01_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L08:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFDC],ecx
       jmp       short M01_L10
M01_L09:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFDC]
       cmp       edx,[rcx+8]
       jae       short M01_L11
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+0FFA0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFDC]
       cmp       eax,[rdx+8]
       jae       short M01_L11
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFA0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFDC]
       inc       eax
       mov       [rbp+0FFDC],eax
M01_L10:
       mov       ecx,[rbp+0FFDC]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L09
       mov       eax,[rbp+0FFFC]
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 465
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualArray()
; 			var result = base.PersonProperArrayFull.AreEqual(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M01_L07
M01_L02:
       cmp       qword ptr [rbp+18],0
       jne       short M01_L03
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L04
M01_L03:
       xor       edx,edx
       mov       [rbp+0FFD0],rdx
       mov       rdx,[rbp+18]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFD0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rdx,[rbp+0FFD0]
       mov       [rbp+0FFC8],rdx
M01_L04:
       mov       rdx,[rbp+0FFC8]
       mov       [rbp+0FFF0],rdx
       cmp       qword ptr [rbp+20],0
       jne       short M01_L05
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFB8],rdx
       jmp       short M01_L06
M01_L05:
       xor       edx,edx
       mov       [rbp+0FFC0],rdx
       mov       rdx,[rbp+20]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFC0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp+0FFC0]
       mov       [rbp+0FFB8],rcx
M01_L06:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFE8],rcx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       mov       [rbp+0FFB4],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       cmp       eax,[rbp+0FFB4]
       sete      cl
       movzx     ecx,cl
       mov       [rbp+0FFB0],ecx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       mov       [rbp+0FFAC],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       cmp       eax,[rbp+0FFAC]
       sete      al
       movzx     eax,al
       and       eax,[rbp+0FFB0]
       test      eax,eax
       jne       short M01_L08
M01_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L08:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFDC],ecx
       jmp       short M01_L10
M01_L09:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFDC]
       cmp       edx,[rcx+8]
       jae       short M01_L11
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+0FFA0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFDC]
       cmp       eax,[rdx+8]
       jae       short M01_L11
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFA0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFDC]
       inc       eax
       mov       [rbp+0FFDC],eax
M01_L10:
       mov       ecx,[rbp+0FFDC]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L09
       mov       eax,[rbp+0FFFC]
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 465
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualArray()
; 			var result = base.PersonProperArrayFull.AreEqual(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M01_L07
M01_L02:
       cmp       qword ptr [rbp+18],0
       jne       short M01_L03
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L04
M01_L03:
       xor       edx,edx
       mov       [rbp+0FFD0],rdx
       mov       rdx,[rbp+18]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFD0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rdx,[rbp+0FFD0]
       mov       [rbp+0FFC8],rdx
M01_L04:
       mov       rdx,[rbp+0FFC8]
       mov       [rbp+0FFF0],rdx
       cmp       qword ptr [rbp+20],0
       jne       short M01_L05
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFB8],rdx
       jmp       short M01_L06
M01_L05:
       xor       edx,edx
       mov       [rbp+0FFC0],rdx
       mov       rdx,[rbp+20]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFC0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp+0FFC0]
       mov       [rbp+0FFB8],rcx
M01_L06:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFE8],rcx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       mov       [rbp+0FFB4],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       cmp       eax,[rbp+0FFB4]
       sete      cl
       movzx     ecx,cl
       mov       [rbp+0FFB0],ecx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       mov       [rbp+0FFAC],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       cmp       eax,[rbp+0FFAC]
       sete      al
       movzx     eax,al
       and       eax,[rbp+0FFB0]
       test      eax,eax
       jne       short M01_L08
M01_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L08:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFDC],ecx
       jmp       short M01_L10
M01_L09:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFDC]
       cmp       edx,[rcx+8]
       jae       short M01_L11
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+0FFA0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFDC]
       cmp       eax,[rdx+8]
       jae       short M01_L11
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFA0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFDC]
       inc       eax
       mov       [rbp+0FFDC],eax
M01_L10:
       mov       ecx,[rbp+0FFDC]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L09
       mov       eax,[rbp+0FFFC]
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 465
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualArray()
; 			var result = base.PersonProperArrayFull.AreEqual(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M01_L07
M01_L02:
       cmp       qword ptr [rbp+18],0
       jne       short M01_L03
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L04
M01_L03:
       xor       edx,edx
       mov       [rbp+0FFD0],rdx
       mov       rdx,[rbp+18]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFD0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rdx,[rbp+0FFD0]
       mov       [rbp+0FFC8],rdx
M01_L04:
       mov       rdx,[rbp+0FFC8]
       mov       [rbp+0FFF0],rdx
       cmp       qword ptr [rbp+20],0
       jne       short M01_L05
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFB8],rdx
       jmp       short M01_L06
M01_L05:
       xor       edx,edx
       mov       [rbp+0FFC0],rdx
       mov       rdx,[rbp+20]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFC0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp+0FFC0]
       mov       [rbp+0FFB8],rcx
M01_L06:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFE8],rcx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       mov       [rbp+0FFB4],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       cmp       eax,[rbp+0FFB4]
       sete      cl
       movzx     ecx,cl
       mov       [rbp+0FFB0],ecx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       mov       [rbp+0FFAC],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       cmp       eax,[rbp+0FFAC]
       sete      al
       movzx     eax,al
       and       eax,[rbp+0FFB0]
       test      eax,eax
       jne       short M01_L08
M01_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L08:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFDC],ecx
       jmp       short M01_L10
M01_L09:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFDC]
       cmp       edx,[rcx+8]
       jae       short M01_L11
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+0FFA0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFDC]
       cmp       eax,[rdx+8]
       jae       short M01_L11
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFA0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFDC]
       inc       eax
       mov       [rbp+0FFDC],eax
M01_L10:
       mov       ecx,[rbp+0FFDC]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L09
       mov       eax,[rbp+0FFFC]
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 465
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualList()
; 			var result = base.PersonProperCollection.AreEqual(base.PersonProperListHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       r8,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AreEqual(System.Collections.Generic.IList`1<!!0>, System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.Collections.Generic.IList`1<System.__Canon>)
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF88],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFF0],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFF0],rax
       mov       [rbp+0FFF8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M01_L07
M01_L02:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFE0],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FE0C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFE0],rax
M01_L04:
       mov       rcx,[rbp+0FFE0]
       mov       [rbp+0FFD8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFD8]
       mov       rax,[rbp+0FFD8]
       call      qword ptr [rax]
       mov       [rbp+0FFD4],eax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFC8],rcx
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FE0C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFC8],rax
M01_L06:
       mov       rcx,[rbp+0FFC8]
       mov       [rbp+0FFC0],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp+0FFC0]
       mov       rax,[rbp+0FFC0]
       call      qword ptr [rax]
       cmp       eax,[rbp+0FFD4]
       je        short M01_L08
M01_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L08:
       mov       dword ptr [rbp+0FFF4],1
       xor       ecx,ecx
       mov       [rbp+0FFF0],ecx
       jmp       near ptr M01_L14
M01_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp+0FFA8],rcx
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FE0DE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFA8],rax
M01_L11:
       mov       rcx,[rbp+0FFA8]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFA0]
       mov       edx,[rbp+0FFF0]
       mov       rax,[rbp+0FFA0]
       call      qword ptr [rax]
       mov       [rbp+0FFE8],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp+0FF98],rcx
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FE0DE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FF98],rax
M01_L13:
       mov       rcx,[rbp+0FF98]
       mov       [rbp+0FF90],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp+0FF90]
       mov       edx,[rbp+0FFF0]
       mov       rax,[rbp+0FF90]
       call      qword ptr [rax]
       mov       [rbp+0FF88],rax
       mov       rdx,[rbp+0FF88]
       mov       rcx,[rbp+0FFE8]
       mov       rax,[rbp+0FFE8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFF4]
       movzx     eax,al
       mov       [rbp+0FFF4],eax
       mov       eax,[rbp+0FFF0]
       inc       eax
       mov       [rbp+0FFF0],eax
M01_L14:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFB8],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FE0C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFB8],rax
M01_L16:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFB0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFB0]
       mov       rax,[rbp+0FFB0]
       call      qword ptr [rax]
       cmp       eax,[rbp+0FFF0]
       jg        near ptr M01_L09
       mov       eax,[rbp+0FFF4]
       lea       rsp,[rbp]
       pop       rbp
       ret
; Total bytes of code 648
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualList()
; 			var result = base.PersonProperCollection.AreEqual(base.PersonProperListHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       r8,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AreEqual(System.Collections.Generic.IList`1<!!0>, System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.Collections.Generic.IList`1<System.__Canon>)
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF88],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFF0],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFF0],rax
       mov       [rbp+0FFF8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M01_L07
M01_L02:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFE0],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF0CA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFE0],rax
M01_L04:
       mov       rcx,[rbp+0FFE0]
       mov       [rbp+0FFD8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFD8]
       mov       rax,[rbp+0FFD8]
       call      qword ptr [rax]
       mov       [rbp+0FFD4],eax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFC8],rcx
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF0CA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFC8],rax
M01_L06:
       mov       rcx,[rbp+0FFC8]
       mov       [rbp+0FFC0],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp+0FFC0]
       mov       rax,[rbp+0FFC0]
       call      qword ptr [rax]
       cmp       eax,[rbp+0FFD4]
       je        short M01_L08
M01_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L08:
       mov       dword ptr [rbp+0FFF4],1
       xor       ecx,ecx
       mov       [rbp+0FFF0],ecx
       jmp       near ptr M01_L14
M01_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp+0FFA8],rcx
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF0E08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFA8],rax
M01_L11:
       mov       rcx,[rbp+0FFA8]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFA0]
       mov       edx,[rbp+0FFF0]
       mov       rax,[rbp+0FFA0]
       call      qword ptr [rax]
       mov       [rbp+0FFE8],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp+0FF98],rcx
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF0E08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FF98],rax
M01_L13:
       mov       rcx,[rbp+0FF98]
       mov       [rbp+0FF90],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp+0FF90]
       mov       edx,[rbp+0FFF0]
       mov       rax,[rbp+0FF90]
       call      qword ptr [rax]
       mov       [rbp+0FF88],rax
       mov       rdx,[rbp+0FF88]
       mov       rcx,[rbp+0FFE8]
       mov       rax,[rbp+0FFE8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFF4]
       movzx     eax,al
       mov       [rbp+0FFF4],eax
       mov       eax,[rbp+0FFF0]
       inc       eax
       mov       [rbp+0FFF0],eax
M01_L14:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFB8],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF0CA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFB8],rax
M01_L16:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFB0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFB0]
       mov       rax,[rbp+0FFB0]
       call      qword ptr [rax]
       cmp       eax,[rbp+0FFF0]
       jg        near ptr M01_L09
       mov       eax,[rbp+0FFF4]
       lea       rsp,[rbp]
       pop       rbp
       ret
; Total bytes of code 648
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualList()
; 			var result = base.PersonProperCollection.AreEqual(base.PersonProperListHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       r8,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AreEqual(System.Collections.Generic.IList`1<!!0>, System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.Collections.Generic.IList`1<System.__Canon>)
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF88],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFF0],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFF0],rax
       mov       [rbp+0FFF8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M01_L07
M01_L02:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFE0],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FE0E08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFE0],rax
M01_L04:
       mov       rcx,[rbp+0FFE0]
       mov       [rbp+0FFD8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFD8]
       mov       rax,[rbp+0FFD8]
       call      qword ptr [rax]
       mov       [rbp+0FFD4],eax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFC8],rcx
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FE0E08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFC8],rax
M01_L06:
       mov       rcx,[rbp+0FFC8]
       mov       [rbp+0FFC0],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp+0FFC0]
       mov       rax,[rbp+0FFC0]
       call      qword ptr [rax]
       cmp       eax,[rbp+0FFD4]
       je        short M01_L08
M01_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L08:
       mov       dword ptr [rbp+0FFF4],1
       xor       ecx,ecx
       mov       [rbp+0FFF0],ecx
       jmp       near ptr M01_L14
M01_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp+0FFA8],rcx
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FE0F70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFA8],rax
M01_L11:
       mov       rcx,[rbp+0FFA8]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFA0]
       mov       edx,[rbp+0FFF0]
       mov       rax,[rbp+0FFA0]
       call      qword ptr [rax]
       mov       [rbp+0FFE8],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp+0FF98],rcx
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FE0F70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FF98],rax
M01_L13:
       mov       rcx,[rbp+0FF98]
       mov       [rbp+0FF90],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp+0FF90]
       mov       edx,[rbp+0FFF0]
       mov       rax,[rbp+0FF90]
       call      qword ptr [rax]
       mov       [rbp+0FF88],rax
       mov       rdx,[rbp+0FF88]
       mov       rcx,[rbp+0FFE8]
       mov       rax,[rbp+0FFE8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFF4]
       movzx     eax,al
       mov       [rbp+0FFF4],eax
       mov       eax,[rbp+0FFF0]
       inc       eax
       mov       [rbp+0FFF0],eax
M01_L14:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFB8],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FE0E08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFB8],rax
M01_L16:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFB0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFB0]
       mov       rax,[rbp+0FFB0]
       call      qword ptr [rax]
       cmp       eax,[rbp+0FFF0]
       jg        near ptr M01_L09
       mov       eax,[rbp+0FFF4]
       lea       rsp,[rbp]
       pop       rbp
       ret
; Total bytes of code 648
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualList()
; 			var result = base.PersonProperCollection.AreEqual(base.PersonProperListHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       r8,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AreEqual(System.Collections.Generic.IList`1<!!0>, System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.Collections.Generic.IList`1<System.__Canon>)
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF88],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFF0],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFF0],rax
       mov       [rbp+0FFF8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M01_L07
M01_L02:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFE0],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF0CA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFE0],rax
M01_L04:
       mov       rcx,[rbp+0FFE0]
       mov       [rbp+0FFD8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFD8]
       mov       rax,[rbp+0FFD8]
       call      qword ptr [rax]
       mov       [rbp+0FFD4],eax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFC8],rcx
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF0CA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFC8],rax
M01_L06:
       mov       rcx,[rbp+0FFC8]
       mov       [rbp+0FFC0],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp+0FFC0]
       mov       rax,[rbp+0FFC0]
       call      qword ptr [rax]
       cmp       eax,[rbp+0FFD4]
       je        short M01_L08
M01_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L08:
       mov       dword ptr [rbp+0FFF4],1
       xor       ecx,ecx
       mov       [rbp+0FFF0],ecx
       jmp       near ptr M01_L14
M01_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp+0FFA8],rcx
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF0E08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFA8],rax
M01_L11:
       mov       rcx,[rbp+0FFA8]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFA0]
       mov       edx,[rbp+0FFF0]
       mov       rax,[rbp+0FFA0]
       call      qword ptr [rax]
       mov       [rbp+0FFE8],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp+0FF98],rcx
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF0E08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FF98],rax
M01_L13:
       mov       rcx,[rbp+0FF98]
       mov       [rbp+0FF90],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp+0FF90]
       mov       edx,[rbp+0FFF0]
       mov       rax,[rbp+0FF90]
       call      qword ptr [rax]
       mov       [rbp+0FF88],rax
       mov       rdx,[rbp+0FF88]
       mov       rcx,[rbp+0FFE8]
       mov       rax,[rbp+0FFE8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFF4]
       movzx     eax,al
       mov       [rbp+0FFF4],eax
       mov       eax,[rbp+0FFF0]
       inc       eax
       mov       [rbp+0FFF0],eax
M01_L14:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFB8],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF0CA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFB8],rax
M01_L16:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFB0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFB0]
       mov       rax,[rbp+0FFB0]
       call      qword ptr [rax]
       cmp       eax,[rbp+0FFF0]
       jg        near ptr M01_L09
       mov       eax,[rbp+0FFF4]
       lea       rsp,[rbp]
       pop       rbp
       ret
; Total bytes of code 648
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualList()
; 			var result = base.PersonProperCollection.AreEqual(base.PersonProperListHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       r8,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AreEqual(System.Collections.Generic.IList`1<!!0>, System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.Collections.Generic.IList`1<System.__Canon>)
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF88],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFF0],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFF0],rax
       mov       [rbp+0FFF8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M01_L07
M01_L02:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFE0],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF0E08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFE0],rax
M01_L04:
       mov       rcx,[rbp+0FFE0]
       mov       [rbp+0FFD8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFD8]
       mov       rax,[rbp+0FFD8]
       call      qword ptr [rax]
       mov       [rbp+0FFD4],eax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFC8],rcx
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF0E08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFC8],rax
M01_L06:
       mov       rcx,[rbp+0FFC8]
       mov       [rbp+0FFC0],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp+0FFC0]
       mov       rax,[rbp+0FFC0]
       call      qword ptr [rax]
       cmp       eax,[rbp+0FFD4]
       je        short M01_L08
M01_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L08:
       mov       dword ptr [rbp+0FFF4],1
       xor       ecx,ecx
       mov       [rbp+0FFF0],ecx
       jmp       near ptr M01_L14
M01_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp+0FFA8],rcx
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF0F70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFA8],rax
M01_L11:
       mov       rcx,[rbp+0FFA8]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFA0]
       mov       edx,[rbp+0FFF0]
       mov       rax,[rbp+0FFA0]
       call      qword ptr [rax]
       mov       [rbp+0FFE8],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp+0FF98],rcx
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF0F70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FF98],rax
M01_L13:
       mov       rcx,[rbp+0FF98]
       mov       [rbp+0FF90],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp+0FF90]
       mov       edx,[rbp+0FFF0]
       mov       rax,[rbp+0FF90]
       call      qword ptr [rax]
       mov       [rbp+0FF88],rax
       mov       rdx,[rbp+0FF88]
       mov       rcx,[rbp+0FFE8]
       mov       rax,[rbp+0FFE8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFF4]
       movzx     eax,al
       mov       [rbp+0FFF4],eax
       mov       eax,[rbp+0FFF0]
       inc       eax
       mov       [rbp+0FFF0],eax
M01_L14:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFB8],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF0E08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFB8],rax
M01_L16:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFB0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFB0]
       mov       rax,[rbp+0FFB0]
       call      qword ptr [rax]
       cmp       eax,[rbp+0FFF0]
       jg        near ptr M01_L09
       mov       eax,[rbp+0FFF4]
       lea       rsp,[rbp]
       pop       rbp
       ret
; Total bytes of code 648
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualList()
; 			var result = base.PersonProperCollection.AreEqual(base.PersonProperListHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       r8,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AreEqual(System.Collections.Generic.IList`1<!!0>, System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.Collections.Generic.IList`1<System.__Canon>)
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF88],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFF0],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFF0],rax
       mov       [rbp+0FFF8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M01_L07
M01_L02:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFE0],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF0EB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFE0],rax
M01_L04:
       mov       rcx,[rbp+0FFE0]
       mov       [rbp+0FFD8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFD8]
       mov       rax,[rbp+0FFD8]
       call      qword ptr [rax]
       mov       [rbp+0FFD4],eax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFC8],rcx
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF0EB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFC8],rax
M01_L06:
       mov       rcx,[rbp+0FFC8]
       mov       [rbp+0FFC0],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp+0FFC0]
       mov       rax,[rbp+0FFC0]
       call      qword ptr [rax]
       cmp       eax,[rbp+0FFD4]
       je        short M01_L08
M01_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L08:
       mov       dword ptr [rbp+0FFF4],1
       xor       ecx,ecx
       mov       [rbp+0FFF0],ecx
       jmp       near ptr M01_L14
M01_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp+0FFA8],rcx
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF1018
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFA8],rax
M01_L11:
       mov       rcx,[rbp+0FFA8]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFA0]
       mov       edx,[rbp+0FFF0]
       mov       rax,[rbp+0FFA0]
       call      qword ptr [rax]
       mov       [rbp+0FFE8],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp+0FF98],rcx
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF1018
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FF98],rax
M01_L13:
       mov       rcx,[rbp+0FF98]
       mov       [rbp+0FF90],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp+0FF90]
       mov       edx,[rbp+0FFF0]
       mov       rax,[rbp+0FF90]
       call      qword ptr [rax]
       mov       [rbp+0FF88],rax
       mov       rdx,[rbp+0FF88]
       mov       rcx,[rbp+0FFE8]
       mov       rax,[rbp+0FFE8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFF4]
       movzx     eax,al
       mov       [rbp+0FFF4],eax
       mov       eax,[rbp+0FFF0]
       inc       eax
       mov       [rbp+0FFF0],eax
M01_L14:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFB8],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF0EB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFB8],rax
M01_L16:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFB0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFB0]
       mov       rax,[rbp+0FFB0]
       call      qword ptr [rax]
       cmp       eax,[rbp+0FFF0]
       jg        near ptr M01_L09
       mov       eax,[rbp+0FFF4]
       lea       rsp,[rbp]
       pop       rbp
       ret
; Total bytes of code 648
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualList()
; 			var result = base.PersonProperCollection.AreEqual(base.PersonProperListHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       r8,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AreEqual(System.Collections.Generic.IList`1<!!0>, System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.Collections.Generic.IList`1<System.__Canon>)
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF88],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFF0],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFF0],rax
       mov       [rbp+0FFF8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M01_L07
M01_L02:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFE0],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB37010EB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFE0],rax
M01_L04:
       mov       rcx,[rbp+0FFE0]
       mov       [rbp+0FFD8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFD8]
       mov       rax,[rbp+0FFD8]
       call      qword ptr [rax]
       mov       [rbp+0FFD4],eax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFC8],rcx
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB37010EB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFC8],rax
M01_L06:
       mov       rcx,[rbp+0FFC8]
       mov       [rbp+0FFC0],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp+0FFC0]
       mov       rax,[rbp+0FFC0]
       call      qword ptr [rax]
       cmp       eax,[rbp+0FFD4]
       je        short M01_L08
M01_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L08:
       mov       dword ptr [rbp+0FFF4],1
       xor       ecx,ecx
       mov       [rbp+0FFF0],ecx
       jmp       near ptr M01_L14
M01_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp+0FFA8],rcx
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB37011018
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFA8],rax
M01_L11:
       mov       rcx,[rbp+0FFA8]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFA0]
       mov       edx,[rbp+0FFF0]
       mov       rax,[rbp+0FFA0]
       call      qword ptr [rax]
       mov       [rbp+0FFE8],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp+0FF98],rcx
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB37011018
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FF98],rax
M01_L13:
       mov       rcx,[rbp+0FF98]
       mov       [rbp+0FF90],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp+0FF90]
       mov       edx,[rbp+0FFF0]
       mov       rax,[rbp+0FF90]
       call      qword ptr [rax]
       mov       [rbp+0FF88],rax
       mov       rdx,[rbp+0FF88]
       mov       rcx,[rbp+0FFE8]
       mov       rax,[rbp+0FFE8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFF4]
       movzx     eax,al
       mov       [rbp+0FFF4],eax
       mov       eax,[rbp+0FFF0]
       inc       eax
       mov       [rbp+0FFF0],eax
M01_L14:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFB8],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB37010EB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFB8],rax
M01_L16:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFB0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFB0]
       mov       rax,[rbp+0FFB0]
       call      qword ptr [rax]
       cmp       eax,[rbp+0FFF0]
       jg        near ptr M01_L09
       mov       eax,[rbp+0FFF4]
       lea       rsp,[rbp]
       pop       rbp
       ret
; Total bytes of code 648
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualList()
; 			var result = base.PersonProperCollection.AreEqual(base.PersonProperListHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       r8,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AreEqual(System.Collections.Generic.IList`1<!!0>, System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.Collections.Generic.IList`1<System.__Canon>)
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF88],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFF0],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFF0],rax
       mov       [rbp+0FFF8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M01_L07
M01_L02:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFE0],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF1090
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFE0],rax
M01_L04:
       mov       rcx,[rbp+0FFE0]
       mov       [rbp+0FFD8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFD8]
       mov       rax,[rbp+0FFD8]
       call      qword ptr [rax]
       mov       [rbp+0FFD4],eax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFC8],rcx
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF1090
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFC8],rax
M01_L06:
       mov       rcx,[rbp+0FFC8]
       mov       [rbp+0FFC0],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp+0FFC0]
       mov       rax,[rbp+0FFC0]
       call      qword ptr [rax]
       cmp       eax,[rbp+0FFD4]
       je        short M01_L08
M01_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L08:
       mov       dword ptr [rbp+0FFF4],1
       xor       ecx,ecx
       mov       [rbp+0FFF0],ecx
       jmp       near ptr M01_L14
M01_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp+0FFA8],rcx
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF11F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFA8],rax
M01_L11:
       mov       rcx,[rbp+0FFA8]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFA0]
       mov       edx,[rbp+0FFF0]
       mov       rax,[rbp+0FFA0]
       call      qword ptr [rax]
       mov       [rbp+0FFE8],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp+0FF98],rcx
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF11F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FF98],rax
M01_L13:
       mov       rcx,[rbp+0FF98]
       mov       [rbp+0FF90],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp+0FF90]
       mov       edx,[rbp+0FFF0]
       mov       rax,[rbp+0FF90]
       call      qword ptr [rax]
       mov       [rbp+0FF88],rax
       mov       rdx,[rbp+0FF88]
       mov       rcx,[rbp+0FFE8]
       mov       rax,[rbp+0FFE8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFF4]
       movzx     eax,al
       mov       [rbp+0FFF4],eax
       mov       eax,[rbp+0FFF0]
       inc       eax
       mov       [rbp+0FFF0],eax
M01_L14:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFB8],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF1090
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFB8],rax
M01_L16:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFB0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFB0]
       mov       rax,[rbp+0FFB0]
       call      qword ptr [rax]
       cmp       eax,[rbp+0FFF0]
       jg        near ptr M01_L09
       mov       eax,[rbp+0FFF4]
       lea       rsp,[rbp]
       pop       rbp
       ret
; Total bytes of code 648
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualList()
; 			var result = base.PersonProperCollection.AreEqual(base.PersonProperListHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       r8,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AreEqual(System.Collections.Generic.IList`1<!!0>, System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.Collections.Generic.IList`1<System.__Canon>)
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF88],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFF0],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFF0],rax
       mov       [rbp+0FFF8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M01_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M01_L07
M01_L02:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFE0],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB37000E08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFE0],rax
M01_L04:
       mov       rcx,[rbp+0FFE0]
       mov       [rbp+0FFD8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFD8]
       mov       rax,[rbp+0FFD8]
       call      qword ptr [rax]
       mov       [rbp+0FFD4],eax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFC8],rcx
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB37000E08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFC8],rax
M01_L06:
       mov       rcx,[rbp+0FFC8]
       mov       [rbp+0FFC0],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp+0FFC0]
       mov       rax,[rbp+0FFC0]
       call      qword ptr [rax]
       cmp       eax,[rbp+0FFD4]
       je        short M01_L08
M01_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M01_L08:
       mov       dword ptr [rbp+0FFF4],1
       xor       ecx,ecx
       mov       [rbp+0FFF0],ecx
       jmp       near ptr M01_L14
M01_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp+0FFA8],rcx
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB37000F70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFA8],rax
M01_L11:
       mov       rcx,[rbp+0FFA8]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFA0]
       mov       edx,[rbp+0FFF0]
       mov       rax,[rbp+0FFA0]
       call      qword ptr [rax]
       mov       [rbp+0FFE8],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp+0FF98],rcx
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB37000F70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FF98],rax
M01_L13:
       mov       rcx,[rbp+0FF98]
       mov       [rbp+0FF90],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp+0FF90]
       mov       edx,[rbp+0FFF0]
       mov       rax,[rbp+0FF90]
       call      qword ptr [rax]
       mov       [rbp+0FF88],rax
       mov       rdx,[rbp+0FF88]
       mov       rcx,[rbp+0FFE8]
       mov       rax,[rbp+0FFE8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFF4]
       movzx     eax,al
       mov       [rbp+0FFF4],eax
       mov       eax,[rbp+0FFF0]
       inc       eax
       mov       [rbp+0FFF0],eax
M01_L14:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp+0FFB8],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB37000E08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp+0FFB8],rax
M01_L16:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFB0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp+0FFB0]
       mov       rax,[rbp+0FFB0]
       call      qword ptr [rax]
       cmp       eax,[rbp+0FFF0]
       jg        near ptr M01_L09
       mov       eax,[rbp+0FFF4]
       lea       rsp,[rbp]
       pop       rbp
       ret
; Total bytes of code 648
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ClearNulls()
; 			var people = base.PersonProperCollection;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Add(null);
; 			^^^^^^^^^^^^^^^^^
; 			var result = people.ClearNulls();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       eax,[rcx+8]
       cmp       eax,edx
       jbe       short M00_L00
       lea       eax,[rdx+1]
       mov       [rdi+10],eax
       movsxd    rdx,edx
       xor       eax,eax
       mov       [rcx+rdx*8+10],rax
       jmp       short M00_L01
M00_L00:
       mov       rcx,rdi
       xor       edx,edx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L01:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 93
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,rsi
       call      qword ptr [7FFB963C7AC0]
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      qword ptr [7FFB963D10A0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 59
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M02_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1408
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M02_L09
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1408
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1960
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        short M02_L10
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__7`1[[System.__Canon, System.Private.CoreLib]].<ClearNulls>b__7_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1408
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
M02_L09:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAll(System.Predicate`1<System.__Canon>)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L10:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 298
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ClearNulls()
; 			var people = base.PersonProperCollection;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Add(null);
; 			^^^^^^^^^^^^^^^^^
; 			var result = people.ClearNulls();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       eax,[rcx+8]
       cmp       eax,edx
       jbe       short M00_L00
       lea       eax,[rdx+1]
       mov       [rdi+10],eax
       movsxd    rdx,edx
       xor       eax,eax
       mov       [rcx+rdx*8+10],rax
       jmp       short M00_L01
M00_L00:
       mov       rcx,rdi
       xor       edx,edx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L01:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 93
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,rsi
       call      qword ptr [7FFB963C7AC0]
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      qword ptr [7FFB963D10A0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 59
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M02_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1220
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M02_L09
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1220
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1778
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        short M02_L10
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__7`1[[System.__Canon, System.Private.CoreLib]].<ClearNulls>b__7_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1220
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
M02_L09:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAll(System.Predicate`1<System.__Canon>)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L10:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 298
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ClearNulls()
; 			var people = base.PersonProperCollection;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Add(null);
; 			^^^^^^^^^^^^^^^^^
; 			var result = people.ClearNulls();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       eax,[rcx+8]
       cmp       eax,edx
       jbe       short M00_L00
       lea       eax,[rdx+1]
       mov       [rdi+10],eax
       movsxd    rdx,edx
       xor       eax,eax
       mov       [rcx+rdx*8+10],rax
       jmp       short M00_L01
M00_L00:
       mov       rcx,rdi
       xor       edx,edx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L01:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 93
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,rsi
       call      qword ptr [7FFB963C7AC0]
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      qword ptr [7FFB963D10A0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 59
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M02_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB370012A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M02_L09
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB370012A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB370017F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        short M02_L10
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__7`1[[System.__Canon, System.Private.CoreLib]].<ClearNulls>b__7_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB370012A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
M02_L09:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAll(System.Predicate`1<System.__Canon>)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L10:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 298
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ClearNulls()
; 			var people = base.PersonProperCollection;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Add(null);
; 			^^^^^^^^^^^^^^^^^
; 			var result = people.ClearNulls();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       eax,[rcx+8]
       cmp       eax,edx
       jbe       short M00_L00
       lea       eax,[rdx+1]
       mov       [rdi+10],eax
       movsxd    rdx,edx
       xor       eax,eax
       mov       [rcx+rdx*8+10],rax
       jmp       short M00_L01
M00_L00:
       mov       rcx,rdi
       xor       edx,edx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L01:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 93
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,rsi
       call      qword ptr [7FFB963C7AC0]
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      qword ptr [7FFB963D10A0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 59
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M02_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1408
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M02_L09
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1408
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1960
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        short M02_L10
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__7`1[[System.__Canon, System.Private.CoreLib]].<ClearNulls>b__7_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1408
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
M02_L09:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAll(System.Predicate`1<System.__Canon>)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L10:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 298
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ClearNulls()
; 			var people = base.PersonProperCollection;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Add(null);
; 			^^^^^^^^^^^^^^^^^
; 			var result = people.ClearNulls();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       eax,[rcx+8]
       cmp       eax,edx
       jbe       short M00_L00
       lea       eax,[rdx+1]
       mov       [rdi+10],eax
       movsxd    rdx,edx
       xor       eax,eax
       mov       [rcx+rdx*8+10],rax
       jmp       short M00_L01
M00_L00:
       mov       rcx,rdi
       xor       edx,edx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L01:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 93
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,rsi
       call      qword ptr [7FFB963C7AC0]
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      qword ptr [7FFB963D10A0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 59
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M02_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB37011410
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M02_L09
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB37011410
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37011968
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        short M02_L10
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__7`1[[System.__Canon, System.Private.CoreLib]].<ClearNulls>b__7_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB37011410
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
M02_L09:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAll(System.Predicate`1<System.__Canon>)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L10:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 298
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ClearNulls()
; 			var people = base.PersonProperCollection;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Add(null);
; 			^^^^^^^^^^^^^^^^^
; 			var result = people.ClearNulls();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       eax,[rcx+8]
       cmp       eax,edx
       jbe       short M00_L00
       lea       eax,[rdx+1]
       mov       [rdi+10],eax
       movsxd    rdx,edx
       xor       eax,eax
       mov       [rcx+rdx*8+10],rax
       jmp       short M00_L01
M00_L00:
       mov       rcx,rdi
       xor       edx,edx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L01:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 93
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,rsi
       call      qword ptr [7FFB963C7AC0]
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      qword ptr [7FFB963D10A0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 59
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M02_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB36FE14B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M02_L09
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB36FE14B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1A08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        short M02_L10
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__7`1[[System.__Canon, System.Private.CoreLib]].<ClearNulls>b__7_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB36FE14B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
M02_L09:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAll(System.Predicate`1<System.__Canon>)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L10:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 298
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ClearNulls()
; 			var people = base.PersonProperCollection;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Add(null);
; 			^^^^^^^^^^^^^^^^^
; 			var result = people.ClearNulls();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       eax,[rcx+8]
       cmp       eax,edx
       jbe       short M00_L00
       lea       eax,[rdx+1]
       mov       [rdi+10],eax
       movsxd    rdx,edx
       xor       eax,eax
       mov       [rcx+rdx*8+10],rax
       jmp       short M00_L01
M00_L00:
       mov       rcx,rdi
       xor       edx,edx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L01:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 93
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,rsi
       call      qword ptr [7FFB963C7AC0]
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      qword ptr [7FFB963D10A0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 59
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M02_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1690
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M02_L09
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1690
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        short M02_L10
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__7`1[[System.__Canon, System.Private.CoreLib]].<ClearNulls>b__7_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1690
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
M02_L09:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAll(System.Predicate`1<System.__Canon>)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L10:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 298
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ClearNulls()
; 			var people = base.PersonProperCollection;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Add(null);
; 			^^^^^^^^^^^^^^^^^
; 			var result = people.ClearNulls();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       eax,[rcx+8]
       cmp       eax,edx
       jbe       short M00_L00
       lea       eax,[rdx+1]
       mov       [rdi+10],eax
       movsxd    rdx,edx
       xor       eax,eax
       mov       [rcx+rdx*8+10],rax
       jmp       short M00_L01
M00_L00:
       mov       rcx,rdi
       xor       edx,edx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L01:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 93
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,rsi
       call      qword ptr [7FFB963C7AC0]
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      qword ptr [7FFB963D10A0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 59
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M02_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB370114B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M02_L09
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB370114B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37011A08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        short M02_L10
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__7`1[[System.__Canon, System.Private.CoreLib]].<ClearNulls>b__7_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB370114B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
M02_L09:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAll(System.Predicate`1<System.__Canon>)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L10:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 298
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ClearNulls()
; 			var people = base.PersonProperCollection;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Add(null);
; 			^^^^^^^^^^^^^^^^^
; 			var result = people.ClearNulls();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       eax,[rcx+8]
       cmp       eax,edx
       jbe       short M00_L00
       lea       eax,[rdx+1]
       mov       [rdi+10],eax
       movsxd    rdx,edx
       xor       eax,eax
       mov       [rcx+rdx*8+10],rax
       jmp       short M00_L01
M00_L00:
       mov       rcx,rdi
       xor       edx,edx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L01:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 93
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,rsi
       call      qword ptr [7FFB963C7AC0]
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      qword ptr [7FFB963D10A0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 59
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M02_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB370114B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M02_L09
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB370114B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37011A08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        short M02_L10
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__7`1[[System.__Canon, System.Private.CoreLib]].<ClearNulls>b__7_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB370114B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
M02_L09:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAll(System.Predicate`1<System.__Canon>)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L10:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 298
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.CopyToList()
; 			var result = base.PersonProperCollection.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.CopyToList(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,184C9193060
       mov       r8,[r8]
       mov       rdx,184F91911A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37011050
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.CopyToList()
; 			var result = base.PersonProperCollection.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.CopyToList(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,140505D3060
       mov       r8,[r8]
       mov       rdx,140605D11A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF10B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.CopyToList()
; 			var result = base.PersonProperCollection.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.CopyToList(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,2227B4D3060
       mov       r8,[r8]
       mov       rdx,2227B4E2030
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37011050
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.CopyToList()
; 			var result = base.PersonProperCollection.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.CopyToList(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1A4E1BB3060
       mov       r8,[r8]
       mov       rdx,1A511BB11A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37011240
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.CopyToList()
; 			var result = base.PersonProperCollection.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.CopyToList(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,23971573060
       mov       r8,[r8]
       mov       rdx,23981580418
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB370014C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.CopyToList()
; 			var result = base.PersonProperCollection.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.CopyToList(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1D77FEA3060
       mov       r8,[r8]
       mov       rdx,1D77FEA35F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB370014C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.CopyToList()
; 			var result = base.PersonProperCollection.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.CopyToList(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,191F4A13060
       mov       r8,[r8]
       mov       rdx,191F4A22030
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB370014C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.CopyToList()
; 			var result = base.PersonProperCollection.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.CopyToList(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,219EE273060
       mov       r8,[r8]
       mov       rdx,219FE27DBC8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB370014C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.CopyToList()
; 			var result = base.PersonProperCollection.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.CopyToList(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,19941743060
       mov       r8,[r8]
       mov       rdx,199417435F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF14C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOf()
; 			var result = base.PersonProperCollection.IndexOf(base.PersonProperCollection.Last());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rdi,rdx
       mov       rcx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       edx,[rdi+10]
       mov       [rsp+20],edx
       mov       rdx,[rdi+8]
       mov       rcx,offset MD_System.Array.IndexOf(!!0[], !!0, Int32, Int32)
       xor       r9d,r9d
       call      System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```
```assembly
; System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FE2160
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       lea       r8,[rsp+20]
       mov       rcx,rdx
       mov       rdx,rsi
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M01_L02
       add       rsp,30
       pop       rsi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 81
```
```assembly
; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       edi,r9d
       mov       ebp,[rsp+80]
       test      rsi,rsi
       je        short M02_L02
       mov       edx,[rsi+8]
       cmp       edx,edi
       jb        short M02_L03
       sub       edx,edi
       cmp       edx,ebp
       jb        short M02_L04
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB36FE2EC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       [rsp+20],ebp
       mov       rcx,rax
       mov       rdx,rsi
       mov       r8,rbx
       mov       r9d,edi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,2
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L03:
       call      System.ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index()
       int       3
M02_L04:
       call      System.ThrowHelper.ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count()
       int       3
; Total bytes of code 147
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOf()
; 			var result = base.PersonProperCollection.IndexOf(base.PersonProperCollection.Last());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rdi,rdx
       mov       rcx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       edx,[rdi+10]
       mov       [rsp+20],edx
       mov       rdx,[rdi+8]
       mov       rcx,offset MD_System.Array.IndexOf(!!0[], !!0, Int32, Int32)
       xor       r9d,r9d
       call      System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```
```assembly
; System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FF2FD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       lea       r8,[rsp+20]
       mov       rcx,rdx
       mov       rdx,rsi
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M01_L02
       add       rsp,30
       pop       rsi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 81
```
```assembly
; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       edi,r9d
       mov       ebp,[rsp+80]
       test      rsi,rsi
       je        short M02_L02
       mov       edx,[rsi+8]
       cmp       edx,edi
       jb        short M02_L03
       sub       edx,edi
       cmp       edx,ebp
       jb        short M02_L04
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB36FF2638
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       [rsp+20],ebp
       mov       rcx,rax
       mov       rdx,rsi
       mov       r8,rbx
       mov       r9d,edi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,2
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L03:
       call      System.ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index()
       int       3
M02_L04:
       call      System.ThrowHelper.ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count()
       int       3
; Total bytes of code 147
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOf()
; 			var result = base.PersonProperCollection.IndexOf(base.PersonProperCollection.Last());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rdi,rdx
       mov       rcx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       edx,[rdi+10]
       mov       [rsp+20],edx
       mov       rdx,[rdi+8]
       mov       rcx,offset MD_System.Array.IndexOf(!!0[], !!0, Int32, Int32)
       xor       r9d,r9d
       call      System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```
```assembly
; System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FF3138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       lea       r8,[rsp+20]
       mov       rcx,rdx
       mov       rdx,rsi
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M01_L02
       add       rsp,30
       pop       rsi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 81
```
```assembly
; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       edi,r9d
       mov       ebp,[rsp+80]
       test      rsi,rsi
       je        short M02_L02
       mov       edx,[rsi+8]
       cmp       edx,edi
       jb        short M02_L03
       sub       edx,edi
       cmp       edx,ebp
       jb        short M02_L04
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB36FF27A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       [rsp+20],ebp
       mov       rcx,rax
       mov       rdx,rsi
       mov       r8,rbx
       mov       r9d,edi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,2
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L03:
       call      System.ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index()
       int       3
M02_L04:
       call      System.ThrowHelper.ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count()
       int       3
; Total bytes of code 147
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOf()
; 			var result = base.PersonProperCollection.IndexOf(base.PersonProperCollection.Last());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rdi,rdx
       mov       rcx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       edx,[rdi+10]
       mov       [rsp+20],edx
       mov       rdx,[rdi+8]
       mov       rcx,offset MD_System.Array.IndexOf(!!0[], !!0, Int32, Int32)
       xor       r9d,r9d
       call      System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```
```assembly
; System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB370131E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       lea       r8,[rsp+20]
       mov       rcx,rdx
       mov       rdx,rsi
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M01_L02
       add       rsp,30
       pop       rsi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 81
```
```assembly
; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       edi,r9d
       mov       ebp,[rsp+80]
       test      rsi,rsi
       je        short M02_L02
       mov       edx,[rsi+8]
       cmp       edx,edi
       jb        short M02_L03
       sub       edx,edi
       cmp       edx,ebp
       jb        short M02_L04
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB37012848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       [rsp+20],ebp
       mov       rcx,rax
       mov       rdx,rsi
       mov       r8,rbx
       mov       r9d,edi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,2
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L03:
       call      System.ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index()
       int       3
M02_L04:
       call      System.ThrowHelper.ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count()
       int       3
; Total bytes of code 147
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOf()
; 			var result = base.PersonProperCollection.IndexOf(base.PersonProperCollection.Last());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rdi,rdx
       mov       rcx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       edx,[rdi+10]
       mov       [rsp+20],edx
       mov       rdx,[rdi+8]
       mov       rcx,offset MD_System.Array.IndexOf(!!0[], !!0, Int32, Int32)
       xor       r9d,r9d
       call      System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```
```assembly
; System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB37003138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       lea       r8,[rsp+20]
       mov       rcx,rdx
       mov       rdx,rsi
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M01_L02
       add       rsp,30
       pop       rsi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 81
```
```assembly
; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       edi,r9d
       mov       ebp,[rsp+80]
       test      rsi,rsi
       je        short M02_L02
       mov       edx,[rsi+8]
       cmp       edx,edi
       jb        short M02_L03
       sub       edx,edi
       cmp       edx,ebp
       jb        short M02_L04
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB370027A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       [rsp+20],ebp
       mov       rcx,rax
       mov       rdx,rsi
       mov       r8,rbx
       mov       r9d,edi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,2
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L03:
       call      System.ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index()
       int       3
M02_L04:
       call      System.ThrowHelper.ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count()
       int       3
; Total bytes of code 147
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOf()
; 			var result = base.PersonProperCollection.IndexOf(base.PersonProperCollection.Last());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rdi,rdx
       mov       rcx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       edx,[rdi+10]
       mov       [rsp+20],edx
       mov       rdx,[rdi+8]
       mov       rcx,offset MD_System.Array.IndexOf(!!0[], !!0, Int32, Int32)
       xor       r9d,r9d
       call      System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```
```assembly
; System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB370133C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       lea       r8,[rsp+20]
       mov       rcx,rdx
       mov       rdx,rsi
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M01_L02
       add       rsp,30
       pop       rsi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 81
```
```assembly
; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       edi,r9d
       mov       ebp,[rsp+80]
       test      rsi,rsi
       je        short M02_L02
       mov       edx,[rsi+8]
       cmp       edx,edi
       jb        short M02_L03
       sub       edx,edi
       cmp       edx,ebp
       jb        short M02_L04
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB37012A28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       [rsp+20],ebp
       mov       rcx,rax
       mov       rdx,rsi
       mov       r8,rbx
       mov       r9d,edi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,2
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L03:
       call      System.ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index()
       int       3
M02_L04:
       call      System.ThrowHelper.ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count()
       int       3
; Total bytes of code 147
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOf()
; 			var result = base.PersonProperCollection.IndexOf(base.PersonProperCollection.Last());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rdi,rdx
       mov       rcx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       edx,[rdi+10]
       mov       [rsp+20],edx
       mov       rdx,[rdi+8]
       mov       rcx,offset MD_System.Array.IndexOf(!!0[], !!0, Int32, Int32)
       xor       r9d,r9d
       call      System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```
```assembly
; System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FE33C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       lea       r8,[rsp+20]
       mov       rcx,rdx
       mov       rdx,rsi
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M01_L02
       add       rsp,30
       pop       rsi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 81
```
```assembly
; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       edi,r9d
       mov       ebp,[rsp+80]
       test      rsi,rsi
       je        short M02_L02
       mov       edx,[rsi+8]
       cmp       edx,edi
       jb        short M02_L03
       sub       edx,edi
       cmp       edx,ebp
       jb        short M02_L04
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB36FE2A28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       [rsp+20],ebp
       mov       rcx,rax
       mov       rdx,rsi
       mov       r8,rbx
       mov       r9d,edi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,2
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L03:
       call      System.ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index()
       int       3
M02_L04:
       call      System.ThrowHelper.ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count()
       int       3
; Total bytes of code 147
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOf()
; 			var result = base.PersonProperCollection.IndexOf(base.PersonProperCollection.Last());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rdi,rdx
       mov       rcx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       edx,[rdi+10]
       mov       [rsp+20],edx
       mov       rdx,[rdi+8]
       mov       rcx,offset MD_System.Array.IndexOf(!!0[], !!0, Int32, Int32)
       xor       r9d,r9d
       call      System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```
```assembly
; System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FE33C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       lea       r8,[rsp+20]
       mov       rcx,rdx
       mov       rdx,rsi
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M01_L02
       add       rsp,30
       pop       rsi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 81
```
```assembly
; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       edi,r9d
       mov       ebp,[rsp+80]
       test      rsi,rsi
       je        short M02_L02
       mov       edx,[rsi+8]
       cmp       edx,edi
       jb        short M02_L03
       sub       edx,edi
       cmp       edx,ebp
       jb        short M02_L04
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB36FE2A28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       [rsp+20],ebp
       mov       rcx,rax
       mov       rdx,rsi
       mov       r8,rbx
       mov       r9d,edi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,2
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L03:
       call      System.ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index()
       int       3
M02_L04:
       call      System.ThrowHelper.ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count()
       int       3
; Total bytes of code 147
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOf()
; 			var result = base.PersonProperCollection.IndexOf(base.PersonProperCollection.Last());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rdi,rdx
       mov       rcx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       edx,[rdi+10]
       mov       [rsp+20],edx
       mov       rdx,[rdi+8]
       mov       rcx,offset MD_System.Array.IndexOf(!!0[], !!0, Int32, Int32)
       xor       r9d,r9d
       call      System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```
```assembly
; System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FF2570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       lea       r8,[rsp+20]
       mov       rcx,rdx
       mov       rdx,rsi
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M01_L02
       add       rsp,30
       pop       rsi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 81
```
```assembly
; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       edi,r9d
       mov       ebp,[rsp+80]
       test      rsi,rsi
       je        short M02_L02
       mov       edx,[rsi+8]
       cmp       edx,edi
       jb        short M02_L03
       sub       edx,edi
       cmp       edx,ebp
       jb        short M02_L04
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB36FF32D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       [rsp+20],ebp
       mov       rcx,rax
       mov       rdx,rsi
       mov       r8,rbx
       mov       r9d,edi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,2
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L03:
       call      System.ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index()
       int       3
M02_L04:
       call      System.ThrowHelper.ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count()
       int       3
; Total bytes of code 147
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOfComparer()
; 			var comparer = new PersonProperComparer();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.PersonProperCollection.IndexOf(base.PersonProperCollection.Last(), comparer);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.BenchmarkTests.PersonProperComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rbx,rdx
       mov       rcx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rbx
       mov       r9,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.IndexOf(System.Collections.Generic.IEnumerable`1<!!0>, !!0, System.Collections.Generic.IEqualityComparer`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
```
```assembly
; System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FE8418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       lea       r8,[rsp+20]
       mov       rcx,rdx
       mov       rdx,rsi
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M01_L02
       add       rsp,30
       pop       rsi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 81
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M02_L00
       mov       rcx,[r14+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0FD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,1DEEC113060
       mov       r8,[r8]
       mov       rdx,1DEFC1111A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[r15+10]
       mov       rdx,1DEFC1111A8
       mov       rdx,[rdx]
       mov       r8,1DEEC113060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r15+8]
       mov       rdx,1DEFC1111B0
       mov       rdx,[rdx]
       mov       r8,1DEEC113060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass11_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
       mov       [rbx+18],rcx
       cmp       qword ptr [r14+20],0
       je        short M02_L04
       mov       rcx,[r14+20]
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FE12A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`3<System.__Canon,Int32,Int32>)
       mov       rdi,rax
       cmp       qword ptr [r14+28],0
       je        short M02_L06
       mov       rcx,[r14+28]
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1600
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M02_L12
       mov       rbx,[r14+28]
       test      rbx,rbx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1600
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M02_L09:
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       test      rdx,rdx
       je        short M02_L13
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__11`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__11_1(Int32)
       mov       [rbp+18],rcx
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1600
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
M02_L12:
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,Boolean>, Int32)
M02_L13:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 544
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOfComparer()
; 			var comparer = new PersonProperComparer();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.PersonProperCollection.IndexOf(base.PersonProperCollection.Last(), comparer);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.BenchmarkTests.PersonProperComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rbx,rdx
       mov       rcx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rbx
       mov       r9,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.IndexOf(System.Collections.Generic.IEnumerable`1<!!0>, !!0, System.Collections.Generic.IEqualityComparer`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
```
```assembly
; System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB370083B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       lea       r8,[rsp+20]
       mov       rcx,rdx
       mov       rdx,rsi
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M01_L02
       add       rsp,30
       pop       rsi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 81
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M02_L00
       mov       rcx,[r14+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37000F78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,1A6A6CB3060
       mov       r8,[r8]
       mov       rdx,1A6B6CB11A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[r15+10]
       mov       rdx,1A6B6CB11A8
       mov       rdx,[rdx]
       mov       r8,1A6A6CB3060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r15+8]
       mov       rdx,1A6B6CB11B0
       mov       rdx,[rdx]
       mov       r8,1A6A6CB3060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB370010D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass11_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
       mov       [rbx+18],rcx
       cmp       qword ptr [r14+20],0
       je        short M02_L04
       mov       rcx,[r14+20]
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB37001240
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`3<System.__Canon,Int32,Int32>)
       mov       rdi,rax
       cmp       qword ptr [r14+28],0
       je        short M02_L06
       mov       rcx,[r14+28]
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB370015A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M02_L12
       mov       rbx,[r14+28]
       test      rbx,rbx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB370015A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M02_L09:
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       test      rdx,rdx
       je        short M02_L13
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__11`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__11_1(Int32)
       mov       [rbp+18],rcx
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB370015A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
M02_L12:
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,Boolean>, Int32)
M02_L13:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 544
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOfComparer()
; 			var comparer = new PersonProperComparer();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.PersonProperCollection.IndexOf(base.PersonProperCollection.Last(), comparer);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.BenchmarkTests.PersonProperComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rbx,rdx
       mov       rcx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rbx
       mov       r9,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.IndexOf(System.Collections.Generic.IEnumerable`1<!!0>, !!0, System.Collections.Generic.IEqualityComparer`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
```
```assembly
; System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FE7EA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       lea       r8,[rsp+20]
       mov       rcx,rdx
       mov       rdx,rsi
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M01_L02
       add       rsp,30
       pop       rsi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 81
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M02_L00
       mov       rcx,[r14+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0FF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,16049893060
       mov       r8,[r8]
       mov       rdx,1603989DBC8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[r15+10]
       mov       rdx,1603989DBD0
       mov       rdx,[rdx]
       mov       r8,16049893060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r15+8]
       mov       rdx,1603989DBD8
       mov       rdx,[rdx]
       mov       r8,16049893060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass11_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
       mov       [rbx+18],rcx
       cmp       qword ptr [r14+20],0
       je        short M02_L04
       mov       rcx,[r14+20]
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FE12C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`3<System.__Canon,Int32,Int32>)
       mov       rdi,rax
       cmp       qword ptr [r14+28],0
       je        short M02_L06
       mov       rcx,[r14+28]
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1620
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M02_L12
       mov       rbx,[r14+28]
       test      rbx,rbx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1620
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M02_L09:
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       test      rdx,rdx
       je        short M02_L13
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__11`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__11_1(Int32)
       mov       [rbp+18],rcx
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1620
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
M02_L12:
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,Boolean>, Int32)
M02_L13:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 544
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOfComparer()
; 			var comparer = new PersonProperComparer();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.PersonProperCollection.IndexOf(base.PersonProperCollection.Last(), comparer);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.BenchmarkTests.PersonProperComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rbx,rdx
       mov       rcx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rbx
       mov       r9,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.IndexOf(System.Collections.Generic.IEnumerable`1<!!0>, !!0, System.Collections.Generic.IEqualityComparer`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
```
```assembly
; System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB37008480
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       lea       r8,[rsp+20]
       mov       rcx,rdx
       mov       rdx,rsi
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M01_L02
       add       rsp,30
       pop       rsi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 81
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M02_L00
       mov       rcx,[r14+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37000FD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,2613E5A3060
       mov       r8,[r8]
       mov       rdx,2614E5A11A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[r15+10]
       mov       rdx,2614E5A11A8
       mov       rdx,[rdx]
       mov       r8,2613E5A3060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r15+8]
       mov       rdx,2614E5A11B0
       mov       rdx,[rdx]
       mov       r8,2613E5A3060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB37001138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass11_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
       mov       [rbx+18],rcx
       cmp       qword ptr [r14+20],0
       je        short M02_L04
       mov       rcx,[r14+20]
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB370012A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`3<System.__Canon,Int32,Int32>)
       mov       rdi,rax
       cmp       qword ptr [r14+28],0
       je        short M02_L06
       mov       rcx,[r14+28]
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB37001600
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M02_L12
       mov       rbx,[r14+28]
       test      rbx,rbx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37001600
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M02_L09:
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       test      rdx,rdx
       je        short M02_L13
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__11`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__11_1(Int32)
       mov       [rbp+18],rcx
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB37001600
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
M02_L12:
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,Boolean>, Int32)
M02_L13:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 544
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOfComparer()
; 			var comparer = new PersonProperComparer();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.PersonProperCollection.IndexOf(base.PersonProperCollection.Last(), comparer);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.BenchmarkTests.PersonProperComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rbx,rdx
       mov       rcx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rbx
       mov       r9,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.IndexOf(System.Collections.Generic.IEnumerable`1<!!0>, !!0, System.Collections.Generic.IEqualityComparer`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
```
```assembly
; System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB37008318
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       lea       r8,[rsp+20]
       mov       rcx,rdx
       mov       rdx,rsi
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M01_L02
       add       rsp,30
       pop       rsi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 81
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M02_L00
       mov       rcx,[r14+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37000FD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,26B8A451048
       mov       r8,[r8]
       mov       rdx,26B7A4519D8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[r15+10]
       mov       rdx,26B7A4519E0
       mov       rdx,[rdx]
       mov       r8,26B8A451048
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r15+8]
       mov       rdx,26B7A4519E8
       mov       rdx,[rdx]
       mov       r8,26B8A451048
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB37001138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass11_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
       mov       [rbx+18],rcx
       cmp       qword ptr [r14+20],0
       je        short M02_L04
       mov       rcx,[r14+20]
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB370012A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`3<System.__Canon,Int32,Int32>)
       mov       rdi,rax
       cmp       qword ptr [r14+28],0
       je        short M02_L06
       mov       rcx,[r14+28]
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB37001600
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M02_L12
       mov       rbx,[r14+28]
       test      rbx,rbx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37001600
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M02_L09:
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       test      rdx,rdx
       je        short M02_L13
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__11`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__11_1(Int32)
       mov       [rbp+18],rcx
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB37001600
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
M02_L12:
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,Boolean>, Int32)
M02_L13:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 544
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOfComparer()
; 			var comparer = new PersonProperComparer();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.PersonProperCollection.IndexOf(base.PersonProperCollection.Last(), comparer);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.BenchmarkTests.PersonProperComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rbx,rdx
       mov       rcx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rbx
       mov       r9,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.IndexOf(System.Collections.Generic.IEnumerable`1<!!0>, !!0, System.Collections.Generic.IEqualityComparer`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
```
```assembly
; System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FF8728
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       lea       r8,[rsp+20]
       mov       rcx,rdx
       mov       rdx,rsi
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M01_L02
       add       rsp,30
       pop       rsi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 81
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M02_L00
       mov       rcx,[r14+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF13E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,21AAF5B3060
       mov       r8,[r8]
       mov       rdx,21A8F5B11A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[r15+10]
       mov       rdx,21A8F5B11A8
       mov       rdx,[rdx]
       mov       r8,21AAF5B3060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r15+8]
       mov       rdx,21A8F5B11B0
       mov       rdx,[rdx]
       mov       r8,21AAF5B3060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1548
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass11_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
       mov       [rbx+18],rcx
       cmp       qword ptr [r14+20],0
       je        short M02_L04
       mov       rcx,[r14+20]
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FF16B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`3<System.__Canon,Int32,Int32>)
       mov       rdi,rax
       cmp       qword ptr [r14+28],0
       je        short M02_L06
       mov       rcx,[r14+28]
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1A10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M02_L12
       mov       rbx,[r14+28]
       test      rbx,rbx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1A10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M02_L09:
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       test      rdx,rdx
       je        short M02_L13
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__11`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__11_1(Int32)
       mov       [rbp+18],rcx
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1A10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
M02_L12:
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,Boolean>, Int32)
M02_L13:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 544
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOfComparer()
; 			var comparer = new PersonProperComparer();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.PersonProperCollection.IndexOf(base.PersonProperCollection.Last(), comparer);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.BenchmarkTests.PersonProperComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rbx,rdx
       mov       rcx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rbx
       mov       r9,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.IndexOf(System.Collections.Generic.IEnumerable`1<!!0>, !!0, System.Collections.Generic.IEqualityComparer`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
```
```assembly
; System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB37008048
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       lea       r8,[rsp+20]
       mov       rcx,rdx
       mov       rdx,rsi
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M01_L02
       add       rsp,30
       pop       rsi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 81
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M02_L00
       mov       rcx,[r14+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37001208
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,20289B23060
       mov       r8,[r8]
       mov       rdx,20279B211A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[r15+10]
       mov       rdx,20279B211A8
       mov       rdx,[rdx]
       mov       r8,20289B23060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r15+8]
       mov       rdx,20279B211B0
       mov       rdx,[rdx]
       mov       r8,20289B23060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB37001368
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass11_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
       mov       [rbx+18],rcx
       cmp       qword ptr [r14+20],0
       je        short M02_L04
       mov       rcx,[r14+20]
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB370014D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`3<System.__Canon,Int32,Int32>)
       mov       rdi,rax
       cmp       qword ptr [r14+28],0
       je        short M02_L06
       mov       rcx,[r14+28]
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB37001830
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M02_L12
       mov       rbx,[r14+28]
       test      rbx,rbx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37001830
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M02_L09:
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       test      rdx,rdx
       je        short M02_L13
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__11`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__11_1(Int32)
       mov       [rbp+18],rcx
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB37001830
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
M02_L12:
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,Boolean>, Int32)
M02_L13:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 544
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOfComparer()
; 			var comparer = new PersonProperComparer();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.PersonProperCollection.IndexOf(base.PersonProperCollection.Last(), comparer);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.BenchmarkTests.PersonProperComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rbx,rdx
       mov       rcx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rbx
       mov       r9,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.IndexOf(System.Collections.Generic.IEnumerable`1<!!0>, !!0, System.Collections.Generic.IEqualityComparer`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
```
```assembly
; System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB37018228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       lea       r8,[rsp+20]
       mov       rcx,rdx
       mov       rdx,rsi
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M01_L02
       add       rsp,30
       pop       rsi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 81
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M02_L00
       mov       rcx,[r14+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB370113E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,26760343060
       mov       r8,[r8]
       mov       rdx,26760383E40
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[r15+10]
       mov       rdx,26760383E48
       mov       rdx,[rdx]
       mov       r8,26760343060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r15+8]
       mov       rdx,26760383E50
       mov       rdx,[rdx]
       mov       r8,26760343060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB37011548
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass11_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
       mov       [rbx+18],rcx
       cmp       qword ptr [r14+20],0
       je        short M02_L04
       mov       rcx,[r14+20]
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB370116B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`3<System.__Canon,Int32,Int32>)
       mov       rdi,rax
       cmp       qword ptr [r14+28],0
       je        short M02_L06
       mov       rcx,[r14+28]
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB37011A10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M02_L12
       mov       rbx,[r14+28]
       test      rbx,rbx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37011A10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M02_L09:
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       test      rdx,rdx
       je        short M02_L13
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__11`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__11_1(Int32)
       mov       [rbp+18],rcx
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB37011A10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
M02_L12:
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,Boolean>, Int32)
M02_L13:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 544
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOfComparer()
; 			var comparer = new PersonProperComparer();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.PersonProperCollection.IndexOf(base.PersonProperCollection.Last(), comparer);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.BenchmarkTests.PersonProperComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rbx,rdx
       mov       rcx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rbx
       mov       r9,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.IndexOf(System.Collections.Generic.IEnumerable`1<!!0>, !!0, System.Collections.Generic.IEqualityComparer`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
```
```assembly
; System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FF86C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       lea       r8,[rsp+20]
       mov       rcx,rdx
       mov       rdx,rsi
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M01_L02
       add       rsp,30
       pop       rsi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 81
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M02_L00
       mov       rcx,[r14+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF13E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,18E8DBD3060
       mov       r8,[r8]
       mov       rdx,18E9DBD11A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[r15+10]
       mov       rdx,18E9DBD11A8
       mov       rdx,[rdx]
       mov       r8,18E8DBD3060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r15+8]
       mov       rdx,18E9DBD11B0
       mov       rdx,[rdx]
       mov       r8,18E8DBD3060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1548
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass11_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
       mov       [rbx+18],rcx
       cmp       qword ptr [r14+20],0
       je        short M02_L04
       mov       rcx,[r14+20]
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FF16B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`3<System.__Canon,Int32,Int32>)
       mov       rdi,rax
       cmp       qword ptr [r14+28],0
       je        short M02_L06
       mov       rcx,[r14+28]
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1A10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M02_L12
       mov       rbx,[r14+28]
       test      rbx,rbx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1A10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M02_L09:
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       test      rdx,rdx
       je        short M02_L13
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__11`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__11_1(Int32)
       mov       [rbp+18],rcx
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1A10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
M02_L12:
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,Boolean>, Int32)
M02_L13:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 544
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeArray()
; 			var result = base.PersonProperArrayFull.ArrayHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 43
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,18931CB3060
       mov       r8,[r8]
       mov       rdx,18931CB5BD8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M01_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rbp,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax]
       cmp       qword ptr [rbp+8],30
       jle       short M01_L04
       mov       rcx,[rbp+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       test      r14,r14
       je        near ptr M01_L22
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_0(System.__Canon)
       mov       [rbp+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       cmp       qword ptr [rbx+18],0
       je        short M01_L09
       mov       rcx,[rbx+18]
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0B70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,rdi
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+10],0
       je        short M01_L11
       mov       rcx,[rbx+10]
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+10]
       test      rbp,rbp
       jne       near ptr M01_L19
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0EC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M01_L22
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_1(Int32, System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L18:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M01_L19:
       cmp       qword ptr [rbx+20],0
       je        short M01_L20
       mov       rcx,[rbx+20]
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0D88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L21:
       mov       rdx,rdi
       mov       r8d,1997
       mov       r9,rbp
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L22:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 622
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeArray()
; 			var result = base.PersonProperArrayFull.ArrayHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 43
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,196303C3060
       mov       r8,[r8]
       mov       rdx,196403C1770
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M01_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rbp,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax]
       cmp       qword ptr [rbp+8],30
       jle       short M01_L04
       mov       rcx,[rbp+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FF10E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       test      r14,r14
       je        near ptr M01_L22
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_0(System.__Canon)
       mov       [rbp+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       cmp       qword ptr [rbx+18],0
       je        short M01_L09
       mov       rcx,[rbx+18]
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0BD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,rdi
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+10],0
       je        short M01_L11
       mov       rcx,[rbx+10]
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+10]
       test      rbp,rbp
       jne       near ptr M01_L19
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0F28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M01_L22
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_1(Int32, System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L18:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M01_L19:
       cmp       qword ptr [rbx+20],0
       je        short M01_L20
       mov       rcx,[rbx+20]
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0DE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L21:
       mov       rdx,rdi
       mov       r8d,1997
       mov       r9,rbp
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L22:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 622
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeArray()
; 			var result = base.PersonProperArrayFull.ArrayHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 43
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,28533F63060
       mov       r8,[r8]
       mov       rdx,28543F61770
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M01_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rbp,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax]
       cmp       qword ptr [rbp+8],30
       jle       short M01_L04
       mov       rcx,[rbp+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       test      r14,r14
       je        near ptr M01_L22
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_0(System.__Canon)
       mov       [rbp+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       cmp       qword ptr [rbx+18],0
       je        short M01_L09
       mov       rcx,[rbx+18]
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0B70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,rdi
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+10],0
       je        short M01_L11
       mov       rcx,[rbx+10]
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+10]
       test      rbp,rbp
       jne       near ptr M01_L19
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0EC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M01_L22
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_1(Int32, System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L18:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M01_L19:
       cmp       qword ptr [rbx+20],0
       je        short M01_L20
       mov       rcx,[rbx+20]
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0D88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L21:
       mov       rdx,rdi
       mov       r8d,1997
       mov       r9,rbp
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L22:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 622
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeArray()
; 			var result = base.PersonProperArrayFull.ArrayHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 43
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1B4DC753060
       mov       r8,[r8]
       mov       rdx,1B4CC751770
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37010DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M01_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB37010DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rbp,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax]
       cmp       qword ptr [rbp+8],30
       jle       short M01_L04
       mov       rcx,[rbp+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB37011318
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       test      r14,r14
       je        near ptr M01_L22
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_0(System.__Canon)
       mov       [rbp+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB37010DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       cmp       qword ptr [rbx+18],0
       je        short M01_L09
       mov       rcx,[rbx+18]
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFB37010E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,rdi
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+10],0
       je        short M01_L11
       mov       rcx,[rbx+10]
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFB37010DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+10]
       test      rbp,rbp
       jne       near ptr M01_L19
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFB37010DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFB37011158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M01_L22
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_1(Int32, System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFB37010DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L18:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M01_L19:
       cmp       qword ptr [rbx+20],0
       je        short M01_L20
       mov       rcx,[rbx+20]
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFB37011018
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L21:
       mov       rdx,rdi
       mov       r8d,1997
       mov       r9,rbp
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L22:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 622
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeArray()
; 			var result = base.PersonProperArrayFull.ArrayHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 43
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,2158EB11048
       mov       r8,[r8]
       mov       rdx,2158EB205E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M01_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rbp,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax]
       cmp       qword ptr [rbp+8],30
       jle       short M01_L04
       mov       rcx,[rbp+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       test      r14,r14
       je        near ptr M01_L22
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_0(System.__Canon)
       mov       [rbp+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       cmp       qword ptr [rbx+18],0
       je        short M01_L09
       mov       rcx,[rbx+18]
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0D58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,rdi
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+10],0
       je        short M01_L11
       mov       rcx,[rbx+10]
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+10]
       test      rbp,rbp
       jne       near ptr M01_L19
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFB36FF10B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M01_L22
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_1(Int32, System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L18:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M01_L19:
       cmp       qword ptr [rbx+20],0
       je        short M01_L20
       mov       rcx,[rbx+20]
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0F70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L21:
       mov       rdx,rdi
       mov       r8d,1997
       mov       r9,rbp
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L22:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 622
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeArray()
; 			var result = base.PersonProperArrayFull.ArrayHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 43
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1E4C29C3060
       mov       r8,[r8]
       mov       rdx,1E4C29D2600
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37000DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M01_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB37000DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rbp,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax]
       cmp       qword ptr [rbp+8],30
       jle       short M01_L04
       mov       rcx,[rbp+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB37001318
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       test      r14,r14
       je        near ptr M01_L22
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_0(System.__Canon)
       mov       [rbp+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB37000DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       cmp       qword ptr [rbx+18],0
       je        short M01_L09
       mov       rcx,[rbx+18]
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFB37000E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,rdi
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+10],0
       je        short M01_L11
       mov       rcx,[rbx+10]
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFB37000DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+10]
       test      rbp,rbp
       jne       near ptr M01_L19
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFB37000DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFB37001158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M01_L22
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_1(Int32, System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFB37000DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L18:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M01_L19:
       cmp       qword ptr [rbx+20],0
       je        short M01_L20
       mov       rcx,[rbx+20]
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFB37001018
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L21:
       mov       rdx,rdi
       mov       r8d,1997
       mov       r9,rbp
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L22:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 622
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeArray()
; 			var result = base.PersonProperArrayFull.ArrayHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 43
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,2CD96F53060
       mov       r8,[r8]
       mov       rdx,2CDA6F581F8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M01_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rbp,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax]
       cmp       qword ptr [rbp+8],30
       jle       short M01_L04
       mov       rcx,[rbp+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1318
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       test      r14,r14
       je        near ptr M01_L22
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_0(System.__Canon)
       mov       [rbp+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       cmp       qword ptr [rbx+18],0
       je        short M01_L09
       mov       rcx,[rbx+18]
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,rdi
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+10],0
       je        short M01_L11
       mov       rcx,[rbx+10]
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+10]
       test      rbp,rbp
       jne       near ptr M01_L19
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M01_L22
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_1(Int32, System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L18:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M01_L19:
       cmp       qword ptr [rbx+20],0
       je        short M01_L20
       mov       rcx,[rbx+20]
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1018
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L21:
       mov       rdx,rdi
       mov       r8d,1997
       mov       r9,rbp
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L22:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 622
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeArray()
; 			var result = base.PersonProperArrayFull.ArrayHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 43
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1364B2D1048
       mov       r8,[r8]
       mov       rdx,1363B2D1770
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0FA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M01_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0FA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rbp,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax]
       cmp       qword ptr [rbp+8],30
       jle       short M01_L04
       mov       rcx,[rbp+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FF14F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       test      r14,r14
       je        near ptr M01_L22
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_0(System.__Canon)
       mov       [rbp+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0FA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       cmp       qword ptr [rbx+18],0
       je        short M01_L09
       mov       rcx,[rbx+18]
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0FE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,rdi
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+10],0
       je        short M01_L11
       mov       rcx,[rbx+10]
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0FA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+10]
       test      rbp,rbp
       jne       near ptr M01_L19
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0FA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1338
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M01_L22
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_1(Int32, System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0FA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L18:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M01_L19:
       cmp       qword ptr [rbx+20],0
       je        short M01_L20
       mov       rcx,[rbx+20]
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFB36FF11F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L21:
       mov       rdx,rdi
       mov       r8d,1997
       mov       r9,rbp
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L22:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 622
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeArray()
; 			var result = base.PersonProperArrayFull.ArrayHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 43
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,279D28E3060
       mov       r8,[r8]
       mov       rdx,279E28F01B0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M01_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rbp,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax]
       cmp       qword ptr [rbp+8],30
       jle       short M01_L04
       mov       rcx,[rbp+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       test      r14,r14
       je        near ptr M01_L22
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_0(System.__Canon)
       mov       [rbp+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       cmp       qword ptr [rbx+18],0
       je        short M01_L09
       mov       rcx,[rbx+18]
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0D58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,rdi
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+10],0
       je        short M01_L11
       mov       rcx,[rbx+10]
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+10]
       test      rbp,rbp
       jne       near ptr M01_L19
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFB36FF10B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M01_L22
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_1(Int32, System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L18:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M01_L19:
       cmp       qword ptr [rbx+20],0
       je        short M01_L20
       mov       rcx,[rbx+20]
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0F70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L21:
       mov       rdx,rdi
       mov       r8d,1997
       mov       r9,rbp
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L22:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 622
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeList()
; 			var result = base.PersonProperCollection.ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 43
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0DD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,25A1AE33060
       mov       r8,[r8]
       mov       rdx,259FAE319D8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0F58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+20],0
       je        short M01_L04
       mov       rcx,[rbx+20]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1188
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax+8]
       test      r14,r14
       jne       near ptr M01_L12
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1188
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       r14,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r15,[rax]
       cmp       qword ptr [r14+8],40
       jle       short M01_L08
       mov       rcx,[r14+40]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FF16E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      r15,r15
       je        near ptr M01_L19
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__14`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__14_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1188
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L12:
       cmp       qword ptr [rbx+28],0
       je        short M01_L13
       mov       rcx,[rbx+28]
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFB36FF11C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M01_L15
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFB36FF14F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass14_0`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__1(Int32, System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L17
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFB36FF15A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L18:
       mov       rdx,rdi
       mov       r9,rbx
       mov       r8d,1997
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 586
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeList()
; 			var result = base.PersonProperCollection.ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 43
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37000E30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,261652F3060
       mov       r8,[r8]
       mov       rdx,261752F11A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB37000FB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+20],0
       je        short M01_L04
       mov       rcx,[rbx+20]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB370011E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax+8]
       test      r14,r14
       jne       near ptr M01_L12
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB370011E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       r14,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r15,[rax]
       cmp       qword ptr [r14+8],40
       jle       short M01_L08
       mov       rcx,[r14+40]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37001740
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      r15,r15
       je        near ptr M01_L19
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__14`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__14_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB370011E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L12:
       cmp       qword ptr [rbx+28],0
       je        short M01_L13
       mov       rcx,[rbx+28]
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFB37001228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M01_L15
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFB37001558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass14_0`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__1(Int32, System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L17
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFB37001600
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L18:
       mov       rdx,rdi
       mov       r9,rbx
       mov       r8d,1997
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 586
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeList()
; 			var result = base.PersonProperCollection.ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 43
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0E50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,1F200CE3060
       mov       r8,[r8]
       mov       rdx,1F200CE35F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0FD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+20],0
       je        short M01_L04
       mov       rcx,[rbx+20]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1208
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax+8]
       test      r14,r14
       jne       near ptr M01_L12
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1208
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       r14,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r15,[rax]
       cmp       qword ptr [r14+8],40
       jle       short M01_L08
       mov       rcx,[r14+40]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1760
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      r15,r15
       je        near ptr M01_L19
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__14`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__14_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1208
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L12:
       cmp       qword ptr [rbx+28],0
       je        short M01_L13
       mov       rcx,[rbx+28]
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1248
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M01_L15
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1578
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass14_0`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__1(Int32, System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L17
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1620
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L18:
       mov       rdx,rdi
       mov       r9,rbx
       mov       r8d,1997
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 586
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeList()
; 			var result = base.PersonProperCollection.ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 43
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0DD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,1B1E48D3060
       mov       r8,[r8]
       mov       rdx,1B1F48E0418
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0F58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+20],0
       je        short M01_L04
       mov       rcx,[rbx+20]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1188
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax+8]
       test      r14,r14
       jne       near ptr M01_L12
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1188
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       r14,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r15,[rax]
       cmp       qword ptr [r14+8],40
       jle       short M01_L08
       mov       rcx,[r14+40]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FF16E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      r15,r15
       je        near ptr M01_L19
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__14`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__14_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1188
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L12:
       cmp       qword ptr [rbx+28],0
       je        short M01_L13
       mov       rcx,[rbx+28]
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFB36FF11C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M01_L15
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFB36FF14F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass14_0`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__1(Int32, System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L17
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFB36FF15A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L18:
       mov       rdx,rdi
       mov       r9,rbx
       mov       r8d,1997
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 586
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeList()
; 			var result = base.PersonProperCollection.ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 43
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37011060
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,1B01D223060
       mov       r8,[r8]
       mov       rdx,1B02D2211A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB370111E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+20],0
       je        short M01_L04
       mov       rcx,[rbx+20]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB37011418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax+8]
       test      r14,r14
       jne       near ptr M01_L12
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB37011418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       r14,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r15,[rax]
       cmp       qword ptr [r14+8],40
       jle       short M01_L08
       mov       rcx,[r14+40]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37011970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      r15,r15
       je        near ptr M01_L19
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__14`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__14_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB37011418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L12:
       cmp       qword ptr [rbx+28],0
       je        short M01_L13
       mov       rcx,[rbx+28]
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFB37011458
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M01_L15
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFB37011788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass14_0`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__1(Int32, System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L17
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFB37011830
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L18:
       mov       rdx,rdi
       mov       r9,rbx
       mov       r8d,1997
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 586
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeList()
; 			var result = base.PersonProperCollection.ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 43
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0E30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,1C803783060
       mov       r8,[r8]
       mov       rdx,1C803785E40
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0FB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+20],0
       je        short M01_L04
       mov       rcx,[rbx+20]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FF11E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax+8]
       test      r14,r14
       jne       near ptr M01_L12
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FF11E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       r14,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r15,[rax]
       cmp       qword ptr [r14+8],40
       jle       short M01_L08
       mov       rcx,[r14+40]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1740
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      r15,r15
       je        near ptr M01_L19
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__14`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__14_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FF11E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L12:
       cmp       qword ptr [rbx+28],0
       je        short M01_L13
       mov       rcx,[rbx+28]
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M01_L15
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass14_0`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__1(Int32, System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L17
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1600
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L18:
       mov       rdx,rdi
       mov       r9,rbx
       mov       r8d,1997
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 586
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeList()
; 			var result = base.PersonProperCollection.ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 43
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37001060
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,1A1E8A23060
       mov       r8,[r8]
       mov       rdx,1A1F8A211A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB370011E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+20],0
       je        short M01_L04
       mov       rcx,[rbx+20]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB37001418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax+8]
       test      r14,r14
       jne       near ptr M01_L12
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB37001418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       r14,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r15,[rax]
       cmp       qword ptr [r14+8],40
       jle       short M01_L08
       mov       rcx,[r14+40]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37001970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      r15,r15
       je        near ptr M01_L19
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__14`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__14_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB37001418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L12:
       cmp       qword ptr [rbx+28],0
       je        short M01_L13
       mov       rcx,[rbx+28]
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFB37001458
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M01_L15
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFB37001788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass14_0`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__1(Int32, System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L17
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFB37001830
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L18:
       mov       rdx,rdi
       mov       r9,rbx
       mov       r8d,1997
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 586
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeList()
; 			var result = base.PersonProperCollection.ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 43
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1060
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,233EDBC3060
       mov       r8,[r8]
       mov       rdx,233CDBC11A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FF11E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+20],0
       je        short M01_L04
       mov       rcx,[rbx+20]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax+8]
       test      r14,r14
       jne       near ptr M01_L12
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       r14,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r15,[rax]
       cmp       qword ptr [r14+8],40
       jle       short M01_L08
       mov       rcx,[r14+40]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      r15,r15
       je        near ptr M01_L19
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__14`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__14_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L12:
       cmp       qword ptr [rbx+28],0
       je        short M01_L13
       mov       rcx,[rbx+28]
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1458
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M01_L15
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass14_0`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__1(Int32, System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L17
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1830
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L18:
       mov       rdx,rdi
       mov       r9,rbx
       mov       r8d,1997
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 586
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeList()
; 			var result = base.PersonProperCollection.ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 43
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ListHashCode[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1240
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,21AA5DD3060
       mov       r8,[r8]
       mov       rdx,21AC5E4E1D8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FE13C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+20],0
       je        short M01_L04
       mov       rcx,[rbx+20]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FE15F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax+8]
       test      r14,r14
       jne       near ptr M01_L12
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FE15F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       r14,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r15,[rax]
       cmp       qword ptr [r14+8],40
       jle       short M01_L08
       mov       rcx,[r14+40]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1B50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      r15,r15
       je        near ptr M01_L19
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__14`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__14_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FE15F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L12:
       cmp       qword ptr [rbx+28],0
       je        short M01_L13
       mov       rcx,[rbx+28]
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1638
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M01_L15
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1968
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__DisplayClass14_0`1[[System.__Canon, System.Private.CoreLib]].<ListHashCode>b__1(Int32, System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L17
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1A10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L18:
       mov       rdx,rdi
       mov       r9,rbx
       mov       r8d,1997
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 586
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderBy()
; 			var result = base.PersonProperCollection.OrderBy(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,22100732EF0
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,22100732EE8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,22100732EF0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],rcx
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8,rbx
       xor       r9d,r9d
       call      System.Linq.OrderedEnumerable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>, Boolean, System.Linq.OrderedEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 193
```
```assembly
; System.Linq.OrderedEnumerable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>, Boolean, System.Linq.OrderedEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M01_L03
       test      rbx,rbx
       je        near ptr M01_L04
       lea       rcx,[rsi+10]
       mov       rdx,[rsp+78]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rbp
       test      rdx,rdx
       jne       short M01_L02
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       cmp       qword ptr [rdx+10],30
       jle       short M01_L00
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FF1E70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M01_L02:
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rsp+70]
       mov       [rsi+28],dil
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L04:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 198
```
**Method was not JITted yet.**
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderBy()
; 			var result = base.PersonProperCollection.OrderBy(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,1B05EE57960
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1B05EE57958
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1B05EE57960
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],rcx
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8,rbx
       xor       r9d,r9d
       call      System.Linq.OrderedEnumerable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>, Boolean, System.Linq.OrderedEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 193
```
```assembly
; System.Linq.OrderedEnumerable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>, Boolean, System.Linq.OrderedEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M01_L03
       test      rbx,rbx
       je        near ptr M01_L04
       lea       rcx,[rsi+10]
       mov       rdx,[rsp+78]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rbp
       test      rdx,rdx
       jne       short M01_L02
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       cmp       qword ptr [rdx+10],30
       jle       short M01_L00
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FE1E70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M01_L02:
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rsp+70]
       mov       [rsi+28],dil
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L04:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 198
```
**Method was not JITted yet.**
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderBy()
; 			var result = base.PersonProperCollection.OrderBy(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,22A5FAC2EF0
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,22A5FAC2EE8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,22A5FAC2EF0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],rcx
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8,rbx
       xor       r9d,r9d
       call      System.Linq.OrderedEnumerable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>, Boolean, System.Linq.OrderedEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 193
```
```assembly
; System.Linq.OrderedEnumerable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>, Boolean, System.Linq.OrderedEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M01_L03
       test      rbx,rbx
       je        near ptr M01_L04
       lea       rcx,[rsi+10]
       mov       rdx,[rsp+78]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rbp
       test      rdx,rdx
       jne       short M01_L02
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       cmp       qword ptr [rdx+10],30
       jle       short M01_L00
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB37011DF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M01_L02:
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rsp+70]
       mov       [rsi+28],dil
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L04:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 198
```
**Method was not JITted yet.**
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderBy()
; 			var result = base.PersonProperCollection.OrderBy(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,21C54BD7960
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,21C54BD7958
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,21C54BD7960
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],rcx
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8,rbx
       xor       r9d,r9d
       call      System.Linq.OrderedEnumerable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>, Boolean, System.Linq.OrderedEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 193
```
```assembly
; System.Linq.OrderedEnumerable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>, Boolean, System.Linq.OrderedEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M01_L03
       test      rbx,rbx
       je        near ptr M01_L04
       lea       rcx,[rsi+10]
       mov       rdx,[rsp+78]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rbp
       test      rdx,rdx
       jne       short M01_L02
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       cmp       qword ptr [rdx+10],30
       jle       short M01_L00
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB37001E50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M01_L02:
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rsp+70]
       mov       [rsi+28],dil
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L04:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 198
```
**Method was not JITted yet.**
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderBy()
; 			var result = base.PersonProperCollection.OrderBy(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,29D0F9E7960
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,29D0F9E7958
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,29D0F9E7960
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],rcx
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8,rbx
       xor       r9d,r9d
       call      System.Linq.OrderedEnumerable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>, Boolean, System.Linq.OrderedEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 193
```
```assembly
; System.Linq.OrderedEnumerable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>, Boolean, System.Linq.OrderedEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M01_L03
       test      rbx,rbx
       je        near ptr M01_L04
       lea       rcx,[rsi+10]
       mov       rdx,[rsp+78]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rbp
       test      rdx,rdx
       jne       short M01_L02
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       cmp       qword ptr [rdx+10],30
       jle       short M01_L00
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB37001FE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M01_L02:
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rsp+70]
       mov       [rsi+28],dil
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L04:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 198
```
**Method was not JITted yet.**
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderBy()
; 			var result = base.PersonProperCollection.OrderBy(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,19229C39978
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,19229C39970
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,19229C39978
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],rcx
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8,rbx
       xor       r9d,r9d
       call      System.Linq.OrderedEnumerable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>, Boolean, System.Linq.OrderedEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 193
```
```assembly
; System.Linq.OrderedEnumerable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>, Boolean, System.Linq.OrderedEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M01_L03
       test      rbx,rbx
       je        near ptr M01_L04
       lea       rcx,[rsi+10]
       mov       rdx,[rsp+78]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rbp
       test      rdx,rdx
       jne       short M01_L02
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       cmp       qword ptr [rdx+10],30
       jle       short M01_L00
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB37002260
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M01_L02:
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rsp+70]
       mov       [rsi+28],dil
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L04:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 198
```
**Method was not JITted yet.**
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderBy()
; 			var result = base.PersonProperCollection.OrderBy(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,1D4AE5AB990
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1D4AE5AB988
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1D4AE5AB990
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],rcx
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8,rbx
       xor       r9d,r9d
       call      System.Linq.OrderedEnumerable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>, Boolean, System.Linq.OrderedEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 193
```
```assembly
; System.Linq.OrderedEnumerable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>, Boolean, System.Linq.OrderedEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M01_L03
       test      rbx,rbx
       je        near ptr M01_L04
       lea       rcx,[rsi+10]
       mov       rdx,[rsp+78]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rbp
       test      rdx,rdx
       jne       short M01_L02
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       cmp       qword ptr [rdx+10],30
       jle       short M01_L00
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB37002260
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M01_L02:
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rsp+70]
       mov       [rsi+28],dil
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L04:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 198
```
**Method was not JITted yet.**
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderBy()
; 			var result = base.PersonProperCollection.OrderBy(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,1E96988BDC8
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1E96988BDC0
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1E96988BDC8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],rcx
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8,rbx
       xor       r9d,r9d
       call      System.Linq.OrderedEnumerable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>, Boolean, System.Linq.OrderedEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 193
```
```assembly
; System.Linq.OrderedEnumerable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>, Boolean, System.Linq.OrderedEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M01_L03
       test      rbx,rbx
       je        near ptr M01_L04
       lea       rcx,[rsi+10]
       mov       rdx,[rsp+78]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rbp
       test      rdx,rdx
       jne       short M01_L02
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       cmp       qword ptr [rdx+10],30
       jle       short M01_L00
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB37012260
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M01_L02:
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rsp+70]
       mov       [rsi+28],dil
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L04:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 198
```
**Method was not JITted yet.**
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderBy()
; 			var result = base.PersonProperCollection.OrderBy(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,152C1929DB0
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,152C1929DA8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,152C1929DB0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],rcx
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8,rbx
       xor       r9d,r9d
       call      System.Linq.OrderedEnumerable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>, Boolean, System.Linq.OrderedEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 193
```
```assembly
; System.Linq.OrderedEnumerable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>, Boolean, System.Linq.OrderedEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M01_L03
       test      rbx,rbx
       je        near ptr M01_L04
       lea       rcx,[rsi+10]
       mov       rdx,[rsp+78]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rbp
       test      rdx,rdx
       jne       short M01_L02
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       cmp       qword ptr [rdx+10],30
       jle       short M01_L00
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB37012080
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M01_L02:
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rsp+70]
       mov       [rsi+28],dil
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L04:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 198
```
**Method was not JITted yet.**
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderByOrdinal()
; 			var result = base.PersonProperCollection.OrderByOrdinal(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,247EACFBDD0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,247EACFBDC0
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,247EACFBDD0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,System.String>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 166
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       r8,247EACF3060
       mov       r8,[r8]
       mov       rdx,247FACF11A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,247EACF3060
       mov       r8,[r8]
       mov       rdx,247FACF11A8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,247EACF13A8
       mov       rbp,[rcx]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37000EF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
; Total bytes of code 161
```
**Method was not JITted yet.**
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderByOrdinal()
; 			var result = base.PersonProperCollection.OrderByOrdinal(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,2335BE09980
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2335BE09970
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2335BE09980
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,System.String>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 166
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       r8,2333BE03060
       mov       r8,[r8]
       mov       rdx,2336BE011A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,2333BE03060
       mov       r8,[r8]
       mov       rdx,2336BE011A8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,2333BE013A8
       mov       rbp,[rcx]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0EF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
; Total bytes of code 161
```
**Method was not JITted yet.**
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderByOrdinal()
; 			var result = base.PersonProperCollection.OrderByOrdinal(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,1A646E27968
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1A646E27958
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1A646E27968
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,System.String>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 166
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       r8,1A656E23060
       mov       r8,[r8]
       mov       rdx,1A646E2DBC8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,1A656E23060
       mov       r8,[r8]
       mov       rdx,1A646E2DBD0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,1A656E213A8
       mov       rbp,[rcx]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0EF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
; Total bytes of code 161
```
**Method was not JITted yet.**
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderByOrdinal()
; 			var result = base.PersonProperCollection.OrderByOrdinal(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,217CEA27968
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,217CEA27958
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,217CEA27968
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,System.String>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 166
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       r8,217BEA23060
       mov       r8,[r8]
       mov       rdx,217EEA211A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,217BEA23060
       mov       r8,[r8]
       mov       rdx,217EEA211A8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,217BEA213A8
       mov       rbp,[rcx]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37001308
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
; Total bytes of code 161
```
**Method was not JITted yet.**
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderByOrdinal()
; 			var result = base.PersonProperCollection.OrderByOrdinal(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,1BCFE3B9980
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1BCFE3B9970
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1BCFE3B9980
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,System.String>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 166
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       r8,1BCEE3B3060
       mov       r8,[r8]
       mov       rdx,1BD0E3B11A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,1BCEE3B3060
       mov       r8,[r8]
       mov       rdx,1BD0E3B11A8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,1BCEE3B13A8
       mov       rbp,[rcx]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1308
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
; Total bytes of code 161
```
**Method was not JITted yet.**
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderByOrdinal()
; 			var result = base.PersonProperCollection.OrderByOrdinal(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,25ECD447968
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,25ECD447958
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,25ECD447968
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,System.String>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 166
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       r8,25E9D443060
       mov       r8,[r8]
       mov       rdx,25ECD44DBC8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,25E9D443060
       mov       r8,[r8]
       mov       rdx,25ECD44DBD0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,25E9D4413A8
       mov       rbp,[rcx]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1080
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
; Total bytes of code 161
```
**Method was not JITted yet.**
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderByOrdinal()
; 			var result = base.PersonProperCollection.OrderByOrdinal(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,20AF59C9980
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,20AF59C9970
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,20AF59C9980
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,System.String>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 166
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       r8,20AD59C3060
       mov       r8,[r8]
       mov       rdx,20B059C11A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,20AD59C3060
       mov       r8,[r8]
       mov       rdx,20B059C11A8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,20AD59C13A8
       mov       rbp,[rcx]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37001308
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
; Total bytes of code 161
```
**Method was not JITted yet.**
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderByOrdinal()
; 			var result = base.PersonProperCollection.OrderByOrdinal(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,1A26FA09980
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1A26FA09970
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1A26FA09980
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,System.String>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 166
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       r8,1A28FA01048
       mov       r8,[r8]
       mov       rdx,1A29FA011A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,1A28FA01048
       mov       r8,[r8]
       mov       rdx,1A29FA011A8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,1A26FA013A8
       mov       rbp,[rcx]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37011308
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
; Total bytes of code 161
```
**Method was not JITted yet.**
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderByOrdinal()
; 			var result = base.PersonProperCollection.OrderByOrdinal(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,24BB2137968
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,24BB2137958
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,24BB2137968
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,System.String>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 166
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       r8,24BC2133060
       mov       r8,[r8]
       mov       rdx,24BB213E400
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,24BC2133060
       mov       r8,[r8]
       mov       rdx,24BB213E408
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,24BC21313A8
       mov       rbp,[rcx]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1308
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
; Total bytes of code 161
```
**Method was not JITted yet.**
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Page()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp+0FFF0],rax
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Page(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,rax
       mov       r11,7FFB36B00588
       call      qword ptr [7FFB36F10588]
       mov       [rbp+0FFF0],rax
; 			foreach (var people in base.PersonProperCollection.Page(10))
; 			                    ^^
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B00590
       call      qword ptr [7FFB36F10590]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B00598
       call      qword ptr [7FFB36F10598]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFB36B005A0
       call      qword ptr [7FFB36F105A0]
       mov       [rbp+0FFE8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B005B0
       call      qword ptr [7FFB36F105B0]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B005A8
       call      qword ptr [7FFB36F105A8]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B005B8
       call      qword ptr [7FFB36F105B8]
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B00590
       call      qword ptr [7FFB36F10590]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B005C0
       call      qword ptr [7FFB36F105C0]
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFE8],0
       je        short M00_L04
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B005B8
       call      qword ptr [7FFB36F105B8]
M00_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFF0],0
       je        short M00_L05
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B005C0
       call      qword ptr [7FFB36F105C0]
M00_L05:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 394
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FF12A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       mov       rcx,7FFB36BF0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M01_L02
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M01_L02:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [rbx+2C],eax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+34],edi
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Page()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp+0FFF0],rax
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Page(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,rax
       mov       r11,7FFB36AF0588
       call      qword ptr [7FFB36F00588]
       mov       [rbp+0FFF0],rax
; 			foreach (var people in base.PersonProperCollection.Page(10))
; 			                    ^^
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36AF0590
       call      qword ptr [7FFB36F00590]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36AF0598
       call      qword ptr [7FFB36F00598]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFB36AF05A0
       call      qword ptr [7FFB36F005A0]
       mov       [rbp+0FFE8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36AF05B0
       call      qword ptr [7FFB36F005B0]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36AF05A8
       call      qword ptr [7FFB36F005A8]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36AF05B8
       call      qword ptr [7FFB36F005B8]
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36AF0590
       call      qword ptr [7FFB36F00590]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36AF05C0
       call      qword ptr [7FFB36F005C0]
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFE8],0
       je        short M00_L04
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36AF05B8
       call      qword ptr [7FFB36F005B8]
M00_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFF0],0
       je        short M00_L05
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36AF05C0
       call      qword ptr [7FFB36F005C0]
M00_L05:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 394
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FE1248
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       mov       rcx,7FFB36BE0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M01_L02
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M01_L02:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [rbx+2C],eax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+34],edi
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Page()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp+0FFF0],rax
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Page(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,rax
       mov       r11,7FFB36B00588
       call      qword ptr [7FFB36F10588]
       mov       [rbp+0FFF0],rax
; 			foreach (var people in base.PersonProperCollection.Page(10))
; 			                    ^^
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B00590
       call      qword ptr [7FFB36F10590]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B00598
       call      qword ptr [7FFB36F10598]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFB36B005A0
       call      qword ptr [7FFB36F105A0]
       mov       [rbp+0FFE8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B005B0
       call      qword ptr [7FFB36F105B0]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B005A8
       call      qword ptr [7FFB36F105A8]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B005B8
       call      qword ptr [7FFB36F105B8]
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B00590
       call      qword ptr [7FFB36F10590]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B005C0
       call      qword ptr [7FFB36F105C0]
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFE8],0
       je        short M00_L04
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B005B8
       call      qword ptr [7FFB36F105B8]
M00_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFF0],0
       je        short M00_L05
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B005C0
       call      qword ptr [7FFB36F105C0]
M00_L05:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 394
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FF1248
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       mov       rcx,7FFB36BF0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M01_L02
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M01_L02:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [rbx+2C],eax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+34],edi
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Page()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp+0FFF0],rax
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Page(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,rax
       mov       r11,7FFB36AF0588
       call      qword ptr [7FFB36F00588]
       mov       [rbp+0FFF0],rax
; 			foreach (var people in base.PersonProperCollection.Page(10))
; 			                    ^^
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36AF0590
       call      qword ptr [7FFB36F00590]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36AF0598
       call      qword ptr [7FFB36F00598]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFB36AF05A0
       call      qword ptr [7FFB36F005A0]
       mov       [rbp+0FFE8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36AF05B0
       call      qword ptr [7FFB36F005B0]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36AF05A8
       call      qword ptr [7FFB36F005A8]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36AF05B8
       call      qword ptr [7FFB36F005B8]
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36AF0590
       call      qword ptr [7FFB36F00590]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36AF05C0
       call      qword ptr [7FFB36F005C0]
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFE8],0
       je        short M00_L04
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36AF05B8
       call      qword ptr [7FFB36F005B8]
M00_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFF0],0
       je        short M00_L05
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36AF05C0
       call      qword ptr [7FFB36F005C0]
M00_L05:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 394
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FE14D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       mov       rcx,7FFB36BE0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M01_L02
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M01_L02:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [rbx+2C],eax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+34],edi
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Page()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp+0FFF0],rax
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Page(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,rax
       mov       r11,7FFB36B20588
       call      qword ptr [7FFB36F30588]
       mov       [rbp+0FFF0],rax
; 			foreach (var people in base.PersonProperCollection.Page(10))
; 			                    ^^
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B20590
       call      qword ptr [7FFB36F30590]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B20598
       call      qword ptr [7FFB36F30598]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFB36B205A0
       call      qword ptr [7FFB36F305A0]
       mov       [rbp+0FFE8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B205B0
       call      qword ptr [7FFB36F305B0]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B205A8
       call      qword ptr [7FFB36F305A8]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B205B8
       call      qword ptr [7FFB36F305B8]
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B20590
       call      qword ptr [7FFB36F30590]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B205C0
       call      qword ptr [7FFB36F305C0]
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFE8],0
       je        short M00_L04
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B205B8
       call      qword ptr [7FFB36F305B8]
M00_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFF0],0
       je        short M00_L05
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B205C0
       call      qword ptr [7FFB36F305C0]
M00_L05:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 394
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB37011430
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       mov       rcx,7FFB36C10020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M01_L02
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M01_L02:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [rbx+2C],eax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+34],edi
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Page()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp+0FFF0],rax
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Page(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,rax
       mov       r11,7FFB36B00588
       call      qword ptr [7FFB36F10588]
       mov       [rbp+0FFF0],rax
; 			foreach (var people in base.PersonProperCollection.Page(10))
; 			                    ^^
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B00590
       call      qword ptr [7FFB36F10590]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B00598
       call      qword ptr [7FFB36F10598]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFB36B005A0
       call      qword ptr [7FFB36F105A0]
       mov       [rbp+0FFE8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B005B0
       call      qword ptr [7FFB36F105B0]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B005A8
       call      qword ptr [7FFB36F105A8]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B005B8
       call      qword ptr [7FFB36F105B8]
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B00590
       call      qword ptr [7FFB36F10590]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B005C0
       call      qword ptr [7FFB36F105C0]
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFE8],0
       je        short M00_L04
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B005B8
       call      qword ptr [7FFB36F105B8]
M00_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFF0],0
       je        short M00_L05
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B005C0
       call      qword ptr [7FFB36F105C0]
M00_L05:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 394
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FF1430
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       mov       rcx,7FFB36BF0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M01_L02
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M01_L02:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [rbx+2C],eax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+34],edi
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Page()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp+0FFF0],rax
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Page(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,rax
       mov       r11,7FFB36B10588
       call      qword ptr [7FFB36F20588]
       mov       [rbp+0FFF0],rax
; 			foreach (var people in base.PersonProperCollection.Page(10))
; 			                    ^^
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B10590
       call      qword ptr [7FFB36F20590]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B10598
       call      qword ptr [7FFB36F20598]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFB36B105A0
       call      qword ptr [7FFB36F205A0]
       mov       [rbp+0FFE8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B105B0
       call      qword ptr [7FFB36F205B0]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B105A8
       call      qword ptr [7FFB36F205A8]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B105B8
       call      qword ptr [7FFB36F205B8]
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B10590
       call      qword ptr [7FFB36F20590]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B105C0
       call      qword ptr [7FFB36F205C0]
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFE8],0
       je        short M00_L04
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B105B8
       call      qword ptr [7FFB36F205B8]
M00_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFF0],0
       je        short M00_L05
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B105C0
       call      qword ptr [7FFB36F205C0]
M00_L05:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 394
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB370014D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       mov       rcx,7FFB36C00020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M01_L02
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M01_L02:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [rbx+2C],eax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+34],edi
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Page()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp+0FFF0],rax
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Page(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,rax
       mov       r11,7FFB36B20588
       call      qword ptr [7FFB36F30588]
       mov       [rbp+0FFF0],rax
; 			foreach (var people in base.PersonProperCollection.Page(10))
; 			                    ^^
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B20590
       call      qword ptr [7FFB36F30590]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B20598
       call      qword ptr [7FFB36F30598]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFB36B205A0
       call      qword ptr [7FFB36F305A0]
       mov       [rbp+0FFE8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B205B0
       call      qword ptr [7FFB36F305B0]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B205A8
       call      qword ptr [7FFB36F305A8]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B205B8
       call      qword ptr [7FFB36F305B8]
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B20590
       call      qword ptr [7FFB36F30590]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B205C0
       call      qword ptr [7FFB36F305C0]
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFE8],0
       je        short M00_L04
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B205B8
       call      qword ptr [7FFB36F305B8]
M00_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFF0],0
       je        short M00_L05
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B205C0
       call      qword ptr [7FFB36F305C0]
M00_L05:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 394
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB370116B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       mov       rcx,7FFB36C10020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M01_L02
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M01_L02:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [rbx+2C],eax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+34],edi
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Page()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp+0FFF0],rax
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Page(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,rax
       mov       r11,7FFB36B10588
       call      qword ptr [7FFB36F20588]
       mov       [rbp+0FFF0],rax
; 			foreach (var people in base.PersonProperCollection.Page(10))
; 			                    ^^
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B10590
       call      qword ptr [7FFB36F20590]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B10598
       call      qword ptr [7FFB36F20598]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFB36B105A0
       call      qword ptr [7FFB36F205A0]
       mov       [rbp+0FFE8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B105B0
       call      qword ptr [7FFB36F205B0]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B105A8
       call      qword ptr [7FFB36F205A8]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B105B8
       call      qword ptr [7FFB36F205B8]
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B10590
       call      qword ptr [7FFB36F20590]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B105C0
       call      qword ptr [7FFB36F205C0]
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFE8],0
       je        short M00_L04
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB36B105B8
       call      qword ptr [7FFB36F205B8]
M00_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFF0],0
       je        short M00_L05
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB36B105C0
       call      qword ptr [7FFB36F205C0]
M00_L05:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 394
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB370016B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       mov       rcx,7FFB36C00020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M01_L02
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M01_L02:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [rbx+2C],eax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+34],edi
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom()
; 			var result = base.PersonProperCollection.Take(base.Count / 10);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+98]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0C0]
       mov       r8d,edx
       shr       r8d,1F
       sar       edx,2
       add       r8d,edx
       mov       rdx,rcx
       mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 84
```
```assembly
; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        short M01_L05
       test      edi,edi
       jle       short M01_L02
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FD22C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8d,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M01_L02:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdx,7FFB36FD2270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       mov       rcx,rdx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Empty[[System.__Canon, System.Private.CoreLib]]()
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 137
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom()
; 			var result = base.PersonProperCollection.Take(base.Count / 10);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+98]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0C0]
       mov       r8d,edx
       shr       r8d,1F
       sar       edx,2
       add       r8d,edx
       mov       rdx,rcx
       mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 84
```
```assembly
; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        short M01_L05
       test      edi,edi
       jle       short M01_L02
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB37002260
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8d,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M01_L02:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdx,7FFB37002210
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       mov       rcx,rdx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Empty[[System.__Canon, System.Private.CoreLib]]()
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 137
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom()
; 			var result = base.PersonProperCollection.Take(base.Count / 10);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+98]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0C0]
       mov       r8d,edx
       shr       r8d,1F
       sar       edx,2
       add       r8d,edx
       mov       rdx,rcx
       mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 84
```
```assembly
; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        short M01_L05
       test      edi,edi
       jle       short M01_L02
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB37002148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8d,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M01_L02:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdx,7FFB370020F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       mov       rcx,rdx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Empty[[System.__Canon, System.Private.CoreLib]]()
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 137
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom()
; 			var result = base.PersonProperCollection.Take(base.Count / 10);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+98]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0C0]
       mov       r8d,edx
       shr       r8d,1F
       sar       edx,2
       add       r8d,edx
       mov       rdx,rcx
       mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 84
```
```assembly
; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        short M01_L05
       test      edi,edi
       jle       short M01_L02
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FF22D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8d,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M01_L02:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdx,7FFB36FF2288
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       mov       rcx,rdx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Empty[[System.__Canon, System.Private.CoreLib]]()
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 137
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom()
; 			var result = base.PersonProperCollection.Take(base.Count / 10);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+98]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0C0]
       mov       r8d,edx
       shr       r8d,1F
       sar       edx,2
       add       r8d,edx
       mov       rdx,rcx
       mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 84
```
```assembly
; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        short M01_L05
       test      edi,edi
       jle       short M01_L02
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB370020E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8d,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M01_L02:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdx,7FFB37002098
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       mov       rcx,rdx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Empty[[System.__Canon, System.Private.CoreLib]]()
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 137
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom()
; 			var result = base.PersonProperCollection.Take(base.Count / 10);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+98]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0C0]
       mov       r8d,edx
       shr       r8d,1F
       sar       edx,2
       add       r8d,edx
       mov       rdx,rcx
       mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 84
```
```assembly
; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        short M01_L05
       test      edi,edi
       jle       short M01_L02
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB37002558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8d,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M01_L02:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdx,7FFB37002508
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       mov       rcx,rdx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Empty[[System.__Canon, System.Private.CoreLib]]()
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 137
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom()
; 			var result = base.PersonProperCollection.Take(base.Count / 10);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+98]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0C0]
       mov       r8d,edx
       shr       r8d,1F
       sar       edx,2
       add       r8d,edx
       mov       rdx,rcx
       mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 84
```
```assembly
; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        short M01_L05
       test      edi,edi
       jle       short M01_L02
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FF2558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8d,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M01_L02:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdx,7FFB36FF2508
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       mov       rcx,rdx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Empty[[System.__Canon, System.Private.CoreLib]]()
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 137
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom()
; 			var result = base.PersonProperCollection.Take(base.Count / 10);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+98]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0C0]
       mov       r8d,edx
       shr       r8d,1F
       sar       edx,2
       add       r8d,edx
       mov       rdx,rcx
       mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 84
```
```assembly
; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        short M01_L05
       test      edi,edi
       jle       short M01_L02
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FF2378
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8d,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M01_L02:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdx,7FFB36FF2328
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       mov       rcx,rdx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Empty[[System.__Canon, System.Private.CoreLib]]()
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 137
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom()
; 			var result = base.PersonProperCollection.Take(base.Count / 10);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+98]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0C0]
       mov       r8d,edx
       shr       r8d,1F
       sar       edx,2
       add       r8d,edx
       mov       rdx,rcx
       mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 84
```
```assembly
; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        short M01_L05
       test      edi,edi
       jle       short M01_L02
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FF2558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8d,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M01_L02:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdx,7FFB36FF2508
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       mov       rcx,rdx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Empty[[System.__Canon, System.Private.CoreLib]]()
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 137
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Shuffle()
; 			var result = base.PersonProperCollection.Shuffle();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,23147373060
       mov       r8,[r8]
       mov       rdx,231673711A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0EA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M01_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0EA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1028
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M01_L11
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__20`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__20_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0EA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M01_L08:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,rdi
       mov       r8,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
M01_L11:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 335
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Shuffle()
; 			var result = base.PersonProperCollection.Shuffle();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1A0EDF93060
       mov       r8,[r8]
       mov       rdx,1A11DF911A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0E48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M01_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0E48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0FC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M01_L11
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__20`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__20_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0E48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M01_L08:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0E88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,rdi
       mov       r8,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
M01_L11:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 335
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Shuffle()
; 			var result = base.PersonProperCollection.Shuffle();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,18C60121048
       mov       r8,[r8]
       mov       rdx,18C5012B170
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0EC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M01_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0EC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1048
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M01_L11
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__20`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__20_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0EC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M01_L08:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0F08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,rdi
       mov       r8,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
M01_L11:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 335
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Shuffle()
; 			var result = base.PersonProperCollection.Shuffle();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,2D374B23060
       mov       r8,[r8]
       mov       rdx,2D3A4B211A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0EA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M01_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0EA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1028
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M01_L11
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__20`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__20_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0EA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M01_L08:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,rdi
       mov       r8,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
M01_L11:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 335
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Shuffle()
; 			var result = base.PersonProperCollection.Shuffle();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1E4B46C3060
       mov       r8,[r8]
       mov       rdx,1E4B46C35F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF12B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M01_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FF12B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1438
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M01_L11
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__20`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__20_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FF12B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M01_L08:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFB36FF12F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,rdi
       mov       r8,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
M01_L11:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 335
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Shuffle()
; 			var result = base.PersonProperCollection.Shuffle();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,2461FB03060
       mov       r8,[r8]
       mov       rdx,2460FB011A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0E48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M01_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0E48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0FC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M01_L11
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__20`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__20_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0E48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M01_L08:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0E88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,rdi
       mov       r8,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
M01_L11:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 335
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Shuffle()
; 			var result = base.PersonProperCollection.Shuffle();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,2DE98D93060
       mov       r8,[r8]
       mov       rdx,2DEC8D919D8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB370012B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M01_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB370012B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB37001438
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M01_L11
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__20`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__20_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB370012B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M01_L08:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFB370012F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,rdi
       mov       r8,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
M01_L11:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 335
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Shuffle()
; 			var result = base.PersonProperCollection.Shuffle();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1F537653060
       mov       r8,[r8]
       mov       rdx,1F5676511A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37000EA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M01_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB37000EA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB37001028
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M01_L11
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__20`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__20_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB37000EA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M01_L08:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFB37000EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,rdi
       mov       r8,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
M01_L11:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 335
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Shuffle()
; 			var result = base.PersonProperCollection.Shuffle();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,16B3C6E3060
       mov       r8,[r8]
       mov       rdx,16B5C6F0418
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF12B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M01_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FF12B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1438
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M01_L11
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ListExtensions+<>c__20`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__20_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FF12B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M01_L08:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFB36FF12F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,rdi
       mov       r8,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
M01_L11:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 335
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToObservableCollection()
; 			var result = base.PersonProperCollection.ToObservableCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,18430623060
       mov       r8,[r8]
       mov       rdx,184306235F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE5B58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToObservableCollection()
; 			var result = base.PersonProperCollection.ToObservableCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,29F84053060
       mov       r8,[r8]
       mov       rdx,29F840535F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37015B78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToObservableCollection()
; 			var result = base.PersonProperCollection.ToObservableCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,2529E9B3060
       mov       r8,[r8]
       mov       rdx,2528E9B11A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37005B78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToObservableCollection()
; 			var result = base.PersonProperCollection.ToObservableCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,2177F9C3060
       mov       r8,[r8]
       mov       rdx,217AF9C11A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF5CE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToObservableCollection()
; 			var result = base.PersonProperCollection.ToObservableCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,28630863060
       mov       r8,[r8]
       mov       rdx,286608611A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37005D88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToObservableCollection()
; 			var result = base.PersonProperCollection.ToObservableCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1A936AA3060
       mov       r8,[r8]
       mov       rdx,1A936AB2030
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE5F68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToObservableCollection()
; 			var result = base.PersonProperCollection.ToObservableCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,2ACF4953060
       mov       r8,[r8]
       mov       rdx,2ACE495E400
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37005D88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToObservableCollection()
; 			var result = base.PersonProperCollection.ToObservableCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,195A71B3060
       mov       r8,[r8]
       mov       rdx,195C71B39F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37005F68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToObservableCollection()
; 			var result = base.PersonProperCollection.ToObservableCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,18E73DD1048
       mov       r8,[r8]
       mov       rdx,18E53DD31B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37015F68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToReadOnlyCollection()
; 			var result = base.PersonProperCollection.ToReadOnlyCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,18EE55A3060
       mov       r8,[r8]
       mov       rdx,18ED55A11A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FE1738
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M01_L02
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 133
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToReadOnlyCollection()
; 			var result = base.PersonProperCollection.ToReadOnlyCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,25F37073060
       mov       r8,[r8]
       mov       rdx,25F270711A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF1738
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M01_L02
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 133
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToReadOnlyCollection()
; 			var result = base.PersonProperCollection.ToReadOnlyCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,24F53A53060
       mov       r8,[r8]
       mov       rdx,24F33A519D8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FE16D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M01_L02
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 133
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToReadOnlyCollection()
; 			var result = base.PersonProperCollection.ToReadOnlyCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,199A85F3060
       mov       r8,[r8]
       mov       rdx,199B85F19D8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF1738
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M01_L02
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 133
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToReadOnlyCollection()
; 			var result = base.PersonProperCollection.ToReadOnlyCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1EE07AF3060
       mov       r8,[r8]
       mov       rdx,1EE37AF11A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF1968
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M01_L02
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 133
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToReadOnlyCollection()
; 			var result = base.PersonProperCollection.ToReadOnlyCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,236E2F73060
       mov       r8,[r8]
       mov       rdx,236F2F711A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FE18C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M01_L02
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 133
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToReadOnlyCollection()
; 			var result = base.PersonProperCollection.ToReadOnlyCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,151B84A3060
       mov       r8,[r8]
       mov       rdx,151D84C7060
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37001B48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M01_L02
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 133
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToReadOnlyCollection()
; 			var result = base.PersonProperCollection.ToReadOnlyCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,17E1FA23060
       mov       r8,[r8]
       mov       rdx,17E2FA211A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37001B48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M01_L02
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 133
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToReadOnlyCollection()
; 			var result = base.PersonProperCollection.ToReadOnlyCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,229399D3060
       mov       r8,[r8]
       mov       rdx,229399E2030
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37011968
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M01_L02
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 133
```

