## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Any01()
; 			var result = AnyWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,128B313B7E0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,128B313B7D8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any01>b__0_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,128B313B7E0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any01>b__0_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = AnyWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                              ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L08
       test      rdi,rdi
       je        near ptr M02_L09
       mov       r14,[rsi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF16430
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
       mov       r11,7FFEBC980638
       call      qword ptr [7FFEBCF40638]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF16508
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC980638
       call      qword ptr [7FFEBCF40638]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp+0FFD4],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC980640
       call      qword ptr [7FFEBCF40640]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L07:
       mov       rcx,rsp
       call      M02_L10
       nop
       mov       eax,[rbp+0FFD4]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L09:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFC8]
       test      rcx,rcx
       je        short M02_L11
       mov       r11,7FFEBC980640
       call      qword ptr [7FFEBCF40640]
M02_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 348
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Any01()
; 			var result = AnyWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,1CB8B6597E8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1CB8B6597E0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any01>b__0_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1CB8B6597E8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any01>b__0_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = AnyWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                              ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L08
       test      rdi,rdi
       je        near ptr M02_L09
       mov       r14,[rsi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06430
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
       mov       r11,7FFEBC970638
       call      qword ptr [7FFEBCF30638]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06508
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC970638
       call      qword ptr [7FFEBCF30638]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp+0FFD4],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC970640
       call      qword ptr [7FFEBCF30640]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L07:
       mov       rcx,rsp
       call      M02_L10
       nop
       mov       eax,[rbp+0FFD4]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L09:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFC8]
       test      rcx,rcx
       je        short M02_L11
       mov       r11,7FFEBC970640
       call      qword ptr [7FFEBCF30640]
M02_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 348
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Any01()
; 			var result = AnyWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,1C4A25673D8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1C4A25673D0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any01>b__0_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1C4A25673D8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any01>b__0_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = AnyWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                              ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L08
       test      rdi,rdi
       je        near ptr M02_L09
       mov       r14,[rsi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF6430
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
       mov       r11,7FFEBC960638
       call      qword ptr [7FFEBCF20638]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF6508
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC960638
       call      qword ptr [7FFEBCF20638]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp+0FFD4],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC960640
       call      qword ptr [7FFEBCF20640]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L07:
       mov       rcx,rsp
       call      M02_L10
       nop
       mov       eax,[rbp+0FFD4]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L09:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFC8]
       test      rcx,rcx
       je        short M02_L11
       mov       r11,7FFEBC960640
       call      qword ptr [7FFEBCF20640]
M02_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 348
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Any01()
; 			var result = AnyWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,18FAC41B7E0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,18FAC41B7D8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any01>b__0_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,18FAC41B7E0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any01>b__0_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = AnyWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                              ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L08
       test      rdi,rdi
       je        near ptr M02_L09
       mov       r14,[rsi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF26430
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
       mov       r11,7FFEBC990638
       call      qword ptr [7FFEBCF50638]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF26508
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC990638
       call      qword ptr [7FFEBCF50638]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp+0FFD4],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC990640
       call      qword ptr [7FFEBCF50640]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L07:
       mov       rcx,rsp
       call      M02_L10
       nop
       mov       eax,[rbp+0FFD4]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L09:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFC8]
       test      rcx,rcx
       je        short M02_L11
       mov       r11,7FFEBC990640
       call      qword ptr [7FFEBCF50640]
M02_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 348
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Any01()
; 			var result = AnyWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,27AFA5293D0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,27AFA5293C8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any01>b__0_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,27AFA5293D0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any01>b__0_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = AnyWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                              ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L08
       test      rdi,rdi
       je        near ptr M02_L09
       mov       r14,[rsi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06430
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
       mov       r11,7FFEBC970638
       call      qword ptr [7FFEBCF30638]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06508
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC970638
       call      qword ptr [7FFEBCF30638]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp+0FFD4],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC970640
       call      qword ptr [7FFEBCF30640]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L07:
       mov       rcx,rsp
       call      M02_L10
       nop
       mov       eax,[rbp+0FFD4]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L09:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFC8]
       test      rcx,rcx
       je        short M02_L11
       mov       r11,7FFEBC970640
       call      qword ptr [7FFEBCF30640]
M02_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 348
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Any01()
; 			var result = AnyWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,28E2CA3B7E0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,28E2CA3B7D8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any01>b__0_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,28E2CA3B7E0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any01>b__0_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = AnyWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                              ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L08
       test      rdi,rdi
       je        near ptr M02_L09
       mov       r14,[rsi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF26430
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
       mov       r11,7FFEBC990638
       call      qword ptr [7FFEBCF50638]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF26508
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC990638
       call      qword ptr [7FFEBCF50638]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp+0FFD4],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC990640
       call      qword ptr [7FFEBCF50640]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L07:
       mov       rcx,rsp
       call      M02_L10
       nop
       mov       eax,[rbp+0FFD4]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L09:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFC8]
       test      rcx,rcx
       je        short M02_L11
       mov       r11,7FFEBC990640
       call      qword ptr [7FFEBCF50640]
M02_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 348
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Any01()
; 			var result = AnyWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,1F69ECC97E8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1F69ECC97E0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any01>b__0_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1F69ECC97E8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any01>b__0_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = AnyWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                              ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L08
       test      rdi,rdi
       je        near ptr M02_L09
       mov       r14,[rsi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF16410
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
       mov       r11,7FFEBC980638
       call      qword ptr [7FFEBCF40638]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF164E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC980638
       call      qword ptr [7FFEBCF40638]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp+0FFD4],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC980640
       call      qword ptr [7FFEBCF40640]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L07:
       mov       rcx,rsp
       call      M02_L10
       nop
       mov       eax,[rbp+0FFD4]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L09:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFC8]
       test      rcx,rcx
       je        short M02_L11
       mov       r11,7FFEBC980640
       call      qword ptr [7FFEBCF40640]
M02_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 348
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Any01()
; 			var result = AnyWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,2E031F893D0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2E031F893C8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any01>b__0_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2E031F893D0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any01>b__0_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = AnyWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                              ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L08
       test      rdi,rdi
       je        near ptr M02_L09
       mov       r14,[rsi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCFC1DA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
       mov       r11,7FFEBC980768
       call      qword ptr [7FFEBCF30768]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCFC1E78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC980768
       call      qword ptr [7FFEBCF30768]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp+0FFD4],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC980770
       call      qword ptr [7FFEBCF30770]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L07:
       mov       rcx,rsp
       call      M02_L10
       nop
       mov       eax,[rbp+0FFD4]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L09:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFC8]
       test      rcx,rcx
       je        short M02_L11
       mov       r11,7FFEBC980770
       call      qword ptr [7FFEBCF30770]
