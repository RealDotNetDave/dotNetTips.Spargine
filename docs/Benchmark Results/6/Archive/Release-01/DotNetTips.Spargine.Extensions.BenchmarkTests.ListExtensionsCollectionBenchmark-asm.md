## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeReadOnlyList()
; 			var result = base.GetPersonProperArray(Tristate.False).ToReadOnlyCollection().GetHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF435F90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,26F39503020
       mov       r8,[r8]
       mov       r9,26F59503188
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF4363C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rdi,rdi
       je        short M01_L04
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 170
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeReadOnlyList()
; 			var result = base.GetPersonProperArray(Tristate.False).ToReadOnlyCollection().GetHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF435F90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,1D987151028
       mov       r8,[r8]
       mov       r9,1D9871619C8
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF4363C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rdi,rdi
       je        short M01_L04
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 170
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeReadOnlyList()
; 			var result = base.GetPersonProperArray(Tristate.False).ToReadOnlyCollection().GetHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF445F90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,1A5584B1028
       mov       r8,[r8]
       mov       r9,1A5684B3188
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF4463C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rdi,rdi
       je        short M01_L04
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 170
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeReadOnlyList()
; 			var result = base.GetPersonProperArray(Tristate.False).ToReadOnlyCollection().GetHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF445F90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,197CFAD3020
       mov       r8,[r8]
       mov       r9,197CFAE39C0
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF4463C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rdi,rdi
       je        short M01_L04
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 170
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeReadOnlyList()
; 			var result = base.GetPersonProperArray(Tristate.False).ToReadOnlyCollection().GetHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF455F90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,12F40453020
       mov       r8,[r8]
       mov       r9,12F404639C0
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF4563C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rdi,rdi
       je        short M01_L04
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 170
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeReadOnlyList()
; 			var result = base.GetPersonProperArray(Tristate.False).ToReadOnlyCollection().GetHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF445F48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,1BAF3AC1028
       mov       r8,[r8]
       mov       r9,1BB13AC5180
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF446380
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rdi,rdi
       je        short M01_L04
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 170
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeReadOnlyList()
; 			var result = base.GetPersonProperArray(Tristate.False).ToReadOnlyCollection().GetHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF455F48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,1ED7C9B3020
       mov       r8,[r8]
       mov       r9,1ED9C9B2170
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF456380
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rdi,rdi
       je        short M01_L04
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 170
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeReadOnlyList()
; 			var result = base.GetPersonProperArray(Tristate.False).ToReadOnlyCollection().GetHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF449A80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,2B097713020
       mov       r8,[r8]
       mov       r9,2B0977239C0
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF449EB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rdi,rdi
       je        short M01_L04
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 170
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems03()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people.HasItems(5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,[rsi+20]
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       cmp       rax,5
       sete      dil
       movzx     edi,dil
M00_L01:
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 85
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF457700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L04
M01_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L05
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       jmp       short M01_L07
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF457C60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF457860
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       [rbp+0FFE8],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFAAF4571E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp+0FFE0],rsi
M02_L02:
       mov       rcx,rsi
       mov       r11,7FFAAEE20678
       call      qword ptr [7FFAAF3E0678]
       test      eax,eax
       je        short M02_L04
       add       rdi,1
       jo        short M02_L03
       jmp       short M02_L02
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L04:
       mov       rcx,rsi
       mov       r11,7FFAAEE20680
       call      qword ptr [7FFAAF3E0680]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M02_L06
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFAAEE20680
       call      qword ptr [7FFAAF3E0680]
M02_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems03()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people.HasItems(5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,[rsi+20]
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       cmp       rax,5
       sete      dil
       movzx     edi,dil
M00_L01:
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 85
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF437700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L04
M01_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L05
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       jmp       short M01_L07
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF437C60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF437860
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       [rbp+0FFE8],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFAAF4371E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp+0FFE0],rsi
M02_L02:
       mov       rcx,rsi
       mov       r11,7FFAAEE00678
       call      qword ptr [7FFAAF3C0678]
       test      eax,eax
       je        short M02_L04
       add       rdi,1
       jo        short M02_L03
       jmp       short M02_L02
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L04:
       mov       rcx,rsi
       mov       r11,7FFAAEE00680
       call      qword ptr [7FFAAF3C0680]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M02_L06
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFAAEE00680
       call      qword ptr [7FFAAF3C0680]
M02_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems03()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people.HasItems(5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,[rsi+20]
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       cmp       rax,5
       sete      dil
       movzx     edi,dil
M00_L01:
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 85
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF457700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L04
M01_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L05
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       jmp       short M01_L07
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF457C60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF457860
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       [rbp+0FFE8],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFAAF4571E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp+0FFE0],rsi
M02_L02:
       mov       rcx,rsi
       mov       r11,7FFAAEE20678
       call      qword ptr [7FFAAF3E0678]
       test      eax,eax
       je        short M02_L04
       add       rdi,1
       jo        short M02_L03
       jmp       short M02_L02
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L04:
       mov       rcx,rsi
       mov       r11,7FFAAEE20680
       call      qword ptr [7FFAAF3E0680]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M02_L06
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFAAEE20680
       call      qword ptr [7FFAAF3E0680]
M02_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems03()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people.HasItems(5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,[rsi+20]
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       cmp       rax,5
       sete      dil
       movzx     edi,dil
M00_L01:
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 85
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF437700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L04
M01_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L05
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       jmp       short M01_L07
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF437C60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF437860
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       [rbp+0FFE8],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFAAF4371E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp+0FFE0],rsi
M02_L02:
       mov       rcx,rsi
       mov       r11,7FFAAEE00678
       call      qword ptr [7FFAAF3C0678]
       test      eax,eax
       je        short M02_L04
       add       rdi,1
       jo        short M02_L03
       jmp       short M02_L02
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L04:
       mov       rcx,rsi
       mov       r11,7FFAAEE00680
       call      qword ptr [7FFAAF3C0680]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M02_L06
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFAAEE00680
       call      qword ptr [7FFAAF3C0680]
M02_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems03()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people.HasItems(5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,[rsi+20]
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       cmp       rax,5
       sete      dil
       movzx     edi,dil
M00_L01:
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 85
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF457700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L04
M01_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L05
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       jmp       short M01_L07
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF457C60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF457860
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       [rbp+0FFE8],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFAAF4571E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp+0FFE0],rsi
M02_L02:
       mov       rcx,rsi
       mov       r11,7FFAAEE20678
       call      qword ptr [7FFAAF3E0678]
       test      eax,eax
       je        short M02_L04
       add       rdi,1
       jo        short M02_L03
       jmp       short M02_L02
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L04:
       mov       rcx,rsi
       mov       r11,7FFAAEE20680
       call      qword ptr [7FFAAF3E0680]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M02_L06
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFAAEE20680
       call      qword ptr [7FFAAF3E0680]
M02_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems03()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people.HasItems(5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,[rsi+20]
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       cmp       rax,5
       sete      dil
       movzx     edi,dil
M00_L01:
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 85
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4476B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L04
M01_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L05
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       jmp       short M01_L07
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF447C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF447818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       [rbp+0FFE8],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFAAF4471A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp+0FFE0],rsi
M02_L02:
       mov       rcx,rsi
       mov       r11,7FFAAEE10678
       call      qword ptr [7FFAAF3D0678]
       test      eax,eax
       je        short M02_L04
       add       rdi,1
       jo        short M02_L03
       jmp       short M02_L02
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L04:
       mov       rcx,rsi
       mov       r11,7FFAAEE10680
       call      qword ptr [7FFAAF3D0680]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M02_L06
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFAAEE10680
       call      qword ptr [7FFAAF3D0680]
M02_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems03()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people.HasItems(5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,[rsi+20]
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       cmp       rax,5
       sete      dil
       movzx     edi,dil
M00_L01:
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 85
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF426F78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L04
M01_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L05
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       jmp       short M01_L07
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4274D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4270D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       [rbp+0FFE8],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFAAF428220
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp+0FFE0],rsi
M02_L02:
       mov       rcx,rsi
       mov       r11,7FFAAEDF0698
       call      qword ptr [7FFAAF3B0698]
       test      eax,eax
       je        short M02_L04
       add       rdi,1
       jo        short M02_L03
       jmp       short M02_L02
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L04:
       mov       rcx,rsi
       mov       r11,7FFAAEDF06A0
       call      qword ptr [7FFAAF3B06A0]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M02_L06
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFAAEDF06A0
       call      qword ptr [7FFAAF3B06A0]
M02_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems03()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people.HasItems(5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,[rsi+20]
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       cmp       rax,5
       sete      dil
       movzx     edi,dil
M00_L01:
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 85
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF43FC30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L04
M01_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L05
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       jmp       short M01_L07
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF450190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF43FD90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       [rbp+0FFE8],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFAAF450308
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp+0FFE0],rsi
M02_L02:
       mov       rcx,rsi
       mov       r11,7FFAAEDF07C8
       call      qword ptr [7FFAAF3C07C8]
       test      eax,eax
       je        short M02_L04
       add       rdi,1
       jo        short M02_L03
       jmp       short M02_L02
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L04:
       mov       rcx,rsi
       mov       r11,7FFAAEDF07D0
       call      qword ptr [7FFAAF3C07D0]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M02_L06
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFAAEDF07D0
       call      qword ptr [7FFAAF3C07D0]
