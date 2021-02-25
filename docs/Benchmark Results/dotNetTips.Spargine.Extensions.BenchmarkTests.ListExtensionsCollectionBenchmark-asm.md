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
       mov       rdx,[rsi+0A0]
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
       mov       r8,25575FE3060
       mov       r8,[r8]
       mov       rdx,25585FE19F0
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
       mov       rdx,7FFB1724F170
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
       mov       rdx,7FFB1724F5B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,25575FE3060
       mov       r8,[r8]
       mov       rdx,25585FE19F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M02_L02
       mov       rcx,[rbx+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1724F728
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
       mov       rdx,7FFB1724F958
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
       mov       rdx,7FFB1724F958
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
       mov       rdx,7FFB1724FEB0
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
       mov       rdx,7FFB1724F958
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
       mov       rdx,7FFB1724F998
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
       mov       rdx,7FFB1724FCC8
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
       mov       rdx,7FFB1724FD70
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,223131E1048
       mov       r8,[r8]
       mov       rdx,223031E31D0
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
       mov       rdx,7FFB1723F170
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
       mov       rdx,7FFB1723F5B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,223131E1048
       mov       r8,[r8]
       mov       rdx,223031E31D0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M02_L02
       mov       rcx,[rbx+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1723F728
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
       mov       rdx,7FFB1723F958
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
       mov       rdx,7FFB1723F958
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
       mov       rdx,7FFB1723FEB0
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
       mov       rdx,7FFB1723F958
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
       mov       rdx,7FFB1723F998
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
       mov       rdx,7FFB1723FCC8
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
       mov       rdx,7FFB1723FD70
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,1F84ED03060
       mov       r8,[r8]
       mov       rdx,1F85ED011B8
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
       mov       rdx,7FFB1721F170
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
       mov       rdx,7FFB1721F5B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,1F84ED03060
       mov       r8,[r8]
       mov       rdx,1F85ED011B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M02_L02
       mov       rcx,[rbx+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1721F728
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
       mov       rdx,7FFB1721F958
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
       mov       rdx,7FFB1721F958
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
       mov       rdx,7FFB1721FEB0
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
       mov       rdx,7FFB1721F958
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
       mov       rdx,7FFB1721F998
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
       mov       rdx,7FFB1721FCC8
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
       mov       rdx,7FFB1721FD70
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,1DEF2F33060
       mov       r8,[r8]
       mov       rdx,1DEF2F33E40
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
       mov       rdx,7FFB1722F170
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
       mov       rdx,7FFB1722F5B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,1DEF2F33060
       mov       r8,[r8]
       mov       rdx,1DEF2F33E40
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M02_L02
       mov       rcx,[rbx+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1722F728
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
       mov       rdx,7FFB1722F958
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
       mov       rdx,7FFB1722F958
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
       mov       rdx,7FFB1722FEB0
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
       mov       rdx,7FFB1722F958
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
       mov       rdx,7FFB1722F998
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
       mov       rdx,7FFB1722FCC8
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
       mov       rdx,7FFB1722FD70
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,16DC9D83060
       mov       r8,[r8]
       mov       rdx,16DE9D811B8
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
       mov       rdx,7FFB1721F228
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
       mov       rdx,7FFB1721F670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,16DC9D83060
       mov       r8,[r8]
       mov       rdx,16DE9D811B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M02_L02
       mov       rcx,[rbx+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1721F7E0
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
       mov       rdx,7FFB1721FA10
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
       mov       rdx,7FFB1721FA10
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
       mov       rdx,7FFB1721FF68
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
       mov       rdx,7FFB1721FA10
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
       mov       rdx,7FFB1721FA50
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
       mov       rdx,7FFB1721FD80
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
       mov       rdx,7FFB1721FE28
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,14E6C4A3060
       mov       r8,[r8]
       mov       rdx,14E5C4ADD90
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
       mov       rdx,7FFB1721F170
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
       mov       rdx,7FFB1721F5B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,14E6C4A3060
       mov       r8,[r8]
       mov       rdx,14E5C4ADD90
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M02_L02
       mov       rcx,[rbx+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1721F728
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
       mov       rdx,7FFB1721F958
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
       mov       rdx,7FFB1721F958
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
       mov       rdx,7FFB1721FEB0
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
       mov       rdx,7FFB1721F958
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
       mov       rdx,7FFB1721F998
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
       mov       rdx,7FFB1721FCC8
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
       mov       rdx,7FFB1721FD70
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,2A8CE991048
       mov       r8,[r8]
       mov       rdx,2A8DE9B05F0
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
       mov       rdx,7FFB1723F2F8
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
       mov       rdx,7FFB1723F740
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,2A8CE991048
       mov       r8,[r8]
       mov       rdx,2A8DE9B05F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M02_L02
       mov       rcx,[rbx+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1723F8B0
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
       mov       rdx,7FFB1723FAE0
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
       mov       rdx,7FFB1723FAE0
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
       mov       rdx,7FFB17260068
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
       mov       rdx,7FFB1723FAE0
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
       mov       rdx,7FFB1723FB20
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
       mov       rdx,7FFB1723FE50
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
       mov       rdx,7FFB1723FEF8
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,296DCC93060
       mov       r8,[r8]
       mov       rdx,296CCC9DD90
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
       mov       rdx,7FFB1721F4B8
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
       mov       rdx,7FFB1721F900
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,296DCC93060
       mov       r8,[r8]
       mov       rdx,296CCC9DD90
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M02_L02
       mov       rcx,[rbx+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1721FA70
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
       mov       rdx,7FFB1721FCA0
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
       mov       rdx,7FFB1721FCA0
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
       mov       rdx,7FFB17240290
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
       mov       rdx,7FFB1721FCA0
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
       mov       rdx,7FFB1721FCE0
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
       mov       rdx,7FFB172400A8
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
       mov       rdx,7FFB17240150
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,188941F3060
       mov       r8,[r8]
       mov       rdx,188A41F31D0
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
       mov       rdx,7FFB1723F170
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
       mov       rdx,7FFB1723F5B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,188941F3060
       mov       r8,[r8]
       mov       rdx,188A41F31D0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M02_L02
       mov       rcx,[rbx+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1723F728
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
       mov       rdx,7FFB1723F958
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
       mov       rdx,7FFB1723F958
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
       mov       rdx,7FFB1723FEB0
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
       mov       rdx,7FFB1723F958
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
       mov       rdx,7FFB1723F998
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
       mov       rdx,7FFB1723FCC8
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
       mov       rdx,7FFB1723FD70
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
       mov       rdx,[rsi+0A0]
       mov       r8d,[rsi+0D0]
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
       mov       r8,2C766EB3060
       mov       r8,[r8]
       mov       rdx,2C796EB11B8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,2C766EB3060
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
       mov       rdx,2C766EB3450
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
       mov       rdx,7FFB1721E768
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
       mov       rdx,7FFB1721E7B8
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
       mov       rdx,[rsi+0A0]
       mov       r8d,[rsi+0D0]
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
       mov       r8,25922E53060
       mov       r8,[r8]
       mov       rdx,25952E511B8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,25922E53060
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
       mov       rdx,25922E53450
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
       mov       rdx,7FFB1721E768
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
       mov       rdx,7FFB1721E7B8
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
       mov       rdx,[rsi+0A0]
       mov       r8d,[rsi+0D0]
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
       mov       r8,27BF8801048
       mov       r8,[r8]
       mov       rdx,27C088011B8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,27BF8801048
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
       mov       rdx,27BF8801438
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
       mov       rdx,7FFB1723E820
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
       mov       rdx,7FFB1723E870
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
       mov       rdx,[rsi+0A0]
       mov       r8d,[rsi+0D0]
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
       mov       r8,2739F513060
       mov       r8,[r8]
       mov       rdx,2737F5119F0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,2739F513060
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
       mov       rdx,2739F513450
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
       mov       rdx,7FFB1724E820
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
       mov       rdx,7FFB1724E870
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
       mov       rdx,[rsi+0A0]
       mov       r8d,[rsi+0D0]
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
       mov       r8,1EEAC623060
       mov       r8,[r8]
       mov       rdx,1EECC6211B8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,1EEAC623060
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
       mov       rdx,1EEAC623450
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
       mov       rdx,7FFB1721E820
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
       mov       rdx,7FFB1721E870
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
       mov       rdx,[rsi+0A0]
       mov       r8d,[rsi+0D0]
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
       mov       r8,1EFE3833060
       mov       r8,[r8]
       mov       rdx,1EFE3842A30
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,1EFE3833060
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
       mov       rdx,1EFE3833450
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
       mov       rdx,7FFB1721E820
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
       mov       rdx,7FFB1721E870
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
       mov       rdx,[rsi+0A0]
       mov       r8d,[rsi+0D0]
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
       mov       r8,260900A3060
       mov       r8,[r8]
       mov       rdx,260800A11B8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,260900A3060
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
       mov       rdx,260900A3450
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
       mov       rdx,7FFB1724EAB0
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
       mov       rdx,7FFB1724EB00
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
       mov       rdx,[rsi+0A0]
       mov       r8d,[rsi+0D0]
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
       mov       r8,1DD37E61048
       mov       r8,[r8]
       mov       rdx,1DD17E63A08
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,1DD37E61048
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
       mov       rdx,1DD37E61438
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
       mov       rdx,7FFB1722E8F0
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
       mov       rdx,7FFB1722E940
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
       mov       rdx,[rsi+0A0]
       mov       r8d,[rsi+0D0]
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
       mov       r8,2C453D01048
       mov       r8,[r8]
       mov       rdx,2C463D80208
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,2C453D01048
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
       mov       rdx,2C453D01438
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
       mov       rdx,7FFB1723E768
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
       mov       rdx,7FFB1723E7B8
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
       mov       rdx,[rsi+90]
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
       mov       r8,18462C43060
       mov       r8,[r8]
       mov       rdx,18482C41788
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
       mov       rdx,7FFB1724E490
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
       mov       r8,18482C41788
       mov       r8,[r8]
       mov       r9,18462C43060
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
       mov       rdx,7FFB1724E7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17186080]
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
       mov       rdx,[rsi+90]
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
       mov       r8,2786B973060
       mov       r8,[r8]
       mov       rdx,2786B975BF0
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
       mov       rdx,7FFB1721E618
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
       mov       r8,2786B975BF0
       mov       r8,[r8]
       mov       r9,2786B973060
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
       mov       rdx,7FFB1721E948
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17156080]
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
       mov       rdx,[rsi+90]
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
       mov       r8,1C3F0293060
       mov       r8,[r8]
       mov       rdx,1C420291788
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
       mov       rdx,7FFB1724E490
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
       mov       r8,1C420291788
       mov       r8,[r8]
       mov       r9,1C3F0293060
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
       mov       rdx,7FFB1724E7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17186080]
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
       mov       rdx,[rsi+90]
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
       mov       r8,1F328FB3060
       mov       r8,[r8]
       mov       rdx,1F328FB3BD8
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
       mov       rdx,7FFB1724E490
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
       mov       r8,1F328FB3BD8
       mov       r8,[r8]
       mov       r9,1F328FB3060
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
       mov       rdx,7FFB1724E7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17186080]
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
       mov       rdx,[rsi+90]
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
       mov       r8,1F4DA8A3060
       mov       r8,[r8]
       mov       rdx,1F4BA8A1788
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
       mov       rdx,7FFB1721E7D8
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
       mov       r8,1F4BA8A1788
       mov       r8,[r8]
       mov       r9,1F4DA8A3060
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
       mov       rdx,7FFB1721EB08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17156080]
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
       mov       rdx,[rsi+90]
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
       mov       r8,18E44543060
       mov       r8,[r8]
       mov       rdx,18E34541788
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
       mov       rdx,7FFB1724E7D8
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
       mov       r8,18E34541788
       mov       r8,[r8]
       mov       r9,18E44543060
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
       mov       rdx,7FFB1724EB08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17186080]
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
       mov       rdx,[rsi+90]
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
       mov       r8,23DB1363060
       mov       r8,[r8]
       mov       rdx,23D91361788
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
       mov       rdx,7FFB1723E7D8
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
       mov       r8,23D91361788
       mov       r8,[r8]
       mov       r9,23DB1363060
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
       mov       rdx,7FFB1723EB08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17176080]
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
       mov       rdx,[rsi+90]
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
       mov       r8,1E180B13060
       mov       r8,[r8]
       mov       rdx,1E170B11788
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
       mov       rdx,7FFB1724E7D8
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
       mov       r8,1E170B11788
       mov       r8,[r8]
       mov       r9,1E180B13060
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
       mov       rdx,7FFB1724EB08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17186080]
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
       mov       rdx,[rsi+90]
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
       mov       r8,22BFE3C3060
       mov       r8,[r8]
       mov       rdx,22BFE3C3BD8
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
       mov       rdx,7FFB1724E7D8
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
       mov       r8,22BFE3C3BD8
       mov       r8,[r8]
       mov       r9,22BFE3C3060
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
       mov       rdx,7FFB1724EB08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17186080]
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,13B7CFA3060
       mov       r8,[r8]
       mov       rdx,13B9CFA11B8
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
       mov       rdx,7FFB1724EB20
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
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       r8,13B7CFA3060
       mov       r8,[r8]
       mov       rdx,13B9CFA11B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbp,[rdi+10]
       mov       r11,[rbp+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB1724ED88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,13B7CFA3060
       mov       r9,[r9]
       mov       r8,13B9CFA11B8
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       test      rbx,rbx
       jne       short M02_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFB1724EF80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFB1724EF98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,24464193060
       mov       r8,[r8]
       mov       rdx,2445419DD90
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
       mov       rdx,7FFB1724EBD8
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
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       r8,24464193060
       mov       r8,[r8]
       mov       rdx,2445419DD90
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbp,[rdi+10]
       mov       r11,[rbp+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB1724EE40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,24464193060
       mov       r9,[r9]
       mov       r8,2445419DD90
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       test      rbx,rbx
       jne       short M02_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFB1724F038
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFB1724F050
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,22BD5753060
       mov       r8,[r8]
       mov       rdx,22BD5753608
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
       mov       rdx,7FFB1720EB20
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
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       r8,22BD5753060
       mov       r8,[r8]
       mov       rdx,22BD5753608
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbp,[rdi+10]
       mov       r11,[rbp+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB1720ED88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,22BD5753060
       mov       r9,[r9]
       mov       r8,22BD5753608
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       test      rbx,rbx
       jne       short M02_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFB1720EF80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFB1720EF98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,1CA4CE13060
       mov       r8,[r8]
       mov       rdx,1CA6CE111B8
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
       mov       rdx,7FFB1722EE68
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
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       r8,1CA4CE13060
       mov       r8,[r8]
       mov       rdx,1CA6CE111B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbp,[rdi+10]
       mov       r11,[rbp+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB1722F0D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1CA4CE13060
       mov       r9,[r9]
       mov       r8,1CA6CE111B8
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       test      rbx,rbx
       jne       short M02_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFB1722F2C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFB1722F2E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,1E7180E3060
       mov       r8,[r8]
       mov       rdx,1E7080E19F0
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
       mov       rdx,7FFB1721EE68
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
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       r8,1E7180E3060
       mov       r8,[r8]
       mov       rdx,1E7080E19F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbp,[rdi+10]
       mov       r11,[rbp+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB1721F0D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1E7180E3060
       mov       r9,[r9]
       mov       r8,1E7080E19F0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       test      rbx,rbx
       jne       short M02_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFB1721F2C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFB1721F2E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,19F9EFC3060
       mov       r8,[r8]
       mov       rdx,19F8EFCDD90
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
       mov       rdx,7FFB1724EE68
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
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       r8,19F9EFC3060
       mov       r8,[r8]
       mov       rdx,19F8EFCDD90
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbp,[rdi+10]
       mov       r11,[rbp+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB1724F0D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,19F9EFC3060
       mov       r9,[r9]
       mov       r8,19F8EFCDD90
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       test      rbx,rbx
       jne       short M02_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFB1724F2C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFB1724F2E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,21C13821048
       mov       r8,[r8]
       mov       rdx,21C0382FDA8
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
       mov       rdx,7FFB1722EBD8
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
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       r8,21C13821048
       mov       r8,[r8]
       mov       rdx,21C0382FDA8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbp,[rdi+10]
       mov       r11,[rbp+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB1722EE40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,21C13821048
       mov       r9,[r9]
       mov       r8,21C0382FDA8
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       test      rbx,rbx
       jne       short M02_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFB1722F038
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFB1722F050
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,25225743060
       mov       r8,[r8]
       mov       rdx,252557411B8
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
       mov       rdx,7FFB1723EE68
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
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       r8,25225743060
       mov       r8,[r8]
       mov       rdx,252557411B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbp,[rdi+10]
       mov       r11,[rbp+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB1723F0D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,25225743060
       mov       r9,[r9]
       mov       r8,252557411B8
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       test      rbx,rbx
       jne       short M02_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFB1723F2C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFB1723F2E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,1747EB43060
       mov       r8,[r8]
       mov       rdx,174AEB411B8
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
       mov       rdx,7FFB1724EE68
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
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       r8,1747EB43060
       mov       r8,[r8]
       mov       rdx,174AEB411B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbp,[rdi+10]
       mov       r11,[rbp+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB1724F0D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1747EB43060
       mov       r9,[r9]
       mov       r8,174AEB411B8
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       test      rbx,rbx
       jne       short M02_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFB1724F2C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFB1724F2E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
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
       mov       rdx,[rsi+90]
       mov       r8,[rsi+98]
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
       mov       rdx,[rsi+90]
       mov       r8,[rsi+98]
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
       mov       rdx,[rsi+90]
       mov       r8,[rsi+98]
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
       mov       rdx,[rsi+90]
       mov       r8,[rsi+98]
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
       mov       rdx,[rsi+90]
       mov       r8,[rsi+98]
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
       mov       rdx,[rsi+90]
       mov       r8,[rsi+98]
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
       mov       rdx,[rsi+90]
       mov       r8,[rsi+98]
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
       mov       rdx,[rsi+90]
       mov       r8,[rsi+98]
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
       mov       rdx,[rsi+90]
       mov       r8,[rsi+98]
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
       mov       rdx,[rsi+0A0]
       mov       r8,[rsi+0B0]
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
       mov       rdx,7FFB1724E6B8
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
       mov       rdx,7FFB1724E6B8
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
       mov       rdx,7FFB1724E820
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
       mov       rdx,7FFB1724E820
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
       mov       rdx,7FFB1724E6B8
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
       mov       rdx,[rsi+0A0]
       mov       r8,[rsi+0B0]
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
       mov       rdx,7FFB1721E6B8
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
       mov       rdx,7FFB1721E6B8
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
       mov       rdx,7FFB1721E820
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
       mov       rdx,7FFB1721E820
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
       mov       rdx,7FFB1721E6B8
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
       mov       rdx,[rsi+0A0]
       mov       r8,[rsi+0B0]
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
       mov       rdx,7FFB1723E6B8
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
       mov       rdx,7FFB1723E6B8
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
       mov       rdx,7FFB1723E820
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
       mov       rdx,7FFB1723E820
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
       mov       rdx,7FFB1723E6B8
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
       mov       rdx,[rsi+0A0]
       mov       r8,[rsi+0B0]
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
       mov       rdx,7FFB1722E770
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
       mov       rdx,7FFB1722E770
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
       mov       rdx,7FFB1722E8D8
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
       mov       rdx,7FFB1722E8D8
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
       mov       rdx,7FFB1722E770
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
       mov       rdx,[rsi+0A0]
       mov       r8,[rsi+0B0]
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
       mov       rdx,7FFB1721EA00
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
       mov       rdx,7FFB1721EA00
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
       mov       rdx,7FFB1721EB68
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
       mov       rdx,7FFB1721EB68
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
       mov       rdx,7FFB1721EA00
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
       mov       rdx,[rsi+0A0]
       mov       r8,[rsi+0B0]
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
       mov       rdx,7FFB1723EA00
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
       mov       rdx,7FFB1723EA00
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
       mov       rdx,7FFB1723EB68
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
       mov       rdx,7FFB1723EB68
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
       mov       rdx,7FFB1723EA00
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
       mov       rdx,[rsi+0A0]
       mov       r8,[rsi+0B0]
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
       mov       rdx,7FFB1722EA00
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
       mov       rdx,7FFB1722EA00
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
       mov       rdx,7FFB1722EB68
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
       mov       rdx,7FFB1722EB68
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
       mov       rdx,7FFB1722EA00
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
       mov       rdx,[rsi+0A0]
       mov       r8,[rsi+0B0]
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
       mov       rdx,7FFB1721EA00
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
       mov       rdx,7FFB1721EA00
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
       mov       rdx,7FFB1721EB68
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
       mov       rdx,7FFB1721EB68
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
       mov       rdx,7FFB1721EA00
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
       mov       rdx,[rsi+0A0]
       mov       r8,[rsi+0B0]
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
       mov       rdx,7FFB1722EA00
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
       mov       rdx,7FFB1722EA00
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
       mov       rdx,7FFB1722EB68
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
       mov       rdx,7FFB1722EB68
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
       mov       rdx,7FFB1722EA00
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
       mov       rdi,[rsi+0A0]
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
       call      qword ptr [7FFB76607AC0]
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      qword ptr [7FFB766110A0]
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
       mov       rdx,7FFB1721ECB8
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
       mov       rdx,7FFB1721ECB8
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
       mov       rdx,7FFB1721F210
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
       mov       rdx,7FFB1721ECB8
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
       mov       rdi,[rsi+0A0]
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
       call      qword ptr [7FFB76607AC0]
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      qword ptr [7FFB766110A0]
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
       mov       rdx,7FFB1721ECB8
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
       mov       rdx,7FFB1721ECB8
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
       mov       rdx,7FFB1721F210
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
       mov       rdx,7FFB1721ECB8
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
       mov       rdi,[rsi+0A0]
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
       call      qword ptr [7FFB76607AC0]
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      qword ptr [7FFB766110A0]
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
       mov       rdx,7FFB1723ECB8
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
       mov       rdx,7FFB1723ECB8
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
       mov       rdx,7FFB1723F210
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
       mov       rdx,7FFB1723ECB8
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
       mov       rdi,[rsi+0A0]
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
       call      qword ptr [7FFB76607AC0]
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      qword ptr [7FFB766110A0]
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
       mov       rdx,7FFB1722ECB8
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
       mov       rdx,7FFB1722ECB8
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
       mov       rdx,7FFB1722F210
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
       mov       rdx,7FFB1722ECB8
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
       mov       rdi,[rsi+0A0]
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
       call      qword ptr [7FFB76607AC0]
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      qword ptr [7FFB766110A0]
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
       mov       rdx,7FFB1721EE40
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
       mov       rdx,7FFB1721EE40
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
       mov       rdx,7FFB1721F398
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
       mov       rdx,7FFB1721EE40
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
       mov       rdi,[rsi+0A0]
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
       call      qword ptr [7FFB76607AC0]
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      qword ptr [7FFB766110A0]
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
       mov       rdx,7FFB1723F000
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
       mov       rdx,7FFB1723F000
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
       mov       rdx,7FFB1723F558
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
       mov       rdx,7FFB1723F000
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
       mov       rdi,[rsi+0A0]
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
       call      qword ptr [7FFB76607AC0]
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      qword ptr [7FFB766110A0]
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
       mov       rdx,7FFB1724F000
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
       mov       rdx,7FFB1724F000
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
       mov       rdx,7FFB1724F558
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
       mov       rdx,7FFB1724F000
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
       mov       rdi,[rsi+0A0]
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
       call      qword ptr [7FFB76607AC0]
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      qword ptr [7FFB766110A0]
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
       mov       rdx,7FFB1724ED70
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
       mov       rdx,7FFB1724ED70
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
       mov       rdx,7FFB1724F2C8
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
       mov       rdx,7FFB1724ED70
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
       mov       rdi,[rsi+0A0]
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
       call      qword ptr [7FFB76607AC0]
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      qword ptr [7FFB766110A0]
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
       mov       rdx,7FFB1723F000
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
       mov       rdx,7FFB1723F000
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
       mov       rdx,7FFB1723F558
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
       mov       rdx,7FFB1723F000
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,29F68783060
       mov       r8,[r8]
       mov       rdx,29F5878DD90
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
       mov       rdx,7FFB1721EAE8
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,1D837841048
       mov       r8,[r8]
       mov       rdx,1D817843A08
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
       mov       rdx,7FFB1723EAE8
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,1D125FE3060
       mov       r8,[r8]
       mov       rdx,1D135FE11B8
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
       mov       rdx,7FFB1723EAE8
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,1A4EAC63060
       mov       r8,[r8]
       mov       rdx,1A4FAC611B8
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
       mov       rdx,7FFB1722EBA0
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,20F0C353060
       mov       r8,[r8]
       mov       rdx,20F1C3511B8
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
       mov       rdx,7FFB1721EE30
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,1C2A0B13060
       mov       r8,[r8]
       mov       rdx,1C2A0B13608
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
       mov       rdx,7FFB1723EC70
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,1ACC8683060
       mov       r8,[r8]
       mov       rdx,1ACD86819F0
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
       mov       rdx,7FFB1724EE30
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,25EC3EE3060
       mov       r8,[r8]
       mov       rdx,25EF3F1F9F0
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
       mov       rdx,7FFB1721EE30
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,1572FC63060
       mov       r8,[r8]
       mov       rdx,1574FC6FDA8
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
       mov       rdx,7FFB1723EC70
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB17260B18
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
       mov       rdx,7FFB17260180
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB17250A78
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
       mov       rdx,7FFB172500E0
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB17250A78
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
       mov       rdx,7FFB172500E0
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB17270B18
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
       mov       rdx,7FFB17270180
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB17280BA8
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
       mov       rdx,7FFB17280210
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB17270BA8
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
       mov       rdx,7FFB17270210
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB17260D50
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
       mov       rdx,7FFB172603B8
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB17260A78
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
       mov       rdx,7FFB172600E0
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB17270A28
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
       mov       rdx,7FFB172700E0
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB17255E78
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
       mov       rdx,7FFB1722EA10
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
       mov       r8,21CC6A83060
       mov       r8,[r8]
       mov       rdx,21CD6A811B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[r15+10]
       mov       rdx,21CD6A811C0
       mov       rdx,[rdx]
       mov       r8,21CC6A83060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r15+8]
       mov       rdx,21CD6A811C8
       mov       rdx,[rdx]
       mov       r8,21CC6A83060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1722EB70
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
       mov       rdx,7FFB1722ECD8
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
       mov       rdx,7FFB1722F038
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
       mov       rdx,7FFB1722F038
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
       mov       rdx,7FFB1722F038
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB17255E78
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
       mov       rdx,7FFB1722EA10
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
       mov       r8,1DD18513060
       mov       r8,[r8]
       mov       rdx,1DD485111B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[r15+10]
       mov       rdx,1DD485111C0
       mov       rdx,[rdx]
       mov       r8,1DD18513060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r15+8]
       mov       rdx,1DD485111C8
       mov       rdx,[rdx]
       mov       r8,1DD18513060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1722EB70
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
       mov       rdx,7FFB1722ECD8
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
       mov       rdx,7FFB1722F038
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
       mov       rdx,7FFB1722F038
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
       mov       rdx,7FFB1722F038
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB17255E78
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
       mov       rdx,7FFB1722EA10
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
       mov       r8,28866543060
       mov       r8,[r8]
       mov       rdx,2885654DD90
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[r15+10]
       mov       rdx,2885654DD98
       mov       rdx,[rdx]
       mov       r8,28866543060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r15+8]
       mov       rdx,2885654DDA0
       mov       rdx,[rdx]
       mov       r8,28866543060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1722EB70
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
       mov       rdx,7FFB1722ECD8
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
       mov       rdx,7FFB1722F038
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
       mov       rdx,7FFB1722F038
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
       mov       rdx,7FFB1722F038
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB17265FA8
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
       mov       rdx,7FFB1723EAC8
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
       mov       r8,2987C871048
       mov       r8,[r8]
       mov       rdx,2986C8731D0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[r15+10]
       mov       rdx,2986C8731D8
       mov       rdx,[rdx]
       mov       r8,2987C871048
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r15+8]
       mov       rdx,2986C8731E0
       mov       rdx,[rdx]
       mov       r8,2987C871048
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1723EC28
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
       mov       rdx,7FFB1723ED90
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
       mov       rdx,7FFB1723F0F0
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
       mov       rdx,7FFB1723F0F0
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
       mov       rdx,7FFB1723F0F0
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB17255E40
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
       mov       rdx,7FFB1722EAC8
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
       mov       r8,1B0E40C3060
       mov       r8,[r8]
       mov       rdx,1B0E40C3608
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[r15+10]
       mov       rdx,1B0E40C3610
       mov       rdx,[rdx]
       mov       r8,1B0E40C3060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r15+8]
       mov       rdx,1B0E40C3618
       mov       rdx,[rdx]
       mov       r8,1B0E40C3060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1722EC28
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
       mov       rdx,7FFB1722ED90
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
       mov       rdx,7FFB1722F0F0
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
       mov       rdx,7FFB1722F0F0
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
       mov       rdx,7FFB1722F0F0
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB17275C30
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
       mov       rdx,7FFB1724ED58
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
       mov       r8,208F47C3060
       mov       r8,[r8]
       mov       rdx,209147CFDA8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[r15+10]
       mov       rdx,209147CFDB0
       mov       rdx,[rdx]
       mov       r8,208F47C3060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r15+8]
       mov       rdx,209147CFDB8
       mov       rdx,[rdx]
       mov       r8,208F47C3060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1724EEB8
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
       mov       rdx,7FFB1724F020
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
       mov       rdx,7FFB1724F380
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
       mov       rdx,7FFB1724F380
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
       mov       rdx,7FFB1724F380
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB17275D78
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
       mov       rdx,7FFB1724EA10
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
       mov       r8,19850721048
       mov       r8,[r8]
       mov       rdx,19850730A18
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[r15+10]
       mov       rdx,19850730A20
       mov       rdx,[rdx]
       mov       r8,19850721048
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r15+8]
       mov       rdx,19850730A28
       mov       rdx,[rdx]
       mov       r8,19850721048
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1724EB70
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
       mov       rdx,7FFB1724ECD8
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
       mov       rdx,7FFB1724F038
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
       mov       rdx,7FFB1724F038
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
       mov       rdx,7FFB1724F038
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB172560C8
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
       mov       rdx,7FFB1722ED58
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
       mov       r8,278D1F73060
       mov       r8,[r8]
       mov       rdx,278B1F719F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[r15+10]
       mov       rdx,278B1F719F8
       mov       rdx,[rdx]
       mov       r8,278D1F73060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r15+8]
       mov       rdx,278B1F71A00
       mov       rdx,[rdx]
       mov       r8,278D1F73060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1722EEB8
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
       mov       rdx,7FFB1722F020
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
       mov       rdx,7FFB1722F380
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
       mov       rdx,7FFB1722F380
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
       mov       rdx,7FFB1722F380
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB17235BC8
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
       mov       rdx,7FFB1720ED58
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
       mov       r8,1EBEB693060
       mov       r8,[r8]
       mov       rdx,1EC1B70E1F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[r15+10]
       mov       rdx,1EC1B70E1F8
       mov       rdx,[rdx]
       mov       r8,1EBEB693060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r15+8]
       mov       rdx,1EC1B70E200
       mov       rdx,[rdx]
       mov       r8,1EBEB693060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1720EEB8
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
       mov       rdx,7FFB1720F020
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
       mov       rdx,7FFB1720F380
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
       mov       rdx,7FFB1720F380
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
       mov       rdx,7FFB1720F380
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
       mov       rdx,[rsi+90]
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
       mov       r8,1A983383060
       mov       r8,[r8]
       mov       rdx,1A9A33837A0
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
       mov       rdx,7FFB1724E5C8
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
       mov       rdx,7FFB1724E5C8
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
       mov       rdx,7FFB1724EB20
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
       mov       rdx,7FFB1724E5C8
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
       mov       rdx,7FFB1724E608
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
       mov       rdx,7FFB1724E5C8
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
       mov       rdx,7FFB1724E5C8
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
       mov       rdx,7FFB1724E960
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
       mov       rdx,7FFB1724E5C8
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
       mov       rdx,7FFB1724E820
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
       mov       rdx,[rsi+90]
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
       mov       r8,20745243060
       mov       r8,[r8]
       mov       rdx,20765250378
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
       mov       rdx,7FFB1721E5C8
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
       mov       rdx,7FFB1721E5C8
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
       mov       rdx,7FFB1721EB20
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
       mov       rdx,7FFB1721E5C8
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
       mov       rdx,7FFB1721E608
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
       mov       rdx,7FFB1721E5C8
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
       mov       rdx,7FFB1721E5C8
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
       mov       rdx,7FFB1721E960
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
       mov       rdx,7FFB1721E5C8
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
       mov       rdx,7FFB1721E820
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
       mov       rdx,[rsi+90]
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
       mov       r8,271E93E3060
       mov       r8,[r8]
       mov       rdx,271E93E3BD8
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
       mov       rdx,7FFB1721E5C8
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
       mov       rdx,7FFB1721E5C8
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
       mov       rdx,7FFB1721EB20
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
       mov       rdx,7FFB1721E5C8
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
       mov       rdx,7FFB1721E608
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
       mov       rdx,7FFB1721E5C8
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
       mov       rdx,7FFB1721E5C8
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
       mov       rdx,7FFB1721E960
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
       mov       rdx,7FFB1721E5C8
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
       mov       rdx,7FFB1721E820
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
       mov       rdx,[rsi+90]
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
       mov       r8,2CC846C1048
       mov       r8,[r8]
       mov       rdx,2CC646C37A0
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
       mov       rdx,7FFB1721E680
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
       mov       rdx,7FFB1721E680
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
       mov       rdx,7FFB1721EBD8
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
       mov       rdx,7FFB1721E680
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
       mov       rdx,7FFB1721E6C0
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
       mov       rdx,7FFB1721E680
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
       mov       rdx,7FFB1721E680
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
       mov       rdx,7FFB1721EA18
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
       mov       rdx,7FFB1721E680
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
       mov       rdx,7FFB1721E8D8
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
       mov       rdx,[rsi+90]
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
       mov       r8,181A23D3060
       mov       r8,[r8]
       mov       rdx,181A23D3BD8
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
       mov       rdx,7FFB1721E680
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
       mov       rdx,7FFB1721E680
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
       mov       rdx,7FFB1721EBD8
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
       mov       rdx,7FFB1721E680
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
       mov       rdx,7FFB1721E6C0
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
       mov       rdx,7FFB1721E680
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
       mov       rdx,7FFB1721E680
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
       mov       rdx,7FFB1721EA18
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
       mov       rdx,7FFB1721E680
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
       mov       rdx,7FFB1721E8D8
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
       mov       rdx,[rsi+90]
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
       mov       r8,2A4D2CF3060
       mov       r8,[r8]
       mov       rdx,2A4D2D027C8
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
       mov       rdx,7FFB1724E5C8
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
       mov       rdx,7FFB1724E5C8
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
       mov       rdx,7FFB1724EB20
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
       mov       rdx,7FFB1724E5C8
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
       mov       rdx,7FFB1724E608
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
       mov       rdx,7FFB1724E5C8
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
       mov       rdx,7FFB1724E5C8
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
       mov       rdx,7FFB1724E960
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
       mov       rdx,7FFB1724E5C8
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
       mov       rdx,7FFB1724E820
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
       mov       rdx,[rsi+90]
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
       mov       r8,28882053060
       mov       r8,[r8]
       mov       rdx,28892051788
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
       mov       rdx,7FFB1724E910
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
       mov       rdx,7FFB1724E910
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
       mov       rdx,7FFB1724EE68
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
       mov       rdx,7FFB1724E910
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
       mov       rdx,7FFB1724E950
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
       mov       rdx,7FFB1724E910
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
       mov       rdx,7FFB1724E910
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
       mov       rdx,7FFB1724ECA8
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
       mov       rdx,7FFB1724E910
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
       mov       rdx,7FFB1724EB68
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
       mov       rdx,[rsi+90]
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
       mov       r8,26B3DF73060
       mov       r8,[r8]
       mov       rdx,26B1DF71788
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
       mov       rdx,7FFB1724E680
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
       mov       rdx,7FFB1724E680
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
       mov       rdx,7FFB1724EBD8
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
       mov       rdx,7FFB1724E680
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
       mov       rdx,7FFB1724E6C0
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
       mov       rdx,7FFB1724E680
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
       mov       rdx,7FFB1724E680
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
       mov       rdx,7FFB1724EA18
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
       mov       rdx,7FFB1724E680
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
       mov       rdx,7FFB1724E8D8
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
       mov       rdx,[rsi+90]
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
       mov       r8,24904933060
       mov       r8,[r8]
       mov       rdx,24904935BF0
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
       mov       rdx,7FFB1724E750
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
       mov       rdx,7FFB1724E750
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
       mov       rdx,7FFB1724ECA8
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
       mov       rdx,7FFB1724E750
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
       mov       rdx,7FFB1724E790
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
       mov       rdx,7FFB1724E750
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
       mov       rdx,7FFB1724E750
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
       mov       rdx,7FFB1724EAE8
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
       mov       rdx,7FFB1724E750
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
       mov       rdx,7FFB1724E9A8
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB1722E868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,2AC0DEA3060
       mov       r8,[r8]
       mov       rdx,2AC2DEB05E0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1722E9F0
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
       mov       rdx,7FFB1722EC20
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
       mov       rdx,7FFB1722EC20
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
       mov       rdx,7FFB1722F178
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
       mov       rdx,7FFB1722EC20
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
       mov       rdx,7FFB1722EC60
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
       mov       rdx,7FFB1722EF90
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
       mov       rdx,7FFB1722F038
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB1722E868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,24C1DFD3060
       mov       r8,[r8]
       mov       rdx,24C4DFD11B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1722E9F0
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
       mov       rdx,7FFB1722EC20
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
       mov       rdx,7FFB1722EC20
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
       mov       rdx,7FFB1722F178
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
       mov       rdx,7FFB1722EC20
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
       mov       rdx,7FFB1722EC60
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
       mov       rdx,7FFB1722EF90
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
       mov       rdx,7FFB1722F038
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB1724E868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,24665763060
       mov       r8,[r8]
       mov       rdx,24665763608
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1724E9F0
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
       mov       rdx,7FFB1724EC20
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
       mov       rdx,7FFB1724EC20
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
       mov       rdx,7FFB1724F178
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
       mov       rdx,7FFB1724EC20
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
       mov       rdx,7FFB1724EC60
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
       mov       rdx,7FFB1724EF90
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
       mov       rdx,7FFB1724F038
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB1722E9F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,26804C03060
       mov       r8,[r8]
       mov       rdx,267F4C019F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1722EB78
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
       mov       rdx,7FFB1722EDA8
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
       mov       rdx,7FFB1722EDA8
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
       mov       rdx,7FFB1722F300
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
       mov       rdx,7FFB1722EDA8
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
       mov       rdx,7FFB1722EDE8
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
       mov       rdx,7FFB1722F118
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
       mov       rdx,7FFB1722F1C0
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB1721EBB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,1BCFBEA3060
       mov       r8,[r8]
       mov       rdx,1BD1BEA31D0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1721ED38
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
       mov       rdx,7FFB1721EF68
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
       mov       rdx,7FFB1721EF68
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
       mov       rdx,7FFB1721F4C0
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
       mov       rdx,7FFB1721EF68
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
       mov       rdx,7FFB1721EFA8
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
       mov       rdx,7FFB1721F2D8
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
       mov       rdx,7FFB1721F380
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB1723E868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,23EB5671048
       mov       r8,[r8]
       mov       rdx,23EC56711B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1723E9F0
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
       mov       rdx,7FFB1723EC20
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
       mov       rdx,7FFB1723EC20
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
       mov       rdx,7FFB1723F178
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
       mov       rdx,7FFB1723EC20
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
       mov       rdx,7FFB1723EC60
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
       mov       rdx,7FFB1723EF90
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
       mov       rdx,7FFB1723F038
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB1722EBB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,1F66FC93060
       mov       r8,[r8]
       mov       rdx,1F67FCB2608
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1722ED38
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
       mov       rdx,7FFB1722EF68
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
       mov       rdx,7FFB1722EF68
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
       mov       rdx,7FFB1722F4C0
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
       mov       rdx,7FFB1722EF68
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
       mov       rdx,7FFB1722EFA8
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
       mov       rdx,7FFB1722F2D8
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
       mov       rdx,7FFB1722F380
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB1723EBB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,1E582393060
       mov       r8,[r8]
       mov       rdx,1E5923919F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1723ED38
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
       mov       rdx,7FFB1723EF68
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
       mov       rdx,7FFB1723EF68
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
       mov       rdx,7FFB1723F4C0
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
       mov       rdx,7FFB1723EF68
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
       mov       rdx,7FFB1723EFA8
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
       mov       rdx,7FFB1723F2D8
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
       mov       rdx,7FFB1723F380
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB1721EBB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,1A14A413060
       mov       r8,[r8]
       mov       rdx,1A14A415620
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFB1721ED38
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
       mov       rdx,7FFB1721EF68
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
       mov       rdx,7FFB1721EF68
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
       mov       rdx,7FFB1721F4C0
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
       mov       rdx,7FFB1721EF68
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
       mov       rdx,7FFB1721EFA8
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
       mov       rdx,7FFB1721F2D8
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
       mov       rdx,7FFB1721F380
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
       mov       rdi,[rsi+0A0]
       mov       rcx,13845937B10
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,13845937B08
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,13845937B10
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
       mov       rdx,7FFB1723F888
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
       mov       rdi,[rsi+0A0]
       mov       rcx,18907F07B10
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,18907F07B08
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,18907F07B10
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
       mov       rdx,7FFB1721F888
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
       mov       rdi,[rsi+0A0]
       mov       rcx,21152D5BF78
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,21152D5BF70
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,21152D5BF78
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
       mov       rdx,7FFB1722F888
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
       mov       rdi,[rsi+0A0]
       mov       rcx,24548DBBF78
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,24548DBBF70
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,24548DBBF78
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
       mov       rdx,7FFB1720FA10
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
       mov       rdi,[rsi+0A0]
       mov       rcx,2D5508B7B10
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2D5508B7B08
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2D5508B7B10
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
       mov       rdx,7FFB1722FA10
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
       mov       rdi,[rsi+0A0]
       mov       rcx,2097DEC7B10
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2097DEC7B08
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2097DEC7B10
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
       mov       rdx,7FFB1722FBD0
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
       mov       rdi,[rsi+0A0]
       mov       rcx,16B1F589F60
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,16B1F589F58
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,16B1F589F60
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
       mov       rdx,7FFB1723FBD0
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
       mov       rdi,[rsi+0A0]
       mov       rcx,16687307B10
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,16687307B08
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,16687307B10
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
       mov       rdx,7FFB1722FBD0
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
       mov       rdi,[rsi+0A0]
       mov       rcx,177972E7B10
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,177972E7B08
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,177972E7B10
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
       mov       rdx,7FFB1721F888
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
       mov       rdi,[rsi+0A0]
       mov       rcx,26B15989B30
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,26B15989B20
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,26B15989B30
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
       mov       r8,26AF5983060
       mov       r8,[r8]
       mov       rdx,26B1598FDA8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,26AF5983060
       mov       r8,[r8]
       mov       rdx,26B1598FDB0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,26AF59813A8
       mov       rbp,[rcx]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB1721EAB8
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
       mov       rdi,[rsi+0A0]
       mov       rcx,162537B9B30
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,162537B9B20
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,162537B9B30
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
       mov       r8,162337B3060
       mov       r8,[r8]
       mov       rdx,162637B11B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,162337B3060
       mov       r8,[r8]
       mov       rdx,162637B11C0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,162337B13A8
       mov       rbp,[rcx]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB1723E930
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
       mov       rdi,[rsi+0A0]
       mov       rcx,28D76F5BF80
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,28D76F5BF70
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,28D76F5BF80
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
       mov       r8,28D76F53060
       mov       r8,[r8]
       mov       rdx,28D76F621F8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,28D76F53060
       mov       r8,[r8]
       mov       rdx,28D76F62200
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,28D76F513A8
       mov       rbp,[rcx]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB1723E930
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
       mov       rdi,[rsi+0A0]
       mov       rcx,2004B549F68
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2004B549F58
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2004B549F68
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
       mov       r8,2004B541048
       mov       r8,[r8]
       mov       rdx,2003B5411B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,2004B541048
       mov       r8,[r8]
       mov       rdx,2003B5411C0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,2002B5413A8
       mov       rbp,[rcx]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB1720E9E8
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
       mov       rdi,[rsi+0A0]
       mov       rcx,1DE008E7B18
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1DE008E7B08
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1DE008E7B18
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
       mov       r8,1DE108E3060
       mov       r8,[r8]
       mov       rdx,1DE008EDD90
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,1DE108E3060
       mov       r8,[r8]
       mov       rdx,1DE008EDD98
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,1DE108E13A8
       mov       rbp,[rcx]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB1723E930
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
       mov       rdi,[rsi+0A0]
       mov       rcx,1D4672D7B18
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1D4672D7B08
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1D4672D7B18
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
       mov       r8,1D4872D3060
       mov       r8,[r8]
       mov       rdx,1D4672DDD90
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,1D4872D3060
       mov       r8,[r8]
       mov       rdx,1D4672DDD98
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,1D4872D13A8
       mov       rbp,[rcx]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB1721E9E8
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
       mov       rdi,[rsi+0A0]
       mov       rcx,199B9179B30
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,199B9179B20
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,199B9179B30
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
       mov       r8,199A9173060
       mov       r8,[r8]
       mov       rdx,199A9173E40
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,199A9173060
       mov       r8,[r8]
       mov       rdx,199A9173E48
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,199A91713A8
       mov       rbp,[rcx]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB1723E930
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
       mov       rdi,[rsi+0A0]
       mov       rcx,218375A7B18
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,218375A7B08
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,218375A7B18
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
       mov       r8,218275A3060
       mov       r8,[r8]
       mov       rdx,218475E1A08
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,218275A3060
       mov       r8,[r8]
       mov       rdx,218475E1A10
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,218275A13A8
       mov       rbp,[rcx]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB1722EC78
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
       mov       rdi,[rsi+0A0]
       mov       rcx,1822B0CBF80
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1822B0CBF70
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1822B0CBF80
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
       mov       r8,1822B0C3060
       mov       r8,[r8]
       mov       rdx,1822B0D2A30
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,1822B0C3060
       mov       r8,[r8]
       mov       rdx,1822B0D2A38
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,1822B0C13A8
       mov       rbp,[rcx]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB1724EAB8
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
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Page(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,rax
       mov       r11,7FFB16D405A8
       call      qword ptr [7FFB171605A8]
       mov       [rbp+0FFF0],rax
; 			foreach (var people in base.PersonProperCollection.Page(10))
; 			                    ^^
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D405B0
       call      qword ptr [7FFB171605B0]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D405B8
       call      qword ptr [7FFB171605B8]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFB16D405C0
       call      qword ptr [7FFB171605C0]
       mov       [rbp+0FFE8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D405D0
       call      qword ptr [7FFB171605D0]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D405C8
       call      qword ptr [7FFB171605C8]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D405D8
       call      qword ptr [7FFB171605D8]
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D405B0
       call      qword ptr [7FFB171605B0]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D405E0
       call      qword ptr [7FFB171605E0]
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
       mov       r11,7FFB16D405D8
       call      qword ptr [7FFB171605D8]
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
       mov       r11,7FFB16D405E0
       call      qword ptr [7FFB171605E0]
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
       mov       rdx,7FFB1722ECE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       mov       rcx,7FFB16E30020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M01_L02
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M01_L02:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Page(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,rax
       mov       r11,7FFB16D305A8
       call      qword ptr [7FFB171505A8]
       mov       [rbp+0FFF0],rax
; 			foreach (var people in base.PersonProperCollection.Page(10))
; 			                    ^^
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D305B0
       call      qword ptr [7FFB171505B0]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D305B8
       call      qword ptr [7FFB171505B8]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFB16D305C0
       call      qword ptr [7FFB171505C0]
       mov       [rbp+0FFE8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D305D0
       call      qword ptr [7FFB171505D0]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D305C8
       call      qword ptr [7FFB171505C8]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D305D8
       call      qword ptr [7FFB171505D8]
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D305B0
       call      qword ptr [7FFB171505B0]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D305E0
       call      qword ptr [7FFB171505E0]
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
       mov       r11,7FFB16D305D8
       call      qword ptr [7FFB171505D8]
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
       mov       r11,7FFB16D305E0
       call      qword ptr [7FFB171505E0]
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
       mov       rdx,7FFB1721ECE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       mov       rcx,7FFB16E20020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M01_L02
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M01_L02:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Page(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,rax
       mov       r11,7FFB16D505A8
       call      qword ptr [7FFB171705A8]
       mov       [rbp+0FFF0],rax
; 			foreach (var people in base.PersonProperCollection.Page(10))
; 			                    ^^
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D505B0
       call      qword ptr [7FFB171705B0]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D505B8
       call      qword ptr [7FFB171705B8]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFB16D505C0
       call      qword ptr [7FFB171705C0]
       mov       [rbp+0FFE8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D505D0
       call      qword ptr [7FFB171705D0]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D505C8
       call      qword ptr [7FFB171705C8]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D505D8
       call      qword ptr [7FFB171705D8]
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D505B0
       call      qword ptr [7FFB171705B0]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D505E0
       call      qword ptr [7FFB171705E0]
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
       mov       r11,7FFB16D505D8
       call      qword ptr [7FFB171705D8]
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
       mov       r11,7FFB16D505E0
       call      qword ptr [7FFB171705E0]
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
       mov       rdx,7FFB1723ECE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       mov       rcx,7FFB16E40020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M01_L02
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M01_L02:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Page(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,rax
       mov       r11,7FFB16D605A8
       call      qword ptr [7FFB171805A8]
       mov       [rbp+0FFF0],rax
; 			foreach (var people in base.PersonProperCollection.Page(10))
; 			                    ^^
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D605B0
       call      qword ptr [7FFB171805B0]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D605B8
       call      qword ptr [7FFB171805B8]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFB16D605C0
       call      qword ptr [7FFB171805C0]
       mov       [rbp+0FFE8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D605D0
       call      qword ptr [7FFB171805D0]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D605C8
       call      qword ptr [7FFB171805C8]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D605D8
       call      qword ptr [7FFB171805D8]
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D605B0
       call      qword ptr [7FFB171805B0]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D605E0
       call      qword ptr [7FFB171805E0]
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
       mov       r11,7FFB16D605D8
       call      qword ptr [7FFB171805D8]
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
       mov       r11,7FFB16D605E0
       call      qword ptr [7FFB171805E0]
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
       mov       rdx,7FFB1724ED98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       mov       rcx,7FFB16E50020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M01_L02
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M01_L02:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Page(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,rax
       mov       r11,7FFB16D305A8
       call      qword ptr [7FFB171505A8]
       mov       [rbp+0FFF0],rax
; 			foreach (var people in base.PersonProperCollection.Page(10))
; 			                    ^^
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D305B0
       call      qword ptr [7FFB171505B0]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D305B8
       call      qword ptr [7FFB171505B8]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFB16D305C0
       call      qword ptr [7FFB171505C0]
       mov       [rbp+0FFE8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D305D0
       call      qword ptr [7FFB171505D0]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D305C8
       call      qword ptr [7FFB171505C8]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D305D8
       call      qword ptr [7FFB171505D8]
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D305B0
       call      qword ptr [7FFB171505B0]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D305E0
       call      qword ptr [7FFB171505E0]
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
       mov       r11,7FFB16D305D8
       call      qword ptr [7FFB171505D8]
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
       mov       r11,7FFB16D305E0
       call      qword ptr [7FFB171505E0]
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
       mov       rdx,7FFB1721ECE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       mov       rcx,7FFB16E20020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M01_L02
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M01_L02:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Page(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,rax
       mov       r11,7FFB16D605A8
       call      qword ptr [7FFB171805A8]
       mov       [rbp+0FFF0],rax
; 			foreach (var people in base.PersonProperCollection.Page(10))
; 			                    ^^
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D605B0
       call      qword ptr [7FFB171805B0]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D605B8
       call      qword ptr [7FFB171805B8]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFB16D605C0
       call      qword ptr [7FFB171805C0]
       mov       [rbp+0FFE8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D605D0
       call      qword ptr [7FFB171805D0]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D605C8
       call      qword ptr [7FFB171805C8]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D605D8
       call      qword ptr [7FFB171805D8]
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D605B0
       call      qword ptr [7FFB171805B0]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D605E0
       call      qword ptr [7FFB171805E0]
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
       mov       r11,7FFB16D605D8
       call      qword ptr [7FFB171805D8]
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
       mov       r11,7FFB16D605E0
       call      qword ptr [7FFB171805E0]
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
       mov       rdx,7FFB1724EE68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       mov       rcx,7FFB16E50020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M01_L02
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M01_L02:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Page(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,rax
       mov       r11,7FFB16D305A8
       call      qword ptr [7FFB171505A8]
       mov       [rbp+0FFF0],rax
; 			foreach (var people in base.PersonProperCollection.Page(10))
; 			                    ^^
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D305B0
       call      qword ptr [7FFB171505B0]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D305B8
       call      qword ptr [7FFB171505B8]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFB16D305C0
       call      qword ptr [7FFB171505C0]
       mov       [rbp+0FFE8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D305D0
       call      qword ptr [7FFB171505D0]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D305C8
       call      qword ptr [7FFB171505C8]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D305D8
       call      qword ptr [7FFB171505D8]
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D305B0
       call      qword ptr [7FFB171505B0]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D305E0
       call      qword ptr [7FFB171505E0]
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
       mov       r11,7FFB16D305D8
       call      qword ptr [7FFB171505D8]
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
       mov       r11,7FFB16D305E0
       call      qword ptr [7FFB171505E0]
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
       mov       rdx,7FFB1721ED98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       mov       rcx,7FFB16E20020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M01_L02
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M01_L02:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Page(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,rax
       mov       r11,7FFB16D505A8
       call      qword ptr [7FFB171705A8]
       mov       [rbp+0FFF0],rax
; 			foreach (var people in base.PersonProperCollection.Page(10))
; 			                    ^^
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D505B0
       call      qword ptr [7FFB171705B0]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D505B8
       call      qword ptr [7FFB171705B8]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFB16D505C0
       call      qword ptr [7FFB171705C0]
       mov       [rbp+0FFE8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D505D0
       call      qword ptr [7FFB171705D0]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D505C8
       call      qword ptr [7FFB171705C8]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D505D8
       call      qword ptr [7FFB171705D8]
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D505B0
       call      qword ptr [7FFB171705B0]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D505E0
       call      qword ptr [7FFB171705E0]
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
       mov       r11,7FFB16D505D8
       call      qword ptr [7FFB171705D8]
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
       mov       r11,7FFB16D505E0
       call      qword ptr [7FFB171705E0]
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
       mov       rdx,7FFB1723ECE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       mov       rcx,7FFB16E40020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M01_L02
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M01_L02:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Page(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,rax
       mov       r11,7FFB16D305A8
       call      qword ptr [7FFB171505A8]
       mov       [rbp+0FFF0],rax
; 			foreach (var people in base.PersonProperCollection.Page(10))
; 			                    ^^
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D305B0
       call      qword ptr [7FFB171505B0]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D305B8
       call      qword ptr [7FFB171505B8]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFB16D305C0
       call      qword ptr [7FFB171505C0]
       mov       [rbp+0FFE8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D305D0
       call      qword ptr [7FFB171505D0]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D305C8
       call      qword ptr [7FFB171505C8]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFB16D305D8
       call      qword ptr [7FFB171505D8]
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D305B0
       call      qword ptr [7FFB171505B0]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFB16D305E0
       call      qword ptr [7FFB171505E0]
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
       mov       r11,7FFB16D305D8
       call      qword ptr [7FFB171505D8]
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
       mov       r11,7FFB16D305E0
       call      qword ptr [7FFB171505E0]
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
       mov       rdx,7FFB1721F028
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       mov       rcx,7FFB16E20020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M01_L02
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M01_L02:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rcx,[rsi+0A0]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0D0]
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
       mov       rdx,7FFB1721F850
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
       mov       rdx,7FFB1721F800
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
       mov       rcx,[rsi+0A0]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0D0]
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
       mov       rdx,7FFB1722FCF8
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
       mov       rdx,7FFB1722FCA8
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
       mov       rcx,[rsi+0A0]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0D0]
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
       mov       rdx,7FFB1721FB80
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
       mov       rdx,7FFB1721FB30
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
       mov       rcx,[rsi+0A0]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0D0]
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
       mov       rdx,7FFB1720FB80
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
       mov       rdx,7FFB1720FB30
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
       mov       rcx,[rsi+0A0]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0D0]
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
       mov       rdx,7FFB1722FD08
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
       mov       rdx,7FFB1722FCB8
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
       mov       rcx,[rsi+0A0]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0D0]
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
       mov       rdx,7FFB1723FB80
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
       mov       rdx,7FFB1723FB30
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
       mov       rcx,[rsi+0A0]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0D0]
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
       mov       rdx,7FFB1722FEC8
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
       mov       rdx,7FFB1722FE78
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
       mov       rcx,[rsi+0A0]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0D0]
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
       mov       rdx,7FFB1723FB80
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
       mov       rdx,7FFB1723FB30
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
       mov       rcx,[rsi+0A0]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0D0]
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
       mov       rdx,7FFB1723FB80
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
       mov       rdx,7FFB1723FB30
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,28337521048
       mov       r8,[r8]
       mov       rdx,283575211B8
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
       mov       rdx,7FFB1722E8E0
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
       mov       rdx,7FFB1722E8E0
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
       mov       rdx,7FFB1722EA60
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
       mov       rdx,7FFB1722E8E0
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
       mov       rdx,7FFB1722E920
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,21351103060
       mov       r8,[r8]
       mov       rdx,213311019F0
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
       mov       rdx,7FFB1724E8E0
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
       mov       rdx,7FFB1724E8E0
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
       mov       rdx,7FFB1724EA60
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
       mov       rdx,7FFB1724E8E0
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
       mov       rdx,7FFB1724E920
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,25C8F043060
       mov       r8,[r8]
       mov       rdx,25C7F04DD90
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
       mov       rdx,7FFB1724E8E0
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
       mov       rdx,7FFB1724E8E0
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
       mov       rdx,7FFB1724EA60
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
       mov       rdx,7FFB1724E8E0
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
       mov       rdx,7FFB1724E920
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,26BF87D3060
       mov       r8,[r8]
       mov       rdx,26BF87D3608
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
       mov       rdx,7FFB1724E8E0
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
       mov       rdx,7FFB1724E8E0
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
       mov       rdx,7FFB1724EA60
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
       mov       rdx,7FFB1724E8E0
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
       mov       rdx,7FFB1724E920
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,243951F3060
       mov       r8,[r8]
       mov       rdx,243B51F31D0
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
       mov       rdx,7FFB1724E998
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
       mov       rdx,7FFB1724E998
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
       mov       rdx,7FFB1724EB18
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
       mov       rdx,7FFB1724E998
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
       mov       rdx,7FFB1724E9D8
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,241EB7C3060
       mov       r8,[r8]
       mov       rdx,241EB7C5620
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
       mov       rdx,7FFB1723EC28
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
       mov       rdx,7FFB1723EC28
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
       mov       rdx,7FFB1723EDA8
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
       mov       rdx,7FFB1723EC28
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
       mov       rdx,7FFB1723EC68
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,2948F933060
       mov       r8,[r8]
       mov       rdx,2946F9311B8
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
       mov       rdx,7FFB1724EC28
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
       mov       rdx,7FFB1724EC28
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
       mov       rdx,7FFB1724EDA8
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
       mov       rdx,7FFB1724EC28
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
       mov       rdx,7FFB1724EC68
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,21137673060
       mov       r8,[r8]
       mov       rdx,21137682A30
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
       mov       rdx,7FFB1723E8E0
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
       mov       rdx,7FFB1723E8E0
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
       mov       rdx,7FFB1723EA60
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
       mov       rdx,7FFB1723E8E0
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
       mov       rdx,7FFB1723E920
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,17BEA6C3060
       mov       r8,[r8]
       mov       rdx,17C0A74CDE0
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
       mov       rdx,7FFB1722E8E0
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
       mov       rdx,7FFB1722E8E0
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
       mov       rdx,7FFB1722EA60
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
       mov       rdx,7FFB1722E8E0
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
       mov       rdx,7FFB1722E920
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,19A4F4E3060
       mov       r8,[r8]
       mov       rdx,19A6F4E11B8
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
       mov       rdx,7FFB17243F60
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,21715893060
       mov       r8,[r8]
       mov       rdx,217258911B8
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
       mov       rdx,7FFB17253F60
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,2A3A8F23060
       mov       r8,[r8]
       mov       rdx,2A398F2DD90
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
       mov       rdx,7FFB17253F60
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,1CCE5663060
       mov       r8,[r8]
       mov       rdx,1CCF56611B8
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
       mov       rdx,7FFB17253F60
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,19661D43060
       mov       r8,[r8]
       mov       rdx,19671D411B8
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
       mov       rdx,7FFB17253F60
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,1E889A03060
       mov       r8,[r8]
       mov       rdx,1E899A031D0
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
       mov       rdx,7FFB17253F60
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,202A3B73060
       mov       r8,[r8]
       mov       rdx,202B3B77DF0
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
       mov       rdx,7FFB17233F60
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,234DC633060
       mov       r8,[r8]
       mov       rdx,234DC67F250
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
       mov       rdx,7FFB17243F60
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,1AEFBC43060
       mov       r8,[r8]
       mov       rdx,1AF1BCC0208
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
       mov       rdx,7FFB17253F60
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,181DC933060
       mov       r8,[r8]
       mov       rdx,181EC9311B8
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
       mov       rdx,7FFB1722F170
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,249FD983060
       mov       r8,[r8]
       mov       rdx,24A1D9811B8
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
       mov       rdx,7FFB1720F170
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,16416BC3060
       mov       r8,[r8]
       mov       rdx,16426BC11B8
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
       mov       rdx,7FFB1721F228
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,1BA7C1B3060
       mov       r8,[r8]
       mov       rdx,1BAAC1B11B8
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
       mov       rdx,7FFB1721F170
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,274274E3060
       mov       r8,[r8]
       mov       rdx,274374EFDA8
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
       mov       rdx,7FFB1722F4B8
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,1550B423060
       mov       r8,[r8]
       mov       rdx,154FB4211B8
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
       mov       rdx,7FFB1721F4B8
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,261D61D3060
       mov       r8,[r8]
       mov       rdx,261D61E2A30
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
       mov       rdx,7FFB1723F170
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,1634B2B3060
       mov       r8,[r8]
       mov       rdx,1633B2EF9F0
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
       mov       rdx,7FFB1722F4B8
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
       mov       rdx,[rsi+0A0]
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
       mov       r8,15145123060
       mov       r8,[r8]
       mov       rdx,151651219F0
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
       mov       rdx,7FFB1724F4B8
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