M02_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 348
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Count01()
; 			var result = CountWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,17A14CB93E0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,17A14CB93C8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count01>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,17A14CB93E0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Count(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count01>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = CountWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                                ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L07
       test      rsi,rsi
       je        near ptr M02_L08
       xor       r14d,r14d
       mov       r15,[rdi+10]
       mov       r11,[r15+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCF06490
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFC8],rbx
M02_L02:
       mov       rcx,rbx
       mov       r11,7FFEBC970638
       call      qword ptr [7FFEBCF30638]
       test      eax,eax
       je        short M02_L06
       mov       r11,[r15+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFEBCF06568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        short M02_L02
       add       r14d,1
       jo        short M02_L05
       jmp       short M02_L02
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L06:
       mov       rcx,rbx
       mov       r11,7FFEBC970640
       call      qword ptr [7FFEBCF30640]
       mov       eax,r14d
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L08:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M02_L09
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC970640
       call      qword ptr [7FFEBCF30640]
M02_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 319
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Count01()
; 			var result = CountWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,2A67DEDB7F0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2A67DEDB7D8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count01>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2A67DEDB7F0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Count(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count01>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = CountWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                                ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L07
       test      rsi,rsi
       je        near ptr M02_L08
       xor       r14d,r14d
       mov       r15,[rdi+10]
       mov       r11,[r15+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCF26490
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFC8],rbx
M02_L02:
       mov       rcx,rbx
       mov       r11,7FFEBC990638
       call      qword ptr [7FFEBCF50638]
       test      eax,eax
       je        short M02_L06
       mov       r11,[r15+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFEBCF26568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        short M02_L02
       add       r14d,1
       jo        short M02_L05
       jmp       short M02_L02
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L06:
       mov       rcx,rbx
       mov       r11,7FFEBC990640
       call      qword ptr [7FFEBCF50640]
       mov       eax,r14d
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L08:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M02_L09
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC990640
       call      qword ptr [7FFEBCF50640]
M02_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 319
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Count01()
; 			var result = CountWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,17B4C6173E8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,17B4C6173D0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count01>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,17B4C6173E8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Count(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count01>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = CountWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                                ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L07
       test      rsi,rsi
       je        near ptr M02_L08
       xor       r14d,r14d
       mov       r15,[rdi+10]
       mov       r11,[r15+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCF16490
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFC8],rbx
M02_L02:
       mov       rcx,rbx
       mov       r11,7FFEBC980638
       call      qword ptr [7FFEBCF40638]
       test      eax,eax
       je        short M02_L06
       mov       r11,[r15+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFEBCF16568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        short M02_L02
       add       r14d,1
       jo        short M02_L05
       jmp       short M02_L02
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L06:
       mov       rcx,rbx
       mov       r11,7FFEBC980640
       call      qword ptr [7FFEBCF40640]
       mov       eax,r14d
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L08:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M02_L09
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC980640
       call      qword ptr [7FFEBCF40640]
M02_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 319
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Count01()
; 			var result = CountWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,2377D8A97F8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2377D8A97E0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count01>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2377D8A97F8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Count(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count01>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = CountWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                                ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L07
       test      rsi,rsi
       je        near ptr M02_L08
       xor       r14d,r14d
       mov       r15,[rdi+10]
       mov       r11,[r15+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCF06490
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFC8],rbx
M02_L02:
       mov       rcx,rbx
       mov       r11,7FFEBC970638
       call      qword ptr [7FFEBCF30638]
       test      eax,eax
       je        short M02_L06
       mov       r11,[r15+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFEBCF06568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        short M02_L02
       add       r14d,1
       jo        short M02_L05
       jmp       short M02_L02
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L06:
       mov       rcx,rbx
       mov       r11,7FFEBC970640
       call      qword ptr [7FFEBCF30640]
       mov       eax,r14d
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L08:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M02_L09
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC970640
       call      qword ptr [7FFEBCF30640]
M02_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 319
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Count01()
; 			var result = CountWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,251B42C73E8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,251B42C73D0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count01>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,251B42C73E8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Count(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count01>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = CountWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                                ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L07
       test      rsi,rsi
       je        near ptr M02_L08
       xor       r14d,r14d
       mov       r15,[rdi+10]
       mov       r11,[r15+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCF063D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFC8],rbx
M02_L02:
       mov       rcx,rbx
       mov       r11,7FFEBC970638
       call      qword ptr [7FFEBCF30638]
       test      eax,eax
       je        short M02_L06
       mov       r11,[r15+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFEBCF064B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        short M02_L02
       add       r14d,1
       jo        short M02_L05
       jmp       short M02_L02
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L06:
       mov       rcx,rbx
       mov       r11,7FFEBC970640
       call      qword ptr [7FFEBCF30640]
       mov       eax,r14d
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L08:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M02_L09
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC970640
       call      qword ptr [7FFEBCF30640]
M02_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 319
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Count01()
; 			var result = CountWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,2A35D0873E8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2A35D0873D0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count01>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2A35D0873E8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Count(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count01>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = CountWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                                ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L07
       test      rsi,rsi
       je        near ptr M02_L08
       xor       r14d,r14d
       mov       r15,[rdi+10]
       mov       r11,[r15+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCF263D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFC8],rbx
M02_L02:
       mov       rcx,rbx
       mov       r11,7FFEBC990638
       call      qword ptr [7FFEBCF50638]
       test      eax,eax
       je        short M02_L06
       mov       r11,[r15+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFEBCF264B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        short M02_L02
       add       r14d,1
       jo        short M02_L05
       jmp       short M02_L02
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L06:
       mov       rcx,rbx
       mov       r11,7FFEBC990640
       call      qword ptr [7FFEBCF50640]
       mov       eax,r14d
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L08:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M02_L09
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC990640
       call      qword ptr [7FFEBCF50640]
M02_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 319
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Count01()
; 			var result = CountWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,1A15BFA97F8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1A15BFA97E0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count01>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1A15BFA97F8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Count(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count01>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = CountWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                                ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L07
       test      rsi,rsi
       je        near ptr M02_L08
       xor       r14d,r14d
       mov       r15,[rdi+10]
       mov       r11,[r15+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCF263B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFC8],rbx
M02_L02:
       mov       rcx,rbx
       mov       r11,7FFEBC990638
       call      qword ptr [7FFEBCF50638]
       test      eax,eax
       je        short M02_L06
       mov       r11,[r15+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFEBCF26490
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        short M02_L02
       add       r14d,1
       jo        short M02_L05
       jmp       short M02_L02
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L06:
       mov       rcx,rbx
       mov       r11,7FFEBC990640
       call      qword ptr [7FFEBCF50640]
       mov       eax,r14d
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L08:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M02_L09
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC990640
       call      qword ptr [7FFEBCF50640]
M02_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 319
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Count01()
; 			var result = CountWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,1E41A8973E8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1E41A8973D0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count01>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1E41A8973E8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Count(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count01>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = CountWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                                ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L07
       test      rsi,rsi
       je        near ptr M02_L08
       xor       r14d,r14d
       mov       r15,[rdi+10]
       mov       r11,[r15+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCFD1610
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFC8],rbx
M02_L02:
       mov       rcx,rbx
       mov       r11,7FFEBC990768
       call      qword ptr [7FFEBCF40768]
       test      eax,eax
       je        short M02_L06
       mov       r11,[r15+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFEBCFD16E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        short M02_L02
       add       r14d,1
       jo        short M02_L05
       jmp       short M02_L02
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L06:
       mov       rcx,rbx
       mov       r11,7FFEBC990770
       call      qword ptr [7FFEBCF40770]
       mov       eax,r14d
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L08:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M02_L09
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC990770
       call      qword ptr [7FFEBCF40770]
M02_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 319
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Any02()
; 			var result = base.GetPersonProperArray(Tristate.False).FastAny(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,1C7898973E0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1C7898973D0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any02>b__1_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1C7898973E0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any02>b__1_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = base.GetPersonProperArray(Tristate.False).FastAny(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+58],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rax,1C779891028
       mov       rbx,[rax]
       mov       [rsp+50],rbx
       mov       rbp,[rsi+10]
       mov       r14,rdx
       mov       rax,1C769894FC8
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      r14,r14
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rbx
       mov       rax,1C769895268
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF12370
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,r14
       mov       r8,rdi
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 281
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Any02()
; 			var result = base.GetPersonProperArray(Tristate.False).FastAny(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,22117CBB7E8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,22117CBB7D8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any02>b__1_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,22117CBB7E8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any02>b__1_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = base.GetPersonProperArray(Tristate.False).FastAny(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+58],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rax,22117CB3020
       mov       rbx,[rax]
       mov       [rsp+50],rbx
       mov       rbp,[rsi+10]
       mov       r14,rdx
       mov       rax,22117CC2FF0
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      r14,r14
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rbx
       mov       rax,22117CC3290
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF32370
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,r14
       mov       r8,rdi
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 281
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Any02()
; 			var result = base.GetPersonProperArray(Tristate.False).FastAny(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,1704B6CB7E8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1704B6CB7D8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any02>b__1_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1704B6CB7E8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any02>b__1_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = base.GetPersonProperArray(Tristate.False).FastAny(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+58],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rax,1704B6C3020
       mov       rbx,[rax]
       mov       [rsp+50],rbx
       mov       rbp,[rsi+10]
       mov       r14,rdx
       mov       rax,1702B6C1FB8
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      r14,r14
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rbx
       mov       rax,1702B6C2258
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02370
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,r14
       mov       r8,rdi
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 281
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Any02()
; 			var result = base.GetPersonProperArray(Tristate.False).FastAny(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,1E33382B7E8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1E33382B7D8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any02>b__1_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1E33382B7E8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any02>b__1_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = base.GetPersonProperArray(Tristate.False).FastAny(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+58],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rax,1E333823020
       mov       rbx,[rax]
       mov       [rsp+50],rbx
       mov       rbp,[rsi+10]
       mov       r14,rdx
       mov       rax,1E313822FD0
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      r14,r14
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rbx
       mov       rax,1E313823270
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02370
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,r14
       mov       r8,rdi
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 281
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Any02()
; 			var result = base.GetPersonProperArray(Tristate.False).FastAny(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,2302350B7E8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2302350B7D8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any02>b__1_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2302350B7E8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any02>b__1_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = base.GetPersonProperArray(Tristate.False).FastAny(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+58],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rax,23023503020
       mov       rbx,[rax]
       mov       [rsp+50],rbx
       mov       rbp,[rsi+10]
       mov       r14,rdx
       mov       rax,230135017A0
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      r14,r14
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rbx
       mov       rax,23013501A40
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF22370
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,r14
       mov       r8,rdi
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 281
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Any02()
; 			var result = base.GetPersonProperArray(Tristate.False).FastAny(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,1A1BC0E73E0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1A1BC0E73D0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any02>b__1_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1A1BC0E73E0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any02>b__1_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = base.GetPersonProperArray(Tristate.False).FastAny(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+58],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rax,1A18C0E3020
       mov       rbx,[rax]
       mov       [rsp+50],rbx
       mov       rbp,[rsi+10]
       mov       r14,rdx
       mov       rax,1A18C0E73D8
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      r14,r14
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rbx
       mov       rax,1A18C0E7678
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF2370
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,r14
       mov       r8,rdi
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 281
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Any02()
; 			var result = base.GetPersonProperArray(Tristate.False).FastAny(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,215F40573E0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,215F40573D0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any02>b__1_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,215F40573E0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any02>b__1_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = base.GetPersonProperArray(Tristate.False).FastAny(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+58],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rax,215C4053020
       mov       rbx,[rax]
       mov       [rsp+50],rbx
       mov       rbp,[rsi+10]
       mov       r14,rdx
       mov       rax,215E40517A0
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      r14,r14
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rbx
       mov       rax,215E4051A40
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02370
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,r14
       mov       r8,rdi
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 281
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Any02()
; 			var result = base.GetPersonProperArray(Tristate.False).FastAny(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,1856ED1B7E8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1856ED1B7D8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any02>b__1_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1856ED1B7E8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Any02>b__1_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = base.GetPersonProperArray(Tristate.False).FastAny(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+58],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rax,1856ED13020
       mov       rbx,[rax]
       mov       [rsp+50],rbx
       mov       rbp,[rsi+10]
       mov       r14,rdx
       mov       rax,1854ED12FD0
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      r14,r14
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rbx
       mov       rax,1854ED13270
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF9B268
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,r14
       mov       r8,rdi
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 281
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Count02()
; 			var result = base.GetPersonProperArray(Tristate.False).FastCount(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,25E357FB7F8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,25E357FB7D8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count02>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,25E357FB7F8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count02>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = base.GetPersonProperArray(Tristate.False).FastCount(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+58],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rax,25E357F3020
       mov       rbx,[rax]
       mov       [rsp+50],rbx
       mov       rbp,[rsi+10]
       mov       r14,rdx
       mov       rax,25E35802FF0
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      r14,r14
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rbx
       mov       rax,25E35803290
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF323D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,r14
       mov       r8,rdi
       call      System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 281
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Count02()
; 			var result = base.GetPersonProperArray(Tristate.False).FastCount(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,16809B473F0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,16809B473D0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count02>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,16809B473F0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count02>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = base.GetPersonProperArray(Tristate.False).FastCount(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+58],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rax,16829B43020
       mov       rbx,[rax]
       mov       [rsp+50],rbx
       mov       rbp,[rsi+10]
       mov       r14,rdx
       mov       rax,16829B46BC0
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      r14,r14
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rbx
       mov       rax,16829B46E60
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF223D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,r14
       mov       r8,rdi
       call      System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 281
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Count02()
; 			var result = base.GetPersonProperArray(Tristate.False).FastCount(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,1FE703E73F0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1FE703E73D0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count02>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1FE703E73F0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count02>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = base.GetPersonProperArray(Tristate.False).FastCount(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+58],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rax,1FE503E3020
       mov       rbx,[rax]
       mov       [rsp+50],rbx
       mov       rbp,[rsi+10]
       mov       r14,rdx
       mov       rax,1FE703EDBD0
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      r14,r14
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rbx
       mov       rax,1FE703EDE70
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF23D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,r14
       mov       r8,rdi
       call      System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 281
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Count02()
; 			var result = base.GetPersonProperArray(Tristate.False).FastCount(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,18C0745B7F8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,18C0745B7D8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count02>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,18C0745B7F8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count02>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = base.GetPersonProperArray(Tristate.False).FastCount(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+58],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rax,18C07453020
       mov       rbx,[rax]
       mov       [rsp+50],rbx
       mov       rbp,[rsi+10]
       mov       r14,rdx
       mov       rax,18C07462FF0
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      r14,r14
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rbx
       mov       rax,18C07463290
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF123D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,r14
       mov       r8,rdi
       call      System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 281
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Count02()
; 			var result = base.GetPersonProperArray(Tristate.False).FastCount(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,2106478B7F8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2106478B7D8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count02>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2106478B7F8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count02>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = base.GetPersonProperArray(Tristate.False).FastCount(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+58],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rax,21064783020
       mov       rbx,[rax]
       mov       [rsp+50],rbx
       mov       rbp,[rsi+10]
       mov       r14,rdx
       mov       rax,21064792FF0
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      r14,r14
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rbx
       mov       rax,21064793290
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF23D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,r14
       mov       r8,rdi
       call      System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 281
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Count02()
; 			var result = base.GetPersonProperArray(Tristate.False).FastCount(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,2A0F9E373F0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2A0F9E373D0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count02>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2A0F9E373F0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count02>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = base.GetPersonProperArray(Tristate.False).FastCount(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+58],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rax,2A0E9E33020
       mov       rbx,[rax]
       mov       [rsp+50],rbx
       mov       rbp,[rsi+10]
       mov       r14,rdx
       mov       rax,2A0C9E31FB8
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      r14,r14
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rbx
       mov       rax,2A0C9E32258
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF23D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,r14
       mov       r8,rdi
       call      System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 281
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Count02()
; 			var result = base.GetPersonProperArray(Tristate.False).FastCount(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,1D4D721B7F8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1D4D721B7D8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count02>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1D4D721B7F8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count02>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = base.GetPersonProperArray(Tristate.False).FastCount(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+58],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rax,1D4D7213020
       mov       rbx,[rax]
       mov       [rsp+50],rbx
       mov       rbp,[rsi+10]
       mov       r14,rdx
       mov       rax,1D4D7221FD8
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      r14,r14
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rbx
       mov       rax,1D4D7222278
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF323B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,r14
       mov       r8,rdi
       call      System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 281
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Count02()
; 			var result = base.GetPersonProperArray(Tristate.False).FastCount(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rcx,18CE31BB7F8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,18CE31BB7D8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count02>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,18CE31BB7F8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<Count02>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = base.GetPersonProperArray(Tristate.False).FastCount(p => p.City.Contains('A', StringComparison.CurrentCulture));
; 			                                                                      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       edx,41
       xor       r8d,r8d
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+58],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rax,18CE31B3020
       mov       rbx,[rax]
       mov       [rsp+50],rbx
       mov       rbp,[rsi+10]
       mov       r14,rdx
       mov       rax,18CE31C2FF0
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      r14,r14
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rbx
       mov       rax,18CE31C3290
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCFBB2C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,r14
       mov       r8,rdi
       call      System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 281
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
; 			var result = base.GetPersonProperArray(Tristate.False).FirstOrDefault(alternate: this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rbx,[rsi+18]
       test      rdi,rdi
       je        short M00_L00
       mov       rcx,offset MT_System.Linq.Enumerable+DefaultIfEmptyIterator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       r8,[rsp+20]
       mov       rdx,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M00_L02
       mov       rdx,rax
       jmp       short M00_L01
M00_L00:
       mov       rdx,rbx
M00_L01:
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 153
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       xor       eax,eax
       mov       [rbp+0FFB0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L21
       mov       r14,[rsi+10]
       mov       rcx,r14
       mov       r15,[rcx+8]
       cmp       r15,48
       jle       near ptr M01_L06
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L06
M01_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r12,rax
       test      r12,r12
       jne       short M01_L04
       mov       rcx,r14
       cmp       r15,50
       jle       near ptr M01_L10
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L13
       cmp       r15,68
       jle       near ptr M01_L11
       mov       r11,[r14+68]
       test      r11,r11
       je        near ptr M01_L11
M01_L02:
       mov       rcx,r13
       call      qword ptr [r11]
       test      eax,eax
       jg        near ptr M01_L09
M01_L03:
       mov       byte ptr [rbx],0
       xor       eax,eax
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
M01_L04:
       mov       rcx,r14
       cmp       r15,78
       jle       near ptr M01_L12
       mov       r11,[rcx+78]
       test      r11,r11
       je        near ptr M01_L12
M01_L05:
       mov       rcx,r12
       mov       rdx,rbx
       call      qword ptr [r11]
       nop
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
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF26800
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFEBCF26D30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       mov       rcx,r13
       mov       r11,rax
       xor       edx,edx
       call      qword ptr [rax]
       nop
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
M01_L09:
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],70
       jle       short M01_L07
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L07
       mov       rax,r11
       jmp       short M01_L08
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCF26AF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFEBCF26D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FFEBCF26D48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L05
M01_L13:
       mov       rcx,r14
       cmp       r15,58
       jle       short M01_L18
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M01_L18
M01_L14:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,rax
       mov       r11,7FFEBC990678
       call      qword ptr [7FFEBCF50678]
       test      eax,eax
       jne       short M01_L16
       jmp       short M01_L19
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       [rbp+0FFB0],rax
       jmp       short M01_L20
M01_L16:
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],60
       jle       short M01_L17
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L15
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCF26C40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L15
M01_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCF26C28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L14
M01_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFEBC990680
       call      qword ptr [7FFEBCF50680]
       jmp       near ptr M01_L03
M01_L20:
       mov       rcx,rsp
       call      M01_L22
       nop
       mov       rax,[rbp+0FFB0]
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
M01_L21:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L22:
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
       lea       rbp,[rbp+80]
       mov       rcx,[rbp+0FFB8]
       test      rcx,rcx
       je        short M01_L23
       mov       r11,7FFEBC990680
       call      qword ptr [7FFEBCF50680]
M01_L23:
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
; Total bytes of code 720
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
; 			var result = base.GetPersonProperArray(Tristate.False).FirstOrDefault(alternate: this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rbx,[rsi+18]
       test      rdi,rdi
       je        short M00_L00
       mov       rcx,offset MT_System.Linq.Enumerable+DefaultIfEmptyIterator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       r8,[rsp+20]
       mov       rdx,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M00_L02
       mov       rdx,rax
       jmp       short M00_L01
M00_L00:
       mov       rdx,rbx
M00_L01:
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 153
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       xor       eax,eax
       mov       [rbp+0FFB0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L21
       mov       r14,[rsi+10]
       mov       rcx,r14
       mov       r15,[rcx+8]
       cmp       r15,48
       jle       near ptr M01_L06
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L06
M01_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r12,rax
       test      r12,r12
       jne       short M01_L04
       mov       rcx,r14
       cmp       r15,50
       jle       near ptr M01_L10
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L13
       cmp       r15,68
       jle       near ptr M01_L11
       mov       r11,[r14+68]
       test      r11,r11
       je        near ptr M01_L11
M01_L02:
       mov       rcx,r13
       call      qword ptr [r11]
       test      eax,eax
       jg        near ptr M01_L09
M01_L03:
       mov       byte ptr [rbx],0
       xor       eax,eax
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
M01_L04:
       mov       rcx,r14
       cmp       r15,78
       jle       near ptr M01_L12
       mov       r11,[rcx+78]
       test      r11,r11
       je        near ptr M01_L12
M01_L05:
       mov       rcx,r12
       mov       rdx,rbx
       call      qword ptr [r11]
       nop
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
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06800
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06D30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       mov       rcx,r13
       mov       r11,rax
       xor       edx,edx
       call      qword ptr [rax]
       nop
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
M01_L09:
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],70
       jle       short M01_L07
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L07
       mov       rax,r11
       jmp       short M01_L08
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06AF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06D48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L05
M01_L13:
       mov       rcx,r14
       cmp       r15,58
       jle       short M01_L18
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M01_L18
M01_L14:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,rax
       mov       r11,7FFEBC970678
       call      qword ptr [7FFEBCF30678]
       test      eax,eax
       jne       short M01_L16
       jmp       short M01_L19
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       [rbp+0FFB0],rax
       jmp       short M01_L20
M01_L16:
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],60
       jle       short M01_L17
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L15
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06C40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L15
M01_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06C28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L14
M01_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFEBC970680
       call      qword ptr [7FFEBCF30680]
       jmp       near ptr M01_L03
M01_L20:
       mov       rcx,rsp
       call      M01_L22
       nop
       mov       rax,[rbp+0FFB0]
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
M01_L21:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L22:
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
       lea       rbp,[rbp+80]
       mov       rcx,[rbp+0FFB8]
       test      rcx,rcx
       je        short M01_L23
       mov       r11,7FFEBC970680
       call      qword ptr [7FFEBCF30680]
M01_L23:
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
; Total bytes of code 720
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
; 			var result = base.GetPersonProperArray(Tristate.False).FirstOrDefault(alternate: this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rbx,[rsi+18]
       test      rdi,rdi
       je        short M00_L00
       mov       rcx,offset MT_System.Linq.Enumerable+DefaultIfEmptyIterator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       r8,[rsp+20]
       mov       rdx,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M00_L02
       mov       rdx,rax
       jmp       short M00_L01
M00_L00:
       mov       rdx,rbx
M00_L01:
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 153
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       xor       eax,eax
       mov       [rbp+0FFB0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L21
       mov       r14,[rsi+10]
       mov       rcx,r14
       mov       r15,[rcx+8]
       cmp       r15,48
       jle       near ptr M01_L06
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L06
M01_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r12,rax
       test      r12,r12
       jne       short M01_L04
       mov       rcx,r14
       cmp       r15,50
       jle       near ptr M01_L10
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L13
       cmp       r15,68
       jle       near ptr M01_L11
       mov       r11,[r14+68]
       test      r11,r11
       je        near ptr M01_L11
M01_L02:
       mov       rcx,r13
       call      qword ptr [r11]
       test      eax,eax
       jg        near ptr M01_L09
M01_L03:
       mov       byte ptr [rbx],0
       xor       eax,eax
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
M01_L04:
       mov       rcx,r14
       cmp       r15,78
       jle       near ptr M01_L12
       mov       r11,[rcx+78]
       test      r11,r11
       je        near ptr M01_L12
M01_L05:
       mov       rcx,r12
       mov       rdx,rbx
       call      qword ptr [r11]
       nop
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
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF16800
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFEBCF16D30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       mov       rcx,r13
       mov       r11,rax
       xor       edx,edx
       call      qword ptr [rax]
       nop
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
M01_L09:
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],70
       jle       short M01_L07
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L07
       mov       rax,r11
       jmp       short M01_L08
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCF16AF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFEBCF16D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FFEBCF16D48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L05
M01_L13:
       mov       rcx,r14
       cmp       r15,58
       jle       short M01_L18
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M01_L18
M01_L14:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,rax
       mov       r11,7FFEBC980678
       call      qword ptr [7FFEBCF40678]
       test      eax,eax
       jne       short M01_L16
       jmp       short M01_L19
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       [rbp+0FFB0],rax
       jmp       short M01_L20
M01_L16:
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],60
       jle       short M01_L17
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L15
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCF16C40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L15
M01_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCF16C28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L14
M01_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFEBC980680
       call      qword ptr [7FFEBCF40680]
       jmp       near ptr M01_L03
M01_L20:
       mov       rcx,rsp
       call      M01_L22
       nop
       mov       rax,[rbp+0FFB0]
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
M01_L21:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L22:
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
       lea       rbp,[rbp+80]
       mov       rcx,[rbp+0FFB8]
       test      rcx,rcx
       je        short M01_L23
       mov       r11,7FFEBC980680
       call      qword ptr [7FFEBCF40680]
M01_L23:
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
; Total bytes of code 720
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
; 			var result = base.GetPersonProperArray(Tristate.False).FirstOrDefault(alternate: this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rbx,[rsi+18]
       test      rdi,rdi
       je        short M00_L00
       mov       rcx,offset MT_System.Linq.Enumerable+DefaultIfEmptyIterator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       r8,[rsp+20]
       mov       rdx,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M00_L02
       mov       rdx,rax
       jmp       short M00_L01
M00_L00:
       mov       rdx,rbx
M00_L01:
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 153
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       xor       eax,eax
       mov       [rbp+0FFB0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L21
       mov       r14,[rsi+10]
       mov       rcx,r14
       mov       r15,[rcx+8]
       cmp       r15,48
       jle       near ptr M01_L06
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L06
M01_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r12,rax
       test      r12,r12
       jne       short M01_L04
       mov       rcx,r14
       cmp       r15,50
       jle       near ptr M01_L10
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L13
       cmp       r15,68
       jle       near ptr M01_L11
       mov       r11,[r14+68]
       test      r11,r11
       je        near ptr M01_L11
M01_L02:
       mov       rcx,r13
       call      qword ptr [r11]
       test      eax,eax
       jg        near ptr M01_L09
M01_L03:
       mov       byte ptr [rbx],0
       xor       eax,eax
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
M01_L04:
       mov       rcx,r14
       cmp       r15,78
       jle       near ptr M01_L12
       mov       r11,[rcx+78]
       test      r11,r11
       je        near ptr M01_L12
M01_L05:
       mov       rcx,r12
       mov       rdx,rbx
       call      qword ptr [r11]
       nop
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
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF26800
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFEBCF26D30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       mov       rcx,r13
       mov       r11,rax
       xor       edx,edx
       call      qword ptr [rax]
       nop
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
M01_L09:
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],70
       jle       short M01_L07
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L07
       mov       rax,r11
       jmp       short M01_L08
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCF26AF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFEBCF26D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FFEBCF26D48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L05
M01_L13:
       mov       rcx,r14
       cmp       r15,58
       jle       short M01_L18
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M01_L18
M01_L14:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,rax
       mov       r11,7FFEBC990678
       call      qword ptr [7FFEBCF50678]
       test      eax,eax
       jne       short M01_L16
       jmp       short M01_L19
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       [rbp+0FFB0],rax
       jmp       short M01_L20
M01_L16:
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],60
       jle       short M01_L17
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L15
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCF26C40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L15
M01_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCF26C28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L14
M01_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFEBC990680
       call      qword ptr [7FFEBCF50680]
       jmp       near ptr M01_L03
M01_L20:
       mov       rcx,rsp
       call      M01_L22
       nop
       mov       rax,[rbp+0FFB0]
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
M01_L21:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L22:
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
       lea       rbp,[rbp+80]
       mov       rcx,[rbp+0FFB8]
       test      rcx,rcx
       je        short M01_L23
       mov       r11,7FFEBC990680
       call      qword ptr [7FFEBCF50680]
M01_L23:
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
; Total bytes of code 720
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
; 			var result = base.GetPersonProperArray(Tristate.False).FirstOrDefault(alternate: this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rbx,[rsi+18]
       test      rdi,rdi
       je        short M00_L00
       mov       rcx,offset MT_System.Linq.Enumerable+DefaultIfEmptyIterator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       r8,[rsp+20]
       mov       rdx,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M00_L02
       mov       rdx,rax
       jmp       short M00_L01
M00_L00:
       mov       rdx,rbx
M00_L01:
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 153
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       xor       eax,eax
       mov       [rbp+0FFB0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L21
       mov       r14,[rsi+10]
       mov       rcx,r14
       mov       r15,[rcx+8]
       cmp       r15,48
       jle       near ptr M01_L06
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L06
M01_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r12,rax
       test      r12,r12
       jne       short M01_L04
       mov       rcx,r14
       cmp       r15,50
       jle       near ptr M01_L10
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L13
       cmp       r15,68
       jle       near ptr M01_L11
       mov       r11,[r14+68]
       test      r11,r11
       je        near ptr M01_L11
M01_L02:
       mov       rcx,r13
       call      qword ptr [r11]
       test      eax,eax
       jg        near ptr M01_L09
M01_L03:
       mov       byte ptr [rbx],0
       xor       eax,eax
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
M01_L04:
       mov       rcx,r14
       cmp       r15,78
       jle       near ptr M01_L12
       mov       r11,[rcx+78]
       test      r11,r11
       je        near ptr M01_L12
M01_L05:
       mov       rcx,r12
       mov       rdx,rbx
       call      qword ptr [r11]
       nop
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
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF25EB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFEBCF263E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       mov       rcx,r13
       mov       r11,rax
       xor       edx,edx
       call      qword ptr [rax]
       nop
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
M01_L09:
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],70
       jle       short M01_L07
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L07
       mov       rax,r11
       jmp       short M01_L08
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCF261A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFEBCF263C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FFEBCF263F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L05
M01_L13:
       mov       rcx,r14
       cmp       r15,58
       jle       short M01_L18
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M01_L18
M01_L14:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,rax
       mov       r11,7FFEBC990648
       call      qword ptr [7FFEBCF50648]
       test      eax,eax
       jne       short M01_L16
       jmp       short M01_L19
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       [rbp+0FFB0],rax
       jmp       short M01_L20
M01_L16:
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],60
       jle       short M01_L17
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L15
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCF262F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L15
M01_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCF262D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L14
M01_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFEBC990650
       call      qword ptr [7FFEBCF50650]
       jmp       near ptr M01_L03
M01_L20:
       mov       rcx,rsp
       call      M01_L22
       nop
       mov       rax,[rbp+0FFB0]
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
M01_L21:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L22:
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
       lea       rbp,[rbp+80]
       mov       rcx,[rbp+0FFB8]
       test      rcx,rcx
       je        short M01_L23
       mov       r11,7FFEBC990650
       call      qword ptr [7FFEBCF50650]
M01_L23:
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
; Total bytes of code 720
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
; 			var result = base.GetPersonProperArray(Tristate.False).FirstOrDefault(alternate: this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rbx,[rsi+18]
       test      rdi,rdi
       je        short M00_L00
       mov       rcx,offset MT_System.Linq.Enumerable+DefaultIfEmptyIterator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       r8,[rsp+20]
       mov       rdx,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M00_L02
       mov       rdx,rax
       jmp       short M00_L01
M00_L00:
       mov       rdx,rbx
M00_L01:
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 153
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       xor       eax,eax
       mov       [rbp+0FFB0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L21
       mov       r14,[rsi+10]
       mov       rcx,r14
       mov       r15,[rcx+8]
       cmp       r15,48
       jle       near ptr M01_L06
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L06
M01_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r12,rax
       test      r12,r12
       jne       short M01_L04
       mov       rcx,r14
       cmp       r15,50
       jle       near ptr M01_L10
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L13
       cmp       r15,68
       jle       near ptr M01_L11
       mov       r11,[r14+68]
       test      r11,r11
       je        near ptr M01_L11
M01_L02:
       mov       rcx,r13
       call      qword ptr [r11]
       test      eax,eax
       jg        near ptr M01_L09
M01_L03:
       mov       byte ptr [rbx],0
       xor       eax,eax
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
M01_L04:
       mov       rcx,r14
       cmp       r15,78
       jle       near ptr M01_L12
       mov       r11,[rcx+78]
       test      r11,r11
       je        near ptr M01_L12
M01_L05:
       mov       rcx,r12
       mov       rdx,rbx
       call      qword ptr [r11]
       nop
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
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06800
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06D30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       mov       rcx,r13
       mov       r11,rax
       xor       edx,edx
       call      qword ptr [rax]
       nop
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
M01_L09:
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],70
       jle       short M01_L07
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L07
       mov       rax,r11
       jmp       short M01_L08
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06AF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06D48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L05
M01_L13:
       mov       rcx,r14
       cmp       r15,58
       jle       short M01_L18
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M01_L18
M01_L14:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,rax
       mov       r11,7FFEBC970678
       call      qword ptr [7FFEBCF30678]
       test      eax,eax
       jne       short M01_L16
       jmp       short M01_L19
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       [rbp+0FFB0],rax
       jmp       short M01_L20
M01_L16:
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],60
       jle       short M01_L17
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L15
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06C40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L15
M01_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06C28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L14
M01_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFEBC970680
       call      qword ptr [7FFEBCF30680]
       jmp       near ptr M01_L03
M01_L20:
       mov       rcx,rsp
       call      M01_L22
       nop
       mov       rax,[rbp+0FFB0]
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
M01_L21:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L22:
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
       lea       rbp,[rbp+80]
       mov       rcx,[rbp+0FFB8]
       test      rcx,rcx
       je        short M01_L23
       mov       r11,7FFEBC970680
       call      qword ptr [7FFEBCF30680]
M01_L23:
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
; Total bytes of code 720
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
; 			var result = base.GetPersonProperArray(Tristate.False).FirstOrDefault(alternate: this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rbx,[rsi+18]
       test      rdi,rdi
       je        short M00_L00
       mov       rcx,offset MT_System.Linq.Enumerable+DefaultIfEmptyIterator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       r8,[rsp+20]
       mov       rdx,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M00_L02
       mov       rdx,rax
       jmp       short M00_L01
M00_L00:
       mov       rdx,rbx
M00_L01:
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 153
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       xor       eax,eax
       mov       [rbp+0FFB0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L21
       mov       r14,[rsi+10]
       mov       rcx,r14
       mov       r15,[rcx+8]
       cmp       r15,48
       jle       near ptr M01_L06
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L06
M01_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r12,rax
       test      r12,r12
       jne       short M01_L04
       mov       rcx,r14
       cmp       r15,50
       jle       near ptr M01_L10
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L13
       cmp       r15,68
       jle       near ptr M01_L11
       mov       r11,[r14+68]
       test      r11,r11
       je        near ptr M01_L11
M01_L02:
       mov       rcx,r13
       call      qword ptr [r11]
       test      eax,eax
       jg        near ptr M01_L09
M01_L03:
       mov       byte ptr [rbx],0
       xor       eax,eax
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
M01_L04:
       mov       rcx,r14
       cmp       r15,78
       jle       near ptr M01_L12
       mov       r11,[rcx+78]
       test      r11,r11
       je        near ptr M01_L12
M01_L05:
       mov       rcx,r12
       mov       rdx,rbx
       call      qword ptr [r11]
       nop
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
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF067E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06D10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       mov       rcx,r13
       mov       r11,rax
       xor       edx,edx
       call      qword ptr [rax]
       nop
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
M01_L09:
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],70
       jle       short M01_L07
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L07
       mov       rax,r11
       jmp       short M01_L08
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06AD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06CF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06D28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L05
M01_L13:
       mov       rcx,r14
       cmp       r15,58
       jle       short M01_L18
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M01_L18
M01_L14:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,rax
       mov       r11,7FFEBC970678
       call      qword ptr [7FFEBCF30678]
       test      eax,eax
       jne       short M01_L16
       jmp       short M01_L19
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       [rbp+0FFB0],rax
       jmp       short M01_L20
M01_L16:
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],60
       jle       short M01_L17
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L15
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06C20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L15
M01_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06C08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L14
M01_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFEBC970680
       call      qword ptr [7FFEBCF30680]
       jmp       near ptr M01_L03
M01_L20:
       mov       rcx,rsp
       call      M01_L22
       nop
       mov       rax,[rbp+0FFB0]
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
M01_L21:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L22:
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
       lea       rbp,[rbp+80]
       mov       rcx,[rbp+0FFB8]
       test      rcx,rcx
       je        short M01_L23
       mov       r11,7FFEBC970680
       call      qword ptr [7FFEBCF30680]
M01_L23:
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
; Total bytes of code 720
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
; 			var result = base.GetPersonProperArray(Tristate.False).FirstOrDefault(alternate: this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+100]
       mov       rbx,[rsi+18]
       test      rdi,rdi
       je        short M00_L00
       mov       rcx,offset MT_System.Linq.Enumerable+DefaultIfEmptyIterator`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       r8,[rsp+20]
       mov       rdx,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M00_L02
       mov       rdx,rax
       jmp       short M00_L01
M00_L00:
       mov       rdx,rbx
M00_L01:
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 153
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       xor       eax,eax
       mov       [rbp+0FFB0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M01_L21
       mov       r14,[rsi+10]
       mov       rcx,r14
       mov       r15,[rcx+8]
       cmp       r15,48
       jle       near ptr M01_L06
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L06
M01_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r12,rax
       test      r12,r12
       jne       short M01_L04
       mov       rcx,r14
       cmp       r15,50
       jle       near ptr M01_L10
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L13
       cmp       r15,68
       jle       near ptr M01_L11
       mov       r11,[r14+68]
       test      r11,r11
       je        near ptr M01_L11
M01_L02:
       mov       rcx,r13
       call      qword ptr [r11]
       test      eax,eax
       jg        near ptr M01_L09
M01_L03:
       mov       byte ptr [rbx],0
       xor       eax,eax
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
M01_L04:
       mov       rcx,r14
       cmp       r15,78
       jle       near ptr M01_L12
       mov       r11,[rcx+78]
       test      r11,r11
       je        near ptr M01_L12
M01_L05:
       mov       rcx,r12
       mov       rdx,rbx
       call      qword ptr [r11]
       nop
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
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCFC0640
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFEBCFC0B70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       mov       rcx,r13
       mov       r11,rax
       xor       edx,edx
       call      qword ptr [rax]
       nop
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
M01_L09:
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],70
       jle       short M01_L07
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L07
       mov       rax,r11
       jmp       short M01_L08
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCFC0938
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFEBCFC0B58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FFEBCFC0B88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L05
M01_L13:
       mov       rcx,r14
       cmp       r15,58
       jle       short M01_L18
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M01_L18
M01_L14:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,rax
       mov       r11,7FFEBC9806B8
       call      qword ptr [7FFEBCF306B8]
       test      eax,eax
       jne       short M01_L16
       jmp       short M01_L19
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       [rbp+0FFB0],rax
       jmp       short M01_L20
M01_L16:
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],60
       jle       short M01_L17
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L15
M01_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCFC0A80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L15
M01_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCFC0A68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L14
M01_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFEBC9806C0
       call      qword ptr [7FFEBCF306C0]
       jmp       near ptr M01_L03
M01_L20:
       mov       rcx,rsp
       call      M01_L22
       nop
       mov       rax,[rbp+0FFB0]
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
M01_L21:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L22:
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
       lea       rbp,[rbp+80]
       mov       rcx,[rbp+0FFB8]
       test      rcx,rcx
       je        short M01_L23
       mov       r11,7FFEBC9806C0
       call      qword ptr [7FFEBCF306C0]
M01_L23:
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
; Total bytes of code 720
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
; 			var result = this.GetPersonProperArray().FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],r9
       mov       r9,[rsi+18]
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
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
; Total bytes of code 131
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,11F5D523020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,11F3D5215C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE300A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = this.GetPersonProperArray().FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
; 			                                                             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r8,[rdx+48]
       mov       rax,[rcx+18]
       mov       rdx,[rax+48]
       cmp       r8,rdx
       je        short M02_L03
       test      r8,r8
       je        short M02_L00
       test      rdx,rdx
       je        short M02_L00
       mov       eax,[r8+8]
       cmp       eax,[rdx+8]
       je        short M02_L02
M02_L00:
       xor       eax,eax
M02_L01:
       ret
M02_L02:
       lea       rcx,[r8+0C]
       add       rdx,0C
       mov       r8d,[r8+8]
       add       r8d,r8d
       jmp       near ptr System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M02_L03:
       mov       eax,1
       jmp       short M02_L01
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+48],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbp,r8
       mov       rsi,r9
       mov       rax,11F5D523020
       mov       rax,[rax]
       mov       [rsp+40],rax
       mov       r14,[rdi+10]
       mov       rax,11F3D522268
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+30],rax
       test      rbx,rbx
       jne       short M03_L01
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L01:
       mov       rax,11F5D523020
       mov       rax,[rax]
       mov       [rsp+40],rax
       mov       rax,11F3D522270
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M03_L03
       jmp       short M03_L04
M03_L03:
       mov       rcx,rdi
       mov       rdx,7FFEBCF839B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       mov       rdx,rbx
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       test      rbx,rbx
       je        short M03_L05
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
M03_L05:
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L06:
       mov       rcx,[rdi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCF83B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 405
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
; 			var result = this.GetPersonProperArray().FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],r9
       mov       r9,[rsi+18]
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
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
; Total bytes of code 131
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2A51B2A1028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2A4FB2A35C0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE400A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = this.GetPersonProperArray().FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
; 			                                                             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r8,[rdx+48]
       mov       rax,[rcx+18]
       mov       rdx,[rax+48]
       cmp       r8,rdx
       je        short M02_L03
       test      r8,r8
       je        short M02_L00
       test      rdx,rdx
       je        short M02_L00
       mov       eax,[r8+8]
       cmp       eax,[rdx+8]
       je        short M02_L02
M02_L00:
       xor       eax,eax
M02_L01:
       ret
M02_L02:
       lea       rcx,[r8+0C]
       add       rdx,0C
       mov       r8d,[r8+8]
       add       r8d,r8d
       jmp       near ptr System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M02_L03:
       mov       eax,1
       jmp       short M02_L01
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+48],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbp,r8
       mov       rsi,r9
       mov       rax,2A51B2A1028
       mov       rax,[rax]
       mov       [rsp+40],rax
       mov       r14,[rdi+10]
       mov       rax,2A4FB2A4260
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+30],rax
       test      rbx,rbx
       jne       short M03_L01
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L01:
       mov       rax,2A51B2A1028
       mov       rax,[rax]
       mov       [rsp+40],rax
       mov       rax,2A4FB2A4268
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M03_L03
       jmp       short M03_L04
M03_L03:
       mov       rcx,rdi
       mov       rdx,7FFEBCF93948
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       mov       rdx,rbx
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       test      rbx,rbx
       je        short M03_L05
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
M03_L05:
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L06:
       mov       rcx,[rdi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCF93B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 405
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
; 			var result = this.GetPersonProperArray().FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],r9
       mov       r9,[rsi+18]
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
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
; Total bytes of code 131
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,244F5F03020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,244F5F0FE08
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE300A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = this.GetPersonProperArray().FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
; 			                                                             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r8,[rdx+48]
       mov       rax,[rcx+18]
       mov       rdx,[rax+48]
       cmp       r8,rdx
       je        short M02_L03
       test      r8,r8
       je        short M02_L00
       test      rdx,rdx
       je        short M02_L00
       mov       eax,[r8+8]
       cmp       eax,[rdx+8]
       je        short M02_L02
M02_L00:
       xor       eax,eax
M02_L01:
       ret
M02_L02:
       lea       rcx,[r8+0C]
       add       rdx,0C
       mov       r8d,[r8+8]
       add       r8d,r8d
       jmp       near ptr System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M02_L03:
       mov       eax,1
       jmp       short M02_L01
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+48],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbp,r8
       mov       rsi,r9
       mov       rax,244F5F03020
       mov       rax,[rax]
       mov       [rsp+40],rax
       mov       r14,[rdi+10]
       mov       rax,244F5F11AC0
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+30],rax
       test      rbx,rbx
       jne       short M03_L01
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L01:
       mov       rax,244F5F03020
       mov       rax,[rax]
       mov       [rsp+40],rax
       mov       rax,244F5F11AC8
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M03_L03
       jmp       short M03_L04
M03_L03:
       mov       rcx,rdi
       mov       rdx,7FFEBCF83948
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       mov       rdx,rbx
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       test      rbx,rbx
       je        short M03_L05
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
M03_L05:
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L06:
       mov       rcx,[rdi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCF83B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 405
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
; 			var result = this.GetPersonProperArray().FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],r9
       mov       r9,[rsi+18]
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
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
; Total bytes of code 131
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2C8A3993020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2C8839915C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE100A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = this.GetPersonProperArray().FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
; 			                                                             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r8,[rdx+48]
       mov       rax,[rcx+18]
       mov       rdx,[rax+48]
       cmp       r8,rdx
       je        short M02_L03
       test      r8,r8
       je        short M02_L00
       test      rdx,rdx
       je        short M02_L00
       mov       eax,[r8+8]
       cmp       eax,[rdx+8]
       je        short M02_L02
M02_L00:
       xor       eax,eax
M02_L01:
       ret
M02_L02:
       lea       rcx,[r8+0C]
       add       rdx,0C
       mov       r8d,[r8+8]
       add       r8d,r8d
       jmp       near ptr System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M02_L03:
       mov       eax,1
       jmp       short M02_L01
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+48],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbp,r8
       mov       rsi,r9
       mov       rax,2C8A3993020
       mov       rax,[rax]
       mov       [rsp+40],rax
       mov       r14,[rdi+10]
       mov       rax,2C8A39A2288
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+30],rax
       test      rbx,rbx
       jne       short M03_L01
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L01:
       mov       rax,2C8A3993020
       mov       rax,[rax]
       mov       [rsp+40],rax
       mov       rax,2C8A39A2290
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M03_L03
       jmp       short M03_L04
M03_L03:
       mov       rcx,rdi
       mov       rdx,7FFEBCF639B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       mov       rdx,rbx
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       test      rbx,rbx
       je        short M03_L05
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
M03_L05:
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L06:
       mov       rcx,[rdi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCF63B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 405
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
; 			var result = this.GetPersonProperArray().FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],r9
       mov       r9,[rsi+18]
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
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
; Total bytes of code 131
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,277829A3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,277629A15C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE000A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = this.GetPersonProperArray().FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
; 			                                                             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r8,[rdx+48]
       mov       rax,[rcx+18]
       mov       rdx,[rax+48]
       cmp       r8,rdx
       je        short M02_L03
       test      r8,r8
       je        short M02_L00
       test      rdx,rdx
       je        short M02_L00
       mov       eax,[r8+8]
       cmp       eax,[rdx+8]
       je        short M02_L02
M02_L00:
       xor       eax,eax
M02_L01:
       ret
M02_L02:
       lea       rcx,[r8+0C]
       add       rdx,0C
       mov       r8d,[r8+8]
       add       r8d,r8d
       jmp       near ptr System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M02_L03:
       mov       eax,1
       jmp       short M02_L01
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+48],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbp,r8
       mov       rsi,r9
       mov       rax,277829A3020
       mov       rax,[rax]
       mov       [rsp+40],rax
       mov       r14,[rdi+10]
       mov       rax,277829B32A0
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+30],rax
       test      rbx,rbx
       jne       short M03_L01
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L01:
       mov       rax,277829A3020
       mov       rax,[rax]
       mov       [rsp+40],rax
       mov       rax,277829B32A8
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M03_L03
       jmp       short M03_L04
M03_L03:
       mov       rcx,rdi
       mov       rdx,7FFEBCF53948
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       mov       rdx,rbx
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       test      rbx,rbx
       je        short M03_L05
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
M03_L05:
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L06:
       mov       rcx,[rdi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCF53B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 405
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
; 			var result = this.GetPersonProperArray().FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],r9
       mov       r9,[rsi+18]
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
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
; Total bytes of code 131
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,205AAF73020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2058AF735C0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE300A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = this.GetPersonProperArray().FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
; 			                                                             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r8,[rdx+48]
       mov       rax,[rcx+18]
       mov       rdx,[rax+48]
       cmp       r8,rdx
       je        short M02_L03
       test      r8,r8
       je        short M02_L00
       test      rdx,rdx
       je        short M02_L00
       mov       eax,[r8+8]
       cmp       eax,[rdx+8]
       je        short M02_L02
M02_L00:
       xor       eax,eax
M02_L01:
       ret
M02_L02:
       lea       rcx,[r8+0C]
       add       rdx,0C
       mov       r8d,[r8+8]
       add       r8d,r8d
       jmp       near ptr System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M02_L03:
       mov       eax,1
       jmp       short M02_L01
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+48],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbp,r8
       mov       rsi,r9
       mov       rax,205AAF73020
       mov       rax,[rax]
       mov       [rsp+40],rax
       mov       r14,[rdi+10]
       mov       rax,205AAF80290
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+30],rax
       test      rbx,rbx
       jne       short M03_L01
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L01:
       mov       rax,205AAF73020
       mov       rax,[rax]
       mov       [rsp+40],rax
       mov       rax,205AAF80298
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M03_L03
       jmp       short M03_L04
M03_L03:
       mov       rcx,rdi
       mov       rdx,7FFEBCF839B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       mov       rdx,rbx
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       test      rbx,rbx
       je        short M03_L05
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
M03_L05:
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L06:
       mov       rcx,[rdi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCF83B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 405
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
; 			var result = this.GetPersonProperArray().FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],r9
       mov       r9,[rsi+18]
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
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
; Total bytes of code 131
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1C9755C3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1C9755C59D0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE400A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = this.GetPersonProperArray().FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
; 			                                                             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r8,[rdx+48]
       mov       rax,[rcx+18]
       mov       rdx,[rax+48]
       cmp       r8,rdx
       je        short M02_L03
       test      r8,r8
       je        short M02_L00
       test      rdx,rdx
       je        short M02_L00
       mov       eax,[r8+8]
       cmp       eax,[rdx+8]
       je        short M02_L02
M02_L00:
       xor       eax,eax
M02_L01:
       ret
M02_L02:
       lea       rcx,[r8+0C]
       add       rdx,0C
       mov       r8d,[r8+8]
       add       r8d,r8d
       jmp       near ptr System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M02_L03:
       mov       eax,1
       jmp       short M02_L01
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+48],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbp,r8
       mov       rsi,r9
       mov       rax,1C9755C3020
       mov       rax,[rax]
       mov       [rsp+40],rax
       mov       r14,[rdi+10]
       mov       rax,1C9955C1A50
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+30],rax
       test      rbx,rbx
       jne       short M03_L01
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L01:
       mov       rax,1C9755C3020
       mov       rax,[rax]
       mov       [rsp+40],rax
       mov       rax,1C9955C1A58
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M03_L03
       jmp       short M03_L04
M03_L03:
       mov       rcx,rdi
       mov       rdx,7FFEBCF939C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       mov       rdx,rbx
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       test      rbx,rbx
       je        short M03_L05
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
M03_L05:
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L06:
       mov       rcx,[rdi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCF93BB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 405
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
; 			var result = this.GetPersonProperArray().FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],r9
       mov       r9,[rsi+18]
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
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
; Total bytes of code 131
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1EEF6373020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1EED63715C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE300A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			var result = this.GetPersonProperArray().FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);
; 			                                                             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r8,[rdx+48]
       mov       rax,[rcx+18]
       mov       rdx,[rax+48]
       cmp       r8,rdx
       je        short M02_L03
       test      r8,r8
       je        short M02_L00
       test      rdx,rdx
       je        short M02_L00
       mov       eax,[r8+8]
       cmp       eax,[rdx+8]
       je        short M02_L02
M02_L00:
       xor       eax,eax
M02_L01:
       ret
M02_L02:
       lea       rcx,[r8+0C]
       add       rdx,0C
       mov       r8d,[r8+8]
       add       r8d,r8d
       jmp       near ptr System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M02_L03:
       mov       eax,1
       jmp       short M02_L01
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+48],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbp,r8
       mov       rsi,r9
       mov       rax,1EEF6373020
       mov       rax,[rax]
       mov       [rsp+40],rax
       mov       r14,[rdi+10]
       mov       rax,1EEF63832A0
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+30],rax
       test      rbx,rbx
       jne       short M03_L01
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L01:
       mov       rax,1EEF6373020
       mov       rax,[rax]
       mov       [rsp+40],rax
       mov       rax,1EEF63832A8
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M03_L03
       jmp       short M03_L04
M03_L03:
       mov       rcx,rdi
       mov       rdx,7FFEBD011960
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       mov       rdx,rbx
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       test      rbx,rbx
       je        short M03_L05
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
M03_L05:
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L06:
       mov       rcx,[rdi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBD011B48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 405
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.HasItems02()
; 			var result = base.GetPersonProperArray().AsEnumerable().HasItems(5);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,5
       sete      dil
       movzx     edi,dil
M00_L01:
       mov       rax,[rsi+10]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,26132E63020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,26132E659D0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE100A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L01
       mov       rcx,rax
       mov       r11,7FFEBC970470
       mov       rax,[7FFEBCD60470]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M02_L01:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFEBC970460
       call      qword ptr [7FFEBCD60460]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FFEBC970468
       call      qword ptr [7FFEBCD60468]
       test      eax,eax
       je        short M02_L03
M02_L02:
       add       edi,1
       jo        short M02_L04
       mov       rcx,rsi
       mov       r11,7FFEBC970468
       call      qword ptr [7FFEBCD60468]
       test      eax,eax
       jne       short M02_L02
M02_L03:
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 165
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.HasItems02()
; 			var result = base.GetPersonProperArray().AsEnumerable().HasItems(5);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,5
       sete      dil
       movzx     edi,dil
M00_L01:
       mov       rax,[rsi+10]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1ED0CC03020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1ED0CC059D0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE100A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L01
       mov       rcx,rax
       mov       r11,7FFEBC970470
       mov       rax,[7FFEBCD60470]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M02_L01:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFEBC970460
       call      qword ptr [7FFEBCD60460]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FFEBC970468
       call      qword ptr [7FFEBCD60468]
       test      eax,eax
       je        short M02_L03
M02_L02:
       add       edi,1
       jo        short M02_L04
       mov       rcx,rsi
       mov       r11,7FFEBC970468
       call      qword ptr [7FFEBCD60468]
       test      eax,eax
       jne       short M02_L02
M02_L03:
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 165
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.HasItems02()
; 			var result = base.GetPersonProperArray().AsEnumerable().HasItems(5);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,5
       sete      dil
       movzx     edi,dil
M00_L01:
       mov       rax,[rsi+10]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1C4052A3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1C4052B1E00
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE300A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L01
       mov       rcx,rax
       mov       r11,7FFEBC990470
       mov       rax,[7FFEBCD80470]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M02_L01:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFEBC990460
       call      qword ptr [7FFEBCD80460]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FFEBC990468
       call      qword ptr [7FFEBCD80468]
       test      eax,eax
       je        short M02_L03
M02_L02:
       add       edi,1
       jo        short M02_L04
       mov       rcx,rsi
       mov       r11,7FFEBC990468
       call      qword ptr [7FFEBCD80468]
       test      eax,eax
       jne       short M02_L02
M02_L03:
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 165
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.HasItems02()
; 			var result = base.GetPersonProperArray().AsEnumerable().HasItems(5);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,5
       sete      dil
       movzx     edi,dil
M00_L01:
       mov       rax,[rsi+10]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,221A3FB3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,221A3FC1E00
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE300A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L01
       mov       rcx,rax
       mov       r11,7FFEBC990470
       mov       rax,[7FFEBCD80470]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M02_L01:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFEBC990460
       call      qword ptr [7FFEBCD80460]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FFEBC990468
       call      qword ptr [7FFEBCD80468]
       test      eax,eax
       je        short M02_L03
M02_L02:
       add       edi,1
       jo        short M02_L04
       mov       rcx,rsi
       mov       r11,7FFEBC990468
       call      qword ptr [7FFEBCD80468]
       test      eax,eax
       jne       short M02_L02
M02_L03:
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 165
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.HasItems02()
; 			var result = base.GetPersonProperArray().AsEnumerable().HasItems(5);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,5
       sete      dil
       movzx     edi,dil
M00_L01:
       mov       rax,[rsi+10]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2309AAD3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2307AAD15C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE300A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L01
       mov       rcx,rax
       mov       r11,7FFEBC990470
       mov       rax,[7FFEBCD80470]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M02_L01:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFEBC990460
       call      qword ptr [7FFEBCD80460]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FFEBC990468
       call      qword ptr [7FFEBCD80468]
       test      eax,eax
       je        short M02_L03
M02_L02:
       add       edi,1
       jo        short M02_L04
       mov       rcx,rsi
       mov       r11,7FFEBC990468
       call      qword ptr [7FFEBCD80468]
       test      eax,eax
       jne       short M02_L02
M02_L03:
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 165
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.HasItems02()
; 			var result = base.GetPersonProperArray().AsEnumerable().HasItems(5);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,5
       sete      dil
       movzx     edi,dil
M00_L01:
       mov       rax,[rsi+10]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,28A18B31028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,28A18B339D8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE400A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L01
       mov       rcx,rax
       mov       r11,7FFEBC9A0470
       mov       rax,[7FFEBCD90470]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M02_L01:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFEBC9A0460
       call      qword ptr [7FFEBCD90460]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FFEBC9A0468
       call      qword ptr [7FFEBCD90468]
       test      eax,eax
       je        short M02_L03
M02_L02:
       add       edi,1
       jo        short M02_L04
       mov       rcx,rsi
       mov       r11,7FFEBC9A0468
       call      qword ptr [7FFEBCD90468]
       test      eax,eax
       jne       short M02_L02
M02_L03:
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 165
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.HasItems02()
; 			var result = base.GetPersonProperArray().AsEnumerable().HasItems(5);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,5
       sete      dil
       movzx     edi,dil
M00_L01:
       mov       rax,[rsi+10]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,197FDAA3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,197DDAA15C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE400A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L01
       mov       rcx,rax
       mov       r11,7FFEBC9A0470
       mov       rax,[7FFEBCD90470]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M02_L01:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFEBC9A0460
       call      qword ptr [7FFEBCD90460]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FFEBC9A0468
       call      qword ptr [7FFEBCD90468]
       test      eax,eax
       je        short M02_L03
M02_L02:
       add       edi,1
       jo        short M02_L04
       mov       rcx,rsi
       mov       r11,7FFEBC9A0468
       call      qword ptr [7FFEBCD90468]
       test      eax,eax
       jne       short M02_L02
M02_L03:
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 165
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.HasItems02()
; 			var result = base.GetPersonProperArray().AsEnumerable().HasItems(5);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,5
       sete      dil
       movzx     edi,dil
M00_L01:
       mov       rax,[rsi+10]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,253B87D3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,253987D15C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE400A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L01
       mov       rcx,rax
       mov       r11,7FFEBC9A0470
       mov       rax,[7FFEBCDA0470]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M02_L01:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFEBC9A0460
       call      qword ptr [7FFEBCDA0460]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FFEBC9A0468
       call      qword ptr [7FFEBCDA0468]
       test      eax,eax
       je        short M02_L03
M02_L02:
       add       edi,1
       jo        short M02_L04
       mov       rcx,rsi
       mov       r11,7FFEBC9A0468
       call      qword ptr [7FFEBCDA0468]
       test      eax,eax
       jne       short M02_L02
M02_L03:
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 165
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableDictionary01()
; 			var result = base.GetPersonProperDictionary().ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1F4F2FA3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1F4D2FA15C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE100A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       [rsp+38],rcx
       mov       rsi,rcx
       mov       rax,1F4F2FA3020
       mov       rax,[rax]
       mov       [rsp+30],rax
       mov       rdi,[rsi+10]
       mov       rbx,rdx
       mov       rax,1F4F2FB32A0
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rdi+20]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCFF51E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       mov       rdx,rbx
       call      System.Collections.Immutable.ImmutableDictionary.CreateRange[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableDictionary01()
; 			var result = base.GetPersonProperDictionary().ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2D7DC813020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2D7BC8115C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE200A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       [rsp+38],rcx
       mov       rsi,rcx
       mov       rax,2D7DC813020
       mov       rax,[rax]
       mov       [rsp+30],rax
       mov       rdi,[rsi+10]
       mov       rbx,rdx
       mov       rax,2D7DC8232A0
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rdi+20]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBD0051E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       mov       rdx,rbx
       call      System.Collections.Immutable.ImmutableDictionary.CreateRange[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableDictionary01()
; 			var result = base.GetPersonProperDictionary().ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,17E12D41028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,17DF2D435C0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE000A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       [rsp+38],rcx
       mov       rsi,rcx
       mov       rax,17E12D41028
       mov       rax,[rax]
       mov       [rsp+30],rax
       mov       rdi,[rsi+10]
       mov       rbx,rdx
       mov       rax,17E12D50290
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rdi+20]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCFE51E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       mov       rdx,rbx
       call      System.Collections.Immutable.ImmutableDictionary.CreateRange[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableDictionary01()
; 			var result = base.GetPersonProperDictionary().ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,203BEB01028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,203BEB0FE08
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE000A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       [rsp+38],rcx
       mov       rsi,rcx
       mov       rax,203BEB01028
       mov       rax,[rax]
       mov       [rsp+30],rax
       mov       rdi,[rsi+10]
       mov       rbx,rdx
       mov       rax,203CEB01A50
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rdi+20]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCFE51E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       mov       rdx,rbx
       call      System.Collections.Immutable.ImmutableDictionary.CreateRange[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableDictionary01()
; 			var result = base.GetPersonProperDictionary().ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,16D6A511028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,16D4A5115C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE100A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       [rsp+38],rcx
       mov       rsi,rcx
       mov       rax,16D6A511028
       mov       rax,[rax]
       mov       [rsp+30],rax
       mov       rdi,[rsi+10]
       mov       rbx,rdx
       mov       rax,16D6A5212A8
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rdi+20]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCFF51E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       mov       rdx,rbx
       call      System.Collections.Immutable.ImmutableDictionary.CreateRange[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableDictionary01()
; 			var result = base.GetPersonProperDictionary().ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1FC173D1028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1FC173DFE08
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE400A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       [rsp+38],rcx
       mov       rsi,rcx
       mov       rax,1FC173D1028
       mov       rax,[rax]
       mov       [rsp+30],rax
       mov       rdi,[rsi+10]
       mov       rbx,rdx
       mov       rax,1FC173E0AA8
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rdi+20]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBD0251E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       mov       rdx,rbx
       call      System.Collections.Immutable.ImmutableDictionary.CreateRange[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableDictionary01()
; 			var result = base.GetPersonProperDictionary().ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2AA72323020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2AA523215C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE100A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       [rsp+38],rcx
       mov       rsi,rcx
       mov       rax,2AA72323020
       mov       rax,[rax]
       mov       [rsp+30],rax
       mov       rdi,[rsi+10]
       mov       rbx,rdx
       mov       rax,2AA52322268
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rdi+20]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCFF5200
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       mov       rdx,rbx
       call      System.Collections.Immutable.ImmutableDictionary.CreateRange[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableDictionary01()
; 			var result = base.GetPersonProperDictionary().ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,28A408D3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,28A208D15C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE200A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       [rsp+38],rcx
       mov       rsi,rcx
       mov       rax,28A408D3020
       mov       rax,[rax]
       mov       [rsp+30],rax
       mov       rdi,[rsi+10]
       mov       rbx,rdx
       mov       rax,28A208D3280
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rdi+20]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBD0127F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       mov       rdx,rbx
       call      System.Collections.Immutable.ImmutableDictionary.CreateRange[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableList01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,21E24203020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rdi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCF1BDA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,21E24212FF0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF1C2C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rsi
       call      System.Collections.Immutable.ImmutableList.CreateRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableList01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,1B0D1921028
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rdi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCF0BDA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1B0F19247B0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF0C2C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rsi
       call      System.Collections.Immutable.ImmutableList.CreateRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableList01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,22A85CD3020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rdi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCF2BDA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,22A75CD17A0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF2C2C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rsi
       call      System.Collections.Immutable.ImmutableList.CreateRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableList01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,17CF6A83020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rdi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCF1BDA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,17D16A827B8
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF1C2C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rsi
       call      System.Collections.Immutable.ImmutableList.CreateRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableList01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,1FB0D483020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rdi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCF3BDA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1FAED4817A0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF3C2C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rsi
       call      System.Collections.Immutable.ImmutableList.CreateRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableList01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,1E42F0A1028
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rdi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCF2BDA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1E42F0A43C8
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF2C2C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rsi
       call      System.Collections.Immutable.ImmutableList.CreateRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableList01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,2000ED11028
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rdi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCF0BD88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1FFFED117A0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF0C2A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rsi
       call      System.Collections.Immutable.ImmutableList.CreateRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableList01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,215BFAE1028
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rdi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCFB4E50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,215DFAE47B0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCFB5368
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rsi
       call      System.Collections.Immutable.ImmutableList.CreateRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrNull01()
; 			var result = base.GetCoordinateArray().FirstOrNull(p => p.X == this.Coordinate01.X);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__6_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       mov       [rbx+18],rcx
       lea       rcx,[rsp+20]
       mov       rdx,rdi
       mov       r8,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>, System.Func`2<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate,Boolean>)
       mov       rsi,[rsi+10]
       cmp       [rsi],esi
       lea       rdx,[rsp+20]
       mov       rcx,offset MT_System.Nullable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_BOX_NULLABLE
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1F326AC3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1F306AC15C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE100A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__6_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
; 			var result = base.GetCoordinateArray().FirstOrNull(p => p.X == this.Coordinate01.X);
; 			                                                        ^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       [rsp+10],rdx
       mov       eax,[rsp+10]
       add       rcx,78
       mov       edx,[rcx]
       cmp       eax,edx
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 24
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>, System.Func`2<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate,Boolean>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rdi,rcx
       mov       rcx,rdx
       mov       rsi,r8
       mov       r8,1F326AC3020
       mov       r8,[r8]
       mov       [rsp+40],r8
       mov       r8,1F326AD1FD8
       mov       r8,[r8]
       lea       rdx,[rsp+40]
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>, System.String ByRef, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>)
       mov       rbx,rax
       xor       ebp,ebp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       short M03_L02
M03_L00:
       cmp       ebp,[rbx+10]
       jae       near ptr M03_L05
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M03_L06
       movsxd    rdx,ebp
       lea       rcx,[rcx+rdx*8+10]
       mov       r14d,[rcx]
       mov       r15d,[rcx+4]
       test      rsi,rsi
       je        short M03_L01
       mov       [rsp+28],r14d
       mov       [rsp+2C],r15d
       mov       rax,rsi
       mov       rcx,[rax+8]
       mov       rdx,[rsp+28]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M03_L03
M03_L01:
       add       ebp,1
       jo        short M03_L04
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,ebp
       jg        short M03_L00
M03_L02:
       xor       eax,eax
       mov       [rdi],rax
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L03:
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],eax
       lea       rax,[rsp+34]
       mov       [rax],r14d
       mov       [rax+4],r15d
       mov       byte ptr [rsp+30],1
       mov       rax,[rsp+30]
       mov       [rdi],rax
       mov       eax,[rsp+38]
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       call      CORINFO_HELP_OVERFLOW
M03_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M03_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 275
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrNull01()
; 			var result = base.GetCoordinateArray().FirstOrNull(p => p.X == this.Coordinate01.X);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__6_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       mov       [rbx+18],rcx
       lea       rcx,[rsp+20]
       mov       rdx,rdi
       mov       r8,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>, System.Func`2<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate,Boolean>)
       mov       rsi,[rsi+10]
       cmp       [rsi],esi
       lea       rdx,[rsp+20]
       mov       rcx,offset MT_System.Nullable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_BOX_NULLABLE
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,257430E1028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,257530E15C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE200A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__6_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
; 			var result = base.GetCoordinateArray().FirstOrNull(p => p.X == this.Coordinate01.X);
; 			                                                        ^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       [rsp+10],rdx
       mov       eax,[rsp+10]
       add       rcx,78
       mov       edx,[rcx]
       cmp       eax,edx
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 24
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>, System.Func`2<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate,Boolean>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rdi,rcx
       mov       rcx,rdx
       mov       rsi,r8
       mov       r8,257430E1028
       mov       r8,[r8]
       mov       [rsp+40],r8
       mov       r8,257430F0FF8
       mov       r8,[r8]
       lea       rdx,[rsp+40]
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>, System.String ByRef, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>)
       mov       rbx,rax
       xor       ebp,ebp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       short M03_L02
M03_L00:
       cmp       ebp,[rbx+10]
       jae       near ptr M03_L05
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M03_L06
       movsxd    rdx,ebp
       lea       rcx,[rcx+rdx*8+10]
       mov       r14d,[rcx]
       mov       r15d,[rcx+4]
       test      rsi,rsi
       je        short M03_L01
       mov       [rsp+28],r14d
       mov       [rsp+2C],r15d
       mov       rax,rsi
       mov       rcx,[rax+8]
       mov       rdx,[rsp+28]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M03_L03
M03_L01:
       add       ebp,1
       jo        short M03_L04
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,ebp
       jg        short M03_L00
M03_L02:
       xor       eax,eax
       mov       [rdi],rax
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L03:
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],eax
       lea       rax,[rsp+34]
       mov       [rax],r14d
       mov       [rax+4],r15d
       mov       byte ptr [rsp+30],1
       mov       rax,[rsp+30]
       mov       [rdi],rax
       mov       eax,[rsp+38]
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       call      CORINFO_HELP_OVERFLOW
M03_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M03_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 275
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrNull01()
; 			var result = base.GetCoordinateArray().FirstOrNull(p => p.X == this.Coordinate01.X);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__6_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       mov       [rbx+18],rcx
       lea       rcx,[rsp+20]
       mov       rdx,rdi
       mov       r8,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>, System.Func`2<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate,Boolean>)
       mov       rsi,[rsi+10]
       cmp       [rsi],esi
       lea       rdx,[rsp+20]
       mov       rcx,offset MT_System.Nullable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_BOX_NULLABLE
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1F18DEB1028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1F1ADEB35C0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE000A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__6_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
; 			var result = base.GetCoordinateArray().FirstOrNull(p => p.X == this.Coordinate01.X);
; 			                                                        ^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       [rsp+10],rdx
       mov       eax,[rsp+10]
       add       rcx,78
       mov       edx,[rcx]
       cmp       eax,edx
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 24
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>, System.Func`2<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate,Boolean>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rdi,rcx
       mov       rcx,rdx
       mov       rsi,r8
       mov       r8,1F18DEB1028
       mov       r8,[r8]
       mov       [rsp+40],r8
       mov       r8,1F18DEC0FF8
       mov       r8,[r8]
       lea       rdx,[rsp+40]
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>, System.String ByRef, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>)
       mov       rbx,rax
       xor       ebp,ebp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       short M03_L02
M03_L00:
       cmp       ebp,[rbx+10]
       jae       near ptr M03_L05
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M03_L06
       movsxd    rdx,ebp
       lea       rcx,[rcx+rdx*8+10]
       mov       r14d,[rcx]
       mov       r15d,[rcx+4]
       test      rsi,rsi
       je        short M03_L01
       mov       [rsp+28],r14d
       mov       [rsp+2C],r15d
       mov       rax,rsi
       mov       rcx,[rax+8]
       mov       rdx,[rsp+28]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M03_L03
M03_L01:
       add       ebp,1
       jo        short M03_L04
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,ebp
       jg        short M03_L00
M03_L02:
       xor       eax,eax
       mov       [rdi],rax
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L03:
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],eax
       lea       rax,[rsp+34]
       mov       [rax],r14d
       mov       [rax+4],r15d
       mov       byte ptr [rsp+30],1
       mov       rax,[rsp+30]
       mov       [rdi],rax
       mov       eax,[rsp+38]
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       call      CORINFO_HELP_OVERFLOW
M03_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M03_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 275
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrNull01()
; 			var result = base.GetCoordinateArray().FirstOrNull(p => p.X == this.Coordinate01.X);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__6_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       mov       [rbx+18],rcx
       lea       rcx,[rsp+20]
       mov       rdx,rdi
       mov       r8,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>, System.Func`2<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate,Boolean>)
       mov       rsi,[rsi+10]
       cmp       [rsi],esi
       lea       rdx,[rsp+20]
       mov       rcx,offset MT_System.Nullable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_BOX_NULLABLE
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2826B371028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2824B3735C0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE300A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__6_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
; 			var result = base.GetCoordinateArray().FirstOrNull(p => p.X == this.Coordinate01.X);
; 			                                                        ^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       [rsp+10],rdx
       mov       eax,[rsp+10]
       add       rcx,78
       mov       edx,[rcx]
       cmp       eax,edx
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 24
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>, System.Func`2<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate,Boolean>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rdi,rcx
       mov       rcx,rdx
       mov       rsi,r8
       mov       r8,2826B371028
       mov       r8,[r8]
       mov       [rsp+40],r8
       mov       r8,2826B380FF8
       mov       r8,[r8]
       lea       rdx,[rsp+40]
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>, System.String ByRef, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>)
       mov       rbx,rax
       xor       ebp,ebp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       short M03_L02
M03_L00:
       cmp       ebp,[rbx+10]
       jae       near ptr M03_L05
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M03_L06
       movsxd    rdx,ebp
       lea       rcx,[rcx+rdx*8+10]
       mov       r14d,[rcx]
       mov       r15d,[rcx+4]
       test      rsi,rsi
       je        short M03_L01
       mov       [rsp+28],r14d
       mov       [rsp+2C],r15d
       mov       rax,rsi
       mov       rcx,[rax+8]
       mov       rdx,[rsp+28]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M03_L03
M03_L01:
       add       ebp,1
       jo        short M03_L04
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,ebp
       jg        short M03_L00
M03_L02:
       xor       eax,eax
       mov       [rdi],rax
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L03:
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],eax
       lea       rax,[rsp+34]
       mov       [rax],r14d
       mov       [rax+4],r15d
       mov       byte ptr [rsp+30],1
       mov       rax,[rsp+30]
       mov       [rdi],rax
       mov       eax,[rsp+38]
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       call      CORINFO_HELP_OVERFLOW
M03_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M03_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 275
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrNull01()
; 			var result = base.GetCoordinateArray().FirstOrNull(p => p.X == this.Coordinate01.X);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__6_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       mov       [rbx+18],rcx
       lea       rcx,[rsp+20]
       mov       rdx,rdi
       mov       r8,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>, System.Func`2<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate,Boolean>)
       mov       rsi,[rsi+10]
       cmp       [rsi],esi
       lea       rdx,[rsp+20]
       mov       rcx,offset MT_System.Nullable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_BOX_NULLABLE
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,23E43EC3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,23E23EC15C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE200A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__6_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
; 			var result = base.GetCoordinateArray().FirstOrNull(p => p.X == this.Coordinate01.X);
; 			                                                        ^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       [rsp+10],rdx
       mov       eax,[rsp+10]
       add       rcx,78
       mov       edx,[rcx]
       cmp       eax,edx
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 24
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>, System.Func`2<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate,Boolean>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rdi,rcx
       mov       rcx,rdx
       mov       rsi,r8
       mov       r8,23E43EC3020
       mov       r8,[r8]
       mov       [rsp+40],r8
       mov       r8,23E43ED1FD8
       mov       r8,[r8]
       lea       rdx,[rsp+40]
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>, System.String ByRef, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>)
       mov       rbx,rax
       xor       ebp,ebp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       short M03_L02
M03_L00:
       cmp       ebp,[rbx+10]
       jae       near ptr M03_L05
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M03_L06
       movsxd    rdx,ebp
       lea       rcx,[rcx+rdx*8+10]
       mov       r14d,[rcx]
       mov       r15d,[rcx+4]
       test      rsi,rsi
       je        short M03_L01
       mov       [rsp+28],r14d
       mov       [rsp+2C],r15d
       mov       rax,rsi
       mov       rcx,[rax+8]
       mov       rdx,[rsp+28]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M03_L03
M03_L01:
       add       ebp,1
       jo        short M03_L04
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,ebp
       jg        short M03_L00
M03_L02:
       xor       eax,eax
       mov       [rdi],rax
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L03:
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],eax
       lea       rax,[rsp+34]
       mov       [rax],r14d
       mov       [rax+4],r15d
       mov       byte ptr [rsp+30],1
       mov       rax,[rsp+30]
       mov       [rdi],rax
       mov       eax,[rsp+38]
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       call      CORINFO_HELP_OVERFLOW
M03_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M03_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 275
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrNull01()
; 			var result = base.GetCoordinateArray().FirstOrNull(p => p.X == this.Coordinate01.X);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__6_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       mov       [rbx+18],rcx
       lea       rcx,[rsp+20]
       mov       rdx,rdi
       mov       r8,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>, System.Func`2<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate,Boolean>)
       mov       rsi,[rsi+10]
       cmp       [rsi],esi
       lea       rdx,[rsp+20]
       mov       rcx,offset MT_System.Nullable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_BOX_NULLABLE
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,245791B3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,245591B15C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE200A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__6_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
; 			var result = base.GetCoordinateArray().FirstOrNull(p => p.X == this.Coordinate01.X);
; 			                                                        ^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       [rsp+10],rdx
       mov       eax,[rsp+10]
       add       rcx,78
       mov       edx,[rcx]
       cmp       eax,edx
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 24
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>, System.Func`2<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate,Boolean>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rdi,rcx
       mov       rcx,rdx
       mov       rsi,r8
       mov       r8,245791B3020
       mov       r8,[r8]
       mov       [rsp+40],r8
       mov       r8,245791C1FD8
       mov       r8,[r8]
       lea       rdx,[rsp+40]
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>, System.String ByRef, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>)
       mov       rbx,rax
       xor       ebp,ebp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       short M03_L02
M03_L00:
       cmp       ebp,[rbx+10]
       jae       near ptr M03_L05
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M03_L06
       movsxd    rdx,ebp
       lea       rcx,[rcx+rdx*8+10]
       mov       r14d,[rcx]
       mov       r15d,[rcx+4]
       test      rsi,rsi
       je        short M03_L01
       mov       [rsp+28],r14d
       mov       [rsp+2C],r15d
       mov       rax,rsi
       mov       rcx,[rax+8]
       mov       rdx,[rsp+28]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M03_L03
M03_L01:
       add       ebp,1
       jo        short M03_L04
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,ebp
       jg        short M03_L00
M03_L02:
       xor       eax,eax
       mov       [rdi],rax
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L03:
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],eax
       lea       rax,[rsp+34]
       mov       [rax],r14d
       mov       [rax+4],r15d
       mov       byte ptr [rsp+30],1
       mov       rax,[rsp+30]
       mov       [rdi],rax
       mov       eax,[rsp+38]
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       call      CORINFO_HELP_OVERFLOW
M03_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M03_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 275
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrNull01()
; 			var result = base.GetCoordinateArray().FirstOrNull(p => p.X == this.Coordinate01.X);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__6_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       mov       [rbx+18],rcx
       lea       rcx,[rsp+20]
       mov       rdx,rdi
       mov       r8,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>, System.Func`2<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate,Boolean>)
       mov       rsi,[rsi+10]
       cmp       [rsi],esi
       lea       rdx,[rsp+20]
       mov       rcx,offset MT_System.Nullable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_BOX_NULLABLE
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,20AD8173020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,20AD81739D8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE200A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__6_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
; 			var result = base.GetCoordinateArray().FirstOrNull(p => p.X == this.Coordinate01.X);
; 			                                                        ^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       [rsp+10],rdx
       mov       eax,[rsp+10]
       add       rcx,78
       mov       edx,[rcx]
       cmp       eax,edx
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 24
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>, System.Func`2<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate,Boolean>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rdi,rcx
       mov       rcx,rdx
       mov       rsi,r8
       mov       r8,20AD8173020
       mov       r8,[r8]
       mov       [rsp+40],r8
       mov       r8,20AF8180BE0
       mov       r8,[r8]
       lea       rdx,[rsp+40]
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>, System.String ByRef, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>)
       mov       rbx,rax
       xor       ebp,ebp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       short M03_L02
M03_L00:
       cmp       ebp,[rbx+10]
       jae       near ptr M03_L05
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M03_L06
       movsxd    rdx,ebp
       lea       rcx,[rcx+rdx*8+10]
       mov       r14d,[rcx]
       mov       r15d,[rcx+4]
       test      rsi,rsi
       je        short M03_L01
       mov       [rsp+28],r14d
       mov       [rsp+2C],r15d
       mov       rax,rsi
       mov       rcx,[rax+8]
       mov       rdx,[rsp+28]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M03_L03
M03_L01:
       add       ebp,1
       jo        short M03_L04
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,ebp
       jg        short M03_L00
M03_L02:
       xor       eax,eax
       mov       [rdi],rax
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L03:
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],eax
       lea       rax,[rsp+34]
       mov       [rax],r14d
       mov       [rax+4],r15d
       mov       byte ptr [rsp+30],1
       mov       rax,[rsp+30]
       mov       [rdi],rax
       mov       eax,[rsp+38]
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       call      CORINFO_HELP_OVERFLOW
M03_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M03_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 275
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrNull01()
; 			var result = base.GetCoordinateArray().FirstOrNull(p => p.X == this.Coordinate01.X);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__6_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       mov       [rbx+18],rcx
       lea       rcx,[rsp+20]
       mov       rdx,rdi
       mov       r8,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>, System.Func`2<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate,Boolean>)
       mov       rsi,[rsi+10]
       cmp       [rsi],esi
       lea       rdx,[rsp+20]
       mov       rcx,offset MT_System.Nullable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_BOX_NULLABLE
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,296E80C3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,296C80C15C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE200A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__6_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
; 			var result = base.GetCoordinateArray().FirstOrNull(p => p.X == this.Coordinate01.X);
; 			                                                        ^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       [rsp+10],rdx
       mov       eax,[rsp+10]
       add       rcx,78
       mov       edx,[rcx]
       cmp       eax,edx
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 24
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>, System.Func`2<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate,Boolean>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rdi,rcx
       mov       rcx,rdx
       mov       rsi,r8
       mov       r8,296E80C3020
       mov       r8,[r8]
       mov       [rsp+40],r8
       mov       r8,296E80D2FF0
       mov       r8,[r8]
       lea       rdx,[rsp+40]
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>, System.String ByRef, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate>)
       mov       rbx,rax
       xor       ebp,ebp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       short M03_L02
M03_L00:
       cmp       ebp,[rbx+10]
       jae       near ptr M03_L05
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M03_L06
       movsxd    rdx,ebp
       lea       rcx,[rcx+rdx*8+10]
       mov       r14d,[rcx]
       mov       r15d,[rcx+4]
       test      rsi,rsi
       je        short M03_L01
       mov       [rsp+28],r14d
       mov       [rsp+2C],r15d
       mov       rax,rsi
       mov       rcx,[rax+8]
       mov       rdx,[rsp+28]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M03_L03
M03_L01:
       add       ebp,1
       jo        short M03_L04
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,ebp
       jg        short M03_L00
M03_L02:
       xor       eax,eax
       mov       [rdi],rax
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L03:
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],eax
       lea       rax,[rsp+34]
       mov       [rax],r14d
       mov       [rax+4],r15d
       mov       byte ptr [rsp+30],1
       mov       rax,[rsp+30]
       mov       [rdi],rax
       mov       eax,[rsp+38]
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       call      CORINFO_HELP_OVERFLOW
M03_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M03_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 275
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.HasItems01()
; 			var result = base.GetPersonProperArray().AsEnumerable().HasItems();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       rax,[rsi+10]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,17EE47D3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,17EE47D59D0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE300A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L01
       mov       rcx,rax
       mov       r11,7FFEBC990470
       mov       rax,[7FFEBCD80470]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M02_L01:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFEBC990460
       call      qword ptr [7FFEBCD80460]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FFEBC990468
       call      qword ptr [7FFEBCD80468]
       test      eax,eax
       je        short M02_L03
M02_L02:
       add       edi,1
       jo        short M02_L04
       mov       rcx,rsi
       mov       r11,7FFEBC990468
       call      qword ptr [7FFEBCD80468]
       test      eax,eax
       jne       short M02_L02
M02_L03:
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 165
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.HasItems01()
; 			var result = base.GetPersonProperArray().AsEnumerable().HasItems();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       rax,[rsi+10]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1A6A2F93020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1A6C2F915C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE000A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L01
       mov       rcx,rax
       mov       r11,7FFEBC960470
       mov       rax,[7FFEBCD50470]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M02_L01:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFEBC960460
       call      qword ptr [7FFEBCD50460]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FFEBC960468
       call      qword ptr [7FFEBCD50468]
       test      eax,eax
       je        short M02_L03
M02_L02:
       add       edi,1
       jo        short M02_L04
       mov       rcx,rsi
       mov       r11,7FFEBC960468
       call      qword ptr [7FFEBCD50468]
       test      eax,eax
       jne       short M02_L02
M02_L03:
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 165
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.HasItems01()
; 			var result = base.GetPersonProperArray().AsEnumerable().HasItems();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       rax,[rsi+10]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,22055DD3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,22035DD15C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE200A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L01
       mov       rcx,rax
       mov       r11,7FFEBC980470
       mov       rax,[7FFEBCD70470]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M02_L01:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFEBC980460
       call      qword ptr [7FFEBCD70460]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FFEBC980468
       call      qword ptr [7FFEBCD70468]
       test      eax,eax
       je        short M02_L03
M02_L02:
       add       edi,1
       jo        short M02_L04
       mov       rcx,rsi
       mov       r11,7FFEBC980468
       call      qword ptr [7FFEBCD70468]
       test      eax,eax
       jne       short M02_L02
M02_L03:
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 165
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.HasItems01()
; 			var result = base.GetPersonProperArray().AsEnumerable().HasItems();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       rax,[rsi+10]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,27995A33020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,27975A315C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE200A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L01
       mov       rcx,rax
       mov       r11,7FFEBC980470
       mov       rax,[7FFEBCD70470]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M02_L01:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFEBC980460
       call      qword ptr [7FFEBCD70460]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FFEBC980468
       call      qword ptr [7FFEBCD70468]
       test      eax,eax
       je        short M02_L03
M02_L02:
       add       edi,1
       jo        short M02_L04
       mov       rcx,rsi
       mov       r11,7FFEBC980468
       call      qword ptr [7FFEBCD70468]
       test      eax,eax
       jne       short M02_L02
M02_L03:
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 165
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.HasItems01()
; 			var result = base.GetPersonProperArray().AsEnumerable().HasItems();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       rax,[rsi+10]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,17AC9043020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,17AA90415C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE200A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L01
       mov       rcx,rax
       mov       r11,7FFEBC980470
       mov       rax,[7FFEBCD70470]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M02_L01:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFEBC980460
       call      qword ptr [7FFEBCD70460]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FFEBC980468
       call      qword ptr [7FFEBCD70468]
       test      eax,eax
       je        short M02_L03
M02_L02:
       add       edi,1
       jo        short M02_L04
       mov       rcx,rsi
       mov       r11,7FFEBC980468
       call      qword ptr [7FFEBCD70468]
       test      eax,eax
       jne       short M02_L02
M02_L03:
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 165
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.HasItems01()
; 			var result = base.GetPersonProperArray().AsEnumerable().HasItems();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       rax,[rsi+10]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,127C22C3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,127A22C15C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE200A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L01
       mov       rcx,rax
       mov       r11,7FFEBC980470
       mov       rax,[7FFEBCD70470]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M02_L01:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFEBC980460
       call      qword ptr [7FFEBCD70460]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FFEBC980468
       call      qword ptr [7FFEBCD70468]
       test      eax,eax
       je        short M02_L03
M02_L02:
       add       edi,1
       jo        short M02_L04
       mov       rcx,rsi
       mov       r11,7FFEBC980468
       call      qword ptr [7FFEBCD70468]
       test      eax,eax
       jne       short M02_L02
M02_L03:
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 165
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.HasItems01()
; 			var result = base.GetPersonProperArray().AsEnumerable().HasItems();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       rax,[rsi+10]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,245CD4A3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,245CD4A59D0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE300A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L01
       mov       rcx,rax
       mov       r11,7FFEBC990470
       mov       rax,[7FFEBCD80470]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M02_L01:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFEBC990460
       call      qword ptr [7FFEBCD80460]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FFEBC990468
       call      qword ptr [7FFEBCD80468]
       test      eax,eax
       je        short M02_L03
M02_L02:
       add       edi,1
       jo        short M02_L04
       mov       rcx,rsi
       mov       r11,7FFEBC990468
       call      qword ptr [7FFEBCD80468]
       test      eax,eax
       jne       short M02_L02
M02_L03:
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 165
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.HasItems01()
; 			var result = base.GetPersonProperArray().AsEnumerable().HasItems();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       rax,[rsi+10]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,211C5983020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,211A59815C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
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
       mov       rdx,7FFEBCE400A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L01
       mov       rcx,rax
       mov       r11,7FFEBC9A0470
       mov       rax,[7FFEBCDA0470]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M02_L01:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFEBC9A0460
       call      qword ptr [7FFEBCDA0460]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FFEBC9A0468
       call      qword ptr [7FFEBCDA0468]
       test      eax,eax
       je        short M02_L03
M02_L02:
       add       edi,1
       jo        short M02_L04
       mov       rcx,rsi
       mov       r11,7FFEBC9A0468
       call      qword ptr [7FFEBCDA0468]
       test      eax,eax
       jne       short M02_L02
M02_L03:
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 165
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StartsWith01()
; 			var result = base.GetPersonProperArray(Tristate.False).StartsWith(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFC8],rax
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       r14,[rsi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF11E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFC8],rdi
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF11E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFC0],rbx
       jmp       near ptr M01_L12
M01_L07:
       mov       rcx,rdi
       mov       r11,7FFEBC980610
       call      qword ptr [7FFEBCD80610]
       test      eax,eax
       je        near ptr M01_L13
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCF11EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCF11EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       r15,rax
       je        short M01_L12
       test      r15,r15
       je        short M01_L13
       test      rax,rax
       je        short M01_L13
       mov       rcx,r15
       mov       rdx,rax
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M01_L13
M01_L12:
       mov       rcx,rbx
       mov       r11,7FFEBC980608
       call      qword ptr [7FFEBCD80608]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,rbx
       mov       r11,7FFEBC980618
       call      qword ptr [7FFEBCD80618]
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsp
       call      M01_L18
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L17
M01_L15:
       mov       rdi,[rbp+0FFC8]
       test      rdi,rdi
       je        short M01_L16
       mov       rcx,rdi
       mov       r11,7FFEBC980620
       call      qword ptr [7FFEBCD80620]
M01_L16:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rbx,[rbp+0FFC0]
       test      rbx,rbx
       je        short M01_L19
       mov       rcx,rbx
       mov       r11,7FFEBC980618
       call      qword ptr [7FFEBCD80618]
M01_L19:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rdi,[rbp+0FFC8]
       test      rdi,rdi
       je        short M01_L21
       mov       rcx,rdi
       mov       r11,7FFEBC980620
       call      qword ptr [7FFEBCD80620]
M01_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 591
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StartsWith01()
; 			var result = base.GetPersonProperArray(Tristate.False).StartsWith(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFC8],rax
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       r14,[rsi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF21E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFC8],rdi
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF21E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFC0],rbx
       jmp       near ptr M01_L12
M01_L07:
       mov       rcx,rdi
       mov       r11,7FFEBC990610
       call      qword ptr [7FFEBCD90610]
       test      eax,eax
       je        near ptr M01_L13
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCF21EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCF21EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       r15,rax
       je        short M01_L12
       test      r15,r15
       je        short M01_L13
       test      rax,rax
       je        short M01_L13
       mov       rcx,r15
       mov       rdx,rax
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M01_L13
M01_L12:
       mov       rcx,rbx
       mov       r11,7FFEBC990608
       call      qword ptr [7FFEBCD90608]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,rbx
       mov       r11,7FFEBC990618
       call      qword ptr [7FFEBCD90618]
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsp
       call      M01_L18
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L17
M01_L15:
       mov       rdi,[rbp+0FFC8]
       test      rdi,rdi
       je        short M01_L16
       mov       rcx,rdi
       mov       r11,7FFEBC990620
       call      qword ptr [7FFEBCD90620]
M01_L16:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rbx,[rbp+0FFC0]
       test      rbx,rbx
       je        short M01_L19
       mov       rcx,rbx
       mov       r11,7FFEBC990618
       call      qword ptr [7FFEBCD90618]
M01_L19:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rdi,[rbp+0FFC8]
       test      rdi,rdi
       je        short M01_L21
       mov       rcx,rdi
       mov       r11,7FFEBC990620
       call      qword ptr [7FFEBCD90620]
M01_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 591
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StartsWith01()
; 			var result = base.GetPersonProperArray(Tristate.False).StartsWith(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFC8],rax
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       r14,[rsi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF11E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFC8],rdi
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF11E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFC0],rbx
       jmp       near ptr M01_L12
M01_L07:
       mov       rcx,rdi
       mov       r11,7FFEBC980610
       call      qword ptr [7FFEBCD80610]
       test      eax,eax
       je        near ptr M01_L13
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCF11EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCF11EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       r15,rax
       je        short M01_L12
       test      r15,r15
       je        short M01_L13
       test      rax,rax
       je        short M01_L13
       mov       rcx,r15
       mov       rdx,rax
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M01_L13
M01_L12:
       mov       rcx,rbx
       mov       r11,7FFEBC980608
       call      qword ptr [7FFEBCD80608]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,rbx
       mov       r11,7FFEBC980618
       call      qword ptr [7FFEBCD80618]
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsp
       call      M01_L18
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L17
M01_L15:
       mov       rdi,[rbp+0FFC8]
       test      rdi,rdi
       je        short M01_L16
       mov       rcx,rdi
       mov       r11,7FFEBC980620
       call      qword ptr [7FFEBCD80620]
M01_L16:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rbx,[rbp+0FFC0]
       test      rbx,rbx
       je        short M01_L19
       mov       rcx,rbx
       mov       r11,7FFEBC980618
       call      qword ptr [7FFEBCD80618]
M01_L19:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rdi,[rbp+0FFC8]
       test      rdi,rdi
       je        short M01_L21
       mov       rcx,rdi
       mov       r11,7FFEBC980620
       call      qword ptr [7FFEBCD80620]
M01_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 591
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StartsWith01()
; 			var result = base.GetPersonProperArray(Tristate.False).StartsWith(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFC8],rax
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       r14,[rsi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF11E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFC8],rdi
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF11E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFC0],rbx
       jmp       near ptr M01_L12
M01_L07:
       mov       rcx,rdi
       mov       r11,7FFEBC980610
       call      qword ptr [7FFEBCD80610]
       test      eax,eax
       je        near ptr M01_L13
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCF11EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCF11EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       r15,rax
       je        short M01_L12
       test      r15,r15
       je        short M01_L13
       test      rax,rax
       je        short M01_L13
       mov       rcx,r15
       mov       rdx,rax
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M01_L13
M01_L12:
       mov       rcx,rbx
       mov       r11,7FFEBC980608
       call      qword ptr [7FFEBCD80608]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,rbx
       mov       r11,7FFEBC980618
       call      qword ptr [7FFEBCD80618]
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsp
       call      M01_L18
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L17
M01_L15:
       mov       rdi,[rbp+0FFC8]
       test      rdi,rdi
       je        short M01_L16
       mov       rcx,rdi
       mov       r11,7FFEBC980620
       call      qword ptr [7FFEBCD80620]
M01_L16:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rbx,[rbp+0FFC0]
       test      rbx,rbx
       je        short M01_L19
       mov       rcx,rbx
       mov       r11,7FFEBC980618
       call      qword ptr [7FFEBCD80618]
M01_L19:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rdi,[rbp+0FFC8]
       test      rdi,rdi
       je        short M01_L21
       mov       rcx,rdi
       mov       r11,7FFEBC980620
       call      qword ptr [7FFEBCD80620]
M01_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 591
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StartsWith01()
; 			var result = base.GetPersonProperArray(Tristate.False).StartsWith(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFC8],rax
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       r14,[rsi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF1E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFC8],rdi
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF1E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFC0],rbx
       jmp       near ptr M01_L12
M01_L07:
       mov       rcx,rdi
       mov       r11,7FFEBC960610
       call      qword ptr [7FFEBCD60610]
       test      eax,eax
       je        near ptr M01_L13
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF1EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF1EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       r15,rax
       je        short M01_L12
       test      r15,r15
       je        short M01_L13
       test      rax,rax
       je        short M01_L13
       mov       rcx,r15
       mov       rdx,rax
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M01_L13
M01_L12:
       mov       rcx,rbx
       mov       r11,7FFEBC960608
       call      qword ptr [7FFEBCD60608]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,rbx
       mov       r11,7FFEBC960618
       call      qword ptr [7FFEBCD60618]
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsp
       call      M01_L18
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L17
M01_L15:
       mov       rdi,[rbp+0FFC8]
       test      rdi,rdi
       je        short M01_L16
       mov       rcx,rdi
       mov       r11,7FFEBC960620
       call      qword ptr [7FFEBCD60620]
M01_L16:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rbx,[rbp+0FFC0]
       test      rbx,rbx
       je        short M01_L19
       mov       rcx,rbx
       mov       r11,7FFEBC960618
       call      qword ptr [7FFEBCD60618]
M01_L19:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rdi,[rbp+0FFC8]
       test      rdi,rdi
       je        short M01_L21
       mov       rcx,rdi
       mov       r11,7FFEBC960620
       call      qword ptr [7FFEBCD60620]
M01_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 591
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StartsWith01()
; 			var result = base.GetPersonProperArray(Tristate.False).StartsWith(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFC8],rax
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       r14,[rsi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF01E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFC8],rdi
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF01E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFC0],rbx
       jmp       near ptr M01_L12
M01_L07:
       mov       rcx,rdi
       mov       r11,7FFEBC970610
       call      qword ptr [7FFEBCD70610]
       test      eax,eax
       je        near ptr M01_L13
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCF01EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCF01EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       r15,rax
       je        short M01_L12
       test      r15,r15
       je        short M01_L13
       test      rax,rax
       je        short M01_L13
       mov       rcx,r15
       mov       rdx,rax
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M01_L13
M01_L12:
       mov       rcx,rbx
       mov       r11,7FFEBC970608
       call      qword ptr [7FFEBCD70608]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,rbx
       mov       r11,7FFEBC970618
       call      qword ptr [7FFEBCD70618]
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsp
       call      M01_L18
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L17
M01_L15:
       mov       rdi,[rbp+0FFC8]
       test      rdi,rdi
       je        short M01_L16
       mov       rcx,rdi
       mov       r11,7FFEBC970620
       call      qword ptr [7FFEBCD70620]
M01_L16:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rbx,[rbp+0FFC0]
       test      rbx,rbx
       je        short M01_L19
       mov       rcx,rbx
       mov       r11,7FFEBC970618
       call      qword ptr [7FFEBCD70618]
M01_L19:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rdi,[rbp+0FFC8]
       test      rdi,rdi
       je        short M01_L21
       mov       rcx,rdi
       mov       r11,7FFEBC970620
       call      qword ptr [7FFEBCD70620]
M01_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 591
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StartsWith01()
; 			var result = base.GetPersonProperArray(Tristate.False).StartsWith(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFC8],rax
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       r14,[rsi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF21E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFC8],rdi
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF21E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFC0],rbx
       jmp       near ptr M01_L12
M01_L07:
       mov       rcx,rdi
       mov       r11,7FFEBC990610
       call      qword ptr [7FFEBCD90610]
       test      eax,eax
       je        near ptr M01_L13
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCF21EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCF21EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       r15,rax
       je        short M01_L12
       test      r15,r15
       je        short M01_L13
       test      rax,rax
       je        short M01_L13
       mov       rcx,r15
       mov       rdx,rax
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M01_L13
M01_L12:
       mov       rcx,rbx
       mov       r11,7FFEBC990608
       call      qword ptr [7FFEBCD90608]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,rbx
       mov       r11,7FFEBC990618
       call      qword ptr [7FFEBCD90618]
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsp
       call      M01_L18
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L17
M01_L15:
       mov       rdi,[rbp+0FFC8]
       test      rdi,rdi
       je        short M01_L16
       mov       rcx,rdi
       mov       r11,7FFEBC990620
       call      qword ptr [7FFEBCD90620]
M01_L16:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rbx,[rbp+0FFC0]
       test      rbx,rbx
       je        short M01_L19
       mov       rcx,rbx
       mov       r11,7FFEBC990618
       call      qword ptr [7FFEBCD90618]
M01_L19:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rdi,[rbp+0FFC8]
       test      rdi,rdi
       je        short M01_L21
       mov       rcx,rdi
       mov       r11,7FFEBC990620
       call      qword ptr [7FFEBCD90620]
M01_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 591
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StartsWith01()
; 			var result = base.GetPersonProperArray(Tristate.False).StartsWith(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFC8],rax
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       r14,[rsi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCFBAD08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFC8],rdi
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCFBAD08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFC0],rbx
       jmp       near ptr M01_L12
M01_L07:
       mov       rcx,rdi
       mov       r11,7FFEBC990610
       call      qword ptr [7FFEBCF40610]
       test      eax,eax
       je        near ptr M01_L13
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCFBADE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCFBADE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       r15,rax
       je        short M01_L12
       test      r15,r15
       je        short M01_L13
       test      rax,rax
       je        short M01_L13
       mov       rcx,r15
       mov       rdx,rax
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M01_L13
M01_L12:
       mov       rcx,rbx
       mov       r11,7FFEBC990608
       call      qword ptr [7FFEBCF40608]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,rbx
       mov       r11,7FFEBC990618
       call      qword ptr [7FFEBCF40618]
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsp
       call      M01_L18
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L17
M01_L15:
       mov       rdi,[rbp+0FFC8]
       test      rdi,rdi
       je        short M01_L16
       mov       rcx,rdi
       mov       r11,7FFEBC990620
       call      qword ptr [7FFEBCF40620]
M01_L16:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rbx,[rbp+0FFC0]
       test      rbx,rbx
       je        short M01_L19
       mov       rcx,rbx
       mov       r11,7FFEBC990618
       call      qword ptr [7FFEBCF40618]
M01_L19:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rdi,[rbp+0FFC8]
       test      rdi,rdi
       je        short M01_L21
       mov       rcx,rdi
       mov       r11,7FFEBC990620
       call      qword ptr [7FFEBCF40620]
M01_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 591
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StructuralSequenceEqual01()
; 			var result = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half).StructuralSequenceEqual(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       r14,[rsi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF01E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFC0],rdi
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF01E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rdi
       mov       r11,7FFEBC970608
       call      qword ptr [7FFEBCD70608]
       test      eax,eax
       je        near ptr M01_L12
M01_L07:
       mov       rcx,rbx
       mov       r11,7FFEBC970610
       call      qword ptr [7FFEBCD70610]
       test      eax,eax
       je        near ptr M01_L13
       call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
       mov       r15,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCF01F78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r12,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCF01F78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,r15
       mov       rdx,r12
       mov       r11,7FFEBC970618
       call      qword ptr [7FFEBCD70618]
       test      eax,eax
       je        short M01_L13
       mov       rcx,rdi
       mov       r11,7FFEBC970608
       call      qword ptr [7FFEBCD70608]
       test      eax,eax
       jne       near ptr M01_L07
M01_L12:
       mov       rcx,rbx
       mov       r11,7FFEBC970620
       call      qword ptr [7FFEBCD70620]
       test      eax,eax
       sete      sil
       movzx     esi,sil
       jmp       short M01_L14
M01_L13:
       xor       esi,esi
M01_L14:
       mov       rcx,rbx
       mov       r11,7FFEBC970628
       call      qword ptr [7FFEBCD70628]
       nop
       mov       rcx,rdi
       mov       r11,7FFEBC970630
       call      qword ptr [7FFEBCD70630]
       mov       eax,esi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L15
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFEBC970628
       call      qword ptr [7FFEBCD70628]
M01_L15:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC970630
       call      qword ptr [7FFEBCD70630]
M01_L16:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 614
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StructuralSequenceEqual01()
; 			var result = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half).StructuralSequenceEqual(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       r14,[rsi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF31E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFC0],rdi
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF31E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rdi
       mov       r11,7FFEBC9A0608
       call      qword ptr [7FFEBCDA0608]
       test      eax,eax
       je        near ptr M01_L12
M01_L07:
       mov       rcx,rbx
       mov       r11,7FFEBC9A0610
       call      qword ptr [7FFEBCDA0610]
       test      eax,eax
       je        near ptr M01_L13
       call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
       mov       r15,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCF31F78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r12,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCF31F78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,r15
       mov       rdx,r12
       mov       r11,7FFEBC9A0618
       call      qword ptr [7FFEBCDA0618]
       test      eax,eax
       je        short M01_L13
       mov       rcx,rdi
       mov       r11,7FFEBC9A0608
       call      qword ptr [7FFEBCDA0608]
       test      eax,eax
       jne       near ptr M01_L07
M01_L12:
       mov       rcx,rbx
       mov       r11,7FFEBC9A0620
       call      qword ptr [7FFEBCDA0620]
       test      eax,eax
       sete      sil
       movzx     esi,sil
       jmp       short M01_L14
M01_L13:
       xor       esi,esi
M01_L14:
       mov       rcx,rbx
       mov       r11,7FFEBC9A0628
       call      qword ptr [7FFEBCDA0628]
       nop
       mov       rcx,rdi
       mov       r11,7FFEBC9A0630
       call      qword ptr [7FFEBCDA0630]
       mov       eax,esi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L15
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFEBC9A0628
       call      qword ptr [7FFEBCDA0628]
M01_L15:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC9A0630
       call      qword ptr [7FFEBCDA0630]
M01_L16:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 614
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StructuralSequenceEqual01()
; 			var result = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half).StructuralSequenceEqual(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       r14,[rsi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF1E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFC0],rdi
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF1E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rdi
       mov       r11,7FFEBC960608
       call      qword ptr [7FFEBCD60608]
       test      eax,eax
       je        near ptr M01_L12
M01_L07:
       mov       rcx,rbx
       mov       r11,7FFEBC960610
       call      qword ptr [7FFEBCD60610]
       test      eax,eax
       je        near ptr M01_L13
       call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
       mov       r15,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF1F78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r12,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF1F78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,r15
       mov       rdx,r12
       mov       r11,7FFEBC960618
       call      qword ptr [7FFEBCD60618]
       test      eax,eax
       je        short M01_L13
       mov       rcx,rdi
       mov       r11,7FFEBC960608
       call      qword ptr [7FFEBCD60608]
       test      eax,eax
       jne       near ptr M01_L07
M01_L12:
       mov       rcx,rbx
       mov       r11,7FFEBC960620
       call      qword ptr [7FFEBCD60620]
       test      eax,eax
       sete      sil
       movzx     esi,sil
       jmp       short M01_L14
M01_L13:
       xor       esi,esi
M01_L14:
       mov       rcx,rbx
       mov       r11,7FFEBC960628
       call      qword ptr [7FFEBCD60628]
       nop
       mov       rcx,rdi
       mov       r11,7FFEBC960630
       call      qword ptr [7FFEBCD60630]
       mov       eax,esi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L15
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFEBC960628
       call      qword ptr [7FFEBCD60628]
M01_L15:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC960630
       call      qword ptr [7FFEBCD60630]
M01_L16:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 614
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StructuralSequenceEqual01()
; 			var result = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half).StructuralSequenceEqual(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       r14,[rsi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF21E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFC0],rdi
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF21E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rdi
       mov       r11,7FFEBC990608
       call      qword ptr [7FFEBCD90608]
       test      eax,eax
       je        near ptr M01_L12
M01_L07:
       mov       rcx,rbx
       mov       r11,7FFEBC990610
       call      qword ptr [7FFEBCD90610]
       test      eax,eax
       je        near ptr M01_L13
       call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
       mov       r15,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCF21F78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r12,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCF21F78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,r15
       mov       rdx,r12
       mov       r11,7FFEBC990618
       call      qword ptr [7FFEBCD90618]
       test      eax,eax
       je        short M01_L13
       mov       rcx,rdi
       mov       r11,7FFEBC990608
       call      qword ptr [7FFEBCD90608]
       test      eax,eax
       jne       near ptr M01_L07
M01_L12:
       mov       rcx,rbx
       mov       r11,7FFEBC990620
       call      qword ptr [7FFEBCD90620]
       test      eax,eax
       sete      sil
       movzx     esi,sil
       jmp       short M01_L14
M01_L13:
       xor       esi,esi
M01_L14:
       mov       rcx,rbx
       mov       r11,7FFEBC990628
       call      qword ptr [7FFEBCD90628]
       nop
       mov       rcx,rdi
       mov       r11,7FFEBC990630
       call      qword ptr [7FFEBCD90630]
       mov       eax,esi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L15
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFEBC990628
       call      qword ptr [7FFEBCD90628]
M01_L15:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC990630
       call      qword ptr [7FFEBCD90630]
M01_L16:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 614
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StructuralSequenceEqual01()
; 			var result = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half).StructuralSequenceEqual(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       r14,[rsi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF01E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFC0],rdi
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF01E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rdi
       mov       r11,7FFEBC970608
       call      qword ptr [7FFEBCD70608]
       test      eax,eax
       je        near ptr M01_L12
M01_L07:
       mov       rcx,rbx
       mov       r11,7FFEBC970610
       call      qword ptr [7FFEBCD70610]
       test      eax,eax
       je        near ptr M01_L13
       call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
       mov       r15,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCF01F78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r12,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCF01F78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,r15
       mov       rdx,r12
       mov       r11,7FFEBC970618
       call      qword ptr [7FFEBCD70618]
       test      eax,eax
       je        short M01_L13
       mov       rcx,rdi
       mov       r11,7FFEBC970608
       call      qword ptr [7FFEBCD70608]
       test      eax,eax
       jne       near ptr M01_L07
M01_L12:
       mov       rcx,rbx
       mov       r11,7FFEBC970620
       call      qword ptr [7FFEBCD70620]
       test      eax,eax
       sete      sil
       movzx     esi,sil
       jmp       short M01_L14
M01_L13:
       xor       esi,esi
M01_L14:
       mov       rcx,rbx
       mov       r11,7FFEBC970628
       call      qword ptr [7FFEBCD70628]
       nop
       mov       rcx,rdi
       mov       r11,7FFEBC970630
       call      qword ptr [7FFEBCD70630]
       mov       eax,esi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L15
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFEBC970628
       call      qword ptr [7FFEBCD70628]
M01_L15:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC970630
       call      qword ptr [7FFEBCD70630]
M01_L16:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 614
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StructuralSequenceEqual01()
; 			var result = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half).StructuralSequenceEqual(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       r14,[rsi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF11E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFC0],rdi
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF11E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rdi
       mov       r11,7FFEBC980608
       call      qword ptr [7FFEBCD80608]
       test      eax,eax
       je        near ptr M01_L12
M01_L07:
       mov       rcx,rbx
       mov       r11,7FFEBC980610
       call      qword ptr [7FFEBCD80610]
       test      eax,eax
       je        near ptr M01_L13
       call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
       mov       r15,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCF11F78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r12,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCF11F78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,r15
       mov       rdx,r12
       mov       r11,7FFEBC980618
       call      qword ptr [7FFEBCD80618]
       test      eax,eax
       je        short M01_L13
       mov       rcx,rdi
       mov       r11,7FFEBC980608
       call      qword ptr [7FFEBCD80608]
       test      eax,eax
       jne       near ptr M01_L07
M01_L12:
       mov       rcx,rbx
       mov       r11,7FFEBC980620
       call      qword ptr [7FFEBCD80620]
       test      eax,eax
       sete      sil
       movzx     esi,sil
       jmp       short M01_L14
M01_L13:
       xor       esi,esi
M01_L14:
       mov       rcx,rbx
       mov       r11,7FFEBC980628
       call      qword ptr [7FFEBCD80628]
       nop
       mov       rcx,rdi
       mov       r11,7FFEBC980630
       call      qword ptr [7FFEBCD80630]
       mov       eax,esi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L15
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFEBC980628
       call      qword ptr [7FFEBCD80628]
M01_L15:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC980630
       call      qword ptr [7FFEBCD80630]
M01_L16:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 614
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StructuralSequenceEqual01()
; 			var result = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half).StructuralSequenceEqual(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       r14,[rsi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF1DF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFC0],rdi
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF1DF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rdi
       mov       r11,7FFEBC960608
       call      qword ptr [7FFEBCD60608]
       test      eax,eax
       je        near ptr M01_L12
M01_L07:
       mov       rcx,rbx
       mov       r11,7FFEBC960610
       call      qword ptr [7FFEBCD60610]
       test      eax,eax
       je        near ptr M01_L13
       call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
       mov       r15,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF1F58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r12,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF1F58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,r15
       mov       rdx,r12
       mov       r11,7FFEBC960618
       call      qword ptr [7FFEBCD60618]
       test      eax,eax
       je        short M01_L13
       mov       rcx,rdi
       mov       r11,7FFEBC960608
       call      qword ptr [7FFEBCD60608]
       test      eax,eax
       jne       near ptr M01_L07
M01_L12:
       mov       rcx,rbx
       mov       r11,7FFEBC960620
       call      qword ptr [7FFEBCD60620]
       test      eax,eax
       sete      sil
       movzx     esi,sil
       jmp       short M01_L14
M01_L13:
       xor       esi,esi
M01_L14:
       mov       rcx,rbx
       mov       r11,7FFEBC960628
       call      qword ptr [7FFEBCD60628]
       nop
       mov       rcx,rdi
       mov       r11,7FFEBC960630
       call      qword ptr [7FFEBCD60630]
       mov       eax,esi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L15
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFEBC960628
       call      qword ptr [7FFEBCD60628]
M01_L15:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC960630
       call      qword ptr [7FFEBCD60630]
M01_L16:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 614
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StructuralSequenceEqual01()
; 			var result = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half).StructuralSequenceEqual(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       r14,[rsi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCFAAD08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFC0],rdi
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCFAAD08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rdi
       mov       r11,7FFEBC980608
       call      qword ptr [7FFEBCF30608]
       test      eax,eax
       je        near ptr M01_L12
M01_L07:
       mov       rcx,rbx
       mov       r11,7FFEBC980610
       call      qword ptr [7FFEBCF30610]
       test      eax,eax
       je        near ptr M01_L13
       call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
       mov       r15,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCFAAE70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r12,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCFAAE70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,r15
       mov       rdx,r12
       mov       r11,7FFEBC980618
       call      qword ptr [7FFEBCF30618]
       test      eax,eax
       je        short M01_L13
       mov       rcx,rdi
       mov       r11,7FFEBC980608
       call      qword ptr [7FFEBCF30608]
       test      eax,eax
       jne       near ptr M01_L07
M01_L12:
       mov       rcx,rbx
       mov       r11,7FFEBC980620
       call      qword ptr [7FFEBCF30620]
       test      eax,eax
       sete      sil
       movzx     esi,sil
       jmp       short M01_L14
M01_L13:
       xor       esi,esi
M01_L14:
       mov       rcx,rbx
       mov       r11,7FFEBC980628
       call      qword ptr [7FFEBCF30628]
       nop
       mov       rcx,rdi
       mov       r11,7FFEBC980630
       call      qword ptr [7FFEBCF30630]
       mov       eax,esi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L15
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFEBC980628
       call      qword ptr [7FFEBCF30628]
M01_L15:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC980630
       call      qword ptr [7FFEBCF30630]
M01_L16:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 614
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToBlockingCollection01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToBlockingCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToBlockingCollection(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToBlockingCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToBlockingCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFC8],rax
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,184EE713020
       mov       rcx,[rcx]
       mov       [rbp+0FFC8],rcx
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCF32420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1850E71DBD0
       mov       r9,[r9]
       lea       r8,[rbp+0FFC8]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rsi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       r14d,eax
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF32660
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       edx,r14d
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       cmp       qword ptr [rbx+20],0
       je        short M01_L04
       mov       r11,[rbx+20]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFEBCF32670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp+0FFC0],rsi
       mov       rcx,rsi
       mov       r11,7FFEBC9A0608
       call      qword ptr [7FFEBCDA0608]
       test      eax,eax
       je        short M01_L09
M01_L06:
       mov       r11,[rbx+28]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCF32688
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,r15
       xor       r9d,r9d
       xor       r8d,r8d
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAddWithNoTimeValidation(System.__Canon, Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       mov       r11,7FFEBC9A0608
       call      qword ptr [7FFEBCDA0608]
       test      eax,eax
       jne       short M01_L06
M01_L09:
       mov       rcx,rsi
       mov       r11,7FFEBC9A0610
       call      qword ptr [7FFEBCDA0610]
       mov       rax,r15
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L10
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC9A0610
       call      qword ptr [7FFEBCDA0610]
M01_L10:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 433
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToBlockingCollection01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToBlockingCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToBlockingCollection(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToBlockingCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToBlockingCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFC8],rax
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,1D8C7113020
       mov       rcx,[rcx]
       mov       [rbp+0FFC8],rcx
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCF12420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1D8C7121FD8
       mov       r9,[r9]
       lea       r8,[rbp+0FFC8]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rsi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       r14d,eax
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF12660
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       edx,r14d
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       cmp       qword ptr [rbx+20],0
       je        short M01_L04
       mov       r11,[rbx+20]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFEBCF12670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp+0FFC0],rsi
       mov       rcx,rsi
       mov       r11,7FFEBC980608
       call      qword ptr [7FFEBCD80608]
       test      eax,eax
       je        short M01_L09
M01_L06:
       mov       r11,[rbx+28]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCF12688
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,r15
       xor       r9d,r9d
       xor       r8d,r8d
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAddWithNoTimeValidation(System.__Canon, Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       mov       r11,7FFEBC980608
       call      qword ptr [7FFEBCD80608]
       test      eax,eax
       jne       short M01_L06
M01_L09:
       mov       rcx,rsi
       mov       r11,7FFEBC980610
       call      qword ptr [7FFEBCD80610]
       mov       rax,r15
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L10
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC980610
       call      qword ptr [7FFEBCD80610]
M01_L10:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 433
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToBlockingCollection01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToBlockingCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToBlockingCollection(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToBlockingCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToBlockingCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFC8],rax
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,259300B3020
       mov       rcx,[rcx]
       mov       [rbp+0FFC8],rcx
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCF02420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,259300B63C0
       mov       r9,[r9]
       lea       r8,[rbp+0FFC8]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rsi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       r14d,eax
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF02660
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       edx,r14d
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       cmp       qword ptr [rbx+20],0
       je        short M01_L04
       mov       r11,[rbx+20]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFEBCF02670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp+0FFC0],rsi
       mov       rcx,rsi
       mov       r11,7FFEBC970608
       call      qword ptr [7FFEBCD70608]
       test      eax,eax
       je        short M01_L09
M01_L06:
       mov       r11,[rbx+28]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCF02688
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,r15
       xor       r9d,r9d
       xor       r8d,r8d
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAddWithNoTimeValidation(System.__Canon, Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       mov       r11,7FFEBC970608
       call      qword ptr [7FFEBCD70608]
       test      eax,eax
       jne       short M01_L06
M01_L09:
       mov       rcx,rsi
       mov       r11,7FFEBC970610
       call      qword ptr [7FFEBCD70610]
       mov       rax,r15
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L10
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC970610
       call      qword ptr [7FFEBCD70610]
M01_L10:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 433
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToBlockingCollection01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToBlockingCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToBlockingCollection(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToBlockingCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToBlockingCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFC8],rax
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,18F53EF3020
       mov       rcx,[rcx]
       mov       [rbp+0FFC8],rcx
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCF02420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,18F73EF17A0
       mov       r9,[r9]
       lea       r8,[rbp+0FFC8]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rsi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       r14d,eax
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF02660
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       edx,r14d
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       cmp       qword ptr [rbx+20],0
       je        short M01_L04
       mov       r11,[rbx+20]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFEBCF02670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp+0FFC0],rsi
       mov       rcx,rsi
       mov       r11,7FFEBC970608
       call      qword ptr [7FFEBCD70608]
       test      eax,eax
       je        short M01_L09
M01_L06:
       mov       r11,[rbx+28]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCF02688
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,r15
       xor       r9d,r9d
       xor       r8d,r8d
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAddWithNoTimeValidation(System.__Canon, Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       mov       r11,7FFEBC970608
       call      qword ptr [7FFEBCD70608]
       test      eax,eax
       jne       short M01_L06
M01_L09:
       mov       rcx,rsi
       mov       r11,7FFEBC970610
       call      qword ptr [7FFEBCD70610]
       mov       rax,r15
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L10
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC970610
       call      qword ptr [7FFEBCD70610]
M01_L10:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 433
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToBlockingCollection01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToBlockingCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToBlockingCollection(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToBlockingCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToBlockingCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFC8],rax
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,1C6C6F23020
       mov       rcx,[rcx]
       mov       [rbp+0FFC8],rcx
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCF12420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1C6C6F32FF0
       mov       r9,[r9]
       lea       r8,[rbp+0FFC8]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rsi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       r14d,eax
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF12660
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       edx,r14d
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       cmp       qword ptr [rbx+20],0
       je        short M01_L04
       mov       r11,[rbx+20]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFEBCF12670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp+0FFC0],rsi
       mov       rcx,rsi
       mov       r11,7FFEBC980608
       call      qword ptr [7FFEBCD80608]
       test      eax,eax
       je        short M01_L09
M01_L06:
       mov       r11,[rbx+28]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCF12688
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,r15
       xor       r9d,r9d
       xor       r8d,r8d
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAddWithNoTimeValidation(System.__Canon, Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       mov       r11,7FFEBC980608
       call      qword ptr [7FFEBCD80608]
       test      eax,eax
       jne       short M01_L06
M01_L09:
       mov       rcx,rsi
       mov       r11,7FFEBC980610
       call      qword ptr [7FFEBCD80610]
       mov       rax,r15
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L10
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC980610
       call      qword ptr [7FFEBCD80610]
M01_L10:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 433
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToBlockingCollection01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToBlockingCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToBlockingCollection(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToBlockingCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToBlockingCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFC8],rax
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,184B61B3020
       mov       rcx,[rcx]
       mov       [rbp+0FFC8],rcx
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCF02420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,184D61B27B8
       mov       r9,[r9]
       lea       r8,[rbp+0FFC8]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rsi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       r14d,eax
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF02660
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       edx,r14d
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       cmp       qword ptr [rbx+20],0
       je        short M01_L04
       mov       r11,[rbx+20]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFEBCF02670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp+0FFC0],rsi
       mov       rcx,rsi
       mov       r11,7FFEBC970608
       call      qword ptr [7FFEBCD70608]
       test      eax,eax
       je        short M01_L09
M01_L06:
       mov       r11,[rbx+28]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCF02688
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,r15
       xor       r9d,r9d
       xor       r8d,r8d
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAddWithNoTimeValidation(System.__Canon, Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       mov       r11,7FFEBC970608
       call      qword ptr [7FFEBCD70608]
       test      eax,eax
       jne       short M01_L06
M01_L09:
       mov       rcx,rsi
       mov       r11,7FFEBC970610
       call      qword ptr [7FFEBCD70610]
       mov       rax,r15
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L10
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC970610
       call      qword ptr [7FFEBCD70610]
M01_L10:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 433
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToBlockingCollection01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToBlockingCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToBlockingCollection(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToBlockingCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToBlockingCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFC8],rax
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,21C88FB3020
       mov       rcx,[rcx]
       mov       [rbp+0FFC8],rcx
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCEF2400
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,21CA8FB1FB8
       mov       r9,[r9]
       lea       r8,[rbp+0FFC8]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rsi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       r14d,eax
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCEF2640
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       edx,r14d
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       cmp       qword ptr [rbx+20],0
       je        short M01_L04
       mov       r11,[rbx+20]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFEBCEF2650
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp+0FFC0],rsi
       mov       rcx,rsi
       mov       r11,7FFEBC960608
       call      qword ptr [7FFEBCD60608]
       test      eax,eax
       je        short M01_L09
M01_L06:
       mov       r11,[rbx+28]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCEF2668
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,r15
       xor       r9d,r9d
       xor       r8d,r8d
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAddWithNoTimeValidation(System.__Canon, Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       mov       r11,7FFEBC960608
       call      qword ptr [7FFEBCD60608]
       test      eax,eax
       jne       short M01_L06
M01_L09:
       mov       rcx,rsi
       mov       r11,7FFEBC960610
       call      qword ptr [7FFEBCD60610]
       mov       rax,r15
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L10
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC960610
       call      qword ptr [7FFEBCD60610]
M01_L10:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 433
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToBlockingCollection01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToBlockingCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToBlockingCollection(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToBlockingCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToBlockingCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFC8],rax
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,22AF0E33020
       mov       rcx,[rcx]
       mov       [rbp+0FFC8],rcx
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCFBB318
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,22AF0E41FD8
       mov       r9,[r9]
       lea       r8,[rbp+0FFC8]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rsi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       r14d,eax
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCFBB558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       edx,r14d
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       cmp       qword ptr [rbx+20],0
       je        short M01_L04
       mov       r11,[rbx+20]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFEBCFBB568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp+0FFC0],rsi
       mov       rcx,rsi
       mov       r11,7FFEBC990608
       call      qword ptr [7FFEBCF40608]
       test      eax,eax
       je        short M01_L09
M01_L06:
       mov       r11,[rbx+28]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFEBCFBB580
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,r15
       xor       r9d,r9d
       xor       r8d,r8d
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAddWithNoTimeValidation(System.__Canon, Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       mov       r11,7FFEBC990608
       call      qword ptr [7FFEBCF40608]
       test      eax,eax
       jne       short M01_L06
M01_L09:
       mov       rcx,rsi
       mov       r11,7FFEBC990610
       call      qword ptr [7FFEBCF40610]
       mov       rax,r15
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L10
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFEBC990610
       call      qword ptr [7FFEBCF40610]
M01_L10:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 433
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToDelimitedString(',');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF2020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L03
M01_L02:
       mov       rax,200CD323020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M01_L08
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF20F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF2230
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFEBCF178C0]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M01_L08
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 358
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToDelimitedString(',');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L03
M01_L02:
       mov       rax,1D694783020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M01_L08
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFEBCF020F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02230
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFEBCF278C0]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M01_L08
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 358
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToDelimitedString(',');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L03
M01_L02:
       mov       rax,1C0A3A33020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M01_L08
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFEBCF020F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02230
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFEBCF278C0]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M01_L08
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 358
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToDelimitedString(',');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF22020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L03
M01_L02:
       mov       rax,17E7A5F3020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M01_L08
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFEBCF220F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF22230
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFEBCF478C0]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M01_L08
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 358
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToDelimitedString(',');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF2020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L03
M01_L02:
       mov       rax,19DB9893020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M01_L08
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF20F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF2230
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFEBCF178C0]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M01_L08
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 358
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToDelimitedString(',');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L03
M01_L02:
       mov       rax,20653351028
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M01_L08
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFEBCF020F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02230
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFEBCF278C0]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M01_L08
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 358
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToDelimitedString(',');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02000
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L03
M01_L02:
       mov       rax,257A93D3020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M01_L08
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFEBCF020D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02210
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFEBCF278C0]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M01_L08
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 358
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToDelimitedString(',');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF8AF18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L03
M01_L02:
       mov       rax,1DB8B863020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M01_L08
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFEBCF8AFE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF8B128
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFEBCF178C0]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M01_L08
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 358
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToLinkedList01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToLinkedList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,243230F3020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rdi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCF323E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,24323101FD8
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF326B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Collections.Generic.LinkedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 163
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToLinkedList01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToLinkedList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,1EF04803020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rdi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCF123E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1EF048073D8
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF126B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Collections.Generic.LinkedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 163
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToLinkedList01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToLinkedList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,28E57AB3020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rdi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCEF23E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,28E77AB27B8
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCEF26B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Collections.Generic.LinkedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 163
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToLinkedList01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToLinkedList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,2B8ABF13020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rdi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCF123E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,2B8BBF117A0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF126B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Collections.Generic.LinkedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 163
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToLinkedList01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToLinkedList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,1A577043020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rdi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCF023E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1A5770463C0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF026B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Collections.Generic.LinkedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 163
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToLinkedList01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToLinkedList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,16B00813020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rdi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCEF23E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,16AE08127B8
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCEF26B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Collections.Generic.LinkedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 163
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToLinkedList01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToLinkedList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,294B0023020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rdi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCEF23C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,294B0032FF0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCEF2698
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Collections.Generic.LinkedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 163
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToLinkedList01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToLinkedList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,1F87FC61028
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rdi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFEBCF9B2D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1F89FC63798
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rsi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFEBCF9B5B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Collections.Generic.LinkedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 163
```