M02_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems02()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rsi,[rsi+20]
       mov       rcx,14277D07400
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,14277D073F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<HasItems02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,14277D07400
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 164
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF428BD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L04
M01_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L05
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       jmp       short M01_L07
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF429130
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF428D30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<HasItems02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			base.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
; 			                                           ^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,0FFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,0
       or        rax,rdx
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,0
       or        rdx,rcx
       mov       rcx,0FFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAAF3AAF58]
       vucomisd  xmm0,qword ptr [7FFAAF3AAF60]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
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
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4261B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r9,14247D03020
       mov       r14,[r9]
       mov       r9,r14
       mov       rdx,rdi
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       je        short M03_L04
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF426330
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       r9,r14
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       jne       short M03_L05
M03_L04:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
       mov       rax,14267D01CD0
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L06:
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
; Total bytes of code 230
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems02()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rsi,[rsi+20]
       mov       rcx,13350E87400
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,13350E873F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<HasItems02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,13350E87400
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 164
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF448268
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L04
M01_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L05
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       jmp       short M01_L07
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4487C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4483C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<HasItems02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			base.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
; 			                                           ^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,0FFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,0
       or        rax,rdx
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,0
       or        rdx,rcx
       mov       rcx,0FFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAAF3CAF58]
       vucomisd  xmm0,qword ptr [7FFAAF3CAF60]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
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
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4461B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r9,13370E83020
       mov       r14,[r9]
       mov       r9,r14
       mov       rdx,rdi
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       je        short M03_L04
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF446330
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       r9,r14
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       jne       short M03_L05
M03_L04:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
       mov       rax,13370E860D8
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L06:
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
; Total bytes of code 230
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems02()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rsi,[rsi+20]
       mov       rcx,18CF9707400
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,18CF97073F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<HasItems02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,18CF9707400
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 164
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF458268
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L04
M01_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L05
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       jmp       short M01_L07
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4587C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4583C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<HasItems02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			base.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
; 			                                           ^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,0FFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,0
       or        rax,rdx
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,0
       or        rdx,rcx
       mov       rcx,0FFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAAF3DAF58]
       vucomisd  xmm0,qword ptr [7FFAAF3DAF60]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
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
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4561B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r9,18CD9703020
       mov       r14,[r9]
       mov       r9,r14
       mov       rdx,rdi
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       je        short M03_L04
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF456330
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       r9,r14
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       jne       short M03_L05
M03_L04:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
       mov       rax,18CE9702CE8
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L06:
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
; Total bytes of code 230
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems02()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rsi,[rsi+20]
       mov       rcx,1DC5945B808
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1DC5945B800
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<HasItems02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1DC5945B808
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 164
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF438268
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L04
M01_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L05
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       jmp       short M01_L07
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4387C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4383C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<HasItems02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			base.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
; 			                                           ^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,0FFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,0
       or        rax,rdx
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,0
       or        rdx,rcx
       mov       rcx,0FFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAAF3BAF58]
       vucomisd  xmm0,qword ptr [7FFAAF3BAF60]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
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
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4361B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r9,1DC59453020
       mov       r14,[r9]
       mov       r9,r14
       mov       rdx,rdi
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       je        short M03_L04
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF436330
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       r9,r14
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       jne       short M03_L05
M03_L04:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
       mov       rax,1DC59463520
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L06:
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
; Total bytes of code 230
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems02()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rsi,[rsi+20]
       mov       rcx,21AEE7F9810
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,21AEE7F9808
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<HasItems02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,21AEE7F9810
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 164
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF448BD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L04
M01_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L05
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       jmp       short M01_L07
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF449130
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF448D30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<HasItems02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			base.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
; 			                                           ^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,0FFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,0
       or        rax,rdx
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,0
       or        rdx,rcx
       mov       rcx,0FFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAAF3CAF58]
       vucomisd  xmm0,qword ptr [7FFAAF3CAF60]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
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
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4461B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r9,21AEE7F1028
       mov       r14,[r9]
       mov       r9,r14
       mov       rdx,rdi
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       je        short M03_L04
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF446330
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       r9,r14
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       jne       short M03_L05
M03_L04:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
       mov       rax,21AEE7FFCF8
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L06:
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
; Total bytes of code 230
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems02()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rsi,[rsi+20]
       mov       rcx,1F10C147400
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1F10C1473F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<HasItems02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1F10C147400
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 164
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF458220
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L04
M01_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L05
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       jmp       short M01_L07
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF458780
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF458380
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<HasItems02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			base.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
; 			                                           ^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,0FFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,0
       or        rax,rdx
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,0
       or        rdx,rcx
       mov       rcx,0FFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAAF3DAF58]
       vucomisd  xmm0,qword ptr [7FFAAF3DAF60]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
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
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF456170
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r9,1F0EC141028
       mov       r14,[r9]
       mov       r9,r14
       mov       rdx,rdi
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       je        short M03_L04
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF4562E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       r9,r14
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       jne       short M03_L05
M03_L04:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
       mov       rax,1F0DC1434B0
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L06:
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
; Total bytes of code 230
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems02()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rsi,[rsi+20]
       mov       rcx,185F2217400
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,185F22173F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<HasItems02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,185F2217400
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 164
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF438220
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L04
M01_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L05
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       jmp       short M01_L07
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF438780
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF438380
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<HasItems02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			base.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
; 			                                           ^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,0FFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,0
       or        rax,rdx
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,0
       or        rdx,rcx
       mov       rcx,0FFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAAF3BAF58]
       vucomisd  xmm0,qword ptr [7FFAAF3BAF60]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
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
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF436170
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r9,185C2213020
       mov       r14,[r9]
       mov       r9,r14
       mov       rdx,rdi
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       je        short M03_L04
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF4362E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       r9,r14
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       jne       short M03_L05
M03_L04:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
       mov       rax,185C22158C0
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L06:
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
; Total bytes of code 230
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems02()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rsi,[rsi+20]
       mov       rcx,2380DF3B808
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2380DF3B800
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<HasItems02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2380DF3B808
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 164
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4608F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L04
M01_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L05
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       jmp       short M01_L07
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF460E50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF460A50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<HasItems02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			base.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
; 			                                           ^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,0FFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,0
       or        rax,rdx
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,0
       or        rdx,rcx
       mov       rcx,0FFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAAF3C82D8]
       vucomisd  xmm0,qword ptr [7FFAAF3C82E0]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
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
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF449CA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r9,2380DF33020
       mov       r14,[r9]
       mov       r9,r14
       mov       rdx,rdi
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       je        short M03_L04
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF449E20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       r9,r14
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       jne       short M03_L05
M03_L04:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
       mov       rax,237EDF324D0
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L06:
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
; Total bytes of code 230
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ShuffleWithCount()
; 			var result = base.GetPersonProperArray(Tristate.False).Shuffle(Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8d,[rsi+134]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rbp,[rdi+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1CA4BF73020
       mov       r14,[rax]
       mov       rax,1CA4BF829A8
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       cmp       ebx,1
       jle       short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       ebx,1
M01_L02:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAF392DB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rsi
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFAAF392E68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rsi
       mov       r8d,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; Total bytes of code 206
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ShuffleWithCount()
; 			var result = base.GetPersonProperArray(Tristate.False).Shuffle(Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8d,[rsi+134]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rbp,[rdi+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,22225633020
       mov       r14,[rax]
       mov       rax,22245633188
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       cmp       ebx,1
       jle       short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       ebx,1
M01_L02:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAF3B2DB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rsi
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFAAF3B2E68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rsi
       mov       r8d,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; Total bytes of code 206
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ShuffleWithCount()
; 			var result = base.GetPersonProperArray(Tristate.False).Shuffle(Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8d,[rsi+134]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rbp,[rdi+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1940B5C3020
       mov       r14,[rax]
       mov       rax,1940B5D39C0
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       cmp       ebx,1
       jle       short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       ebx,1
M01_L02:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAF3B2DB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rsi
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFAAF3B2E68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rsi
       mov       r8d,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; Total bytes of code 206
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ShuffleWithCount()
; 			var result = base.GetPersonProperArray(Tristate.False).Shuffle(Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8d,[rsi+134]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rbp,[rdi+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1FBBA703020
       mov       r14,[rax]
       mov       rax,1FBBA7139C0
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       cmp       ebx,1
       jle       short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       ebx,1
M01_L02:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAF3A2DB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rsi
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFAAF3A2E68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rsi
       mov       r8d,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; Total bytes of code 206
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ShuffleWithCount()
; 			var result = base.GetPersonProperArray(Tristate.False).Shuffle(Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8d,[rsi+134]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rbp,[rdi+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1B5823C3020
       mov       r14,[rax]
       mov       rax,1B5623C1958
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       cmp       ebx,1
       jle       short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       ebx,1
M01_L02:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAF3A2DB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rsi
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFAAF3A2E68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rsi
       mov       r8d,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; Total bytes of code 206
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ShuffleWithCount()
; 			var result = base.GetPersonProperArray(Tristate.False).Shuffle(Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8d,[rsi+134]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rbp,[rdi+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1D171DA3020
       mov       r14,[rax]
       mov       rax,1D191DA2170
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       cmp       ebx,1
       jle       short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       ebx,1
M01_L02:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAF392E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rsi
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFAAF392EB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rsi
       mov       r8d,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; Total bytes of code 206
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ShuffleWithCount()
; 			var result = base.GetPersonProperArray(Tristate.False).Shuffle(Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8d,[rsi+134]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rbp,[rdi+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1EE75D63020
       mov       r14,[rax]
       mov       rax,1EE75D65D60
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       cmp       ebx,1
       jle       short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       ebx,1
M01_L02:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAF3C2E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rsi
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFAAF3C2EB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rsi
       mov       r8d,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; Total bytes of code 206
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ShuffleWithCount()
; 			var result = base.GetPersonProperArray(Tristate.False).Shuffle(Count / 2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8d,[rsi+134]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rbp,[rdi+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,134E4BD3020
       mov       r14,[rax]
       mov       rax,134C4BD2970
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       cmp       ebx,1
       jle       short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       ebx,1
M01_L02:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAF3AA2A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rsi
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFAAF3AA358
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rsi
       mov       r8d,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; Total bytes of code 206
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom02()
; 			var people = new ArraySegment<PersonProper>(base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.Slice(RandomData.GenerateInteger(0, people.Count - 1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rdi,[rsi+118]
       test      rdi,rdi
       je        short M00_L00
       mov       ebx,[rdi+8]
       mov       ebp,ebx
       lea       edx,[rbp+0FFFF]
       xor       ecx,ecx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       edx,eax
       cmp       edx,ebp
       ja        short M00_L01
       mov       rcx,rdi
       mov       r8d,ebp
       sub       r8d,edx
       cmp       ebx,edx
       jb        short M00_L02
       mov       [rsp+28],rcx
       mov       [rsp+30],edx
       mov       [rsp+34],r8d
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer(!!0 ByRef)
       call      BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.ArraySegment`1[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ArraySegment`1<System.__Canon> ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,2
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M00_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M00_L02:
       call      System.ThrowHelper.ThrowArraySegmentCtorValidationFailedExceptions(System.Array, Int32, Int32)
       int       3
; Total bytes of code 142
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       esi,ecx
       mov       edi,edx
       mov       rdx,1F7863EB850
       mov       rcx,[rdx]
       mov       [rbp+0FFE0],rcx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M01_L00
       lea       rdx,[rbp+0FFE8]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L01
M01_L00:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L01:
       mov       ecx,esi
       mov       edx,edi
       call      System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       esi,eax
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L02
       mov       rcx,[rbp+0FFE0]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L02:
       mov       eax,esi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L03
       mov       rcx,[rbp+0FFE0]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.ArraySegment`1[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ArraySegment`1<System.__Canon> ByRef)
       ret
; Total bytes of code 1
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom02()
; 			var people = new ArraySegment<PersonProper>(base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.Slice(RandomData.GenerateInteger(0, people.Count - 1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rdi,[rsi+118]
       test      rdi,rdi
       je        short M00_L00
       mov       ebx,[rdi+8]
       mov       ebp,ebx
       lea       edx,[rbp+0FFFF]
       xor       ecx,ecx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       edx,eax
       cmp       edx,ebp
       ja        short M00_L01
       mov       rcx,rdi
       mov       r8d,ebp
       sub       r8d,edx
       cmp       ebx,edx
       jb        short M00_L02
       mov       [rsp+28],rcx
       mov       [rsp+30],edx
       mov       [rsp+34],r8d
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer(!!0 ByRef)
       call      BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.ArraySegment`1[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ArraySegment`1<System.__Canon> ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,2
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M00_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M00_L02:
       call      System.ThrowHelper.ThrowArraySegmentCtorValidationFailedExceptions(System.Array, Int32, Int32)
       int       3
; Total bytes of code 142
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       esi,ecx
       mov       edi,edx
       mov       rdx,22C4848B850
       mov       rcx,[rdx]
       mov       [rbp+0FFE0],rcx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M01_L00
       lea       rdx,[rbp+0FFE8]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L01
M01_L00:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L01:
       mov       ecx,esi
       mov       edx,edi
       call      System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       esi,eax
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L02
       mov       rcx,[rbp+0FFE0]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L02:
       mov       eax,esi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L03
       mov       rcx,[rbp+0FFE0]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.ArraySegment`1[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ArraySegment`1<System.__Canon> ByRef)
       ret
; Total bytes of code 1
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom02()
; 			var people = new ArraySegment<PersonProper>(base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.Slice(RandomData.GenerateInteger(0, people.Count - 1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rdi,[rsi+118]
       test      rdi,rdi
       je        short M00_L00
       mov       ebx,[rdi+8]
       mov       ebp,ebx
       lea       edx,[rbp+0FFFF]
       xor       ecx,ecx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       edx,eax
       cmp       edx,ebp
       ja        short M00_L01
       mov       rcx,rdi
       mov       r8d,ebp
       sub       r8d,edx
       cmp       ebx,edx
       jb        short M00_L02
       mov       [rsp+28],rcx
       mov       [rsp+30],edx
       mov       [rsp+34],r8d
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer(!!0 ByRef)
       call      BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.ArraySegment`1[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ArraySegment`1<System.__Canon> ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,2
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M00_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M00_L02:
       call      System.ThrowHelper.ThrowArraySegmentCtorValidationFailedExceptions(System.Array, Int32, Int32)
       int       3
; Total bytes of code 142
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       esi,ecx
       mov       edi,edx
       mov       rdx,21CD5497448
       mov       rcx,[rdx]
       mov       [rbp+0FFE0],rcx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M01_L00
       lea       rdx,[rbp+0FFE8]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L01
M01_L00:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L01:
       mov       ecx,esi
       mov       edx,edi
       call      System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       esi,eax
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L02
       mov       rcx,[rbp+0FFE0]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L02:
       mov       eax,esi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L03
       mov       rcx,[rbp+0FFE0]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.ArraySegment`1[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ArraySegment`1<System.__Canon> ByRef)
       ret
; Total bytes of code 1
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom02()
; 			var people = new ArraySegment<PersonProper>(base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.Slice(RandomData.GenerateInteger(0, people.Count - 1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rdi,[rsi+118]
       test      rdi,rdi
       je        short M00_L00
       mov       ebx,[rdi+8]
       mov       ebp,ebx
       lea       edx,[rbp+0FFFF]
       xor       ecx,ecx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       edx,eax
       cmp       edx,ebp
       ja        short M00_L01
       mov       rcx,rdi
       mov       r8d,ebp
       sub       r8d,edx
       cmp       ebx,edx
       jb        short M00_L02
       mov       [rsp+28],rcx
       mov       [rsp+30],edx
       mov       [rsp+34],r8d
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer(!!0 ByRef)
       call      BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.ArraySegment`1[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ArraySegment`1<System.__Canon> ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,2
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M00_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M00_L02:
       call      System.ThrowHelper.ThrowArraySegmentCtorValidationFailedExceptions(System.Array, Int32, Int32)
       int       3
; Total bytes of code 142
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       esi,ecx
       mov       edi,edx
       mov       rdx,1B0E6557448
       mov       rcx,[rdx]
       mov       [rbp+0FFE0],rcx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M01_L00
       lea       rdx,[rbp+0FFE8]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L01
M01_L00:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L01:
       mov       ecx,esi
       mov       edx,edi
       call      System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       esi,eax
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L02
       mov       rcx,[rbp+0FFE0]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L02:
       mov       eax,esi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L03
       mov       rcx,[rbp+0FFE0]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.ArraySegment`1[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ArraySegment`1<System.__Canon> ByRef)
       ret
; Total bytes of code 1
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom02()
; 			var people = new ArraySegment<PersonProper>(base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.Slice(RandomData.GenerateInteger(0, people.Count - 1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rdi,[rsi+118]
       test      rdi,rdi
       je        short M00_L00
       mov       ebx,[rdi+8]
       mov       ebp,ebx
       lea       edx,[rbp+0FFFF]
       xor       ecx,ecx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       edx,eax
       cmp       edx,ebp
       ja        short M00_L01
       mov       rcx,rdi
       mov       r8d,ebp
       sub       r8d,edx
       cmp       ebx,edx
       jb        short M00_L02
       mov       [rsp+28],rcx
       mov       [rsp+30],edx
       mov       [rsp+34],r8d
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer(!!0 ByRef)
       call      BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.ArraySegment`1[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ArraySegment`1<System.__Canon> ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,2
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M00_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M00_L02:
       call      System.ThrowHelper.ThrowArraySegmentCtorValidationFailedExceptions(System.Array, Int32, Int32)
       int       3
; Total bytes of code 142
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       esi,ecx
       mov       edi,edx
       mov       rdx,2362558B850
       mov       rcx,[rdx]
       mov       [rbp+0FFE0],rcx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M01_L00
       lea       rdx,[rbp+0FFE8]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L01
M01_L00:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L01:
       mov       ecx,esi
       mov       edx,edi
       call      System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       esi,eax
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L02
       mov       rcx,[rbp+0FFE0]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L02:
       mov       eax,esi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L03
       mov       rcx,[rbp+0FFE0]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.ArraySegment`1[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ArraySegment`1<System.__Canon> ByRef)
       ret
; Total bytes of code 1
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom02()
; 			var people = new ArraySegment<PersonProper>(base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.Slice(RandomData.GenerateInteger(0, people.Count - 1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rdi,[rsi+118]
       test      rdi,rdi
       je        short M00_L00
       mov       ebx,[rdi+8]
       mov       ebp,ebx
       lea       edx,[rbp+0FFFF]
       xor       ecx,ecx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       edx,eax
       cmp       edx,ebp
       ja        short M00_L01
       mov       rcx,rdi
       mov       r8d,ebp
       sub       r8d,edx
       cmp       ebx,edx
       jb        short M00_L02
       mov       [rsp+28],rcx
       mov       [rsp+30],edx
       mov       [rsp+34],r8d
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer(!!0 ByRef)
       call      BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.ArraySegment`1[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ArraySegment`1<System.__Canon> ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,2
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M00_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M00_L02:
       call      System.ThrowHelper.ThrowArraySegmentCtorValidationFailedExceptions(System.Array, Int32, Int32)
       int       3
; Total bytes of code 142
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       esi,ecx
       mov       edi,edx
       mov       rdx,1DAB108B850
       mov       rcx,[rdx]
       mov       [rbp+0FFE0],rcx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M01_L00
       lea       rdx,[rbp+0FFE8]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L01
M01_L00:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L01:
       mov       ecx,esi
       mov       edx,edi
       call      System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       esi,eax
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L02
       mov       rcx,[rbp+0FFE0]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L02:
       mov       eax,esi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L03
       mov       rcx,[rbp+0FFE0]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.ArraySegment`1[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ArraySegment`1<System.__Canon> ByRef)
       ret
; Total bytes of code 1
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom02()
; 			var people = new ArraySegment<PersonProper>(base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.Slice(RandomData.GenerateInteger(0, people.Count - 1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rdi,[rsi+118]
       test      rdi,rdi
       je        short M00_L00
       mov       ebx,[rdi+8]
       mov       ebp,ebx
       lea       edx,[rbp+0FFFF]
       xor       ecx,ecx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       edx,eax
       cmp       edx,ebp
       ja        short M00_L01
       mov       rcx,rdi
       mov       r8d,ebp
       sub       r8d,edx
       cmp       ebx,edx
       jb        short M00_L02
       mov       [rsp+28],rcx
       mov       [rsp+30],edx
       mov       [rsp+34],r8d
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer(!!0 ByRef)
       call      BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.ArraySegment`1[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ArraySegment`1<System.__Canon> ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,2
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M00_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M00_L02:
       call      System.ThrowHelper.ThrowArraySegmentCtorValidationFailedExceptions(System.Array, Int32, Int32)
       int       3
; Total bytes of code 142
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       esi,ecx
       mov       edi,edx
       mov       rdx,1F0958F7448
       mov       rcx,[rdx]
       mov       [rbp+0FFE0],rcx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M01_L00
       lea       rdx,[rbp+0FFE8]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L01
M01_L00:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L01:
       mov       ecx,esi
       mov       edx,edi
       call      System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       esi,eax
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L02
       mov       rcx,[rbp+0FFE0]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L02:
       mov       eax,esi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L03
       mov       rcx,[rbp+0FFE0]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.ArraySegment`1[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ArraySegment`1<System.__Canon> ByRef)
       ret
; Total bytes of code 1
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom02()
; 			var people = new ArraySegment<PersonProper>(base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.Slice(RandomData.GenerateInteger(0, people.Count - 1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rdi,[rsi+118]
       test      rdi,rdi
       je        short M00_L00
       mov       ebx,[rdi+8]
       mov       ebp,ebx
       lea       edx,[rbp+0FFFF]
       xor       ecx,ecx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       edx,eax
       cmp       edx,ebp
       ja        short M00_L01
       mov       rcx,rdi
       mov       r8d,ebp
       sub       r8d,edx
       cmp       ebx,edx
       jb        short M00_L02
       mov       [rsp+28],rcx
       mov       [rsp+30],edx
       mov       [rsp+34],r8d
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer(!!0 ByRef)
       call      BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.ArraySegment`1[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ArraySegment`1<System.__Canon> ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,2
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M00_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M00_L02:
       call      System.ThrowHelper.ThrowArraySegmentCtorValidationFailedExceptions(System.Array, Int32, Int32)
       int       3
; Total bytes of code 142
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       esi,ecx
       mov       edi,edx
       mov       rdx,2D44A729440
       mov       rcx,[rdx]
       mov       [rbp+0FFE0],rcx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M01_L00
       lea       rdx,[rbp+0FFE8]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L01
M01_L00:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L01:
       mov       ecx,esi
       mov       edx,edi
       call      System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       esi,eax
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L02
       mov       rcx,[rbp+0FFE0]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L02:
       mov       eax,esi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L03
       mov       rcx,[rbp+0FFE0]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
```assembly
; BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.ArraySegment`1[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ArraySegment`1<System.__Canon> ByRef)
       ret
; Total bytes of code 1
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r8,[rsi+28]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 100
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
       mov       rax,1A3BFFD3020
       mov       rbx,[rax]
       mov       rax,1A3DFFD15C8
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
       mov       rdx,7FFAAF2C0570
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4C29A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L04
M02_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L05
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       jmp       short M02_L07
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4C2F08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4C2B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
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
       mov       rbp,[rdi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rdi
       mov       rdx,7FFAAF481848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r8,1A3BFFD3020
       mov       r8,[r8]
       mov       r9,1A3BFFDA1F8
       mov       r9,[r9]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rsi,rax
       test      rbx,rbx
       jne       short M03_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L02:
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M03_L03
       jmp       short M03_L04
M03_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAF481868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rdi
       mov       rdx,7FFAAF4819D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
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
; Total bytes of code 216
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r8,[rsi+28]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 100
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
       mov       rax,1E5C30B3020
       mov       rbx,[rax]
       mov       rax,1E5C30C1E00
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
       mov       rdx,7FFAAF2C0570
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4C2F40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L04
M02_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L05
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       jmp       short M02_L07
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4C34A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4C30A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
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
       mov       rbp,[rdi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rdi
       mov       rdx,7FFAAF481848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r8,1E5C30B3020
       mov       r8,[r8]
       mov       r9,1E5A30B2970
       mov       r9,[r9]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rsi,rax
       test      rbx,rbx
       jne       short M03_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L02:
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M03_L03
       jmp       short M03_L04
M03_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAF481868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rdi
       mov       rdx,7FFAAF4819D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
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
; Total bytes of code 216
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r8,[rsi+28]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 100
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
       mov       rax,13B6AEC1028
       mov       rbx,[rax]
       mov       rax,13B8AEC15C8
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
       mov       rdx,7FFAAF2E0570
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E11B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L04
M02_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L05
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       jmp       short M02_L07
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E1710
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E1310
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
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
       mov       rbp,[rdi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A17E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r8,13B6AEC1028
       mov       r8,[r8]
       mov       r9,13B7AEC3950
       mov       r9,[r9]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rsi,rax
       test      rbx,rbx
       jne       short M03_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L02:
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M03_L03
       jmp       short M03_L04
M03_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A1800
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A1968
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
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
; Total bytes of code 216
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r8,[rsi+28]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 100
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
       mov       rax,263B50B1028
       mov       rbx,[rax]
       mov       rax,263D50B35C0
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
       mov       rdx,7FFAAF2E0570
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E3318
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L04
M02_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L05
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       jmp       short M02_L07
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E3878
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E3478
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
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
       mov       rbp,[rdi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A1848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r8,263B50B1028
       mov       r8,[r8]
       mov       r9,263B50C0198
       mov       r9,[r9]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rsi,rax
       test      rbx,rbx
       jne       short M03_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L02:
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M03_L03
       jmp       short M03_L04
M03_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A1868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A19D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
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
; Total bytes of code 216
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r8,[rsi+28]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 100
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
       mov       rax,1B5993E3020
       mov       rbx,[rax]
       mov       rax,1B5B93E15C8
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
       mov       rdx,7FFAAF2E0570
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E1278
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L04
M02_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L05
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       jmp       short M02_L07
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E17D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E13D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
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
       mov       rbp,[rdi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A1848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r8,1B5993E3020
       mov       r8,[r8]
       mov       r9,1B5993EDCF8
       mov       r9,[r9]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rsi,rax
       test      rbx,rbx
       jne       short M03_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L02:
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M03_L03
       jmp       short M03_L04
M03_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A1868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A19D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
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
; Total bytes of code 216
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r8,[rsi+28]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 100
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
       mov       rax,25B6C0D1028
       mov       rbx,[rax]
       mov       rax,25B5C0DD9F8
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
       mov       rdx,7FFAAF2D0570
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4D1218
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L04
M02_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L05
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       jmp       short M02_L07
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4D1778
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4D1378
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
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
       mov       rbp,[rdi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rdi
       mov       rdx,7FFAAF4917E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r8,25B6C0D1028
       mov       r8,[r8]
       mov       r9,25B5C0DE5A0
       mov       r9,[r9]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rsi,rax
       test      rbx,rbx
       jne       short M03_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L02:
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M03_L03
       jmp       short M03_L04
M03_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAF491800
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rdi
       mov       rdx,7FFAAF491968
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
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
; Total bytes of code 216
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r8,[rsi+28]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 100
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
       mov       rax,15B1E9D3020
       mov       rbx,[rax]
       mov       rax,15B1E9DD968
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
       mov       rdx,7FFAAF2D0570
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4D1240
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L04
M02_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L05
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       jmp       short M02_L07
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4D17A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4D13A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
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
       mov       rbp,[rdi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rdi
       mov       rdx,7FFAAF4917F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r8,15B1E9D3020
       mov       r8,[r8]
       mov       r9,15B1E9DF528
       mov       r9,[r9]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rsi,rax
       test      rbx,rbx
       jne       short M03_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L02:
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M03_L03
       jmp       short M03_L04
M03_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAF491818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rdi
       mov       rdx,7FFAAF491980
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
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
; Total bytes of code 216
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r8,[rsi+28]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 100
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
       mov       rax,2ABF3173020
       mov       rbx,[rax]
       mov       rax,2ABF3181E00
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
       mov       rdx,7FFAAF2E0570
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4EE580
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L04
M02_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L05
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       jmp       short M02_L07
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4EEAE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4EE6E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
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
       mov       rbp,[rdi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rdi
       mov       rdx,7FFAAF4C17F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r8,2ABF3173020
       mov       r8,[r8]
       mov       r9,2ABF31839C0
       mov       r9,[r9]
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rsi,rax
       test      rbx,rbx
       jne       short M03_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L02:
       mov       r11,[rbp+18]
       test      r11,r11
       je        short M03_L03
       jmp       short M03_L04
M03_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAF4C1818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       r14d,eax
       mov       r11,[rbp+20]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rdi
       mov       rdx,7FFAAF4C1980
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
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
; Total bytes of code 216
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualList()
; 			var result = base.GetPersonProperArray(Core.Tristate.False).AreEqual(base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFF0],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       jne       short M01_L00
       mov       rcx,[rbp+20]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       je        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L01:
       mov       rax,[rbp+18]
       mov       eax,[rax+8]
       mov       rcx,[rbp+20]
       cmp       eax,[rcx+8]
       je        short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L02:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFF8],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFF8]
       cmp       edx,[rcx+8]
       jae       short M01_L05
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFF0],rcx
       mov       rcx,[rbp+0FFF0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFF8]
       cmp       eax,[rdx+8]
       jae       short M01_L05
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFF0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFF8]
       add       eax,1
       jo        short M01_L06
       mov       [rbp+0FFF8],eax
M01_L04:
       mov       ecx,[rbp+0FFF8]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L03
       mov       eax,[rbp+0FFFC]
       add       rsp,30
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 222
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualList()
; 			var result = base.GetPersonProperArray(Core.Tristate.False).AreEqual(base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFF0],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       jne       short M01_L00
       mov       rcx,[rbp+20]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       je        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L01:
       mov       rax,[rbp+18]
       mov       eax,[rax+8]
       mov       rcx,[rbp+20]
       cmp       eax,[rcx+8]
       je        short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L02:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFF8],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFF8]
       cmp       edx,[rcx+8]
       jae       short M01_L05
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFF0],rcx
       mov       rcx,[rbp+0FFF0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFF8]
       cmp       eax,[rdx+8]
       jae       short M01_L05
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFF0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFF8]
       add       eax,1
       jo        short M01_L06
       mov       [rbp+0FFF8],eax
M01_L04:
       mov       ecx,[rbp+0FFF8]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L03
       mov       eax,[rbp+0FFFC]
       add       rsp,30
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 222
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualList()
; 			var result = base.GetPersonProperArray(Core.Tristate.False).AreEqual(base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFF0],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       jne       short M01_L00
       mov       rcx,[rbp+20]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       je        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L01:
       mov       rax,[rbp+18]
       mov       eax,[rax+8]
       mov       rcx,[rbp+20]
       cmp       eax,[rcx+8]
       je        short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L02:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFF8],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFF8]
       cmp       edx,[rcx+8]
       jae       short M01_L05
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFF0],rcx
       mov       rcx,[rbp+0FFF0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFF8]
       cmp       eax,[rdx+8]
       jae       short M01_L05
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFF0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFF8]
       add       eax,1
       jo        short M01_L06
       mov       [rbp+0FFF8],eax
M01_L04:
       mov       ecx,[rbp+0FFF8]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L03
       mov       eax,[rbp+0FFFC]
       add       rsp,30
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 222
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualList()
; 			var result = base.GetPersonProperArray(Core.Tristate.False).AreEqual(base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFF0],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       jne       short M01_L00
       mov       rcx,[rbp+20]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       je        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L01:
       mov       rax,[rbp+18]
       mov       eax,[rax+8]
       mov       rcx,[rbp+20]
       cmp       eax,[rcx+8]
       je        short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L02:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFF8],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFF8]
       cmp       edx,[rcx+8]
       jae       short M01_L05
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFF0],rcx
       mov       rcx,[rbp+0FFF0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFF8]
       cmp       eax,[rdx+8]
       jae       short M01_L05
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFF0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFF8]
       add       eax,1
       jo        short M01_L06
       mov       [rbp+0FFF8],eax
M01_L04:
       mov       ecx,[rbp+0FFF8]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L03
       mov       eax,[rbp+0FFFC]
       add       rsp,30
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 222
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualList()
; 			var result = base.GetPersonProperArray(Core.Tristate.False).AreEqual(base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFF0],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       jne       short M01_L00
       mov       rcx,[rbp+20]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       je        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L01:
       mov       rax,[rbp+18]
       mov       eax,[rax+8]
       mov       rcx,[rbp+20]
       cmp       eax,[rcx+8]
       je        short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L02:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFF8],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFF8]
       cmp       edx,[rcx+8]
       jae       short M01_L05
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFF0],rcx
       mov       rcx,[rbp+0FFF0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFF8]
       cmp       eax,[rdx+8]
       jae       short M01_L05
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFF0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFF8]
       add       eax,1
       jo        short M01_L06
       mov       [rbp+0FFF8],eax
M01_L04:
       mov       ecx,[rbp+0FFF8]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L03
       mov       eax,[rbp+0FFFC]
       add       rsp,30
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 222
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualList()
; 			var result = base.GetPersonProperArray(Core.Tristate.False).AreEqual(base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFF0],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       jne       short M01_L00
       mov       rcx,[rbp+20]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       je        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L01:
       mov       rax,[rbp+18]
       mov       eax,[rax+8]
       mov       rcx,[rbp+20]
       cmp       eax,[rcx+8]
       je        short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L02:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFF8],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFF8]
       cmp       edx,[rcx+8]
       jae       short M01_L05
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFF0],rcx
       mov       rcx,[rbp+0FFF0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFF8]
       cmp       eax,[rdx+8]
       jae       short M01_L05
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFF0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFF8]
       add       eax,1
       jo        short M01_L06
       mov       [rbp+0FFF8],eax
M01_L04:
       mov       ecx,[rbp+0FFF8]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L03
       mov       eax,[rbp+0FFFC]
       add       rsp,30
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 222
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualList()
; 			var result = base.GetPersonProperArray(Core.Tristate.False).AreEqual(base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFF0],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       jne       short M01_L00
       mov       rcx,[rbp+20]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       je        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L01:
       mov       rax,[rbp+18]
       mov       eax,[rax+8]
       mov       rcx,[rbp+20]
       cmp       eax,[rcx+8]
       je        short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L02:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFF8],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFF8]
       cmp       edx,[rcx+8]
       jae       short M01_L05
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFF0],rcx
       mov       rcx,[rbp+0FFF0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFF8]
       cmp       eax,[rdx+8]
       jae       short M01_L05
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFF0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFF8]
       add       eax,1
       jo        short M01_L06
       mov       [rbp+0FFF8],eax
M01_L04:
       mov       ecx,[rbp+0FFF8]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L03
       mov       eax,[rbp+0FFFC]
       add       rsp,30
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 222
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AreEqualList()
; 			var result = base.GetPersonProperArray(Core.Tristate.False).AreEqual(base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFF0],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       jne       short M01_L00
       mov       rcx,[rbp+20]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       je        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L01:
       mov       rax,[rbp+18]
       mov       eax,[rax+8]
       mov       rcx,[rbp+20]
       cmp       eax,[rcx+8]
       je        short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L02:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFF8],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFF8]
       cmp       edx,[rcx+8]
       jae       short M01_L05
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFF0],rcx
       mov       rcx,[rbp+0FFF0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFF8]
       cmp       eax,[rdx+8]
       jae       short M01_L05
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFF0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFF8]
       add       eax,1
       jo        short M01_L06
       mov       [rbp+0FFF8],eax
M01_L04:
       mov       ecx,[rbp+0FFF8]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L03
       mov       eax,[rbp+0FFFC]
       add       rsp,30
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 222
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ClearNulls()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ClearNulls(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 127
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
       mov       rax,2853D863020
       mov       rbx,[rax]
       mov       rax,2853D8659D0
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
       mov       rdx,7FFAAF300570
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF5039D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L04
M02_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L05
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       jmp       short M02_L07
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF503F30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF503B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
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
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       jne       short M04_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       jne       near ptr M04_L10
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF4C2008
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L02:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M04_L09
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF4C2008
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M04_L05
       jmp       short M04_L06
M04_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4C2558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        short M04_L11
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ListExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ClearNulls>b__4_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M04_L07
       jmp       short M04_L08
M04_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAF4C2008
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L08:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
M04_L09:
       mov       rcx,rdi
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
M04_L10:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L11:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 318
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ClearNulls()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ClearNulls(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 127
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
       mov       rax,1AB4D2A3020
       mov       rbx,[rax]
       mov       rax,1AB6D2A15C8
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
       mov       rdx,7FFAAF2D0570
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4D3A38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L04
M02_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L05
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       jmp       short M02_L07
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4D3F98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4D3B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
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
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       jne       short M04_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       jne       near ptr M04_L10
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF492070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L02:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M04_L09
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF492070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M04_L05
       jmp       short M04_L06
M04_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4925C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        short M04_L11
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ListExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ClearNulls>b__4_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M04_L07
       jmp       short M04_L08
M04_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAF492070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L08:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
M04_L09:
       mov       rcx,rdi
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
M04_L10:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L11:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 318
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ClearNulls()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ClearNulls(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 127
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
       mov       rax,295AD613020
       mov       rbx,[rax]
       mov       rax,295AD621E00
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
       mov       rdx,7FFAAF2E0570
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E1D10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L04
M02_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L05
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       jmp       short M02_L07
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E2270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E1E70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
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
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       jne       short M04_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       jne       near ptr M04_L10
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A2070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L02:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M04_L09
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A2070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M04_L05
       jmp       short M04_L06
M04_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A25C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        short M04_L11
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ListExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ClearNulls>b__4_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M04_L07
       jmp       short M04_L08
M04_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A2070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L08:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
M04_L09:
       mov       rcx,rdi
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
M04_L10:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L11:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 318
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ClearNulls()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ClearNulls(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 127
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
       mov       rax,21978203020
       mov       rbx,[rax]
       mov       rax,21978211E00
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
       mov       rdx,7FFAAF2E0570
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E3E18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L04
M02_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L05
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       jmp       short M02_L07
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E4378
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E3F78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
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
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       jne       short M04_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       jne       near ptr M04_L10
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A2070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L02:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M04_L09
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A2070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M04_L05
       jmp       short M04_L06
M04_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A25C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        short M04_L11
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ListExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ClearNulls>b__4_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M04_L07
       jmp       short M04_L08
M04_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A2070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L08:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
M04_L09:
       mov       rcx,rdi
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
M04_L10:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L11:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 318
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ClearNulls()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ClearNulls(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 127
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
       mov       rax,231B50E3020
       mov       rbx,[rax]
       mov       rax,231B50F1E00
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
       mov       rdx,7FFAAF2E0570
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E3DF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L04
M02_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L05
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       jmp       short M02_L07
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E4350
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E3F50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
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
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       jne       short M04_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       jne       near ptr M04_L10
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A2070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L02:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M04_L09
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A2070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M04_L05
       jmp       short M04_L06
M04_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A25C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        short M04_L11
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ListExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ClearNulls>b__4_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M04_L07
       jmp       short M04_L08
M04_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A2070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L08:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
M04_L09:
       mov       rcx,rdi
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
M04_L10:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L11:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 318
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ClearNulls()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ClearNulls(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 127
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
       mov       rax,21FFE083020
       mov       rbx,[rax]
       mov       rax,21FFE091E00
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
       mov       rdx,7FFAAF2F0570
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F1D10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L04
M02_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L05
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       jmp       short M02_L07
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F2270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F1E70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
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
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       jne       short M04_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       jne       near ptr M04_L10
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF4B2008
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L02:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M04_L09
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF4B2008
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M04_L05
       jmp       short M04_L06
M04_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4B2558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        short M04_L11
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ListExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ClearNulls>b__4_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M04_L07
       jmp       short M04_L08
M04_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAF4B2008
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L08:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
M04_L09:
       mov       rcx,rdi
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
M04_L10:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L11:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 318
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ClearNulls()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ClearNulls(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 127
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
       mov       rax,23F4F091028
       mov       rbx,[rax]
       mov       rax,23F6F0935C0
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
       mov       rdx,7FFAAF2E0570
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E4FC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L04
M02_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L05
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       jmp       short M02_L07
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E5520
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E5120
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
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
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       jne       short M04_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       jne       near ptr M04_L10
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A2088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L02:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M04_L09
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A2088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M04_L05
       jmp       short M04_L06
M04_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A25D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        short M04_L11
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ListExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ClearNulls>b__4_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M04_L07
       jmp       short M04_L08
M04_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A2088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L08:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
M04_L09:
       mov       rcx,rdi
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
M04_L10:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L11:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 318
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ClearNulls()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ClearNulls(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 127
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
       mov       rax,1AA92AC3020
       mov       rbx,[rax]
       mov       rax,1AAB2AC15C8
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
       mov       rdx,7FFAAF2E0570
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4EF0C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L04
M02_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L05
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       jmp       short M02_L07
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4EF628
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4EF228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
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
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ClearNulls[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       jne       short M04_L00
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       jne       near ptr M04_L10
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF4C2020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L02:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M04_L09
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF4C2020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L04:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M04_L05
       jmp       short M04_L06
M04_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4C2570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        short M04_L11
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ListExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ClearNulls>b__4_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M04_L07
       jmp       short M04_L08
M04_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAF4C2020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L08:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
M04_L09:
       mov       rcx,rdi
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
M04_L10:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L11:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 318
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.CopyToList()
; 			var result = base.GetPersonProperArray(Tristate.False).ToList().CopyToCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF437388
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L04
M01_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L05
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       jmp       short M01_L07
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4378E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4374E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       jne       short M02_L00
       mov       rcx,1AA986A5180
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFAAF435BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M02_L03
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 122
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.CopyToList()
; 			var result = base.GetPersonProperArray(Tristate.False).ToList().CopyToCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF447CF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L04
M01_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L05
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       jmp       short M01_L07
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF448250
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF447E50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       jne       short M02_L00
       mov       rcx,25C74E839C0
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFAAF445BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M02_L03
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 122
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.CopyToList()
; 			var result = base.GetPersonProperArray(Tristate.False).ToList().CopyToCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF447388
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L04
M01_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L05
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       jmp       short M01_L07
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4478E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4474E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       jne       short M02_L00
       mov       rcx,1AA87732970
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFAAF445BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M02_L03
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 122
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.CopyToList()
; 			var result = base.GetPersonProperArray(Tristate.False).ToList().CopyToCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF437388
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L04
M01_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L05
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       jmp       short M01_L07
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4378E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4374E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       jne       short M02_L00
       mov       rcx,29566AB1958
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFAAF435BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M02_L03
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 122
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.CopyToList()
; 			var result = base.GetPersonProperArray(Tristate.False).ToList().CopyToCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF457388
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L04
M01_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L05
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       jmp       short M01_L07
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4578E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4574E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       jne       short M02_L00
       mov       rcx,240974B4968
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFAAF455BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M02_L03
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 122
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.CopyToList()
; 			var result = base.GetPersonProperArray(Tristate.False).ToList().CopyToCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF447340
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L04
M01_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L05
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       jmp       short M01_L07
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4478A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4474A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       jne       short M02_L00
       mov       rcx,1C2970D29A8
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFAAF445BA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M02_L03
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 122
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.CopyToList()
; 			var result = base.GetPersonProperArray(Tristate.False).ToList().CopyToCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF457340
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L04
M01_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L05
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       jmp       short M01_L07
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4578A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4574A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       jne       short M02_L00
       mov       rcx,1E2E6572170
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFAAF455BA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M02_L03
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 122
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.CopyToList()
; 			var result = base.GetPersonProperArray(Tristate.False).ToList().CopyToCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF46F328
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L04
M01_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L05
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       jmp       short M01_L07
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF46F888
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF46F488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       jne       short M02_L00
       mov       rcx,289C03419C8
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFAAF4696D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M02_L03
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 122
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeList()
; 			var result = base.GetPersonProperArray(Tristate.False).GetHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+110]
       cmp       [rcx],ecx
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
**Extern method**
System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeList()
; 			var result = base.GetPersonProperArray(Tristate.False).GetHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+110]
       cmp       [rcx],ecx
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
**Extern method**
System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeList()
; 			var result = base.GetPersonProperArray(Tristate.False).GetHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+110]
       cmp       [rcx],ecx
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
**Extern method**
System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeList()
; 			var result = base.GetPersonProperArray(Tristate.False).GetHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+110]
       cmp       [rcx],ecx
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
**Extern method**
System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeList()
; 			var result = base.GetPersonProperArray(Tristate.False).GetHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+110]
       cmp       [rcx],ecx
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
**Extern method**
System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeList()
; 			var result = base.GetPersonProperArray(Tristate.False).GetHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+110]
       cmp       [rcx],ecx
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
**Extern method**
System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeList()
; 			var result = base.GetPersonProperArray(Tristate.False).GetHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+110]
       cmp       [rcx],ecx
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
**Extern method**
System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ListHashCodeList()
; 			var result = base.GetPersonProperArray(Tristate.False).GetHashCode();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+110]
       cmp       [rcx],ecx
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
**Extern method**
System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems01()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,[rsi+20]
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
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
       mov       rax,2DF30F43020
       mov       rbx,[rax]
       mov       rax,2DF30F51E00
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
       mov       rdx,7FFAAF2F0570
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F2ED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L04
M02_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L05
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       jmp       short M02_L07
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F3438
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F3038
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       [rbp+0FFE8],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M03_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rdx,7FFAAF4F4148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp+0FFE0],rsi
M03_L02:
       mov       rcx,rsi
       mov       r11,7FFAAEE206F8
       call      qword ptr [7FFAAF4006F8]
       test      eax,eax
       je        short M03_L04
       add       rdi,1
       jo        short M03_L03
       jmp       short M03_L02
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L04:
       mov       rcx,rsi
       mov       r11,7FFAAEE20700
       call      qword ptr [7FFAAF400700]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M03_L06
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFAAEE20700
       call      qword ptr [7FFAAF400700]
M03_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems01()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,[rsi+20]
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
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
       mov       rax,17CF2953020
       mov       rbx,[rax]
       mov       rax,17CF2961E00
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
       mov       rdx,7FFAAF2F0570
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F2F10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L04
M02_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L05
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       jmp       short M02_L07
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F3470
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F3070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       [rbp+0FFE8],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M03_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rdx,7FFAAF4F4180
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp+0FFE0],rsi
M03_L02:
       mov       rcx,rsi
       mov       r11,7FFAAEE206F8
       call      qword ptr [7FFAAF4006F8]
       test      eax,eax
       je        short M03_L04
       add       rdi,1
       jo        short M03_L03
       jmp       short M03_L02
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L04:
       mov       rcx,rsi
       mov       r11,7FFAAEE20700
       call      qword ptr [7FFAAF400700]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M03_L06
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFAAEE20700
       call      qword ptr [7FFAAF400700]
M03_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems01()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,[rsi+20]
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
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
       mov       rax,174EA373020
       mov       rbx,[rax]
       mov       rax,174EA381E00
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
       mov       rdx,7FFAAF2F0570
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F1188
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L04
M02_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L05
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       jmp       short M02_L07
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F16E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F12E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       [rbp+0FFE8],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M03_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rdx,7FFAAF4F23F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp+0FFE0],rsi
M03_L02:
       mov       rcx,rsi
       mov       r11,7FFAAEE20710
       call      qword ptr [7FFAAF400710]
       test      eax,eax
       je        short M03_L04
       add       rdi,1
       jo        short M03_L03
       jmp       short M03_L02
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L04:
       mov       rcx,rsi
       mov       r11,7FFAAEE20718
       call      qword ptr [7FFAAF400718]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M03_L06
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFAAEE20718
       call      qword ptr [7FFAAF400718]
M03_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems01()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,[rsi+20]
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
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
       mov       rax,1CFFEB51028
       mov       rbx,[rax]
       mov       rax,1CFFEB5FE08
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
       mov       rdx,7FFAAF2E0570
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E11E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L04
M02_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L05
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       jmp       short M02_L07
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E1748
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E1348
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       [rbp+0FFE8],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M03_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rdx,7FFAAF4E2458
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp+0FFE0],rsi
M03_L02:
       mov       rcx,rsi
       mov       r11,7FFAAEE10710
       call      qword ptr [7FFAAF3F0710]
       test      eax,eax
       je        short M03_L04
       add       rdi,1
       jo        short M03_L03
       jmp       short M03_L02
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L04:
       mov       rcx,rsi
       mov       r11,7FFAAEE10718
       call      qword ptr [7FFAAF3F0718]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M03_L06
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFAAEE10718
       call      qword ptr [7FFAAF3F0718]
M03_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems01()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,[rsi+20]
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
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
       mov       rax,21682E11028
       mov       rbx,[rax]
       mov       rax,21682E139D8
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
       mov       rdx,7FFAAF2E0570
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E11E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L04
M02_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L05
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       jmp       short M02_L07
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E1748
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E1348
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       [rbp+0FFE8],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M03_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rdx,7FFAAF4E2458
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp+0FFE0],rsi
M03_L02:
       mov       rcx,rsi
       mov       r11,7FFAAEE10700
       call      qword ptr [7FFAAF3F0700]
       test      eax,eax
       je        short M03_L04
       add       rdi,1
       jo        short M03_L03
       jmp       short M03_L02
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L04:
       mov       rcx,rsi
       mov       r11,7FFAAEE10708
       call      qword ptr [7FFAAF3F0708]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M03_L06
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFAAEE10708
       call      qword ptr [7FFAAF3F0708]
M03_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems01()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,[rsi+20]
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
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
       mov       rax,2963EFE3020
       mov       rbx,[rax]
       mov       rax,2965EFE15C8
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
       mov       rdx,7FFAAF2F0570
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F18D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L04
M02_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L05
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       jmp       short M02_L07
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F1E38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F1A38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       [rbp+0FFE8],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M03_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rdx,7FFAAF4F2B48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp+0FFE0],rsi
M03_L02:
       mov       rcx,rsi
       mov       r11,7FFAAEE20700
       call      qword ptr [7FFAAF400700]
       test      eax,eax
       je        short M03_L04
       add       rdi,1
       jo        short M03_L03
       jmp       short M03_L02
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L04:
       mov       rcx,rsi
       mov       r11,7FFAAEE20708
       call      qword ptr [7FFAAF400708]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M03_L06
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFAAEE20708
       call      qword ptr [7FFAAF400708]
M03_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems01()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,[rsi+20]
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
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
       mov       rax,2CDF1243020
       mov       rbx,[rax]
       mov       rax,2CE1124D9F8
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
       mov       rdx,7FFAAF2E0570
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E4428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L04
M02_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L05
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       jmp       short M02_L07
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E4988
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E4588
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       [rbp+0FFE8],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M03_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rdx,7FFAAF4E5698
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp+0FFE0],rsi
M03_L02:
       mov       rcx,rsi
       mov       r11,7FFAAEE10718
       call      qword ptr [7FFAAF3F0718]
       test      eax,eax
       je        short M03_L04
       add       rdi,1
       jo        short M03_L03
       jmp       short M03_L02
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L04:
       mov       rcx,rsi
       mov       r11,7FFAAEE10720
       call      qword ptr [7FFAAF3F0720]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M03_L06
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFAAEE10720
       call      qword ptr [7FFAAF3F0720]
M03_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems01()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,[rsi+20]
       test      rax,rax
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
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
       mov       rax,23C06663020
       mov       rbx,[rax]
       mov       rax,23C06671E00
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
       mov       rdx,7FFAAF2F0570
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
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4FE8F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L04
M02_L02:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L05
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L05
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       jmp       short M02_L07
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4FEE50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF4FEA50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 217
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       [rbp+0FFE8],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M03_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rdx,7FFAAF4FF8F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp+0FFE0],rsi
M03_L02:
       mov       rcx,rsi
       mov       r11,7FFAAEE20870
       call      qword ptr [7FFAAF410870]
       test      eax,eax
       je        short M03_L04
       add       rdi,1
       jo        short M03_L03
       jmp       short M03_L02
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L04:
       mov       rcx,rsi
       mov       r11,7FFAAEE20878
       call      qword ptr [7FFAAF410878]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M03_L06
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFAAEE20878
       call      qword ptr [7FFAAF410878]
M03_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOf()
; 			var result = base.GetPersonProperArray(Tristate.False).IndexOf(base.GetPersonProperArray().Last());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rdi,rdx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       lea       r8,[rsp+20]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetLast(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r8,rax
       cmp       byte ptr [rsp+20],0
       je        short M00_L00
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 112
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
       mov       rax,1FB832D1028
       mov       rbx,[rax]
       mov       rax,1FBA32D35C0
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
       mov       rdx,7FFAAF2D0570
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
; System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       mov       [rbp+20],r8
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L18
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       r14,[rcx+8]
       cmp       r14,30
       jle       short M02_L02
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L02
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M02_L04
       cmp       r14,60
       jle       short M02_L03
       mov       r11,[rbx+60]
       test      r11,r11
       je        short M02_L03
M02_L01:
       mov       rcx,r15
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E71A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L00
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E76E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M02_L01
M02_L04:
       mov       rcx,rbx
       cmp       r14,38
       jle       near ptr M02_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M02_L13
M02_L05:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M02_L08
       mov       rcx,rbx
       cmp       r14,50
       jle       near ptr M02_L14
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L14
M02_L06:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M02_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],58
       jle       near ptr M02_L15
       mov       r11,[rdx+58]
       test      r11,r11
       je        near ptr M02_L15
M02_L07:
       lea       edx,[rbx+0FFFF]
       mov       rcx,r15
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L08:
       mov       rcx,rbx
       cmp       r14,40
       jle       near ptr M02_L16
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M02_L16
M02_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,rax
       mov       r11,7FFAAEE00760
       call      qword ptr [7FFAAF3E0760]
       test      eax,eax
       je        near ptr M02_L19
M02_L10:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L11
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E74D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE00768
       call      qword ptr [7FFAAF3E0768]
       test      eax,eax
       jne       short M02_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE00770
       call      qword ptr [7FFAAF3E0770]
       mov       rax,r15
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E7390
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E76B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L06
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E76D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E74C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L09
M02_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L18:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L19:
       mov       rcx,rsp
       call      M02_L20
       jmp       short M02_L17
M02_L20:
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
       je        short M02_L21
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE00770
       call      qword ptr [7FFAAF3E0770]
M02_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 709
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
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
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M03_L00
       mov       rcx,[rbp+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4917A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r8,1FB832D1028
       mov       r8,[r8]
       mov       r9,1FB832E11B0
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,1FB832D1028
       mov       r14,[rax]
       mov       rax,1FB832E1458
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       cmp       qword ptr [rbp+20],0
       je        short M03_L03
       mov       rcx,[rbp+20]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF491970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       r14,rax
       cmp       qword ptr [rbp+28],0
       je        short M03_L05
       mov       rcx,[rbp+28]
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF491A10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L06:
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9,r14
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 271
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOf()
; 			var result = base.GetPersonProperArray(Tristate.False).IndexOf(base.GetPersonProperArray().Last());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rdi,rdx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       lea       r8,[rsp+20]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetLast(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r8,rax
       cmp       byte ptr [rsp+20],0
       je        short M00_L00
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 112
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
       mov       rax,19B28993020
       mov       rbx,[rax]
       mov       rax,19B289A1E00
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
       mov       rdx,7FFAAF2F0570
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
; System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       mov       [rbp+20],r8
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L18
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       r14,[rcx+8]
       cmp       r14,30
       jle       short M02_L02
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L02
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M02_L04
       cmp       r14,60
       jle       short M02_L03
       mov       r11,[rbx+60]
       test      r11,r11
       je        short M02_L03
M02_L01:
       mov       rcx,r15
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF504F28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L00
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF505470
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M02_L01
M02_L04:
       mov       rcx,rbx
       cmp       r14,38
       jle       near ptr M02_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M02_L13
M02_L05:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M02_L08
       mov       rcx,rbx
       cmp       r14,50
       jle       near ptr M02_L14
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L14
M02_L06:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M02_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],58
       jle       near ptr M02_L15
       mov       r11,[rdx+58]
       test      r11,r11
       je        near ptr M02_L15
M02_L07:
       lea       edx,[rbx+0FFFF]
       mov       rcx,r15
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L08:
       mov       rcx,rbx
       cmp       r14,40
       jle       near ptr M02_L16
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M02_L16
M02_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,rax
       mov       r11,7FFAAEE20760
       call      qword ptr [7FFAAF400760]
       test      eax,eax
       je        near ptr M02_L19
M02_L10:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L11
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF505260
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE20768
       call      qword ptr [7FFAAF400768]
       test      eax,eax
       jne       short M02_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE20770
       call      qword ptr [7FFAAF400770]
       mov       rax,r15
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAF505118
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFAAF505440
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L06
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAF505458
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFAAF505248
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L09
M02_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L18:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L19:
       mov       rcx,rsp
       call      M02_L20
       jmp       short M02_L17
M02_L20:
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
       je        short M02_L21
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE20770
       call      qword ptr [7FFAAF400770]
M02_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 709
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
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
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M03_L00
       mov       rcx,[rbp+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4B1810
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r8,19B28993020
       mov       r8,[r8]
       mov       r9,19B08992970
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,19B28993020
       mov       r14,[rax]
       mov       rax,19B08992C18
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       cmp       qword ptr [rbp+20],0
       je        short M03_L03
       mov       rcx,[rbp+20]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF4B19D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       r14,rax
       cmp       qword ptr [rbp+28],0
       je        short M03_L05
       mov       rcx,[rbp+28]
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4B1A78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L06:
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9,r14
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 271
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOf()
; 			var result = base.GetPersonProperArray(Tristate.False).IndexOf(base.GetPersonProperArray().Last());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rdi,rdx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       lea       r8,[rsp+20]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetLast(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r8,rax
       cmp       byte ptr [rsp+20],0
       je        short M00_L00
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 112
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
       mov       rax,25A897C3020
       mov       rbx,[rax]
       mov       rax,25AA97C15C8
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
       mov       rdx,7FFAAF2E0570
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
; System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       mov       [rbp+20],r8
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L18
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       r14,[rcx+8]
       cmp       r14,30
       jle       short M02_L02
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L02
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M02_L04
       cmp       r14,60
       jle       short M02_L03
       mov       r11,[rbx+60]
       test      r11,r11
       je        short M02_L03
M02_L01:
       mov       rcx,r15
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E76E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L00
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E7C28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M02_L01
M02_L04:
       mov       rcx,rbx
       cmp       r14,38
       jle       near ptr M02_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M02_L13
M02_L05:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M02_L08
       mov       rcx,rbx
       cmp       r14,50
       jle       near ptr M02_L14
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L14
M02_L06:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M02_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],58
       jle       near ptr M02_L15
       mov       r11,[rdx+58]
       test      r11,r11
       je        near ptr M02_L15
M02_L07:
       lea       edx,[rbx+0FFFF]
       mov       rcx,r15
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L08:
       mov       rcx,rbx
       cmp       r14,40
       jle       near ptr M02_L16
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M02_L16
M02_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,rax
       mov       r11,7FFAAEE10778
       call      qword ptr [7FFAAF3F0778]
       test      eax,eax
       je        near ptr M02_L19
M02_L10:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L11
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E7A18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE10780
       call      qword ptr [7FFAAF3F0780]
       test      eax,eax
       jne       short M02_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE10788
       call      qword ptr [7FFAAF3F0788]
       mov       rax,r15
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E78D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E7BF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L06
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E7C10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E7A00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L09
M02_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L18:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L19:
       mov       rcx,rsp
       call      M02_L20
       jmp       short M02_L17
M02_L20:
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
       je        short M02_L21
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE10788
       call      qword ptr [7FFAAF3F0788]
M02_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 709
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
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
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M03_L00
       mov       rcx,[rbp+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1810
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r8,25A897C3020
       mov       r8,[r8]
       mov       r9,25AA97C3188
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,25A897C3020
       mov       r14,[rax]
       mov       rax,25AA97C3430
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       cmp       qword ptr [rbp+20],0
       je        short M03_L03
       mov       rcx,[rbp+20]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A19D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       r14,rax
       cmp       qword ptr [rbp+28],0
       je        short M03_L05
       mov       rcx,[rbp+28]
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1A78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L06:
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9,r14
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 271
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOf()
; 			var result = base.GetPersonProperArray(Tristate.False).IndexOf(base.GetPersonProperArray().Last());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rdi,rdx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       lea       r8,[rsp+20]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetLast(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r8,rax
       cmp       byte ptr [rsp+20],0
       je        short M00_L00
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 112
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
       mov       rax,27639D03020
       mov       rbx,[rax]
       mov       rax,27649D015C8
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
       mov       rdx,7FFAAF2E0570
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
; System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       mov       [rbp+20],r8
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L18
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       r14,[rcx+8]
       cmp       r14,30
       jle       short M02_L02
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L02
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M02_L04
       cmp       r14,60
       jle       short M02_L03
       mov       r11,[rbx+60]
       test      r11,r11
       je        short M02_L03
M02_L01:
       mov       rcx,r15
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F76F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L00
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F7C40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M02_L01
M02_L04:
       mov       rcx,rbx
       cmp       r14,38
       jle       near ptr M02_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M02_L13
M02_L05:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M02_L08
       mov       rcx,rbx
       cmp       r14,50
       jle       near ptr M02_L14
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L14
M02_L06:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M02_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],58
       jle       near ptr M02_L15
       mov       r11,[rdx+58]
       test      r11,r11
       je        near ptr M02_L15
M02_L07:
       lea       edx,[rbx+0FFFF]
       mov       rcx,r15
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L08:
       mov       rcx,rbx
       cmp       r14,40
       jle       near ptr M02_L16
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M02_L16
M02_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,rax
       mov       r11,7FFAAEE10778
       call      qword ptr [7FFAAF3F0778]
       test      eax,eax
       je        near ptr M02_L19
M02_L10:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L11
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F7A30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE10780
       call      qword ptr [7FFAAF3F0780]
       test      eax,eax
       jne       short M02_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE10788
       call      qword ptr [7FFAAF3F0788]
       mov       rax,r15
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F78E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F7C10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L06
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F7C28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F7A18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L09
M02_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L18:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L19:
       mov       rcx,rsp
       call      M02_L20
       jmp       short M02_L17
M02_L20:
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
       je        short M02_L21
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE10788
       call      qword ptr [7FFAAF3F0788]
M02_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 709
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
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
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M03_L00
       mov       rcx,[rbp+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1810
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r8,27639D03020
       mov       r8,[r8]
       mov       r9,27639D12190
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,27639D03020
       mov       r14,[rax]
       mov       rax,27639D12438
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       cmp       qword ptr [rbp+20],0
       je        short M03_L03
       mov       rcx,[rbp+20]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A19D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       r14,rax
       cmp       qword ptr [rbp+28],0
       je        short M03_L05
       mov       rcx,[rbp+28]
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1A78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L06:
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9,r14
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 271
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOf()
; 			var result = base.GetPersonProperArray(Tristate.False).IndexOf(base.GetPersonProperArray().Last());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rdi,rdx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       lea       r8,[rsp+20]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetLast(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r8,rax
       cmp       byte ptr [rsp+20],0
       je        short M00_L00
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 112
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
       mov       rax,1B7BB9C3020
       mov       rbx,[rax]
       mov       rax,1B7DB9C15C8
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
       mov       rdx,7FFAAF2D0570
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
; System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       mov       [rbp+20],r8
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L18
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       r14,[rcx+8]
       cmp       r14,30
       jle       short M02_L02
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L02
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M02_L04
       cmp       r14,60
       jle       short M02_L03
       mov       r11,[rbx+60]
       test      r11,r11
       je        short M02_L03
M02_L01:
       mov       rcx,r15
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E5580
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L00
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E5AC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M02_L01
M02_L04:
       mov       rcx,rbx
       cmp       r14,38
       jle       near ptr M02_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M02_L13
M02_L05:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M02_L08
       mov       rcx,rbx
       cmp       r14,50
       jle       near ptr M02_L14
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L14
M02_L06:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M02_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],58
       jle       near ptr M02_L15
       mov       r11,[rdx+58]
       test      r11,r11
       je        near ptr M02_L15
M02_L07:
       lea       edx,[rbx+0FFFF]
       mov       rcx,r15
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L08:
       mov       rcx,rbx
       cmp       r14,40
       jle       near ptr M02_L16
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M02_L16
M02_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,rax
       mov       r11,7FFAAEE00778
       call      qword ptr [7FFAAF3E0778]
       test      eax,eax
       je        near ptr M02_L19
M02_L10:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L11
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E58B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE00780
       call      qword ptr [7FFAAF3E0780]
       test      eax,eax
       jne       short M02_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE00788
       call      qword ptr [7FFAAF3E0788]
       mov       rax,r15
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E5770
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E5A98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L06
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E5AB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E58A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L09
M02_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L18:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L19:
       mov       rcx,rsp
       call      M02_L20
       jmp       short M02_L17
M02_L20:
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
       je        short M02_L21
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE00788
       call      qword ptr [7FFAAF3E0788]
M02_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 709
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
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
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M03_L00
       mov       rcx,[rbp+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF491810
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r8,1B7BB9C3020
       mov       r8,[r8]
       mov       r9,1B7EB9CDD88
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,1B7BB9C3020
       mov       r14,[rax]
       mov       rax,1B7EB9CE030
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       cmp       qword ptr [rbp+20],0
       je        short M03_L03
       mov       rcx,[rbp+20]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF4919D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       r14,rax
       cmp       qword ptr [rbp+28],0
       je        short M03_L05
       mov       rcx,[rbp+28]
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF491A78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L06:
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9,r14
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 271
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOf()
; 			var result = base.GetPersonProperArray(Tristate.False).IndexOf(base.GetPersonProperArray().Last());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rdi,rdx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       lea       r8,[rsp+20]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetLast(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r8,rax
       cmp       byte ptr [rsp+20],0
       je        short M00_L00
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 112
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
       mov       rax,1CC50B03020
       mov       rbx,[rax]
       mov       rax,1CC50B11E00
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
       mov       rdx,7FFAAF2E0570
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
; System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       mov       [rbp+20],r8
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L18
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       r14,[rcx+8]
       cmp       r14,30
       jle       short M02_L02
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L02
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M02_L04
       cmp       r14,60
       jle       short M02_L03
       mov       r11,[rbx+60]
       test      r11,r11
       je        short M02_L03
M02_L01:
       mov       rcx,r15
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F7740
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L00
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F7C88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M02_L01
M02_L04:
       mov       rcx,rbx
       cmp       r14,38
       jle       near ptr M02_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M02_L13
M02_L05:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M02_L08
       mov       rcx,rbx
       cmp       r14,50
       jle       near ptr M02_L14
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L14
M02_L06:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M02_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],58
       jle       near ptr M02_L15
       mov       r11,[rdx+58]
       test      r11,r11
       je        near ptr M02_L15
M02_L07:
       lea       edx,[rbx+0FFFF]
       mov       rcx,r15
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L08:
       mov       rcx,rbx
       cmp       r14,40
       jle       near ptr M02_L16
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M02_L16
M02_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,rax
       mov       r11,7FFAAEE10778
       call      qword ptr [7FFAAF3F0778]
       test      eax,eax
       je        near ptr M02_L19
M02_L10:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L11
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F7A78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE10780
       call      qword ptr [7FFAAF3F0780]
       test      eax,eax
       jne       short M02_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE10788
       call      qword ptr [7FFAAF3F0788]
       mov       rax,r15
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F7930
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F7C58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L06
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F7C70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFAAF4F7A60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L09
M02_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L18:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L19:
       mov       rcx,rsp
       call      M02_L20
       jmp       short M02_L17
M02_L20:
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
       je        short M02_L21
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE10788
       call      qword ptr [7FFAAF3F0788]
M02_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 709
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
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
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M03_L00
       mov       rcx,[rbp+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1810
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r8,1CC50B03020
       mov       r8,[r8]
       mov       r9,1CC50B139C0
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,1CC50B03020
       mov       r14,[rax]
       mov       rax,1CC50B13C68
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       cmp       qword ptr [rbp+20],0
       je        short M03_L03
       mov       rcx,[rbp+20]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A19D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       r14,rax
       cmp       qword ptr [rbp+28],0
       je        short M03_L05
       mov       rcx,[rbp+28]
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1A78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L06:
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9,r14
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 271
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOf()
; 			var result = base.GetPersonProperArray(Tristate.False).IndexOf(base.GetPersonProperArray().Last());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rdi,rdx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       lea       r8,[rsp+20]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetLast(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r8,rax
       cmp       byte ptr [rsp+20],0
       je        short M00_L00
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 112
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
       mov       rax,1431F9A3020
       mov       rbx,[rax]
       mov       rax,1433F9A15C8
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
       mov       rdx,7FFAAF2F0570
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
; System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       mov       [rbp+20],r8
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L18
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       r14,[rcx+8]
       cmp       r14,30
       jle       short M02_L02
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L02
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M02_L04
       cmp       r14,60
       jle       short M02_L03
       mov       r11,[rbx+60]
       test      r11,r11
       je        short M02_L03
M02_L01:
       mov       rcx,r15
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF505978
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L00
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF505EC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M02_L01
M02_L04:
       mov       rcx,rbx
       cmp       r14,38
       jle       near ptr M02_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M02_L13
M02_L05:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M02_L08
       mov       rcx,rbx
       cmp       r14,50
       jle       near ptr M02_L14
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L14
M02_L06:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M02_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],58
       jle       near ptr M02_L15
       mov       r11,[rdx+58]
       test      r11,r11
       je        near ptr M02_L15
M02_L07:
       lea       edx,[rbx+0FFFF]
       mov       rcx,r15
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L08:
       mov       rcx,rbx
       cmp       r14,40
       jle       near ptr M02_L16
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M02_L16
M02_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,rax
       mov       r11,7FFAAEE20770
       call      qword ptr [7FFAAF400770]
       test      eax,eax
       je        near ptr M02_L19
M02_L10:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L11
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF505CB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE20778
       call      qword ptr [7FFAAF400778]
       test      eax,eax
       jne       short M02_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE20780
       call      qword ptr [7FFAAF400780]
       mov       rax,r15
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAF505B68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFAAF505E90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L06
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAF505EA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFAAF505C98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L09
M02_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L18:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L19:
       mov       rcx,rsp
       call      M02_L20
       jmp       short M02_L17
M02_L20:
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
       je        short M02_L21
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE20780
       call      qword ptr [7FFAAF400780]
M02_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 709
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
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
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M03_L00
       mov       rcx,[rbp+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4B17C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r8,1431F9A3020
       mov       r8,[r8]
       mov       r9,1431F9A5D60
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,1431F9A3020
       mov       r14,[rax]
       mov       rax,1431F9A6008
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       cmp       qword ptr [rbp+20],0
       je        short M03_L03
       mov       rcx,[rbp+20]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF4B1988
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       r14,rax
       cmp       qword ptr [rbp+28],0
       je        short M03_L05
       mov       rcx,[rbp+28]
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4B1A28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L06:
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9,r14
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 271
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOf()
; 			var result = base.GetPersonProperArray(Tristate.False).IndexOf(base.GetPersonProperArray().Last());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rdi,rdx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       lea       r8,[rsp+20]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetLast(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r8,rax
       cmp       byte ptr [rsp+20],0
       je        short M00_L00
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 112
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
       mov       rax,22DBD0E3020
       mov       rbx,[rax]
       mov       rax,22DBD0E59D0
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
       mov       rdx,7FFAAF300570
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
; System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       mov       [rbp+20],r8
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L18
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       r14,[rcx+8]
       cmp       r14,30
       jle       short M02_L02
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L02
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M02_L04
       cmp       r14,60
       jle       short M02_L03
       mov       r11,[rbx+60]
       test      r11,r11
       je        short M02_L03
M02_L01:
       mov       rcx,r15
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF522C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L00
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF523148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M02_L01
M02_L04:
       mov       rcx,rbx
       cmp       r14,38
       jle       near ptr M02_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M02_L13
M02_L05:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M02_L08
       mov       rcx,rbx
       cmp       r14,50
       jle       near ptr M02_L14
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L14
M02_L06:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M02_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],58
       jle       near ptr M02_L15
       mov       r11,[rdx+58]
       test      r11,r11
       je        near ptr M02_L15
M02_L07:
       lea       edx,[rbx+0FFFF]
       mov       rcx,r15
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L08:
       mov       rcx,rbx
       cmp       r14,40
       jle       near ptr M02_L16
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M02_L16
M02_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,rax
       mov       r11,7FFAAEE308E8
       call      qword ptr [7FFAAF4208E8]
       test      eax,eax
       je        near ptr M02_L19
M02_L10:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L11
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF522F38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE308F0
       call      qword ptr [7FFAAF4208F0]
       test      eax,eax
       jne       short M02_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE308F8
       call      qword ptr [7FFAAF4208F8]
       mov       rax,r15
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAF522DF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFAAF523118
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L06
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAF523130
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFAAF522F20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L09
M02_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L18:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L19:
       mov       rcx,rsp
       call      M02_L20
       jmp       short M02_L17
M02_L20:
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
       je        short M02_L21
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE308F8
       call      qword ptr [7FFAAF4208F8]
M02_L21:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 709
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
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
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M03_L00
       mov       rcx,[rbp+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E1828
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r8,22DBD0E3020
       mov       r8,[r8]
       mov       r9,22D9D0EEDA0
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,22DBD0E3020
       mov       r14,[rax]
       mov       rax,22D9D0EF048
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       cmp       qword ptr [rbp+20],0
       je        short M03_L03
       mov       rcx,[rbp+20]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E19F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       r14,rax
       cmp       qword ptr [rbp+28],0
       je        short M03_L05
       mov       rcx,[rbp+28]
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4E1A90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L06:
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9,r14
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 271
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOfComparer()
; 			var comparer = new PersonProperComparer();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.GetPersonProperArray(Tristate.False).IndexOf(base.GetPersonProperArray(Tristate.False, CollectionSize.Half).Last(), comparer);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.PersonProperComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+110]
       mov       rdx,[rsi+118]
       lea       r8,[rsp+28]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetLast(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r8,rax
       cmp       byte ptr [rsp+28],0
       je        short M00_L00
       mov       r9,rdi
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf(System.Collections.Generic.IEnumerable`1<!!0>, !!0, System.Collections.Generic.IEqualityComparer`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 121
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       mov       [rbp+20],r8
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L18
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       r14,[rcx+8]
       cmp       r14,30
       jle       short M01_L02
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       cmp       r14,60
       jle       short M01_L03
       mov       r11,[rbx+60]
       test      r11,r11
       je        short M01_L03
M01_L01:
       mov       rcx,r15
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF44B458
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF44B9A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L01
M01_L04:
       mov       rcx,rbx
       cmp       r14,38
       jle       near ptr M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L13
M01_L05:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L08
       mov       rcx,rbx
       cmp       r14,50
       jle       near ptr M01_L14
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M01_L14
M01_L06:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M01_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],58
       jle       near ptr M01_L15
       mov       r11,[rdx+58]
       test      r11,r11
       je        near ptr M01_L15
M01_L07:
       lea       edx,[rbx+0FFFF]
       mov       rcx,r15
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L08:
       mov       rcx,rbx
       cmp       r14,40
       jle       near ptr M01_L16
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L16
M01_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,rax
       mov       r11,7FFAAEE106E8
       call      qword ptr [7FFAAF3D06E8]
       test      eax,eax
       je        near ptr M01_L19
M01_L10:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L11
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF44B790
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE106F0
       call      qword ptr [7FFAAF3D06F0]
       test      eax,eax
       jne       short M01_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE106F8
       call      qword ptr [7FFAAF3D06F8]
       mov       rax,r15
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAF44B648
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFAAF44B970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAF44B988
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFAAF44B778
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L09
M01_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L19:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L17
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
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L21
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE106F8
       call      qword ptr [7FFAAF3D06F8]
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
; Total bytes of code 709
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       mov       rdx,7FFAAF445AC8
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
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF445C68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r8,15C76FD1028
       mov       rbx,[r8]
       mov       r8,rbx
       mov       r9,15C66FD3950
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rbp,[r15+10]
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
       mov       r14,rbx
       mov       rax,15C66FD3BE8
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L04:
       lea       rcx,[r15+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[r15+8]
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       mov       rax,15C66FD3BF0
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L05:
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF445F98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass18_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
       mov       [rbx+18],rcx
       mov       rbp,[rsi+10]
       mov       rcx,rbp
       cmp       qword ptr [rcx+8],38
       jle       short M02_L08
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFAAF446100
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`3<System.__Canon,Int32,Int32>)
       mov       rdi,rax
       cmp       qword ptr [rbp+8],40
       jle       short M02_L10
       mov       rcx,[rbp+40]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFAAF446460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M02_L16
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L12
       mov       rbx,[rcx+40]
       test      rbx,rbx
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFAAF446460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M02_L13:
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       test      rdx,rdx
       je        short M02_L17
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__18`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__18_1(Int32)
       mov       [rbp+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L14
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFAAF446460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L15:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
M02_L16:
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,Boolean>, Int32)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L17:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 709
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOfComparer()
; 			var comparer = new PersonProperComparer();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.GetPersonProperArray(Tristate.False).IndexOf(base.GetPersonProperArray(Tristate.False, CollectionSize.Half).Last(), comparer);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.PersonProperComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+110]
       mov       rdx,[rsi+118]
       lea       r8,[rsp+28]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetLast(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r8,rax
       cmp       byte ptr [rsp+28],0
       je        short M00_L00
       mov       r9,rdi
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf(System.Collections.Generic.IEnumerable`1<!!0>, !!0, System.Collections.Generic.IEqualityComparer`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 121
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       mov       [rbp+20],r8
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L18
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       r14,[rcx+8]
       cmp       r14,30
       jle       short M01_L02
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       cmp       r14,60
       jle       short M01_L03
       mov       r11,[rbx+60]
       test      r11,r11
       je        short M01_L03
M01_L01:
       mov       rcx,r15
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF45B080
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF45B5C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L01
M01_L04:
       mov       rcx,rbx
       cmp       r14,38
       jle       near ptr M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L13
M01_L05:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L08
       mov       rcx,rbx
       cmp       r14,50
       jle       near ptr M01_L14
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M01_L14
M01_L06:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M01_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],58
       jle       near ptr M01_L15
       mov       r11,[rdx+58]
       test      r11,r11
       je        near ptr M01_L15
M01_L07:
       lea       edx,[rbx+0FFFF]
       mov       rcx,r15
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L08:
       mov       rcx,rbx
       cmp       r14,40
       jle       near ptr M01_L16
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L16
M01_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,rax
       mov       r11,7FFAAEE206E8
       call      qword ptr [7FFAAF3E06E8]
       test      eax,eax
       je        near ptr M01_L19
M01_L10:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L11
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF45B3B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE206F0
       call      qword ptr [7FFAAF3E06F0]
       test      eax,eax
       jne       short M01_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE206F8
       call      qword ptr [7FFAAF3E06F8]
       mov       rax,r15
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAF45B270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFAAF45B598
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAF45B5B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFAAF45B3A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L09
M01_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L19:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L17
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
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L21
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE206F8
       call      qword ptr [7FFAAF3E06F8]
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
; Total bytes of code 709
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       mov       rdx,7FFAAF455AC8
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
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF455C68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r8,1C75ECA1028
       mov       rbx,[r8]
       mov       r8,rbx
       mov       r9,1C75ECA4D80
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rbp,[r15+10]
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
       mov       r14,rbx
       mov       rax,1C75ECA5018
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L04:
       lea       rcx,[r15+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[r15+8]
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       mov       rax,1C75ECA5020
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L05:
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF455F98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass18_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
       mov       [rbx+18],rcx
       mov       rbp,[rsi+10]
       mov       rcx,rbp
       cmp       qword ptr [rcx+8],38
       jle       short M02_L08
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFAAF456100
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`3<System.__Canon,Int32,Int32>)
       mov       rdi,rax
       cmp       qword ptr [rbp+8],40
       jle       short M02_L10
       mov       rcx,[rbp+40]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFAAF456460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M02_L16
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L12
       mov       rbx,[rcx+40]
       test      rbx,rbx
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFAAF456460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M02_L13:
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       test      rdx,rdx
       je        short M02_L17
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__18`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__18_1(Int32)
       mov       [rbp+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L14
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFAAF456460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L15:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
M02_L16:
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,Boolean>, Int32)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L17:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 709
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOfComparer()
; 			var comparer = new PersonProperComparer();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.GetPersonProperArray(Tristate.False).IndexOf(base.GetPersonProperArray(Tristate.False, CollectionSize.Half).Last(), comparer);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.PersonProperComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+110]
       mov       rdx,[rsi+118]
       lea       r8,[rsp+28]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetLast(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r8,rax
       cmp       byte ptr [rsp+28],0
       je        short M00_L00
       mov       r9,rdi
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf(System.Collections.Generic.IEnumerable`1<!!0>, !!0, System.Collections.Generic.IEqualityComparer`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 121
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       mov       [rbp+20],r8
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L18
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       r14,[rcx+8]
       cmp       r14,30
       jle       short M01_L02
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       cmp       r14,60
       jle       short M01_L03
       mov       r11,[rbx+60]
       test      r11,r11
       je        short M01_L03
M01_L01:
       mov       rcx,r15
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF45B080
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF45B5C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L01
M01_L04:
       mov       rcx,rbx
       cmp       r14,38
       jle       near ptr M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L13
M01_L05:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L08
       mov       rcx,rbx
       cmp       r14,50
       jle       near ptr M01_L14
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M01_L14
M01_L06:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M01_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],58
       jle       near ptr M01_L15
       mov       r11,[rdx+58]
       test      r11,r11
       je        near ptr M01_L15
M01_L07:
       lea       edx,[rbx+0FFFF]
       mov       rcx,r15
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L08:
       mov       rcx,rbx
       cmp       r14,40
       jle       near ptr M01_L16
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L16
M01_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,rax
       mov       r11,7FFAAEE206E8
       call      qword ptr [7FFAAF3E06E8]
       test      eax,eax
       je        near ptr M01_L19
M01_L10:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L11
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF45B3B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE206F0
       call      qword ptr [7FFAAF3E06F0]
       test      eax,eax
       jne       short M01_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE206F8
       call      qword ptr [7FFAAF3E06F8]
       mov       rax,r15
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAF45B270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFAAF45B598
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAF45B5B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFAAF45B3A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L09
M01_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L19:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L17
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
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L21
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE206F8
       call      qword ptr [7FFAAF3E06F8]
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
; Total bytes of code 709
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       mov       rdx,7FFAAF455AC8
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
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF455C68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r8,1C07CC53020
       mov       rbx,[r8]
       mov       r8,rbx
       mov       r9,1C07CC57590
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rbp,[r15+10]
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
       mov       r14,rbx
       mov       rax,1C07CC57828
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L04:
       lea       rcx,[r15+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[r15+8]
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       mov       rax,1C07CC57830
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L05:
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF455F98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass18_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
       mov       [rbx+18],rcx
       mov       rbp,[rsi+10]
       mov       rcx,rbp
       cmp       qword ptr [rcx+8],38
       jle       short M02_L08
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFAAF456100
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`3<System.__Canon,Int32,Int32>)
       mov       rdi,rax
       cmp       qword ptr [rbp+8],40
       jle       short M02_L10
       mov       rcx,[rbp+40]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFAAF456460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M02_L16
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L12
       mov       rbx,[rcx+40]
       test      rbx,rbx
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFAAF456460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M02_L13:
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       test      rdx,rdx
       je        short M02_L17
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__18`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__18_1(Int32)
       mov       [rbp+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L14
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFAAF456460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L15:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
M02_L16:
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,Boolean>, Int32)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L17:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 709
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOfComparer()
; 			var comparer = new PersonProperComparer();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.GetPersonProperArray(Tristate.False).IndexOf(base.GetPersonProperArray(Tristate.False, CollectionSize.Half).Last(), comparer);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.PersonProperComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+110]
       mov       rdx,[rsi+118]
       lea       r8,[rsp+28]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetLast(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r8,rax
       cmp       byte ptr [rsp+28],0
       je        short M00_L00
       mov       r9,rdi
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf(System.Collections.Generic.IEnumerable`1<!!0>, !!0, System.Collections.Generic.IEqualityComparer`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 121
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       mov       [rbp+20],r8
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L18
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       r14,[rcx+8]
       cmp       r14,30
       jle       short M01_L02
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       cmp       r14,60
       jle       short M01_L03
       mov       r11,[rbx+60]
       test      r11,r11
       je        short M01_L03
M01_L01:
       mov       rcx,r15
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF44B080
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF44B5C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L01
M01_L04:
       mov       rcx,rbx
       cmp       r14,38
       jle       near ptr M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L13
M01_L05:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L08
       mov       rcx,rbx
       cmp       r14,50
       jle       near ptr M01_L14
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M01_L14
M01_L06:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M01_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],58
       jle       near ptr M01_L15
       mov       r11,[rdx+58]
       test      r11,r11
       je        near ptr M01_L15
M01_L07:
       lea       edx,[rbx+0FFFF]
       mov       rcx,r15
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L08:
       mov       rcx,rbx
       cmp       r14,40
       jle       near ptr M01_L16
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L16
M01_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,rax
       mov       r11,7FFAAEE106E8
       call      qword ptr [7FFAAF3D06E8]
       test      eax,eax
       je        near ptr M01_L19
M01_L10:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L11
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF44B3B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE106F0
       call      qword ptr [7FFAAF3D06F0]
       test      eax,eax
       jne       short M01_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE106F8
       call      qword ptr [7FFAAF3D06F8]
       mov       rax,r15
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAF44B270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFAAF44B598
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAF44B5B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFAAF44B3A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L09
M01_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L19:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L17
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
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L21
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE106F8
       call      qword ptr [7FFAAF3D06F8]
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
; Total bytes of code 709
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       mov       rdx,7FFAAF445AC8
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
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF445C68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r8,20DA4DD1028
       mov       rbx,[r8]
       mov       r8,rbx
       mov       r9,20DC4DD2170
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rbp,[r15+10]
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
       mov       r14,rbx
       mov       rax,20DC4DD2408
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L04:
       lea       rcx,[r15+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[r15+8]
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       mov       rax,20DC4DD2410
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L05:
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF445F98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass18_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
       mov       [rbx+18],rcx
       mov       rbp,[rsi+10]
       mov       rcx,rbp
       cmp       qword ptr [rcx+8],38
       jle       short M02_L08
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFAAF446100
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`3<System.__Canon,Int32,Int32>)
       mov       rdi,rax
       cmp       qword ptr [rbp+8],40
       jle       short M02_L10
       mov       rcx,[rbp+40]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFAAF446460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M02_L16
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L12
       mov       rbx,[rcx+40]
       test      rbx,rbx
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFAAF446460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M02_L13:
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       test      rdx,rdx
       je        short M02_L17
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__18`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__18_1(Int32)
       mov       [rbp+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L14
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFAAF446460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L15:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
M02_L16:
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,Boolean>, Int32)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L17:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 709
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOfComparer()
; 			var comparer = new PersonProperComparer();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.GetPersonProperArray(Tristate.False).IndexOf(base.GetPersonProperArray(Tristate.False, CollectionSize.Half).Last(), comparer);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.PersonProperComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+110]
       mov       rdx,[rsi+118]
       lea       r8,[rsp+28]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetLast(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r8,rax
       cmp       byte ptr [rsp+28],0
       je        short M00_L00
       mov       r9,rdi
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf(System.Collections.Generic.IEnumerable`1<!!0>, !!0, System.Collections.Generic.IEqualityComparer`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 121
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       mov       [rbp+20],r8
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L18
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       r14,[rcx+8]
       cmp       r14,30
       jle       short M01_L02
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       cmp       r14,60
       jle       short M01_L03
       mov       r11,[rbx+60]
       test      r11,r11
       je        short M01_L03
M01_L01:
       mov       rcx,r15
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF46B080
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF46B5C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L01
M01_L04:
       mov       rcx,rbx
       cmp       r14,38
       jle       near ptr M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L13
M01_L05:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L08
       mov       rcx,rbx
       cmp       r14,50
       jle       near ptr M01_L14
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M01_L14
M01_L06:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M01_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],58
       jle       near ptr M01_L15
       mov       r11,[rdx+58]
       test      r11,r11
       je        near ptr M01_L15
M01_L07:
       lea       edx,[rbx+0FFFF]
       mov       rcx,r15
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L08:
       mov       rcx,rbx
       cmp       r14,40
       jle       near ptr M01_L16
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L16
M01_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,rax
       mov       r11,7FFAAEE306E8
       call      qword ptr [7FFAAF3F06E8]
       test      eax,eax
       je        near ptr M01_L19
M01_L10:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L11
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF46B3B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE306F0
       call      qword ptr [7FFAAF3F06F0]
       test      eax,eax
       jne       short M01_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE306F8
       call      qword ptr [7FFAAF3F06F8]
       mov       rax,r15
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAF46B270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFAAF46B598
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAF46B5B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFAAF46B3A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L09
M01_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L19:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L17
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
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L21
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE306F8
       call      qword ptr [7FFAAF3F06F8]
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
; Total bytes of code 709
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       mov       rdx,7FFAAF465AC8
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
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF465C68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r8,19F66193020
       mov       rbx,[r8]
       mov       r8,rbx
       mov       r9,19F66195D60
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rbp,[r15+10]
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
       mov       r14,rbx
       mov       rax,19F66195FF8
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L04:
       lea       rcx,[r15+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[r15+8]
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       mov       rax,19F66196000
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L05:
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF465F98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass18_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
       mov       [rbx+18],rcx
       mov       rbp,[rsi+10]
       mov       rcx,rbp
       cmp       qword ptr [rcx+8],38
       jle       short M02_L08
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFAAF466100
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`3<System.__Canon,Int32,Int32>)
       mov       rdi,rax
       cmp       qword ptr [rbp+8],40
       jle       short M02_L10
       mov       rcx,[rbp+40]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFAAF466460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M02_L16
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L12
       mov       rbx,[rcx+40]
       test      rbx,rbx
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFAAF466460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M02_L13:
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       test      rdx,rdx
       je        short M02_L17
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__18`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__18_1(Int32)
       mov       [rbp+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L14
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFAAF466460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L15:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
M02_L16:
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,Boolean>, Int32)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L17:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 709
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOfComparer()
; 			var comparer = new PersonProperComparer();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.GetPersonProperArray(Tristate.False).IndexOf(base.GetPersonProperArray(Tristate.False, CollectionSize.Half).Last(), comparer);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.PersonProperComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+110]
       mov       rdx,[rsi+118]
       lea       r8,[rsp+28]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetLast(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r8,rax
       cmp       byte ptr [rsp+28],0
       je        short M00_L00
       mov       r9,rdi
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf(System.Collections.Generic.IEnumerable`1<!!0>, !!0, System.Collections.Generic.IEqualityComparer`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 121
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       mov       [rbp+20],r8
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L18
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       r14,[rcx+8]
       cmp       r14,30
       jle       short M01_L02
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       cmp       r14,60
       jle       short M01_L03
       mov       r11,[rbx+60]
       test      r11,r11
       je        short M01_L03
M01_L01:
       mov       rcx,r15
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF42AEA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF42B3E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L01
M01_L04:
       mov       rcx,rbx
       cmp       r14,38
       jle       near ptr M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L13
M01_L05:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L08
       mov       rcx,rbx
       cmp       r14,50
       jle       near ptr M01_L14
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M01_L14
M01_L06:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M01_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],58
       jle       near ptr M01_L15
       mov       r11,[rdx+58]
       test      r11,r11
       je        near ptr M01_L15
M01_L07:
       lea       edx,[rbx+0FFFF]
       mov       rcx,r15
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L08:
       mov       rcx,rbx
       cmp       r14,40
       jle       near ptr M01_L16
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L16
M01_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,rax
       mov       r11,7FFAAEDF06E0
       call      qword ptr [7FFAAF3B06E0]
       test      eax,eax
       je        near ptr M01_L19
M01_L10:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L11
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF42B1D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEDF06E8
       call      qword ptr [7FFAAF3B06E8]
       test      eax,eax
       jne       short M01_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEDF06F0
       call      qword ptr [7FFAAF3B06F0]
       mov       rax,r15
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAF42B090
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFAAF42B3B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAF42B3D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFAAF42B1C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L09
M01_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L19:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L17
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
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L21
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEDF06F0
       call      qword ptr [7FFAAF3B06F0]
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
; Total bytes of code 709
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       mov       rdx,7FFAAF425A80
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
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF425C20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r8,2B175963020
       mov       rbx,[r8]
       mov       r8,rbx
       mov       r9,2B1759739C0
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rbp,[r15+10]
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
       mov       r14,rbx
       mov       rax,2B175973C58
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L04:
       lea       rcx,[r15+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[r15+8]
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       mov       rax,2B175973C60
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L05:
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF425F50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass18_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
       mov       [rbx+18],rcx
       mov       rbp,[rsi+10]
       mov       rcx,rbp
       cmp       qword ptr [rcx+8],38
       jle       short M02_L08
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFAAF4260B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`3<System.__Canon,Int32,Int32>)
       mov       rdi,rax
       cmp       qword ptr [rbp+8],40
       jle       short M02_L10
       mov       rcx,[rbp+40]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFAAF426418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M02_L16
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L12
       mov       rbx,[rcx+40]
       test      rbx,rbx
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFAAF426418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M02_L13:
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       test      rdx,rdx
       je        short M02_L17
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__18`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__18_1(Int32)
       mov       [rbp+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L14
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFAAF426418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L15:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
M02_L16:
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,Boolean>, Int32)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L17:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 709
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOfComparer()
; 			var comparer = new PersonProperComparer();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.GetPersonProperArray(Tristate.False).IndexOf(base.GetPersonProperArray(Tristate.False, CollectionSize.Half).Last(), comparer);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.PersonProperComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+110]
       mov       rdx,[rsi+118]
       lea       r8,[rsp+28]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetLast(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r8,rax
       cmp       byte ptr [rsp+28],0
       je        short M00_L00
       mov       r9,rdi
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf(System.Collections.Generic.IEnumerable`1<!!0>, !!0, System.Collections.Generic.IEqualityComparer`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 121
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       mov       [rbp+20],r8
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L18
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       r14,[rcx+8]
       cmp       r14,30
       jle       short M01_L02
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       cmp       r14,60
       jle       short M01_L03
       mov       r11,[rbx+60]
       test      r11,r11
       je        short M01_L03
M01_L01:
       mov       rcx,r15
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF43AFD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF43B520
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L01
M01_L04:
       mov       rcx,rbx
       cmp       r14,38
       jle       near ptr M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L13
M01_L05:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L08
       mov       rcx,rbx
       cmp       r14,50
       jle       near ptr M01_L14
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M01_L14
M01_L06:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M01_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],58
       jle       near ptr M01_L15
       mov       r11,[rdx+58]
       test      r11,r11
       je        near ptr M01_L15
M01_L07:
       lea       edx,[rbx+0FFFF]
       mov       rcx,r15
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L08:
       mov       rcx,rbx
       cmp       r14,40
       jle       near ptr M01_L16
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L16
M01_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,rax
       mov       r11,7FFAAEE006E8
       call      qword ptr [7FFAAF3C06E8]
       test      eax,eax
       je        near ptr M01_L19
M01_L10:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L11
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF43B310
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE006F0
       call      qword ptr [7FFAAF3C06F0]
       test      eax,eax
       jne       short M01_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE006F8
       call      qword ptr [7FFAAF3C06F8]
       mov       rax,r15
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAF43B1C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFAAF43B4F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAF43B508
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFAAF43B2F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L09
M01_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L19:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L17
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
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L21
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE006F8
       call      qword ptr [7FFAAF3C06F8]
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
; Total bytes of code 709
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       mov       rdx,7FFAAF435A80
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
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF435C20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r8,19AA4711028
       mov       rbx,[r8]
       mov       r8,rbx
       mov       r9,19A84714968
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rbp,[r15+10]
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
       mov       r14,rbx
       mov       rax,19A84714C00
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L04:
       lea       rcx,[r15+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[r15+8]
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       mov       rax,19A84714C08
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L05:
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF435F50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass18_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
       mov       [rbx+18],rcx
       mov       rbp,[rsi+10]
       mov       rcx,rbp
       cmp       qword ptr [rcx+8],38
       jle       short M02_L08
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFAAF4360B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`3<System.__Canon,Int32,Int32>)
       mov       rdi,rax
       cmp       qword ptr [rbp+8],40
       jle       short M02_L10
       mov       rcx,[rbp+40]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFAAF436418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M02_L16
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L12
       mov       rbx,[rcx+40]
       test      rbx,rbx
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFAAF436418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M02_L13:
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       test      rdx,rdx
       je        short M02_L17
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__18`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__18_1(Int32)
       mov       [rbp+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L14
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFAAF436418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L15:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
M02_L16:
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,Boolean>, Int32)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L17:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 709
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.IndexOfComparer()
; 			var comparer = new PersonProperComparer();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.GetPersonProperArray(Tristate.False).IndexOf(base.GetPersonProperArray(Tristate.False, CollectionSize.Half).Last(), comparer);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.PersonProperComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+110]
       mov       rdx,[rsi+118]
       lea       r8,[rsp+28]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetLast(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       r8,rax
       cmp       byte ptr [rsp+28],0
       je        short M00_L00
       mov       r9,rdi
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf(System.Collections.Generic.IEnumerable`1<!!0>, !!0, System.Collections.Generic.IEqualityComparer`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rdx,[rsi+20]
       mov       [rdx+40],eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 121
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       mov       [rbp+20],r8
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L18
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       r14,[rcx+8]
       cmp       r14,30
       jle       short M01_L02
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       cmp       r14,60
       jle       short M01_L03
       mov       r11,[rbx+60]
       test      r11,r11
       je        short M01_L03
M01_L01:
       mov       rcx,r15
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF4630A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAF4635F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L01
M01_L04:
       mov       rcx,rbx
       cmp       r14,38
       jle       near ptr M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L13
M01_L05:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L08
       mov       rcx,rbx
       cmp       r14,50
       jle       near ptr M01_L14
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M01_L14
M01_L06:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jle       near ptr M01_L17
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],58
       jle       near ptr M01_L15
       mov       r11,[rdx+58]
       test      r11,r11
       je        near ptr M01_L15
M01_L07:
       lea       edx,[rbx+0FFFF]
       mov       rcx,r15
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L08:
       mov       rcx,rbx
       cmp       r14,40
       jle       near ptr M01_L16
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L16
M01_L09:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,rax
       mov       r11,7FFAAEE00828
       call      qword ptr [7FFAAF3D0828]
       test      eax,eax
       je        near ptr M01_L19
M01_L10:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L11
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF4633E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE00830
       call      qword ptr [7FFAAF3D0830]
       test      eax,eax
       jne       short M01_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE00838
       call      qword ptr [7FFAAF3D0838]
       mov       rax,r15
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAF463298
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFAAF4635C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAF4635D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFAAF4633C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L09
M01_L17:
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],0
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L19:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L17
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
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L21
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFAAEE00838
       call      qword ptr [7FFAAF3D0838]
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
; Total bytes of code 709
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       mov       rdx,7FFAAF4495B8
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
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF449758
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r8,21E3EB23020
       mov       rbx,[r8]
       mov       r8,rbx
       mov       r9,21E3EB26D78
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rbp,[r15+10]
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
       mov       r14,rbx
       mov       rax,21E3EB27010
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L04:
       lea       rcx,[r15+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[r15+8]
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       mov       rax,21E3EB27018
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L05:
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF449A88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass18_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
       mov       [rbx+18],rcx
       mov       rbp,[rsi+10]
       mov       rcx,rbp
       cmp       qword ptr [rcx+8],38
       jle       short M02_L08
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFAAF449BF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`3<System.__Canon,Int32,Int32>)
       mov       rdi,rax
       cmp       qword ptr [rbp+8],40
       jle       short M02_L10
       mov       rcx,[rbp+40]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFAAF449F50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax+8]
       test      rdx,rdx
       jne       near ptr M02_L16
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L12
       mov       rbx,[rcx+40]
       test      rbx,rbx
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFAAF449F50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M02_L13:
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       test      rdx,rdx
       je        short M02_L17
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__18`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__18_1(Int32)
       mov       [rbp+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L14
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFAAF449F50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L15:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
M02_L16:
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,Boolean>, Int32)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L17:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 709
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderBy()
; 			var result = base.GetPersonProperArray(Tristate.False).OrderBy(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,2CD5F0EB810
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2CD5F0EB800
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2CD5F0EB810
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2CD5F0E2F30
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 242
```
**Method was not JITted yet.**
DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderBy()
; 			var result = base.GetPersonProperArray(Tristate.False).OrderBy(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,1E00EE8B810
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1E00EE8B800
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1E00EE8B810
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1E00EE82F30
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 242
```
**Method was not JITted yet.**
DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderBy()
; 			var result = base.GetPersonProperArray(Tristate.False).OrderBy(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,24EB07E9818
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,24EB07E9808
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,24EB07E9818
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,24E907E2F30
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 242
```
**Method was not JITted yet.**
DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderBy()
; 			var result = base.GetPersonProperArray(Tristate.False).OrderBy(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,1BF06BE7408
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1BF06BE73F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1BF06BE7408
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1BEF6BE2F30
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 242
```
**Method was not JITted yet.**
DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderBy()
; 			var result = base.GetPersonProperArray(Tristate.False).OrderBy(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,26711B47408
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,26711B473F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,26711B47408
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,26701B42F30
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 242
```
**Method was not JITted yet.**
DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderBy()
; 			var result = base.GetPersonProperArray(Tristate.False).OrderBy(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,1D393C37408
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1D393C373F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1D393C37408
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1D363C32F30
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 242
```
**Method was not JITted yet.**
DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderBy()
; 			var result = base.GetPersonProperArray(Tristate.False).OrderBy(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,21707C17408
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,21707C173F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,21707C17408
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,216E7C12F30
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 242
```
**Method was not JITted yet.**
DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderBy()
; 			var result = base.GetPersonProperArray(Tristate.False).OrderBy(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,246B3597408
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,246B35973F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,246B3597408
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,24683592F30
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 242
```
**Method was not JITted yet.**
DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderByOrdinal()
; 			var result = base.GetPersonProperArray(Tristate.False).OrderByOrdinal(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,2211A559820
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2211A559808
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2211A559820
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,System.String>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       mov       rcx,[rsi+20]
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
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rbx,[rsi+10]
       mov       rbp,rdx
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,2211A551028
       mov       r14,[rax]
       mov       rax,220FA553950
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       mov       rax,2211A551028
       mov       r14,[rax]
       mov       rax,220FA553BE8
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L01:
       mov       rcx,220FA5513D0
       mov       r14,[rcx]
       cmp       qword ptr [rbx+20],0
       je        short M01_L02
       mov       rcx,[rbx+20]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF455D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
; Total bytes of code 235
```
**Method was not JITted yet.**
DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderByOrdinal()
; 			var result = base.GetPersonProperArray(Tristate.False).OrderByOrdinal(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,248D65F7410
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,248D65F73F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,248D65F7410
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,System.String>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       mov       rcx,[rsi+20]
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
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rbx,[rsi+10]
       mov       rbp,rdx
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,248A65F3020
       mov       r14,[rax]
       mov       rax,248C65F2170
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       mov       rax,248A65F3020
       mov       r14,[rax]
       mov       rax,248C65F2408
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L01:
       mov       rcx,248A65F13D0
       mov       r14,[rcx]
       cmp       qword ptr [rbx+20],0
       je        short M01_L02
       mov       rcx,[rbx+20]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF435D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
; Total bytes of code 235
```
**Method was not JITted yet.**
DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderByOrdinal()
; 			var result = base.GetPersonProperArray(Tristate.False).OrderByOrdinal(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,22B61132F78
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,22B61132F60
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,22B61132F78
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,System.String>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       mov       rcx,[rsi+20]
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
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rbx,[rsi+10]
       mov       rbp,rdx
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,22B71133020
       mov       r14,[rax]
       mov       rax,22B7113BA28
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       mov       rax,22B71133020
       mov       r14,[rax]
       mov       rax,22B7113BCC0
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L01:
       mov       rcx,22B711313D0
       mov       r14,[rcx]
       cmp       qword ptr [rbx+20],0
       je        short M01_L02
       mov       rcx,[rbx+20]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF465D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
; Total bytes of code 235
```
**Method was not JITted yet.**
DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderByOrdinal()
; 			var result = base.GetPersonProperArray(Tristate.False).OrderByOrdinal(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,204EDFD7410
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,204EDFD73F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,204EDFD7410
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,System.String>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       mov       rcx,[rsi+20]
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
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rbx,[rsi+10]
       mov       rbp,rdx
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,204BDFD3020
       mov       r14,[rax]
       mov       rax,204BDFD5D60
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       mov       rax,204BDFD3020
       mov       r14,[rax]
       mov       rax,204BDFD5FF8
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L01:
       mov       rcx,204BDFD13D0
       mov       r14,[rcx]
       cmp       qword ptr [rbx+20],0
       je        short M01_L02
       mov       rcx,[rbx+20]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF445D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
; Total bytes of code 235
```
**Method was not JITted yet.**
DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderByOrdinal()
; 			var result = base.GetPersonProperArray(Tristate.False).OrderByOrdinal(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,162C0AF7410
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,162C0AF73F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,162C0AF7410
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,System.String>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       mov       rcx,[rsi+20]
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
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rbx,[rsi+10]
       mov       rbp,rdx
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,16290AF3020
       mov       r14,[rax]
       mov       rax,16290AF5D60
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       mov       rax,16290AF3020
       mov       r14,[rax]
       mov       rax,16290AF5FF8
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L01:
       mov       rcx,16290AF13D0
       mov       r14,[rcx]
       cmp       qword ptr [rbx+20],0
       je        short M01_L02
       mov       rcx,[rbx+20]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF445D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
; Total bytes of code 235
```
**Method was not JITted yet.**
DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderByOrdinal()
; 			var result = base.GetPersonProperArray(Tristate.False).OrderByOrdinal(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,28930D19820
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,28930D19808
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,28930D19820
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,System.String>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       mov       rcx,[rsi+20]
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
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rbx,[rsi+10]
       mov       rbp,rdx
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,28930D11028
       mov       r14,[rax]
       mov       rax,28930D20198
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       mov       rax,28930D11028
       mov       r14,[rax]
       mov       rax,28930D20430
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L01:
       mov       rcx,28950D113D0
       mov       r14,[rcx]
       cmp       qword ptr [rbx+20],0
       je        short M01_L02
       mov       rcx,[rbx+20]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF455D48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
; Total bytes of code 235
```
**Method was not JITted yet.**
DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderByOrdinal()
; 			var result = base.GetPersonProperArray(Tristate.False).OrderByOrdinal(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,2842F2F2F78
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2842F2F2F60
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2842F2F2F78
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,System.String>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       mov       rcx,[rsi+20]
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
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rbx,[rsi+10]
       mov       rbp,rdx
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,2841F2F3020
       mov       r14,[rax]
       mov       rax,2841F2FAA10
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       mov       rax,2841F2F3020
       mov       r14,[rax]
       mov       rax,2841F2FACA8
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L01:
       mov       rcx,2841F2F13D0
       mov       r14,[rcx]
       cmp       qword ptr [rbx+20],0
       je        short M01_L02
       mov       rcx,[rbx+20]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF455D48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
; Total bytes of code 235
```
**Method was not JITted yet.**
DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.OrderByOrdinal()
; 			var result = base.GetPersonProperArray(Tristate.False).OrderByOrdinal(p => p.City);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,1BC10612F78
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1BC10612F60
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1BC10612F78
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,System.String>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       mov       rcx,[rsi+20]
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
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rbx,[rsi+10]
       mov       rbp,rdx
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1BC30611028
       mov       r14,[rax]
       mov       rax,1BC30614580
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       mov       rax,1BC30611028
       mov       r14,[rax]
       mov       rax,1BC30614818
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L01:
       mov       rcx,1BC206113D0
       mov       r14,[rcx]
       cmp       qword ptr [rbx+20],0
       je        short M01_L02
       mov       rcx,[rbx+20]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF439880
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
; Total bytes of code 235
```
**Method was not JITted yet.**
DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Page()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
; 			foreach (var people in base.GetPersonProperArray(Tristate.False).Page(25))
; 			                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<Page>d__1`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbx+2C],eax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+34],19
       mov       rcx,rbx
       mov       r11,7FFAAEE30650
       call      qword ptr [7FFAAF3F0650]
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rcx,rdi
       mov       r11,7FFAAEE30658
       call      qword ptr [7FFAAF3F0658]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,rdi
       mov       r11,7FFAAEE30660
       call      qword ptr [7FFAAF3F0660]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFAAEE30668
       call      qword ptr [7FFAAF3F0668]
       mov       [rbp+0FFD8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE30678
       call      qword ptr [7FFAAF3F0678]
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE30670
       call      qword ptr [7FFAAF3F0670]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE30680
       call      qword ptr [7FFAAF3F0680]
       mov       rcx,rdi
       mov       r11,7FFAAEE30658
       call      qword ptr [7FFAAF3F0658]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,rdi
       mov       r11,7FFAAEE30688
       call      qword ptr [7FFAAF3F0688]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M00_L04
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE30680
       call      qword ptr [7FFAAF3F0680]
M00_L04:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M00_L05
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFAAEE30688
       call      qword ptr [7FFAAF3F0688]
M00_L05:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 436
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Page()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
; 			foreach (var people in base.GetPersonProperArray(Tristate.False).Page(25))
; 			                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<Page>d__1`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbx+2C],eax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+34],19
       mov       rcx,rbx
       mov       r11,7FFAAEDF0650
       call      qword ptr [7FFAAF3B0650]
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rcx,rdi
       mov       r11,7FFAAEDF0658
       call      qword ptr [7FFAAF3B0658]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,rdi
       mov       r11,7FFAAEDF0660
       call      qword ptr [7FFAAF3B0660]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFAAEDF0668
       call      qword ptr [7FFAAF3B0668]
       mov       [rbp+0FFD8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEDF0678
       call      qword ptr [7FFAAF3B0678]
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEDF0670
       call      qword ptr [7FFAAF3B0670]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEDF0680
       call      qword ptr [7FFAAF3B0680]
       mov       rcx,rdi
       mov       r11,7FFAAEDF0658
       call      qword ptr [7FFAAF3B0658]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,rdi
       mov       r11,7FFAAEDF0688
       call      qword ptr [7FFAAF3B0688]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M00_L04
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEDF0680
       call      qword ptr [7FFAAF3B0680]
M00_L04:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M00_L05
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFAAEDF0688
       call      qword ptr [7FFAAF3B0688]
M00_L05:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 436
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Page()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
; 			foreach (var people in base.GetPersonProperArray(Tristate.False).Page(25))
; 			                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<Page>d__1`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbx+2C],eax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+34],19
       mov       rcx,rbx
       mov       r11,7FFAAEE30650
       call      qword ptr [7FFAAF3F0650]
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rcx,rdi
       mov       r11,7FFAAEE30658
       call      qword ptr [7FFAAF3F0658]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,rdi
       mov       r11,7FFAAEE30660
       call      qword ptr [7FFAAF3F0660]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFAAEE30668
       call      qword ptr [7FFAAF3F0668]
       mov       [rbp+0FFD8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE30678
       call      qword ptr [7FFAAF3F0678]
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE30670
       call      qword ptr [7FFAAF3F0670]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE30680
       call      qword ptr [7FFAAF3F0680]
       mov       rcx,rdi
       mov       r11,7FFAAEE30658
       call      qword ptr [7FFAAF3F0658]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,rdi
       mov       r11,7FFAAEE30688
       call      qword ptr [7FFAAF3F0688]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M00_L04
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE30680
       call      qword ptr [7FFAAF3F0680]
M00_L04:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M00_L05
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFAAEE30688
       call      qword ptr [7FFAAF3F0688]
M00_L05:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 436
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Page()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
; 			foreach (var people in base.GetPersonProperArray(Tristate.False).Page(25))
; 			                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<Page>d__1`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbx+2C],eax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+34],19
       mov       rcx,rbx
       mov       r11,7FFAAEE00650
       call      qword ptr [7FFAAF3C0650]
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rcx,rdi
       mov       r11,7FFAAEE00658
       call      qword ptr [7FFAAF3C0658]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,rdi
       mov       r11,7FFAAEE00660
       call      qword ptr [7FFAAF3C0660]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFAAEE00668
       call      qword ptr [7FFAAF3C0668]
       mov       [rbp+0FFD8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE00678
       call      qword ptr [7FFAAF3C0678]
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE00670
       call      qword ptr [7FFAAF3C0670]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE00680
       call      qword ptr [7FFAAF3C0680]
       mov       rcx,rdi
       mov       r11,7FFAAEE00658
       call      qword ptr [7FFAAF3C0658]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,rdi
       mov       r11,7FFAAEE00688
       call      qword ptr [7FFAAF3C0688]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M00_L04
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE00680
       call      qword ptr [7FFAAF3C0680]
M00_L04:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M00_L05
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFAAEE00688
       call      qword ptr [7FFAAF3C0688]
M00_L05:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 436
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Page()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
; 			foreach (var people in base.GetPersonProperArray(Tristate.False).Page(25))
; 			                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<Page>d__1`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbx+2C],eax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+34],19
       mov       rcx,rbx
       mov       r11,7FFAAEE00650
       call      qword ptr [7FFAAF3C0650]
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rcx,rdi
       mov       r11,7FFAAEE00658
       call      qword ptr [7FFAAF3C0658]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,rdi
       mov       r11,7FFAAEE00660
       call      qword ptr [7FFAAF3C0660]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFAAEE00668
       call      qword ptr [7FFAAF3C0668]
       mov       [rbp+0FFD8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE00678
       call      qword ptr [7FFAAF3C0678]
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE00670
       call      qword ptr [7FFAAF3C0670]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE00680
       call      qword ptr [7FFAAF3C0680]
       mov       rcx,rdi
       mov       r11,7FFAAEE00658
       call      qword ptr [7FFAAF3C0658]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,rdi
       mov       r11,7FFAAEE00688
       call      qword ptr [7FFAAF3C0688]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M00_L04
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE00680
       call      qword ptr [7FFAAF3C0680]
M00_L04:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M00_L05
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFAAEE00688
       call      qword ptr [7FFAAF3C0688]
M00_L05:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 436
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Page()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
; 			foreach (var people in base.GetPersonProperArray(Tristate.False).Page(25))
; 			                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<Page>d__1`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbx+2C],eax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+34],19
       mov       rcx,rbx
       mov       r11,7FFAAEE20650
       call      qword ptr [7FFAAF3E0650]
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rcx,rdi
       mov       r11,7FFAAEE20658
       call      qword ptr [7FFAAF3E0658]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,rdi
       mov       r11,7FFAAEE20660
       call      qword ptr [7FFAAF3E0660]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFAAEE20668
       call      qword ptr [7FFAAF3E0668]
       mov       [rbp+0FFD8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE20678
       call      qword ptr [7FFAAF3E0678]
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE20670
       call      qword ptr [7FFAAF3E0670]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE20680
       call      qword ptr [7FFAAF3E0680]
       mov       rcx,rdi
       mov       r11,7FFAAEE20658
       call      qword ptr [7FFAAF3E0658]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,rdi
       mov       r11,7FFAAEE20688
       call      qword ptr [7FFAAF3E0688]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M00_L04
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE20680
       call      qword ptr [7FFAAF3E0680]
M00_L04:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M00_L05
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFAAEE20688
       call      qword ptr [7FFAAF3E0688]
M00_L05:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 436
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Page()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
; 			foreach (var people in base.GetPersonProperArray(Tristate.False).Page(25))
; 			                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<Page>d__1`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbx+2C],eax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+34],19
       mov       rcx,rbx
       mov       r11,7FFAAEE30650
       call      qword ptr [7FFAAF3F0650]
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rcx,rdi
       mov       r11,7FFAAEE30658
       call      qword ptr [7FFAAF3F0658]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,rdi
       mov       r11,7FFAAEE30660
       call      qword ptr [7FFAAF3F0660]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFAAEE30668
       call      qword ptr [7FFAAF3F0668]
       mov       [rbp+0FFD8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE30678
       call      qword ptr [7FFAAF3F0678]
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE30670
       call      qword ptr [7FFAAF3F0670]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE30680
       call      qword ptr [7FFAAF3F0680]
       mov       rcx,rdi
       mov       r11,7FFAAEE30658
       call      qword ptr [7FFAAF3F0658]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,rdi
       mov       r11,7FFAAEE30688
       call      qword ptr [7FFAAF3F0688]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M00_L04
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE30680
       call      qword ptr [7FFAAF3F0680]
M00_L04:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M00_L05
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFAAEE30688
       call      qword ptr [7FFAAF3F0688]
M00_L05:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 436
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Page()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
; 			foreach (var people in base.GetPersonProperArray(Tristate.False).Page(25))
; 			                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<Page>d__1`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbx+2C],eax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+34],19
       mov       rcx,rbx
       mov       r11,7FFAAEE10650
       call      qword ptr [7FFAAF3E0650]
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rcx,rdi
       mov       r11,7FFAAEE10658
       call      qword ptr [7FFAAF3E0658]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,rdi
       mov       r11,7FFAAEE10660
       call      qword ptr [7FFAAF3E0660]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFAAEE10668
       call      qword ptr [7FFAAF3E0668]
       mov       [rbp+0FFD8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE10678
       call      qword ptr [7FFAAF3E0678]
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE10670
       call      qword ptr [7FFAAF3E0670]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE10680
       call      qword ptr [7FFAAF3E0680]
       mov       rcx,rdi
       mov       r11,7FFAAEE10658
       call      qword ptr [7FFAAF3E0658]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,rdi
       mov       r11,7FFAAEE10688
       call      qword ptr [7FFAAF3E0688]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M00_L04
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFAAEE10680
       call      qword ptr [7FFAAF3E0680]
M00_L04:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M00_L05
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFAAEE10688
       call      qword ptr [7FFAAF3E0688]
M00_L05:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 436
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom01()
; 			var result = base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half).PickRandom();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,[rsi+10]
       mov       rbx,rdx
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,14A91371028
       mov       rbp,[rax]
       mov       rax,14A71372970
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       sub       edx,1
       jo        short M01_L03
       xor       ecx,ecx
       call      System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ebp,eax
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF445A70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rbx
       mov       r8d,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.ElementAt[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 174
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom01()
; 			var result = base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half).PickRandom();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,[rsi+10]
       mov       rbx,rdx
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,23EAE773020
       mov       rbp,[rax]
       mov       rax,23EAE782190
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       sub       edx,1
       jo        short M01_L03
       xor       ecx,ecx
       call      System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ebp,eax
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF455A70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rbx
       mov       r8d,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.ElementAt[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 174
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom01()
; 			var result = base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half).PickRandom();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,[rsi+10]
       mov       rbx,rdx
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,23752883020
       mov       rbp,[rax]
       mov       rax,2373288EDA0
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       sub       edx,1
       jo        short M01_L03
       xor       ecx,ecx
       call      System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ebp,eax
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF465A70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rbx
       mov       r8d,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.ElementAt[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 174
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom01()
; 			var result = base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half).PickRandom();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,[rsi+10]
       mov       rbx,rdx
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,26F97A93020
       mov       rbp,[rax]
       mov       rax,26F97A96578
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       sub       edx,1
       jo        short M01_L03
       xor       ecx,ecx
       call      System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ebp,eax
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF455A70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rbx
       mov       r8d,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.ElementAt[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 174
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom01()
; 			var result = base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half).PickRandom();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,[rsi+10]
       mov       rbx,rdx
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,15F3C6D3020
       mov       rbp,[rax]
       mov       rax,15F3C6E39C0
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       sub       edx,1
       jo        short M01_L03
       xor       ecx,ecx
       call      System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ebp,eax
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF445A70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rbx
       mov       r8d,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.ElementAt[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 174
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom01()
; 			var result = base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half).PickRandom();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,[rsi+10]
       mov       rbx,rdx
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1E723FC3020
       mov       rbp,[rax]
       mov       rax,1E743FC2170
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       sub       edx,1
       jo        short M01_L03
       xor       ecx,ecx
       call      System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ebp,eax
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF435A28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rbx
       mov       r8d,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.ElementAt[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 174
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom01()
; 			var result = base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half).PickRandom();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,[rsi+10]
       mov       rbx,rdx
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,14978E01028
       mov       rbp,[rax]
       mov       rax,14998E04168
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       sub       edx,1
       jo        short M01_L03
       xor       ecx,ecx
       call      System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ebp,eax
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF425A28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rbx
       mov       r8d,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.ElementAt[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 174
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.PickRandom01()
; 			var result = base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half).PickRandom();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,[rsi+10]
       mov       rbx,rdx
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,19F118B3020
       mov       rbp,[rax]
       mov       rax,19F118C39C0
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       sub       edx,1
       jo        short M01_L03
       xor       ecx,ecx
       call      System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ebp,eax
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF449560
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rbx
       mov       r8d,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.ElementAt[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 174
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Shuffle()
; 			var result = base.GetPersonProperArray(Tristate.False).Shuffle();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF3B2FB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,28659703020
       mov       r8,[r8]
       mov       r9,28659705D60
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF3B31F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M01_L10
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFAAF3B31F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF3B3378
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M01_L13
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ListExtensions+<>c__11`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__11_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFAAF3B31F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M01_L10:
       cmp       qword ptr [rbx+20],0
       je        short M01_L11
       mov       rcx,[rbx+20]
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF3B3238
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,rdi
       mov       r8,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
M01_L13:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 376
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Shuffle()
; 			var result = base.GetPersonProperArray(Tristate.False).Shuffle();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF382FB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,2471D203020
       mov       r8,[r8]
       mov       r9,2471D2129A8
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF3831F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M01_L10
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFAAF3831F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF383378
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M01_L13
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ListExtensions+<>c__11`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__11_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFAAF3831F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M01_L10:
       cmp       qword ptr [rbx+20],0
       je        short M01_L11
       mov       rcx,[rbx+20]
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF383238
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,rdi
       mov       r8,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
M01_L13:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 376
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Shuffle()
; 			var result = base.GetPersonProperArray(Tristate.False).Shuffle();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF3A2FB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,216B0961028
       mov       r8,[r8]
       mov       r9,216B096F9D0
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF3A31F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M01_L10
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFAAF3A31F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF3A3378
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M01_L13
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ListExtensions+<>c__11`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__11_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFAAF3A31F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M01_L10:
       cmp       qword ptr [rbx+20],0
       je        short M01_L11
       mov       rcx,[rbx+20]
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF3A3238
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,rdi
       mov       r8,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
M01_L13:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 376
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Shuffle()
; 			var result = base.GetPersonProperArray(Tristate.False).Shuffle();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF3C2FB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,2410EEA3020
       mov       r8,[r8]
       mov       r9,2410EEB39C0
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF3C31F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M01_L10
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFAAF3C31F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF3C3378
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M01_L13
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ListExtensions+<>c__11`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__11_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFAAF3C31F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M01_L10:
       cmp       qword ptr [rbx+20],0
       je        short M01_L11
       mov       rcx,[rbx+20]
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF3C3238
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,rdi
       mov       r8,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
M01_L13:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 376
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Shuffle()
; 			var result = base.GetPersonProperArray(Tristate.False).Shuffle();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF382FB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,15E1F473020
       mov       r8,[r8]
       mov       r9,15DFF471958
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF3831F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M01_L10
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFAAF3831F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF383378
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M01_L13
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ListExtensions+<>c__11`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__11_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFAAF3831F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M01_L10:
       cmp       qword ptr [rbx+20],0
       je        short M01_L11
       mov       rcx,[rbx+20]
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF383238
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,rdi
       mov       r8,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
M01_L13:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 376
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Shuffle()
; 			var result = base.GetPersonProperArray(Tristate.False).Shuffle();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF3A3000
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,1BC5D503020
       mov       r8,[r8]
       mov       r9,1BC5D505D60
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF3A3240
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M01_L10
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFAAF3A3240
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF3A33C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M01_L13
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ListExtensions+<>c__11`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__11_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFAAF3A3240
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M01_L10:
       cmp       qword ptr [rbx+20],0
       je        short M01_L11
       mov       rcx,[rbx+20]
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF3A3280
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,rdi
       mov       r8,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
M01_L13:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 376
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Shuffle()
; 			var result = base.GetPersonProperArray(Tristate.False).Shuffle();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF393000
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,25995583020
       mov       r8,[r8]
       mov       r9,25995585D60
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF393240
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M01_L10
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFAAF393240
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF3933C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M01_L13
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ListExtensions+<>c__11`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__11_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFAAF393240
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M01_L10:
       cmp       qword ptr [rbx+20],0
       je        short M01_L11
       mov       rcx,[rbx+20]
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF393280
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,rdi
       mov       r8,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
M01_L13:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 376
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.Shuffle()
; 			var result = base.GetPersonProperArray(Tristate.False).Shuffle();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF38A4A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,1D00D3B3020
       mov       r8,[r8]
       mov       r9,1D02D3B2170
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF38A6E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M01_L10
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFAAF38A6E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFAAF38A868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M01_L13
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ListExtensions+<>c__11`1[[System.__Canon, System.Private.CoreLib]].<Shuffle>b__11_0(System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFAAF38A6E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M01_L10:
       cmp       qword ptr [rbx+20],0
       je        short M01_L11
       mov       rcx,[rbx+20]
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF38A728
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,rdi
       mov       r8,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
M01_L13:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 376
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToObservableCollection()
; 			var result = base.GetPersonProperArray(Tristate.False).ToObservableCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF457930
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,23D07B01028
       mov       r8,[r8]
       mov       r9,23D17B115B0
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF457E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToObservableCollection()
; 			var result = base.GetPersonProperArray(Tristate.False).ToObservableCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF437930
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,2B7A09F3020
       mov       r8,[r8]
       mov       r9,2B7809F2970
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF437E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToObservableCollection()
; 			var result = base.GetPersonProperArray(Tristate.False).ToObservableCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF467930
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,11622081028
       mov       r8,[r8]
       mov       r9,11642085180
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF467E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToObservableCollection()
; 			var result = base.GetPersonProperArray(Tristate.False).ToObservableCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF437930
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,1A3F2AD1028
       mov       r8,[r8]
       mov       r9,1A3E2AD4968
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF437E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToObservableCollection()
; 			var result = base.GetPersonProperArray(Tristate.False).ToObservableCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF447930
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,17E154A1028
       mov       r8,[r8]
       mov       r9,17E154B19C8
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF447E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToObservableCollection()
; 			var result = base.GetPersonProperArray(Tristate.False).ToObservableCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4578E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,240E2F73020
       mov       r8,[r8]
       mov       r9,240E2F839C0
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF457DB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToObservableCollection()
; 			var result = base.GetPersonProperArray(Tristate.False).ToObservableCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4378E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,18A6ECF3020
       mov       r8,[r8]
       mov       r9,18A6ED039C0
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF437DB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToObservableCollection()
; 			var result = base.GetPersonProperArray(Tristate.False).ToObservableCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF44B420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,2AE05BE3020
       mov       r8,[r8]
       mov       r9,2AE05BF39C0
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF44B8F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.ObjectModel.ObservableCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToReadOnlyCollection()
; 			var result = base.GetPersonProperArray(Tristate.False).ToReadOnlyCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF445FF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,299D72B1028
       mov       r8,[r8]
       mov       r9,299D72B4D80
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF446428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rdi,rdi
       je        short M01_L04
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 170
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToReadOnlyCollection()
; 			var result = base.GetPersonProperArray(Tristate.False).ToReadOnlyCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF455FF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,1F335201028
       mov       r8,[r8]
       mov       r9,1F315203950
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF456428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rdi,rdi
       je        short M01_L04
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 170
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToReadOnlyCollection()
; 			var result = base.GetPersonProperArray(Tristate.False).ToReadOnlyCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF435FF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,271DC503020
       mov       r8,[r8]
       mov       r9,271DC5129A8
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF436428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rdi,rdi
       je        short M01_L04
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 170
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToReadOnlyCollection()
; 			var result = base.GetPersonProperArray(Tristate.False).ToReadOnlyCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF425FF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,1E5DC483020
       mov       r8,[r8]
       mov       r9,1E5DC485D60
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF426428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rdi,rdi
       je        short M01_L04
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 170
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToReadOnlyCollection()
; 			var result = base.GetPersonProperArray(Tristate.False).ToReadOnlyCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF455FF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,22DC9793020
       mov       r8,[r8]
       mov       r9,22DC9796578
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF456428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rdi,rdi
       je        short M01_L04
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 170
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToReadOnlyCollection()
; 			var result = base.GetPersonProperArray(Tristate.False).ToReadOnlyCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF425FA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,29D3C303020
       mov       r8,[r8]
       mov       r9,29D3C306D78
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF4263E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rdi,rdi
       je        short M01_L04
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 170
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToReadOnlyCollection()
; 			var result = base.GetPersonProperArray(Tristate.False).ToReadOnlyCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF425FA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,1EF60B93020
       mov       r8,[r8]
       mov       r9,1EF60B93D68
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF4263E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rdi,rdi
       je        short M01_L04
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 170
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.ToReadOnlyCollection()
; 			var result = base.GetPersonProperArray(Tristate.False).ToReadOnlyCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF459AE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r8,1CD34223020
       mov       r8,[r8]
       mov       r9,1CD34226578
       mov       r9,[r9]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF459F18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rdi,rdi
       je        short M01_L04
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 170
```

