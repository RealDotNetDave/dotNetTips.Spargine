## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeReadOnlyList()
; 			var result = base.PersonProperList.ToReadOnlyCollection().ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,20A37CB3020
       mov       r8,[r8]
       mov       rdx,20A57CB17E8
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
       mov       rdx,7FFA7F057DE8
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
       mov       rdx,7FFA7F0B03E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,20A37CB3020
       mov       r8,[r8]
       mov       rdx,20A57CB17E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M02_L02
       mov       rcx,[rbx+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B0558
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
       mov       rdx,7FFA7F0B0788
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
       mov       rdx,7FFA7F0B0788
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
       mov       rdx,7FFA7F0B0CE0
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
       mov       rdx,7FFA7F0B0788
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
       mov       rdx,7FFA7F0B07C8
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
       mov       rdx,7FFA7F0B0AF8
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
       mov       rdx,7FFA7F0B0BA0
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeReadOnlyList()
; 			var result = base.PersonProperList.ToReadOnlyCollection().ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,197E5523020
       mov       r8,[r8]
       mov       rdx,197C55217E8
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
       mov       rdx,7FFA7F047D70
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
       mov       rdx,7FFA7F0A0900
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,197E5523020
       mov       r8,[r8]
       mov       rdx,197C55217E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M02_L02
       mov       rcx,[rbx+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A0A70
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
       mov       rdx,7FFA7F0A0CA0
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
       mov       rdx,7FFA7F0A0CA0
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
       mov       rdx,7FFA7F0A11F8
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
       mov       rdx,7FFA7F0A0CA0
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
       mov       rdx,7FFA7F0A0CE0
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
       mov       rdx,7FFA7F0A1010
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
       mov       rdx,7FFA7F0A10B8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeReadOnlyList()
; 			var result = base.PersonProperList.ToReadOnlyCollection().ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,24705953020
       mov       r8,[r8]
       mov       rdx,246E59517E8
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
       mov       rdx,7FFA7F057D58
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
       mov       rdx,7FFA7F0B08A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,24705953020
       mov       r8,[r8]
       mov       rdx,246E59517E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M02_L02
       mov       rcx,[rbx+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B0A10
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
       mov       rdx,7FFA7F0B0C40
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
       mov       rdx,7FFA7F0B0C40
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
       mov       rdx,7FFA7F0B1198
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
       mov       rdx,7FFA7F0B0C40
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
       mov       rdx,7FFA7F0B0C80
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
       mov       rdx,7FFA7F0B0FB0
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
       mov       rdx,7FFA7F0B1058
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeReadOnlyList()
; 			var result = base.PersonProperList.ToReadOnlyCollection().ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,11B58C41028
       mov       r8,[r8]
       mov       rdx,11B48C437E0
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
       mov       rdx,7FFA7F057DE8
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
       mov       rdx,7FFA7F0B08A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,11B58C41028
       mov       r8,[r8]
       mov       rdx,11B48C437E0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M02_L02
       mov       rcx,[rbx+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B0A10
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
       mov       rdx,7FFA7F0B0C40
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
       mov       rdx,7FFA7F0B0C40
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
       mov       rdx,7FFA7F0B1198
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
       mov       rdx,7FFA7F0B0C40
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
       mov       rdx,7FFA7F0B0C80
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
       mov       rdx,7FFA7F0B0FB0
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
       mov       rdx,7FFA7F0B1058
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeReadOnlyList()
; 			var result = base.PersonProperList.ToReadOnlyCollection().ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,19876701028
       mov       r8,[r8]
       mov       rdx,198667017E8
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
       mov       rdx,7FFA7F048230
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
       mov       rdx,7FFA7F0A08B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,19876701028
       mov       r8,[r8]
       mov       rdx,198667017E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M02_L02
       mov       rcx,[rbx+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A0A28
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
       mov       rdx,7FFA7F0A0C58
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
       mov       rdx,7FFA7F0A0C58
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
       mov       rdx,7FFA7F0A11B0
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
       mov       rdx,7FFA7F0A0C58
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
       mov       rdx,7FFA7F0A0C98
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
       mov       rdx,7FFA7F0A0FC8
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
       mov       rdx,7FFA7F0A1070
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeReadOnlyList()
; 			var result = base.PersonProperList.ToReadOnlyCollection().ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,1F7A1823020
       mov       r8,[r8]
       mov       rdx,1F7818217E8
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
       mov       rdx,7FFA7F047FD8
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
       mov       rdx,7FFA7F0A08F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,1F7A1823020
       mov       r8,[r8]
       mov       rdx,1F7818217E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M02_L02
       mov       rcx,[rbx+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A0A68
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
       mov       rdx,7FFA7F0A0C98
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
       mov       rdx,7FFA7F0A0C98
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
       mov       rdx,7FFA7F0A11F0
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
       mov       rdx,7FFA7F0A0C98
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
       mov       rdx,7FFA7F0A0CD8
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
       mov       rdx,7FFA7F0A1008
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
       mov       rdx,7FFA7F0A10B0
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeReadOnlyList()
; 			var result = base.PersonProperList.ToReadOnlyCollection().ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,20948AF1028
       mov       r8,[r8]
       mov       rdx,20948AFFB68
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
       mov       rdx,7FFA7F037FF0
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
       mov       rdx,7FFA7F090900
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,20948AF1028
       mov       r8,[r8]
       mov       rdx,20948AFFB68
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M02_L02
       mov       rcx,[rbx+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFA7F090A70
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
       mov       rdx,7FFA7F090CA0
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
       mov       rdx,7FFA7F090CA0
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
       mov       rdx,7FFA7F0911F8
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
       mov       rdx,7FFA7F090CA0
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
       mov       rdx,7FFA7F090CE0
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
       mov       rdx,7FFA7F091010
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
       mov       rdx,7FFA7F0910B8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ShuffleWithCount()
; 			var result = base.PersonProperList.Shuffle(base.Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       r8d,[rsi+198]
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
       mov       r8,22278B23020
       mov       r8,[r8]
       mov       rdx,22298B2F750
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,22278B23020
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
       mov       rdx,22278B23410
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
       mov       rdx,7FFA7F061E20
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
       mov       rdx,7FFA7F061E70
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ShuffleWithCount()
; 			var result = base.PersonProperList.Shuffle(base.Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       r8d,[rsi+198]
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
       mov       r8,1E2E6EA3020
       mov       r8,[r8]
       mov       rdx,1E2C6EA17E8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,1E2E6EA3020
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
       mov       rdx,1E2E6EA3410
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
       mov       rdx,7FFA7F062338
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
       mov       rdx,7FFA7F062388
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ShuffleWithCount()
; 			var result = base.PersonProperList.Shuffle(base.Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       r8d,[rsi+198]
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
       mov       r8,1F8B3923020
       mov       r8,[r8]
       mov       rdx,1F8B3931B60
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,1F8B3923020
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
       mov       rdx,1F8B3923410
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
       mov       rdx,7FFA7F092338
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
       mov       rdx,7FFA7F092388
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ShuffleWithCount()
; 			var result = base.PersonProperList.Shuffle(base.Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       r8d,[rsi+198]
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
       mov       r8,245A7383020
       mov       r8,[r8]
       mov       rdx,245873817E8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,245A7383020
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
       mov       rdx,245A7383410
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
       mov       rdx,7FFA7F0722E0
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
       mov       rdx,7FFA7F072330
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ShuffleWithCount()
; 			var result = base.PersonProperList.Shuffle(base.Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       r8d,[rsi+198]
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
       mov       r8,204120F3020
       mov       r8,[r8]
       mov       rdx,203F20FD758
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,204120F3020
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
       mov       rdx,204120F3410
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
       mov       rdx,7FFA7F0722F8
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
       mov       rdx,7FFA7F072348
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ShuffleWithCount()
; 			var result = base.PersonProperList.Shuffle(base.Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       r8d,[rsi+198]
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
       mov       r8,202760F1028
       mov       r8,[r8]
       mov       rdx,202560F37E0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,202760F1028
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
       mov       rdx,202760F1418
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
       mov       rdx,7FFA7F082338
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
       mov       rdx,7FFA7F082388
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ShuffleWithCount()
; 			var result = base.PersonProperList.Shuffle(base.Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       r8d,[rsi+198]
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
       mov       r8,22BE3CF3020
       mov       r8,[r8]
       mov       rdx,22BE3CF3BF8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,22BE3CF3020
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
       mov       rdx,22BE3CF3410
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
       mov       rdx,7FFA7F0922F8
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
       mov       rdx,7FFA7F092348
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.PersonProperList.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.CopyToList(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,rax
       mov       r8,[rsi+30]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,21425B63020
       mov       r8,[r8]
       mov       rdx,21405B617E8
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
       mov       rdx,7FFA7F0C0888
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
       mov       r8,21425B63020
       mov       r8,[r8]
       mov       rdx,21405B617E8
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
       mov       rdx,7FFA7F0C0950
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,21425B63020
       mov       r9,[r9]
       mov       r8,21405B617E8
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
       mov       rdx,7FFA7F0C0B48
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
       mov       rdx,7FFA7F0C0B60
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.PersonProperList.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.CopyToList(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,rax
       mov       r8,[rsi+30]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,19470771028
       mov       r8,[r8]
       mov       rdx,194607717E8
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
       mov       rdx,7FFA7F090CB8
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
       mov       r8,19470771028
       mov       r8,[r8]
       mov       rdx,194607717E8
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
       mov       rdx,7FFA7F090D80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,19470771028
       mov       r9,[r9]
       mov       r8,194607717E8
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
       mov       rdx,7FFA7F090F78
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
       mov       rdx,7FFA7F090F90
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.PersonProperList.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.CopyToList(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,rax
       mov       r8,[rsi+30]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1C173243020
       mov       r8,[r8]
       mov       rdx,1C173251B60
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
       mov       rdx,7FFA7F0B0CD0
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
       mov       r8,1C173243020
       mov       r8,[r8]
       mov       rdx,1C173251B60
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
       mov       rdx,7FFA7F0B0D98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1C173243020
       mov       r9,[r9]
       mov       r8,1C173251B60
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
       mov       rdx,7FFA7F0B0F90
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
       mov       rdx,7FFA7F0B0FA8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.PersonProperList.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.CopyToList(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,rax
       mov       r8,[rsi+30]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1E871A23020
       mov       r8,[r8]
       mov       rdx,1E871A23BF8
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
       mov       rdx,7FFA7F0C0D10
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
       mov       r8,1E871A23020
       mov       r8,[r8]
       mov       rdx,1E871A23BF8
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
       mov       rdx,7FFA7F0C0DD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1E871A23020
       mov       r9,[r9]
       mov       r8,1E871A23BF8
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
       mov       rdx,7FFA7F0C0FD0
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
       mov       rdx,7FFA7F0C0FE8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.PersonProperList.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.CopyToList(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,rax
       mov       r8,[rsi+30]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,141A5DA3020
       mov       r8,[r8]
       mov       rdx,14195DA17E8
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
       mov       rdx,7FFA7F090CB8
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
       mov       r8,141A5DA3020
       mov       r8,[r8]
       mov       rdx,14195DA17E8
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
       mov       rdx,7FFA7F090D80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,141A5DA3020
       mov       r9,[r9]
       mov       r8,14195DA17E8
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
       mov       rdx,7FFA7F090F78
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
       mov       rdx,7FFA7F090F90
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.PersonProperList.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.CopyToList(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,rax
       mov       r8,[rsi+30]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,25245161028
       mov       r8,[r8]
       mov       rdx,252251617E8
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
       mov       rdx,7FFA7F0B0CD0
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
       mov       r8,25245161028
       mov       r8,[r8]
       mov       rdx,252251617E8
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
       mov       rdx,7FFA7F0B0D98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,25245161028
       mov       r9,[r9]
       mov       r8,252251617E8
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
       mov       rdx,7FFA7F0B0F90
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
       mov       rdx,7FFA7F0B0FA8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.PersonProperList.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.CopyToList(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,rax
       mov       r8,[rsi+30]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.CopyToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1B6D5DC1028
       mov       r8,[r8]
       mov       rdx,1B6C5DC17E8
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
       mov       rdx,7FFA7F0A0CD0
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
       mov       r8,1B6D5DC1028
       mov       r8,[r8]
       mov       rdx,1B6C5DC17E8
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
       mov       rdx,7FFA7F0A0D98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1B6D5DC1028
       mov       r9,[r9]
       mov       r8,1B6C5DC17E8
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
       mov       rdx,7FFA7F0A0F90
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
       mov       rdx,7FFA7F0A0FA8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualList()
; 			var result = base.PersonProperList.AreEqual(base.PersonProperListHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       r8,[rsi+168]
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
       mov       rdx,7FFA7F0A0268
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
       mov       rdx,7FFA7F0A0268
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
       mov       rdx,7FFA7F0A03D0
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
       mov       rdx,7FFA7F0A03D0
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
       mov       rdx,7FFA7F0A0268
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualList()
; 			var result = base.PersonProperList.AreEqual(base.PersonProperListHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       r8,[rsi+168]
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
       mov       rdx,7FFA7F0C0750
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
       mov       rdx,7FFA7F0C0750
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
       mov       rdx,7FFA7F0C08B8
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
       mov       rdx,7FFA7F0C08B8
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
       mov       rdx,7FFA7F0C0750
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualList()
; 			var result = base.PersonProperList.AreEqual(base.PersonProperListHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       r8,[rsi+168]
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
       mov       rdx,7FFA7F090750
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
       mov       rdx,7FFA7F090750
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
       mov       rdx,7FFA7F0908B8
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
       mov       rdx,7FFA7F0908B8
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
       mov       rdx,7FFA7F090750
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualList()
; 			var result = base.PersonProperList.AreEqual(base.PersonProperListHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       r8,[rsi+168]
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
       mov       rdx,7FFA7F090750
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
       mov       rdx,7FFA7F090750
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
       mov       rdx,7FFA7F0908B8
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
       mov       rdx,7FFA7F0908B8
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
       mov       rdx,7FFA7F090750
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualList()
; 			var result = base.PersonProperList.AreEqual(base.PersonProperListHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       r8,[rsi+168]
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
       mov       rdx,7FFA7F0A0708
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
       mov       rdx,7FFA7F0A0708
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
       mov       rdx,7FFA7F0A0870
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
       mov       rdx,7FFA7F0A0870
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
       mov       rdx,7FFA7F0A0708
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualList()
; 			var result = base.PersonProperList.AreEqual(base.PersonProperListHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       r8,[rsi+168]
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
       mov       rdx,7FFA7F0C0750
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
       mov       rdx,7FFA7F0C0750
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
       mov       rdx,7FFA7F0C08B8
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
       mov       rdx,7FFA7F0C08B8
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
       mov       rdx,7FFA7F0C0750
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualList()
; 			var result = base.PersonProperList.AreEqual(base.PersonProperListHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       r8,[rsi+168]
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
       mov       rdx,7FFA7F0A0748
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
       mov       rdx,7FFA7F0A0748
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
       mov       rdx,7FFA7F0A08B0
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
       mov       rdx,7FFA7F0A08B0
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
       mov       rdx,7FFA7F0A0748
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ClearNulls()
; 			var people = base.PersonProperList;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.AddLast(null);
; 			^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ClearNulls();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+160]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       xor       r8d,r8d
       call      dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
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
       mov       r8,20FBC273020
       mov       r8,[r8]
       mov       rdx,20FDC27F750
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbp,[rdi+10]
       mov       r11,[rbp+10]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA7F0B03C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,20FBC273020
       mov       r9,[r9]
       mov       r8,20FDC27F750
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       test      rbx,rbx
       jne       short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFA7F0B05B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFA7F0B05D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
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
       mov       rdx,7FFA7F0B1038
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
       mov       rdx,7FFA7F0B1038
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
       mov       rdx,7FFA7F0B1590
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
       mov       rdx,7FFA7F0B1038
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ClearNulls()
; 			var people = base.PersonProperList;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.AddLast(null);
; 			^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ClearNulls();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+160]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       xor       r8d,r8d
       call      dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
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
       mov       r8,23C22561028
       mov       r8,[r8]
       mov       rdx,23C2256FB68
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbp,[rdi+10]
       mov       r11,[rbp+10]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA7F0C08D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,23C22561028
       mov       r9,[r9]
       mov       r8,23C2256FB68
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       test      rbx,rbx
       jne       short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFA7F0C0AC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFA7F0C0AE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
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
       mov       rdx,7FFA7F0C1548
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
       mov       rdx,7FFA7F0C1548
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
       mov       rdx,7FFA7F0C1AA0
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
       mov       rdx,7FFA7F0C1548
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ClearNulls()
; 			var people = base.PersonProperList;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.AddLast(null);
; 			^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ClearNulls();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+160]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       xor       r8d,r8d
       call      dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
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
       mov       r8,1CD94CE1028
       mov       r8,[r8]
       mov       rdx,1CD94CEFB68
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbp,[rdi+10]
       mov       r11,[rbp+10]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA7F0908D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1CD94CE1028
       mov       r9,[r9]
       mov       r8,1CD94CEFB68
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       test      rbx,rbx
       jne       short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFA7F090AD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFA7F090AE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
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
       mov       rdx,7FFA7F091550
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
       mov       rdx,7FFA7F091550
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
       mov       rdx,7FFA7F091AA8
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
       mov       rdx,7FFA7F091550
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ClearNulls()
; 			var people = base.PersonProperList;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.AddLast(null);
; 			^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ClearNulls();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+160]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       xor       r8d,r8d
       call      dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
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
       mov       r8,246CAC81028
       mov       r8,[r8]
       mov       rdx,246AAC837E0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbp,[rdi+10]
       mov       r11,[rbp+10]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA7F0B08D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,246CAC81028
       mov       r9,[r9]
       mov       r8,246AAC837E0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       test      rbx,rbx
       jne       short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFA7F0B0AD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFA7F0B0AE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
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
       mov       rdx,7FFA7F0B1550
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
       mov       rdx,7FFA7F0B1550
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
       mov       rdx,7FFA7F0B1AA8
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
       mov       rdx,7FFA7F0B1550
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ClearNulls()
; 			var people = base.PersonProperList;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.AddLast(null);
; 			^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ClearNulls();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+160]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       xor       r8d,r8d
       call      dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
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
       mov       r8,20EFE5C3020
       mov       r8,[r8]
       mov       rdx,20EFE5C5BF0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbp,[rdi+10]
       mov       r11,[rbp+10]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA7F090850
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,20EFE5C3020
       mov       r9,[r9]
       mov       r8,20EFE5C5BF0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       test      rbx,rbx
       jne       short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFA7F090A48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFA7F090A60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
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
       mov       rdx,7FFA7F0914C8
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
       mov       rdx,7FFA7F0914C8
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
       mov       rdx,7FFA7F091A20
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
       mov       rdx,7FFA7F0914C8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ClearNulls()
; 			var people = base.PersonProperList;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.AddLast(null);
; 			^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ClearNulls();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+160]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       xor       r8d,r8d
       call      dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
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
       mov       r8,1F9BA453020
       mov       r8,[r8]
       mov       rdx,1F99A4517E8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbp,[rdi+10]
       mov       r11,[rbp+10]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA7F0B08D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1F9BA453020
       mov       r9,[r9]
       mov       r8,1F99A4517E8
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       test      rbx,rbx
       jne       short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFA7F0B0AC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFA7F0B0AE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
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
       mov       rdx,7FFA7F0B1548
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
       mov       rdx,7FFA7F0B1548
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
       mov       rdx,7FFA7F0B1AA0
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
       mov       rdx,7FFA7F0B1548
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ClearNulls()
; 			var people = base.PersonProperList;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.AddLast(null);
; 			^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ClearNulls();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+160]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       xor       r8d,r8d
       call      dotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls(System.Collections.Generic.List`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
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
       mov       r8,1C091861028
       mov       r8,[r8]
       mov       rdx,1C09186FB68
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbp,[rdi+10]
       mov       r11,[rbp+10]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA7F0A0890
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1C091861028
       mov       r9,[r9]
       mov       r8,1C09186FB68
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       test      rbx,rbx
       jne       short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFA7F0A0A88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFA7F0A0AA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
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
       mov       rdx,7FFA7F0A1508
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
       mov       rdx,7FFA7F0A1508
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
       mov       rdx,7FFA7F0A1A60
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
       mov       rdx,7FFA7F0A1508
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.CopyToList()
; 			var result = base.PersonProperList.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,24E649B3020
       mov       r8,[r8]
       mov       rdx,24E649C1B60
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
       mov       rdx,7FFA7F0C0650
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.CopyToList()
; 			var result = base.PersonProperList.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,1594E711028
       mov       r8,[r8]
       mov       rdx,1595E7117E8
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
       mov       rdx,7FFA7F0C0AE0
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.CopyToList()
; 			var result = base.PersonProperList.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,2BF4A731028
       mov       r8,[r8]
       mov       rdx,2BF2A7337E0
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
       mov       rdx,7FFA7F0A0B68
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.CopyToList()
; 			var result = base.PersonProperList.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,209CEBB3020
       mov       r8,[r8]
       mov       rdx,209AEBB17E8
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
       mov       rdx,7FFA7F0B0B20
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.CopyToList()
; 			var result = base.PersonProperList.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,1BBBAA13020
       mov       r8,[r8]
       mov       rdx,1BB9AA1D758
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
       mov       rdx,7FFA7F0B0B20
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.CopyToList()
; 			var result = base.PersonProperList.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,17FA3983020
       mov       r8,[r8]
       mov       rdx,17FB398F750
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
       mov       rdx,7FFA7F0A0B08
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.CopyToList()
; 			var result = base.PersonProperList.CopyToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,20364813020
       mov       r8,[r8]
       mov       rdx,203448117E8
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
       mov       rdx,7FFA7F0B0B20
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOf()
; 			var result = base.PersonProperList.IndexOf(base.PersonProperList.Last());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       rdx,7FFA7F0A2990
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
       mov       rdx,7FFA7F0A2088
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOf()
; 			var result = base.PersonProperList.IndexOf(base.PersonProperList.Last());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       rdx,7FFA7F0B2E48
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
       mov       rdx,7FFA7F0B2540
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOf()
; 			var result = base.PersonProperList.IndexOf(base.PersonProperList.Last());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       rdx,7FFA7F0C2EA8
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
       mov       rdx,7FFA7F0C25A0
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOf()
; 			var result = base.PersonProperList.IndexOf(base.PersonProperList.Last());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       rdx,7FFA7F0C2EA8
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
       mov       rdx,7FFA7F0C25A0
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOf()
; 			var result = base.PersonProperList.IndexOf(base.PersonProperList.Last());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       rdx,7FFA7F0B2E60
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
       mov       rdx,7FFA7F0B2558
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOf()
; 			var result = base.PersonProperList.IndexOf(base.PersonProperList.Last());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       rdx,7FFA7F092E60
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
       mov       rdx,7FFA7F092558
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOf()
; 			var result = base.PersonProperList.IndexOf(base.PersonProperList.Last());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       rdx,7FFA7F0B2EA0
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
       mov       rdx,7FFA7F0B25E8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOfComparer()
; 			var comparer = new PersonProperComparer();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.PersonProperList.IndexOf(base.PersonProperList.Last(), comparer);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,[rsi+160]
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
       mov       rdx,7FFA7F0B76A8
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
       mov       rdx,7FFA7F0B0578
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
       mov       r8,28A16A73020
       mov       r8,[r8]
       mov       rdx,289F6A717E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[r15+10]
       mov       rdx,28A26A71028
       mov       rdx,[rdx]
       mov       r8,28A16A73020
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r15+8]
       mov       rdx,28A26A71230
       mov       rdx,[rdx]
       mov       r8,28A16A73020
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B06A8
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
       mov       rdx,7FFA7F0B0750
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
       mov       rdx,7FFA7F0B0AB0
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
       mov       rdx,7FFA7F0B0AB0
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
       mov       rdx,7FFA7F0B0AB0
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOfComparer()
; 			var comparer = new PersonProperComparer();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.PersonProperList.IndexOf(base.PersonProperList.Last(), comparer);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,[rsi+160]
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
       mov       rdx,7FFA7F087628
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
       mov       rdx,7FFA7F080A90
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
       mov       r8,1C1D6D13020
       mov       r8,[r8]
       mov       rdx,1C1D6D21B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[r15+10]
       mov       rdx,1C1D6D21BB8
       mov       rdx,[rdx]
       mov       r8,1C1D6D13020
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r15+8]
       mov       rdx,1C1D6D21DC0
       mov       rdx,[rdx]
       mov       r8,1C1D6D13020
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFA7F080BC0
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
       mov       rdx,7FFA7F080C68
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
       mov       rdx,7FFA7F080FC8
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
       mov       rdx,7FFA7F080FC8
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
       mov       rdx,7FFA7F080FC8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOfComparer()
; 			var comparer = new PersonProperComparer();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.PersonProperList.IndexOf(base.PersonProperList.Last(), comparer);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,[rsi+160]
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
       mov       rdx,7FFA7F0B7AB8
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
       mov       rdx,7FFA7F0B0A88
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
       mov       r8,1B0C3043020
       mov       r8,[r8]
       mov       rdx,1B0C3045BF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[r15+10]
       mov       rdx,1B0A304CF98
       mov       rdx,[rdx]
       mov       r8,1B0C3043020
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r15+8]
       mov       rdx,1B0A304D1A0
       mov       rdx,[rdx]
       mov       r8,1B0C3043020
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B0BB8
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
       mov       rdx,7FFA7F0B0C60
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
       mov       rdx,7FFA7F0B0FC0
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
       mov       rdx,7FFA7F0B0FC0
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
       mov       rdx,7FFA7F0B0FC0
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOfComparer()
; 			var comparer = new PersonProperComparer();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.PersonProperList.IndexOf(base.PersonProperList.Last(), comparer);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,[rsi+160]
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
       mov       rdx,7FFA7F0C7AC0
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
       mov       rdx,7FFA7F0C0A90
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
       mov       r8,1C9D8883020
       mov       r8,[r8]
       mov       rdx,1C9E888F750
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[r15+10]
       mov       rdx,1C9D8883438
       mov       rdx,[rdx]
       mov       r8,1C9D8883020
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r15+8]
       mov       rdx,1C9D8883640
       mov       rdx,[rdx]
       mov       r8,1C9D8883020
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFA7F0C0BC0
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
       mov       rdx,7FFA7F0C0C68
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
       mov       rdx,7FFA7F0C0FC8
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
       mov       rdx,7FFA7F0C0FC8
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
       mov       rdx,7FFA7F0C0FC8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOfComparer()
; 			var comparer = new PersonProperComparer();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.PersonProperList.IndexOf(base.PersonProperList.Last(), comparer);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,[rsi+160]
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
       mov       rdx,7FFA7F0A7578
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
       mov       rdx,7FFA7F0A0A48
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
       mov       r8,20B71771028
       mov       r8,[r8]
       mov       rdx,20B517737E0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[r15+10]
       mov       rdx,20B7177F3A8
       mov       rdx,[rdx]
       mov       r8,20B71771028
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r15+8]
       mov       rdx,20B7177F5B0
       mov       rdx,[rdx]
       mov       r8,20B71771028
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A0B78
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
       mov       rdx,7FFA7F0A0C20
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
       mov       rdx,7FFA7F0A0F80
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
       mov       rdx,7FFA7F0A0F80
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
       mov       rdx,7FFA7F0A0F80
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOfComparer()
; 			var comparer = new PersonProperComparer();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.PersonProperList.IndexOf(base.PersonProperList.Last(), comparer);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,[rsi+160]
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
       mov       rdx,7FFA7F0B75C0
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
       mov       rdx,7FFA7F0B0A90
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
       mov       r8,229328F3020
       mov       r8,[r8]
       mov       rdx,22932901B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[r15+10]
       mov       rdx,229428F1028
       mov       rdx,[rdx]
       mov       r8,229328F3020
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r15+8]
       mov       rdx,229428F1230
       mov       rdx,[rdx]
       mov       r8,229328F3020
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B0BC0
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
       mov       rdx,7FFA7F0B0C68
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
       mov       rdx,7FFA7F0B0FC8
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
       mov       rdx,7FFA7F0B0FC8
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
       mov       rdx,7FFA7F0B0FC8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOfComparer()
; 			var comparer = new PersonProperComparer();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.PersonProperList.IndexOf(base.PersonProperList.Last(), comparer);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,[rsi+160]
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
       mov       rdx,7FFA7F0B7410
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
       mov       rdx,7FFA7F0B0A90
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
       mov       r8,2AAC86E1028
       mov       r8,[r8]
       mov       rdx,2AAC86EFB68
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[r15+10]
       mov       rdx,2AAA86E1028
       mov       rdx,[rdx]
       mov       r8,2AAC86E1028
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r15+8]
       mov       rdx,2AAA86E1230
       mov       rdx,[rdx]
       mov       r8,2AAC86E1028
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B0BC0
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
       mov       rdx,7FFA7F0B0C68
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
       mov       rdx,7FFA7F0B0FC8
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
       mov       rdx,7FFA7F0B0FC8
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
       mov       rdx,7FFA7F0B0FC8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeList()
; 			var result = base.PersonProperList.ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       rdx,7FFA7F0B0470
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,16E151A1028
       mov       r8,[r8]
       mov       rdx,16E251A17E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B05E0
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
       mov       rdx,7FFA7F0B0810
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
       mov       rdx,7FFA7F0B0810
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
       mov       rdx,7FFA7F0B0D68
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
       mov       rdx,7FFA7F0B0810
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
       mov       rdx,7FFA7F0B0850
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
       mov       rdx,7FFA7F0B0B80
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
       mov       rdx,7FFA7F0B0C28
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeList()
; 			var result = base.PersonProperList.ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       rdx,7FFA7F0B08A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,1996FE81028
       mov       r8,[r8]
       mov       rdx,1996FE8FB68
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B0A10
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
       mov       rdx,7FFA7F0B0C40
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
       mov       rdx,7FFA7F0B0C40
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
       mov       rdx,7FFA7F0B1198
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
       mov       rdx,7FFA7F0B0C40
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
       mov       rdx,7FFA7F0B0C80
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
       mov       rdx,7FFA7F0B0FB0
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
       mov       rdx,7FFA7F0B1058
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeList()
; 			var result = base.PersonProperList.ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       rdx,7FFA7F080900
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,17987CF3020
       mov       r8,[r8]
       mov       rdx,17977CF17E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFA7F080A70
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
       mov       rdx,7FFA7F080CA0
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
       mov       rdx,7FFA7F080CA0
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
       mov       rdx,7FFA7F0811F8
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
       mov       rdx,7FFA7F080CA0
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
       mov       rdx,7FFA7F080CE0
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
       mov       rdx,7FFA7F081010
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
       mov       rdx,7FFA7F0810B8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeList()
; 			var result = base.PersonProperList.ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       rdx,7FFA7F0A08A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,1A975AD3020
       mov       r8,[r8]
       mov       rdx,1A955AD17E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A0A10
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
       mov       rdx,7FFA7F0A0C40
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
       mov       rdx,7FFA7F0A0C40
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
       mov       rdx,7FFA7F0A1198
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
       mov       rdx,7FFA7F0A0C40
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
       mov       rdx,7FFA7F0A0C80
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
       mov       rdx,7FFA7F0A0FB0
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
       mov       rdx,7FFA7F0A1058
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeList()
; 			var result = base.PersonProperList.ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       rdx,7FFA7F0C08B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,284FCDB3020
       mov       r8,[r8]
       mov       rdx,284FCDC1B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFA7F0C0A28
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
       mov       rdx,7FFA7F0C0C58
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
       mov       rdx,7FFA7F0C0C58
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
       mov       rdx,7FFA7F0C11B0
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
       mov       rdx,7FFA7F0C0C58
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
       mov       rdx,7FFA7F0C0C98
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
       mov       rdx,7FFA7F0C0FC8
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
       mov       rdx,7FFA7F0C1070
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeList()
; 			var result = base.PersonProperList.ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       rdx,7FFA7F0A08B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,253CF4E3020
       mov       r8,[r8]
       mov       rdx,253CF4F1B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A0A28
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
       mov       rdx,7FFA7F0A0C58
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
       mov       rdx,7FFA7F0A0C58
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
       mov       rdx,7FFA7F0A11B0
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
       mov       rdx,7FFA7F0A0C58
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
       mov       rdx,7FFA7F0A0C98
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
       mov       rdx,7FFA7F0A0FC8
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
       mov       rdx,7FFA7F0A1070
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeList()
; 			var result = base.PersonProperList.ListHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       rdx,7FFA7F090900
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,189DB393020
       mov       r8,[r8]
       mov       rdx,189CB3917E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFA7F090A70
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
       mov       rdx,7FFA7F090CA0
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
       mov       rdx,7FFA7F090CA0
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
       mov       rdx,7FFA7F0911F8
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
       mov       rdx,7FFA7F090CA0
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
       mov       rdx,7FFA7F090CE0
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
       mov       rdx,7FFA7F091010
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
       mov       rdx,7FFA7F0910B8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderBy()
; 			var result = base.PersonProperList.OrderBy(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,[rsi+160]
       mov       rcx,23B571BB348
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,23B571BB340
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__8_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,23B571BB348
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
       mov       rdx,7FFA7F0B1950
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
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__8_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderBy()
; 			var result = base.PersonProperList.OrderBy(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,[rsi+160]
       mov       rcx,20369737370
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,20369737368
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__8_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,20369737370
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
       mov       rdx,7FFA7F0C1E60
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
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__8_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderBy()
; 			var result = base.PersonProperList.OrderBy(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,[rsi+160]
       mov       rcx,19642929350
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,19642929348
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__8_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,19642929350
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
       mov       rdx,7FFA7F0B1DE0
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
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__8_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderBy()
; 			var result = base.PersonProperList.OrderBy(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,[rsi+160]
       mov       rcx,169C34FB348
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,169C34FB340
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__8_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,169C34FB348
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
       mov       rdx,7FFA7F091E20
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
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__8_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderBy()
; 			var result = base.PersonProperList.OrderBy(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,[rsi+160]
       mov       rcx,213DCE42F68
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,213DCE42F60
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__8_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,213DCE42F68
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
       mov       rdx,7FFA7F0A1E20
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
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__8_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderBy()
; 			var result = base.PersonProperList.OrderBy(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,[rsi+160]
       mov       rcx,21B82929350
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,21B82929348
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__8_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,21B82929350
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
       mov       rdx,7FFA7F0C1F98
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
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__8_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderBy()
; 			var result = base.PersonProperList.OrderBy(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,[rsi+160]
       mov       rcx,2A754696F40
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2A754696F38
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__8_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2A754696F40
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
       mov       rdx,7FFA7F091E20
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
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__8_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderByOrdinal()
; 			var result = base.PersonProperList.OrderByOrdinal(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+160]
       mov       rcx,195495AB350
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,195495AB340
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__9_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,195495AB350
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
       mov       r8,195495A3020
       mov       r8,[r8]
       mov       rdx,195595A17E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,195495A3020
       mov       r8,[r8]
       mov       rdx,195495B15A8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,195495A1388
       mov       rbp,[rcx]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA7F090468
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
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__9_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderByOrdinal()
; 			var result = base.PersonProperList.OrderByOrdinal(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+160]
       mov       rcx,1C76A249358
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1C76A249348
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__9_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1C76A249358
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
       mov       r8,1C76A241028
       mov       r8,[r8]
       mov       rdx,1C75A2417E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,1C76A241028
       mov       r8,[r8]
       mov       rdx,1C75A241A48
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,1C74A241388
       mov       rbp,[rcx]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA7F0C04B0
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
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__9_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderByOrdinal()
; 			var result = base.PersonProperList.OrderByOrdinal(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+160]
       mov       rcx,24BA6F79358
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,24BA6F79348
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__9_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,24BA6F79358
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
       mov       r8,24BA6F71028
       mov       r8,[r8]
       mov       rdx,24B86F737E0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,24BA6F71028
       mov       r8,[r8]
       mov       rdx,24B86F73A40
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,24B86F71388
       mov       rbp,[rcx]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A0920
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
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__9_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderByOrdinal()
; 			var result = base.PersonProperList.OrderByOrdinal(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+160]
       mov       rcx,1CBB53B2F70
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1CBB53B2F60
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__9_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1CBB53B2F70
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
       mov       r8,1CBD53B3020
       mov       r8,[r8]
       mov       rdx,1CBB53B9780
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,1CBD53B3020
       mov       r8,[r8]
       mov       rdx,1CBC53B1230
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,1CBD53B1388
       mov       rbp,[rcx]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A0980
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
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__9_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderByOrdinal()
; 			var result = base.PersonProperList.OrderByOrdinal(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+160]
       mov       rcx,2BB93A96F48
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2BB93A96F38
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__9_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2BB93A96F48
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
       mov       r8,2BBB3A93020
       mov       r8,[r8]
       mov       rdx,2BBA3A917E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,2BBB3A93020
       mov       r8,[r8]
       mov       rdx,2BBA3A91A48
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,2BBB3A91388
       mov       rbp,[rcx]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA7F080920
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
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__9_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderByOrdinal()
; 			var result = base.PersonProperList.OrderByOrdinal(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+160]
       mov       rcx,28D54C6B350
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,28D54C6B340
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__9_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,28D54C6B350
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
       mov       r8,28D54C63020
       mov       r8,[r8]
       mov       rdx,28D54C71B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,28D54C63020
       mov       r8,[r8]
       mov       rdx,28D44C61230
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,28D54C61388
       mov       rbp,[rcx]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A0920
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
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__9_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderByOrdinal()
; 			var result = base.PersonProperList.OrderByOrdinal(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+160]
       mov       rcx,14E42F39358
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,14E42F39348
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__9_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,14E42F39358
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
       mov       r8,14E42F31028
       mov       r8,[r8]
       mov       rdx,14E42F3FB68
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,14E42F31028
       mov       r8,[r8]
       mov       rdx,14E32F31230
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,14E22F31388
       mov       rbp,[rcx]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B0980
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
dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__9_0(dotNetTips.Spargine.Tester.Models.PersonProper)

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+160]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Page(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,2
       call      dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,rax
       mov       r11,7FFA7EB90640
       call      qword ptr [7FFA7EFA0640]
       mov       [rbp+0FFF0],rax
; 			foreach (var people in base.PersonProperList.Page(2))
; 			                    ^^
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB90648
       call      qword ptr [7FFA7EFA0648]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB90650
       call      qword ptr [7FFA7EFA0650]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFA7EB90658
       call      qword ptr [7FFA7EFA0658]
       mov       [rbp+0FFE8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFA7EB90668
       call      qword ptr [7FFA7EFA0668]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFA7EB90660
       call      qword ptr [7FFA7EFA0660]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFA7EB90670
       call      qword ptr [7FFA7EFA0670]
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB90648
       call      qword ptr [7FFA7EFA0648]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB90678
       call      qword ptr [7FFA7EFA0678]
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
       mov       r11,7FFA7EB90670
       call      qword ptr [7FFA7EFA0670]
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
       mov       r11,7FFA7EB90678
       call      qword ptr [7FFA7EFA0678]
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
       mov       rdx,7FFA7F0C0800
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       mov       rcx,7FFA7EC80020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M01_L02
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M01_L02:
       cmp       [rcx],ecx
       call      00007FFADE7E1100
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+160]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Page(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,2
       call      dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,rax
       mov       r11,7FFA7EB80640
       call      qword ptr [7FFA7EF90640]
       mov       [rbp+0FFF0],rax
; 			foreach (var people in base.PersonProperList.Page(2))
; 			                    ^^
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB80648
       call      qword ptr [7FFA7EF90648]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB80650
       call      qword ptr [7FFA7EF90650]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFA7EB80658
       call      qword ptr [7FFA7EF90658]
       mov       [rbp+0FFE8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFA7EB80668
       call      qword ptr [7FFA7EF90668]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFA7EB80660
       call      qword ptr [7FFA7EF90660]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFA7EB80670
       call      qword ptr [7FFA7EF90670]
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB80648
       call      qword ptr [7FFA7EF90648]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB80678
       call      qword ptr [7FFA7EF90678]
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
       mov       r11,7FFA7EB80670
       call      qword ptr [7FFA7EF90670]
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
       mov       r11,7FFA7EB80678
       call      qword ptr [7FFA7EF90678]
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
       mov       rdx,7FFA7F0B0CB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       mov       rcx,7FFA7EC70020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M01_L02
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M01_L02:
       cmp       [rcx],ecx
       call      00007FFADE7E1100
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+160]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Page(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,2
       call      dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,rax
       mov       r11,7FFA7EB70640
       call      qword ptr [7FFA7EF80640]
       mov       [rbp+0FFF0],rax
; 			foreach (var people in base.PersonProperList.Page(2))
; 			                    ^^
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB70648
       call      qword ptr [7FFA7EF80648]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB70650
       call      qword ptr [7FFA7EF80650]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFA7EB70658
       call      qword ptr [7FFA7EF80658]
       mov       [rbp+0FFE8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFA7EB70668
       call      qword ptr [7FFA7EF80668]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFA7EB70660
       call      qword ptr [7FFA7EF80660]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFA7EB70670
       call      qword ptr [7FFA7EF80670]
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB70648
       call      qword ptr [7FFA7EF80648]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB70678
       call      qword ptr [7FFA7EF80678]
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
       mov       r11,7FFA7EB70670
       call      qword ptr [7FFA7EF80670]
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
       mov       r11,7FFA7EB70678
       call      qword ptr [7FFA7EF80678]
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
       mov       rdx,7FFA7F0A0CB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       mov       rcx,7FFA7EC60020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M01_L02
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M01_L02:
       cmp       [rcx],ecx
       call      00007FFADE7E1100
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+160]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Page(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,2
       call      dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,rax
       mov       r11,7FFA7EB80640
       call      qword ptr [7FFA7EF90640]
       mov       [rbp+0FFF0],rax
; 			foreach (var people in base.PersonProperList.Page(2))
; 			                    ^^
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB80648
       call      qword ptr [7FFA7EF90648]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB80650
       call      qword ptr [7FFA7EF90650]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFA7EB80658
       call      qword ptr [7FFA7EF90658]
       mov       [rbp+0FFE8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFA7EB80668
       call      qword ptr [7FFA7EF90668]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFA7EB80660
       call      qword ptr [7FFA7EF90660]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFA7EB80670
       call      qword ptr [7FFA7EF90670]
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB80648
       call      qword ptr [7FFA7EF90648]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB80678
       call      qword ptr [7FFA7EF90678]
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
       mov       r11,7FFA7EB80670
       call      qword ptr [7FFA7EF90670]
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
       mov       r11,7FFA7EB80678
       call      qword ptr [7FFA7EF90678]
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
       mov       rdx,7FFA7F0B0D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       mov       rcx,7FFA7EC70020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M01_L02
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M01_L02:
       cmp       [rcx],ecx
       call      00007FFADE7E1100
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+160]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Page(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,2
       call      dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,rax
       mov       r11,7FFA7EB60640
       call      qword ptr [7FFA7EF70640]
       mov       [rbp+0FFF0],rax
; 			foreach (var people in base.PersonProperList.Page(2))
; 			                    ^^
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB60648
       call      qword ptr [7FFA7EF70648]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB60650
       call      qword ptr [7FFA7EF70650]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFA7EB60658
       call      qword ptr [7FFA7EF70658]
       mov       [rbp+0FFE8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFA7EB60668
       call      qword ptr [7FFA7EF70668]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFA7EB60660
       call      qword ptr [7FFA7EF70660]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFA7EB60670
       call      qword ptr [7FFA7EF70670]
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB60648
       call      qword ptr [7FFA7EF70648]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB60678
       call      qword ptr [7FFA7EF70678]
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
       mov       r11,7FFA7EB60670
       call      qword ptr [7FFA7EF70670]
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
       mov       r11,7FFA7EB60678
       call      qword ptr [7FFA7EF70678]
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
       mov       rdx,7FFA7F090CD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       mov       rcx,7FFA7EC50020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M01_L02
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M01_L02:
       cmp       [rcx],ecx
       call      00007FFADE7E1100
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+160]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Page(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,2
       call      dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,rax
       mov       r11,7FFA7EB70640
       call      qword ptr [7FFA7EF80640]
       mov       [rbp+0FFF0],rax
; 			foreach (var people in base.PersonProperList.Page(2))
; 			                    ^^
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB70648
       call      qword ptr [7FFA7EF80648]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB70650
       call      qword ptr [7FFA7EF80650]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFA7EB70658
       call      qword ptr [7FFA7EF80658]
       mov       [rbp+0FFE8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFA7EB70668
       call      qword ptr [7FFA7EF80668]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFA7EB70660
       call      qword ptr [7FFA7EF80660]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFA7EB70670
       call      qword ptr [7FFA7EF80670]
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB70648
       call      qword ptr [7FFA7EF80648]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB70678
       call      qword ptr [7FFA7EF80678]
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
       mov       r11,7FFA7EB70670
       call      qword ptr [7FFA7EF80670]
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
       mov       r11,7FFA7EB70678
       call      qword ptr [7FFA7EF80678]
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
       mov       rdx,7FFA7F0A0D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       mov       rcx,7FFA7EC60020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M01_L02
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M01_L02:
       cmp       [rcx],ecx
       call      00007FFADE7E1100
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+160]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.Page(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,2
       call      dotNetTips.Spargine.Extensions.ListExtensions.Page[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,rax
       mov       r11,7FFA7EB60640
       call      qword ptr [7FFA7EF70640]
       mov       [rbp+0FFF0],rax
; 			foreach (var people in base.PersonProperList.Page(2))
; 			                    ^^
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB60648
       call      qword ptr [7FFA7EF70648]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB60650
       call      qword ptr [7FFA7EF70650]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFA7EB60658
       call      qword ptr [7FFA7EF70658]
       mov       [rbp+0FFE8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFA7EB60668
       call      qword ptr [7FFA7EF70668]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFA7EB60660
       call      qword ptr [7FFA7EF70660]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFE8]
       mov       r11,7FFA7EB60670
       call      qword ptr [7FFA7EF70670]
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB60648
       call      qword ptr [7FFA7EF70648]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFA7EB60678
       call      qword ptr [7FFA7EF70678]
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
       mov       r11,7FFA7EB60670
       call      qword ptr [7FFA7EF70670]
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
       mov       r11,7FFA7EB60678
       call      qword ptr [7FFA7EF70678]
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
       mov       rdx,7FFA7F090D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       mov       rcx,7FFA7EC50020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M01_L02
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M01_L02:
       cmp       [rcx],ecx
       call      00007FFADE7E1100
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom()
; 			var result = base.PersonProperList.Take(base.Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       r8d,[rsi+198]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
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
; Total bytes of code 74
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
       mov       rdx,7FFA7F0A1C78
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
       mov       rdx,7FFA7F0A1C28
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom()
; 			var result = base.PersonProperList.Take(base.Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       r8d,[rsi+198]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
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
; Total bytes of code 74
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
       mov       rdx,7FFA7F0A2190
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
       mov       rdx,7FFA7F0A2140
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom()
; 			var result = base.PersonProperList.Take(base.Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       r8d,[rsi+198]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
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
; Total bytes of code 74
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
       mov       rdx,7FFA7F0A1FE0
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
       mov       rdx,7FFA7F0A1F90
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom()
; 			var result = base.PersonProperList.Take(base.Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       r8d,[rsi+198]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
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
; Total bytes of code 74
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
       mov       rdx,7FFA7F0B2188
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
       mov       rdx,7FFA7F0B2138
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom()
; 			var result = base.PersonProperList.Take(base.Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       r8d,[rsi+198]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
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
; Total bytes of code 74
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
       mov       rdx,7FFA7F0C2148
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
       mov       rdx,7FFA7F0C20F8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom()
; 			var result = base.PersonProperList.Take(base.Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       r8d,[rsi+198]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
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
; Total bytes of code 74
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
       mov       rdx,7FFA7F0A2190
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
       mov       rdx,7FFA7F0A2140
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom()
; 			var result = base.PersonProperList.Take(base.Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
       mov       r8d,[rsi+198]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
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
; Total bytes of code 74
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
       mov       rdx,7FFA7F092148
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
       mov       rdx,7FFA7F0920F8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Shuffle()
; 			var result = base.PersonProperList.Shuffle();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,2160EC03020
       mov       r8,[r8]
       mov       rdx,215EEC017E8
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
       mov       rdx,7FFA7F082138
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
       mov       rdx,7FFA7F082138
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
       mov       rdx,7FFA7F0822B8
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
       mov       rdx,7FFA7F082138
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
       mov       rdx,7FFA7F082178
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Shuffle()
; 			var result = base.PersonProperList.Shuffle();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,22177983020
       mov       r8,[r8]
       mov       rdx,2218798F750
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
       mov       rdx,7FFA7F0825B8
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
       mov       rdx,7FFA7F0825B8
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
       mov       rdx,7FFA7F082738
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
       mov       rdx,7FFA7F0825B8
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
       mov       rdx,7FFA7F0825F8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Shuffle()
; 			var result = base.PersonProperList.Shuffle();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,2559B293020
       mov       r8,[r8]
       mov       rdx,2557B2917E8
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
       mov       rdx,7FFA7F092650
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
       mov       rdx,7FFA7F092650
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
       mov       rdx,7FFA7F0927D0
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
       mov       rdx,7FFA7F092650
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
       mov       rdx,7FFA7F092690
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Shuffle()
; 			var result = base.PersonProperList.Shuffle();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,183A6DD3020
       mov       r8,[r8]
       mov       rdx,183A6DE1B60
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
       mov       rdx,7FFA7F0A25D0
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
       mov       rdx,7FFA7F0A25D0
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
       mov       rdx,7FFA7F0A2750
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
       mov       rdx,7FFA7F0A25D0
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
       mov       rdx,7FFA7F0A2610
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Shuffle()
; 			var result = base.PersonProperList.Shuffle();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,254B1691028
       mov       r8,[r8]
       mov       rdx,254916937E0
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
       mov       rdx,7FFA7F092610
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
       mov       rdx,7FFA7F092610
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
       mov       rdx,7FFA7F092790
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
       mov       rdx,7FFA7F092610
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
       mov       rdx,7FFA7F092650
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Shuffle()
; 			var result = base.PersonProperList.Shuffle();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,2D6DF1D3020
       mov       r8,[r8]
       mov       rdx,2D6DF1D5BF0
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
       mov       rdx,7FFA7F0825F8
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
       mov       rdx,7FFA7F0825F8
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
       mov       rdx,7FFA7F082778
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
       mov       rdx,7FFA7F0825F8
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
       mov       rdx,7FFA7F082638
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Shuffle()
; 			var result = base.PersonProperList.Shuffle();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,20FA5B23020
       mov       r8,[r8]
       mov       rdx,20FA5B31B60
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
       mov       rdx,7FFA7F092610
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
       mov       rdx,7FFA7F092610
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
       mov       rdx,7FFA7F092790
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
       mov       rdx,7FFA7F092610
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
       mov       rdx,7FFA7F092650
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToObservableCollection()
; 			var result = base.PersonProperList.ToObservableCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,23E410A3020
       mov       r8,[r8]
       mov       rdx,23E410B1B60
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
       mov       rdx,7FFA7F0578D0
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToObservableCollection()
; 			var result = base.PersonProperList.ToObservableCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,20695BB1028
       mov       r8,[r8]
       mov       rdx,20685BB37E0
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
       mov       rdx,7FFA7F037840
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToObservableCollection()
; 			var result = base.PersonProperList.ToObservableCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,16DEA5D1028
       mov       r8,[r8]
       mov       rdx,16DEA5D3BF8
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
       mov       rdx,7FFA7F037840
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToObservableCollection()
; 			var result = base.PersonProperList.ToObservableCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,211A4313020
       mov       r8,[r8]
       mov       rdx,211843117E8
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
       mov       rdx,7FFA7F067D18
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToObservableCollection()
; 			var result = base.PersonProperList.ToObservableCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,128D09E3020
       mov       r8,[r8]
       mov       rdx,128B09E17E8
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
       mov       rdx,7FFA7F037D18
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToObservableCollection()
; 			var result = base.PersonProperList.ToObservableCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,1DDB3B13020
       mov       r8,[r8]
       mov       rdx,1DDB3B15BF0
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
       mov       rdx,7FFA7F0378D0
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToObservableCollection()
; 			var result = base.PersonProperList.ToObservableCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,1EF3B653020
       mov       r8,[r8]
       mov       rdx,1EF3B661B60
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
       mov       rdx,7FFA7F047D18
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToReadOnlyCollection()
; 			var result = base.PersonProperList.ToReadOnlyCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,1E648D63020
       mov       r8,[r8]
       mov       rdx,1E628D617E8
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
       mov       rdx,7FFA7F047DE8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToReadOnlyCollection()
; 			var result = base.PersonProperList.ToReadOnlyCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,1C136583020
       mov       r8,[r8]
       mov       rdx,1C136585BF0
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
       mov       rdx,7FFA7F047FD8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToReadOnlyCollection()
; 			var result = base.PersonProperList.ToReadOnlyCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,2551F163020
       mov       r8,[r8]
       mov       rdx,2550F1617E8
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
       mov       rdx,7FFA7F057D58
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToReadOnlyCollection()
; 			var result = base.PersonProperList.ToReadOnlyCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,23B19ED1028
       mov       r8,[r8]
       mov       rdx,23B19EDFB68
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
       mov       rdx,7FFA7F068230
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToReadOnlyCollection()
; 			var result = base.PersonProperList.ToReadOnlyCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,20FAA253020
       mov       r8,[r8]
       mov       rdx,20FAA253BF8
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
       mov       rdx,7FFA7F037FD8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToReadOnlyCollection()
; 			var result = base.PersonProperList.ToReadOnlyCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,2A464A93020
       mov       r8,[r8]
       mov       rdx,2A454A917E8
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
       mov       rdx,7FFA7F068230
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToReadOnlyCollection()
; 			var result = base.PersonProperList.ToReadOnlyCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+160]
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
       mov       r8,29C741C3020
       mov       r8,[r8]
       mov       rdx,29C541C17E8
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
       mov       rdx,7FFA7F047FD8
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

