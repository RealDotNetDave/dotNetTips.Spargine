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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       rdx,[rsi+10]
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
       mov       rcx,22B102C3020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF126A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,22AF02C1FB8
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF12AD8
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
; Total bytes of code 180
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       rdx,[rsi+10]
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
       mov       rcx,27A99FF3020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF126A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,27A79FF1FB8
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF12AD8
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
; Total bytes of code 180
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       rdx,[rsi+10]
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
       mov       rcx,1D32AA31028
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF226A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1D34AA413F8
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF22AD8
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
; Total bytes of code 180
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       rdx,[rsi+10]
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
       mov       rcx,23AFCEA3020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF126A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,23ADCEA1FB8
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF12AD8
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
; Total bytes of code 180
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       rdx,[rsi+10]
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
       mov       rcx,1F476E31028
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF026A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1F496E3B730
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02AD8
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
; Total bytes of code 180
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       rdx,[rsi+10]
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
       mov       rcx,2114E6A3020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF226A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,2114E6A63C0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF22AD8
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
; Total bytes of code 180
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       rdx,[rsi+10]
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
       mov       rcx,286E7263020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF32680
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,2870726FBC8
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF32AB8
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
; Total bytes of code 180
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       rdx,[rsi+10]
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
       mov       rcx,146BE3F3020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCFBB7B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1469E3F1FB8
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCFBBBE8
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
; Total bytes of code 180
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems03()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rsi,[rsi+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 70
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
       mov       rdx,7FFEBCF05648
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
       mov       rdx,7FFEBCF05BA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF057A8
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
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rdx,2BB36B73020
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFEBCF020D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       r9,2BB36B773D8
       mov       r9,[r9]
       lea       r8,[rsp+28]
       mov       rcx,rdx
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,edi
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems03()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rsi,[rsi+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 70
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
       mov       rdx,7FFEBCEF5648
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
       mov       rdx,7FFEBCEF5BA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF57A8
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
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rdx,1BD48353020
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFEBCEF20D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       r9,1BD48361FD8
       mov       r9,[r9]
       lea       r8,[rsp+28]
       mov       rcx,rdx
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,edi
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems03()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rsi,[rsi+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 70
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
       mov       rdx,7FFEBCF35EA8
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
       mov       rdx,7FFEBCF36408
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF36008
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
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rdx,15BEF7C3020
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFEBCF320D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       r9,15BEF7C63C0
       mov       r9,[r9]
       lea       r8,[rsp+28]
       mov       rcx,rdx
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,edi
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems03()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rsi,[rsi+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 70
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
       mov       rdx,7FFEBCEF6810
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
       mov       rdx,7FFEBCEF6D70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF6970
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
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rdx,21C8F4D3020
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFEBCEF20D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       r9,21C8F4D6BC0
       mov       r9,[r9]
       lea       r8,[rsp+28]
       mov       rcx,rdx
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,edi
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems03()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rsi,[rsi+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 70
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
       mov       rdx,7FFEBCF15648
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
       mov       rdx,7FFEBCF15BA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF157A8
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
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rdx,14656BC1028
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFEBCF120D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       r9,14636BC3FB0
       mov       r9,[r9]
       lea       r8,[rsp+28]
       mov       rcx,rdx
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,edi
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems03()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rsi,[rsi+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 70
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
       mov       rdx,7FFEBCF25EA8
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
       mov       rdx,7FFEBCF26408
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF26008
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
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rdx,2B834823020
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFEBCF220D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       r9,2B8148227B8
       mov       r9,[r9]
       lea       r8,[rsp+28]
       mov       rcx,rdx
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,edi
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems03()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rsi,[rsi+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 70
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
       mov       rdx,7FFEBCF35EA8
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
       mov       rdx,7FFEBCF36408
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF36008
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
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rdx,1E72BE03020
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFEBCF320D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       r9,1E72BE12FF0
       mov       r9,[r9]
       lea       r8,[rsp+28]
       mov       rcx,rdx
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,edi
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems03()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rsi,[rsi+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 70
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
       mov       rdx,7FFEBCFD1CB8
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
       mov       rdx,7FFEBCFD2218
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCFD1E18
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
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rdx,23FA1D71028
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFEBCFCB1E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       r9,23FA1D7FFE0
       mov       r9,[r9]
       lea       r8,[rsp+28]
       mov       rcx,rdx
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,edi
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems02()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rsi,[rsi+10]
       mov       rcx,25A8083B808
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,25A8083B800
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<HasItems02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,25A8083B808
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
       mov       rdx,7FFEBCEF6AB0
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
       mov       rdx,7FFEBCEF7010
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF6C10
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
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
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
       vdivsd    xmm0,xmm0,[7FFEBCF11DF8]
       vucomisd  xmm0,qword ptr [7FFEBCF11E00]
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
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+58],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,25A80833020
       mov       rbp,[rcx]
       mov       [rsp+48],rbp
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF28D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       lea       r8,[rsp+50]
       lea       r9,[rsp+48]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       je        short M03_L04
       xor       ecx,ecx
       mov       [rsp+40],ecx
       mov       [rsp+38],rbp
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF2A48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       lea       r8,[rsp+40]
       lea       r9,[rsp+38]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M03_L05
M03_L04:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       mov       [rsp+48],rbp
       mov       rax,25A80842CF8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L06:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 312
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems02()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rsi,[rsi+10]
       mov       rcx,25F06057370
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,25F06057368
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<HasItems02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,25F06057370
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
       mov       rdx,7FFEBCF16AB0
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
       mov       rdx,7FFEBCF17010
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF16C10
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
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
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
       vdivsd    xmm0,xmm0,[7FFEBCF31DF8]
       vucomisd  xmm0,qword ptr [7FFEBCF31E00]
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
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+58],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,25F06053020
       mov       rbp,[rcx]
       mov       [rsp+48],rbp
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF128D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       lea       r8,[rsp+50]
       lea       r9,[rsp+48]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       je        short M03_L04
       xor       ecx,ecx
       mov       [rsp+40],ecx
       mov       [rsp+38],rbp
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF12A48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       lea       r8,[rsp+40]
       lea       r9,[rsp+38]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M03_L05
M03_L04:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       mov       [rsp+48],rbp
       mov       rax,25EE6052CD8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L06:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 312
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems02()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rsi,[rsi+10]
       mov       rcx,13199147400
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,131991473F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<HasItems02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,13199147400
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
       mov       rdx,7FFEBCF06AB0
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
       mov       rdx,7FFEBCF07010
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06C10
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
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
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
       vdivsd    xmm0,xmm0,[7FFEBCF21DF8]
       vucomisd  xmm0,qword ptr [7FFEBCF21E00]
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
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+58],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,13179143020
       mov       rbp,[rcx]
       mov       [rsp+48],rbp
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF028D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       lea       r8,[rsp+50]
       lea       r9,[rsp+48]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       je        short M03_L04
       xor       ecx,ecx
       mov       [rsp+40],ecx
       mov       [rsp+38],rbp
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02A48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       lea       r8,[rsp+40]
       lea       r9,[rsp+38]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M03_L05
M03_L04:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       mov       [rsp+48],rbp
       mov       rax,131791468C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L06:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 312
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems02()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rsi,[rsi+10]
       mov       rcx,2904A0D7400
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2904A0D73F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<HasItems02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2904A0D7400
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
       mov       rdx,7FFEBCF364A8
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
       mov       rdx,7FFEBCF36A08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF36608
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
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
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
       vdivsd    xmm0,xmm0,[7FFEBCF51D18]
       vucomisd  xmm0,qword ptr [7FFEBCF51D20]
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
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+58],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,2902A0D3020
       mov       rbp,[rcx]
       mov       [rsp+48],rbp
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF328D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       lea       r8,[rsp+50]
       lea       r9,[rsp+48]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       je        short M03_L04
       xor       ecx,ecx
       mov       [rsp+40],ecx
       mov       [rsp+38],rbp
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF32A48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       lea       r8,[rsp+40]
       lea       r9,[rsp+38]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M03_L05
M03_L04:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       mov       [rsp+48],rbp
       mov       rax,2904A0DD8D8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L06:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 312
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems02()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rsi,[rsi+10]
       mov       rcx,25B8C1C7400
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,25B8C1C73F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<HasItems02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,25B8C1C7400
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
       mov       rdx,7FFEBCF26AB0
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
       mov       rdx,7FFEBCF27010
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF26C10
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
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
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
       vdivsd    xmm0,xmm0,[7FFEBCF41DF8]
       vucomisd  xmm0,qword ptr [7FFEBCF41E00]
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
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+58],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,25B5C1C3020
       mov       rbp,[rcx]
       mov       [rsp+48],rbp
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF228D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       lea       r8,[rsp+50]
       lea       r9,[rsp+48]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       je        short M03_L04
       xor       ecx,ecx
       mov       [rsp+40],ecx
       mov       [rsp+38],rbp
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF22A48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       lea       r8,[rsp+40]
       lea       r9,[rsp+38]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M03_L05
M03_L04:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       mov       [rsp+48],rbp
       mov       rax,25B7C1C24C0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L06:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 312
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems02()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rsi,[rsi+10]
       mov       rcx,20FF0AFB808
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,20FF0AFB800
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<HasItems02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,20FF0AFB808
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
       mov       rdx,7FFEBCF26AB0
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
       mov       rdx,7FFEBCF27010
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF26C10
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
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
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
       vdivsd    xmm0,xmm0,[7FFEBCF41DF8]
       vucomisd  xmm0,qword ptr [7FFEBCF41E00]
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
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+58],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,20FF0AF3020
       mov       rbp,[rcx]
       mov       [rsp+48],rbp
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF228D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       lea       r8,[rsp+50]
       lea       r9,[rsp+48]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       je        short M03_L04
       xor       ecx,ecx
       mov       [rsp+40],ecx
       mov       [rsp+38],rbp
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF22A48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       lea       r8,[rsp+40]
       lea       r9,[rsp+38]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M03_L05
M03_L04:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       mov       [rsp+48],rbp
       mov       rax,20FF0B03510
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L06:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 312
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems02()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rsi,[rsi+10]
       mov       rcx,213F6C0B808
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,213F6C0B800
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<HasItems02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,213F6C0B808
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
       mov       rdx,7FFEBCF06AB0
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
       mov       rdx,7FFEBCF07010
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06C10
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
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
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
       vdivsd    xmm0,xmm0,[7FFEBCF21DF8]
       vucomisd  xmm0,qword ptr [7FFEBCF21E00]
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
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+58],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,213F6C03020
       mov       rbp,[rcx]
       mov       [rsp+48],rbp
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF028D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       lea       r8,[rsp+50]
       lea       r9,[rsp+48]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       je        short M03_L04
       xor       ecx,ecx
       mov       [rsp+40],ecx
       mov       [rsp+38],rbp
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02A48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       lea       r8,[rsp+40]
       lea       r9,[rsp+38]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M03_L05
M03_L04:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       mov       [rsp+48],rbp
       mov       rax,213F6C11CE0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L06:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 312
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems02()
; 			var people = base.GetPersonProperArray(Tristate.False).ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rsi,[rsi+10]
       mov       rcx,28BDA9D7400
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,28BDA9D73F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<HasItems02>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,28BDA9D7400
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
       mov       rdx,7FFEBCFC1CF8
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
       mov       rdx,7FFEBCFC2258
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCFC1E58
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
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
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
       vdivsd    xmm0,xmm0,[7FFEBCF2EF28]
       vucomisd  xmm0,qword ptr [7FFEBCF2EF30]
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
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+58],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,28BAA9D3020
       mov       rbp,[rcx]
       mov       [rsp+48],rbp
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCFAB9E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       lea       r8,[rsp+50]
       lea       r9,[rsp+48]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       je        short M03_L04
       xor       ecx,ecx
       mov       [rsp+40],ecx
       mov       [rsp+38],rbp
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCFABB58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       lea       r8,[rsp+40]
       lea       r9,[rsp+38]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M03_L05
M03_L04:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       mov       [rsp+48],rbp
       mov       rax,28BAA9D70E0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L06:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 312
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
       mov       rdx,[rsi+100]
       mov       r8d,[rsi+124]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rax,15F0E2C1028
       mov       rbp,[rax]
       mov       [rsp+38],rbp
       mov       r14,[rdi+10]
       mov       rax,15EFE2C2FD0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rsi,rsi
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
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       r15d,eax
       mov       [rsp+38],rbp
       test      ebx,ebx
       jle       short M01_L01
       cmp       ebx,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L03
       mov       ebx,r15d
       jmp       short M01_L05
M01_L03:
       test      edx,edx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       mov       rdx,[rsp+38]
       test      rdx,rdx
       je        short M01_L04
       cmp       dword ptr [rdx+8],0
       je        short M01_L04
       mov       rcx,[rsp+38]
       jmp       short M01_L04
M01_L04:
       mov       rdx,15EFE2C1770
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       cmp       qword ptr [r14+18],0
       je        short M01_L06
       mov       rcx,[r14+18]
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFEBCF02BD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,rsi
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       cmp       qword ptr [r14+20],0
       je        short M01_L08
       mov       rcx,[r14+20]
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFEBCF02C88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       mov       rdx,rsi
       mov       r8d,ebx
       call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 340
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
       mov       rdx,[rsi+100]
       mov       r8d,[rsi+124]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rax,291856E3020
       mov       rbp,[rax]
       mov       [rsp+38],rbp
       mov       r14,[rdi+10]
       mov       rax,291A56E27B8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rsi,rsi
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
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       r15d,eax
       mov       [rsp+38],rbp
       test      ebx,ebx
       jle       short M01_L01
       cmp       ebx,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L03
       mov       ebx,r15d
       jmp       short M01_L05
M01_L03:
       test      edx,edx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       mov       rdx,[rsp+38]
       test      rdx,rdx
       je        short M01_L04
       cmp       dword ptr [rdx+8],0
       je        short M01_L04
       mov       rcx,[rsp+38]
       jmp       short M01_L04
M01_L04:
       mov       rdx,291856F1FA8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       cmp       qword ptr [r14+18],0
       je        short M01_L06
       mov       rcx,[r14+18]
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFEBCEE2BD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,rsi
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       cmp       qword ptr [r14+20],0
       je        short M01_L08
       mov       rcx,[r14+20]
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFEBCEE2C88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       mov       rdx,rsi
       mov       r8d,ebx
       call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 340
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
       mov       rdx,[rsi+100]
       mov       r8d,[rsi+124]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rax,290A4201028
       mov       rbp,[rax]
       mov       [rsp+38],rbp
       mov       r14,[rdi+10]
       mov       rax,29094203FB0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rsi,rsi
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
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       r15d,eax
       mov       [rsp+38],rbp
       test      ebx,ebx
       jle       short M01_L01
       cmp       ebx,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L03
       mov       ebx,r15d
       jmp       short M01_L05
M01_L03:
       test      edx,edx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       mov       rdx,[rsp+38]
       test      rdx,rdx
       je        short M01_L04
       cmp       dword ptr [rdx+8],0
       je        short M01_L04
       mov       rcx,[rsp+38]
       jmp       short M01_L04
M01_L04:
       mov       rdx,29094203768
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       cmp       qword ptr [r14+18],0
       je        short M01_L06
       mov       rcx,[r14+18]
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFEBCEF2BD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,rsi
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       cmp       qword ptr [r14+20],0
       je        short M01_L08
       mov       rcx,[r14+20]
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFEBCEF2C88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       mov       rdx,rsi
       mov       r8d,ebx
       call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 340
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
       mov       rdx,[rsi+100]
       mov       r8d,[rsi+124]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rax,1B090773020
       mov       rbp,[rax]
       mov       [rsp+38],rbp
       mov       r14,[rdi+10]
       mov       rax,1B0907827F0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rsi,rsi
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
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       r15d,eax
       mov       [rsp+38],rbp
       test      ebx,ebx
       jle       short M01_L01
       cmp       ebx,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L03
       mov       ebx,r15d
       jmp       short M01_L05
M01_L03:
       test      edx,edx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       mov       rdx,[rsp+38]
       test      rdx,rdx
       je        short M01_L04
       cmp       dword ptr [rdx+8],0
       je        short M01_L04
       mov       rcx,[rsp+38]
       jmp       short M01_L04
M01_L04:
       mov       rdx,1B090781FA8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       cmp       qword ptr [r14+18],0
       je        short M01_L06
       mov       rcx,[r14+18]
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFEBCEF2BD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,rsi
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       cmp       qword ptr [r14+20],0
       je        short M01_L08
       mov       rcx,[r14+20]
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFEBCEF2C88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       mov       rdx,rsi
       mov       r8d,ebx
       call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 340
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
       mov       rdx,[rsi+100]
       mov       r8d,[rsi+124]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rax,1D9A6503020
       mov       rbp,[rax]
       mov       [rsp+38],rbp
       mov       r14,[rdi+10]
       mov       rax,1D9A6511FD8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rsi,rsi
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
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       r15d,eax
       mov       [rsp+38],rbp
       test      ebx,ebx
       jle       short M01_L01
       cmp       ebx,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L03
       mov       ebx,r15d
       jmp       short M01_L05
M01_L03:
       test      edx,edx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       mov       rdx,[rsp+38]
       test      rdx,rdx
       je        short M01_L04
       cmp       dword ptr [rdx+8],0
       je        short M01_L04
       mov       rcx,[rsp+38]
       jmp       short M01_L04
M01_L04:
       mov       rdx,1D9C6501770
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       cmp       qword ptr [r14+18],0
       je        short M01_L06
       mov       rcx,[r14+18]
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFEBCEE2BD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,rsi
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       cmp       qword ptr [r14+20],0
       je        short M01_L08
       mov       rcx,[r14+20]
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFEBCEE2C88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       mov       rdx,rsi
       mov       r8d,ebx
       call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 340
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
       mov       rdx,[rsi+100]
       mov       r8d,[rsi+124]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rax,2251A3B3020
       mov       rbp,[rax]
       mov       [rsp+38],rbp
       mov       r14,[rdi+10]
       mov       rax,2253A3BFBC8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rsi,rsi
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
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       r15d,eax
       mov       [rsp+38],rbp
       test      ebx,ebx
       jle       short M01_L01
       cmp       ebx,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L03
       mov       ebx,r15d
       jmp       short M01_L05
M01_L03:
       test      edx,edx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       mov       rdx,[rsp+38]
       test      rdx,rdx
       je        short M01_L04
       cmp       dword ptr [rdx+8],0
       je        short M01_L04
       mov       rcx,[rsp+38]
       jmp       short M01_L04
M01_L04:
       mov       rdx,2251A3B3B80
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       cmp       qword ptr [r14+18],0
       je        short M01_L06
       mov       rcx,[r14+18]
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFEBCEF2C20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,rsi
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       cmp       qword ptr [r14+20],0
       je        short M01_L08
       mov       rcx,[r14+20]
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFEBCEF2CD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       mov       rdx,rsi
       mov       r8d,ebx
       call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 340
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
       mov       rdx,[rsi+100]
       mov       r8d,[rsi+124]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rax,1DD8C141028
       mov       rbp,[rax]
       mov       [rsp+38],rbp
       mov       r14,[rdi+10]
       mov       rax,1DD8C1443C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rsi,rsi
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
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       r15d,eax
       mov       [rsp+38],rbp
       test      ebx,ebx
       jle       short M01_L01
       cmp       ebx,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L03
       mov       ebx,r15d
       jmp       short M01_L05
M01_L03:
       test      edx,edx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       mov       rdx,[rsp+38]
       test      rdx,rdx
       je        short M01_L04
       cmp       dword ptr [rdx+8],0
       je        short M01_L04
       mov       rcx,[rsp+38]
       jmp       short M01_L04
M01_L04:
       mov       rdx,1DD8C143B80
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       cmp       qword ptr [r14+18],0
       je        short M01_L06
       mov       rcx,[r14+18]
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFEBCF02BD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,rsi
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       cmp       qword ptr [r14+20],0
       je        short M01_L08
       mov       rcx,[r14+20]
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFEBCF02C88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       mov       rdx,rsi
       mov       r8d,ebx
       call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 340
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
       mov       rdx,[rsi+100]
       mov       r8d,[rsi+124]
       mov       ecx,r8d
       shr       ecx,1F
       add       r8d,ecx
       sar       r8d,1
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rax,21A23BF3020
       mov       rbp,[rax]
       mov       [rsp+38],rbp
       mov       r14,[rdi+10]
       mov       rax,21A23C01FD8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rsi,rsi
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
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       r15d,eax
       mov       [rsp+38],rbp
       test      ebx,ebx
       jle       short M01_L01
       cmp       ebx,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L03
       mov       ebx,r15d
       jmp       short M01_L05
M01_L03:
       test      edx,edx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       mov       rdx,[rsp+38]
       test      rdx,rdx
       je        short M01_L04
       cmp       dword ptr [rdx+8],0
       je        short M01_L04
       mov       rcx,[rsp+38]
       jmp       short M01_L04
M01_L04:
       mov       rdx,21A03BF1770
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       cmp       qword ptr [r14+18],0
       je        short M01_L06
       mov       rcx,[r14+18]
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFEBCEF81E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,rsi
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       cmp       qword ptr [r14+20],0
       je        short M01_L08
       mov       rcx,[r14+20]
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFEBCEF8298
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       mov       rdx,rsi
       mov       r8d,ebx
       call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 340
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+108]
       test      rdi,rdi
       je        short M00_L00
       mov       ebx,[rdi+8]
       mov       ebp,ebx
       xor       ecx,ecx
       mov       [rsp+30],ecx
       lea       ecx,[rbp+0FFFF]
       mov       [rsp+28],ecx
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32 ByRef, Int32 ByRef)
       mov       edx,eax
       cmp       edx,ebp
       ja        short M00_L01
       mov       rcx,rdi
       mov       r8d,ebp
       sub       r8d,edx
       cmp       ebx,edx
       jb        short M00_L02
       mov       [rsp+38],rcx
       mov       [rsp+40],edx
       mov       [rsp+44],r8d
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer(!!0 ByRef)
       call      BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.ArraySegment`1[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ArraySegment`1<System.__Canon> ByRef)
       nop
       add       rsp,48
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
; Total bytes of code 170
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32 ByRef, Int32 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rdx,26136C07448
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
       mov       ecx,[rsi]
       mov       edx,[rdi]
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
; Total bytes of code 148
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+108]
       test      rdi,rdi
       je        short M00_L00
       mov       ebx,[rdi+8]
       mov       ebp,ebx
       xor       ecx,ecx
       mov       [rsp+30],ecx
       lea       ecx,[rbp+0FFFF]
       mov       [rsp+28],ecx
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32 ByRef, Int32 ByRef)
       mov       edx,eax
       cmp       edx,ebp
       ja        short M00_L01
       mov       rcx,rdi
       mov       r8d,ebp
       sub       r8d,edx
       cmp       ebx,edx
       jb        short M00_L02
       mov       [rsp+38],rcx
       mov       [rsp+40],edx
       mov       [rsp+44],r8d
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer(!!0 ByRef)
       call      BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.ArraySegment`1[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ArraySegment`1<System.__Canon> ByRef)
       nop
       add       rsp,48
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
; Total bytes of code 170
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32 ByRef, Int32 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rdx,14C9A4B9440
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
       mov       ecx,[rsi]
       mov       edx,[rdi]
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
; Total bytes of code 148
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+108]
       test      rdi,rdi
       je        short M00_L00
       mov       ebx,[rdi+8]
       mov       ebp,ebx
       xor       ecx,ecx
       mov       [rsp+30],ecx
       lea       ecx,[rbp+0FFFF]
       mov       [rsp+28],ecx
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32 ByRef, Int32 ByRef)
       mov       edx,eax
       cmp       edx,ebp
       ja        short M00_L01
       mov       rcx,rdi
       mov       r8d,ebp
       sub       r8d,edx
       cmp       ebx,edx
       jb        short M00_L02
       mov       [rsp+38],rcx
       mov       [rsp+40],edx
       mov       [rsp+44],r8d
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer(!!0 ByRef)
       call      BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.ArraySegment`1[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ArraySegment`1<System.__Canon> ByRef)
       nop
       add       rsp,48
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
; Total bytes of code 170
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32 ByRef, Int32 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rdx,21CB933B850
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
       mov       ecx,[rsi]
       mov       edx,[rdi]
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
; Total bytes of code 148
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+108]
       test      rdi,rdi
       je        short M00_L00
       mov       ebx,[rdi+8]
       mov       ebp,ebx
       xor       ecx,ecx
       mov       [rsp+30],ecx
       lea       ecx,[rbp+0FFFF]
       mov       [rsp+28],ecx
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32 ByRef, Int32 ByRef)
       mov       edx,eax
       cmp       edx,ebp
       ja        short M00_L01
       mov       rcx,rdi
       mov       r8d,ebp
       sub       r8d,edx
       cmp       ebx,edx
       jb        short M00_L02
       mov       [rsp+38],rcx
       mov       [rsp+40],edx
       mov       [rsp+44],r8d
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer(!!0 ByRef)
       call      BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.ArraySegment`1[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ArraySegment`1<System.__Canon> ByRef)
       nop
       add       rsp,48
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
; Total bytes of code 170
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32 ByRef, Int32 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rdx,180D82F9440
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
       mov       ecx,[rsi]
       mov       edx,[rdi]
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
; Total bytes of code 148
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+108]
       test      rdi,rdi
       je        short M00_L00
       mov       ebx,[rdi+8]
       mov       ebp,ebx
       xor       ecx,ecx
       mov       [rsp+30],ecx
       lea       ecx,[rbp+0FFFF]
       mov       [rsp+28],ecx
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32 ByRef, Int32 ByRef)
       mov       edx,eax
       cmp       edx,ebp
       ja        short M00_L01
       mov       rcx,rdi
       mov       r8d,ebp
       sub       r8d,edx
       cmp       ebx,edx
       jb        short M00_L02
       mov       [rsp+38],rcx
       mov       [rsp+40],edx
       mov       [rsp+44],r8d
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer(!!0 ByRef)
       call      BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.ArraySegment`1[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ArraySegment`1<System.__Canon> ByRef)
       nop
       add       rsp,48
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
; Total bytes of code 170
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32 ByRef, Int32 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rdx,17B70ACB850
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
       mov       ecx,[rsi]
       mov       edx,[rdi]
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
; Total bytes of code 148
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+108]
       test      rdi,rdi
       je        short M00_L00
       mov       ebx,[rdi+8]
       mov       ebp,ebx
       xor       ecx,ecx
       mov       [rsp+30],ecx
       lea       ecx,[rbp+0FFFF]
       mov       [rsp+28],ecx
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32 ByRef, Int32 ByRef)
       mov       edx,eax
       cmp       edx,ebp
       ja        short M00_L01
       mov       rcx,rdi
       mov       r8d,ebp
       sub       r8d,edx
       cmp       ebx,edx
       jb        short M00_L02
       mov       [rsp+38],rcx
       mov       [rsp+40],edx
       mov       [rsp+44],r8d
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer(!!0 ByRef)
       call      BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.ArraySegment`1[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ArraySegment`1<System.__Canon> ByRef)
       nop
       add       rsp,48
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
; Total bytes of code 170
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32 ByRef, Int32 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rdx,274B186B850
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
       mov       ecx,[rsi]
       mov       edx,[rdi]
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
; Total bytes of code 148
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+108]
       test      rdi,rdi
       je        short M00_L00
       mov       ebx,[rdi+8]
       mov       ebp,ebx
       xor       ecx,ecx
       mov       [rsp+30],ecx
       lea       ecx,[rbp+0FFFF]
       mov       [rsp+28],ecx
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32 ByRef, Int32 ByRef)
       mov       edx,eax
       cmp       edx,ebp
       ja        short M00_L01
       mov       rcx,rdi
       mov       r8d,ebp
       sub       r8d,edx
       cmp       ebx,edx
       jb        short M00_L02
       mov       [rsp+38],rcx
       mov       [rsp+40],edx
       mov       [rsp+44],r8d
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer(!!0 ByRef)
       call      BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.ArraySegment`1[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ArraySegment`1<System.__Canon> ByRef)
       nop
       add       rsp,48
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
; Total bytes of code 170
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32 ByRef, Int32 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rdx,2257D547448
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
       mov       ecx,[rsi]
       mov       edx,[rdi]
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
; Total bytes of code 148
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+108]
       test      rdi,rdi
       je        short M00_L00
       mov       ebx,[rdi+8]
       mov       ebp,ebx
       xor       ecx,ecx
       mov       [rsp+30],ecx
       lea       ecx,[rbp+0FFFF]
       mov       [rsp+28],ecx
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32 ByRef, Int32 ByRef)
       mov       edx,eax
       cmp       edx,ebp
       ja        short M00_L01
       mov       rcx,rdi
       mov       r8d,ebp
       sub       r8d,edx
       cmp       ebx,edx
       jb        short M00_L02
       mov       [rsp+38],rcx
       mov       [rsp+40],edx
       mov       [rsp+44],r8d
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer(!!0 ByRef)
       call      BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.ArraySegment`1[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ArraySegment`1<System.__Canon> ByRef)
       nop
       add       rsp,48
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
; Total bytes of code 170
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32 ByRef, Int32 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rdx,1F05F2CB850
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
       mov       ecx,[rsi]
       mov       edx,[rdi]
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
; Total bytes of code 148
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
; 			this.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r8,[rsi+18]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rcx,[rsi+10]
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,223217A3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,223017A15C8
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
       mov       rdx,7FFEBD0552D0
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
       mov       rdx,7FFEBD055830
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD055430
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,223217A3020
       mov       rbp,[rcx]
       mov       [rsp+38],rbp
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M03_L00
       mov       rcx,[r14+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF93848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r9,223017A2FD0
       mov       r9,[r9]
       lea       r8,[rsp+38]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       r15,rax
       cmp       qword ptr [r14+18],0
       je        short M03_L02
       mov       r11,[r14+18]
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF93868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       edi,eax
       mov       [rsp+30],rbp
       mov       rax,223017A3280
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L04:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       cmp       qword ptr [r14+28],0
       je        short M03_L05
       mov       r11,[r14+28]
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF93A20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,r15
       mov       edx,edi
       mov       r8,rbx
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 310
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r8,[rsi+18]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rcx,[rsi+10]
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2BDEB053020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2BDCB0515C8
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
       mov       rdx,7FFEBD025078
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
       mov       rdx,7FFEBD0255D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD0251D8
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,2BDEB053020
       mov       rbp,[rcx]
       mov       [rsp+38],rbp
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M03_L00
       mov       rcx,[r14+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF63848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r9,2BDEB061FD8
       mov       r9,[r9]
       lea       r8,[rsp+38]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       r15,rax
       cmp       qword ptr [r14+18],0
       je        short M03_L02
       mov       r11,[r14+18]
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF63868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       edi,eax
       mov       [rsp+30],rbp
       mov       rax,2BDEB062288
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L04:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       cmp       qword ptr [r14+28],0
       je        short M03_L05
       mov       r11,[r14+28]
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF63A20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,r15
       mov       edx,edi
       mov       r8,rbx
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 310
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r8,[rsi+18]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rcx,[rsi+10]
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,167C1C41028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,167C1C47E70
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
       mov       rdx,7FFEBD0153F0
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
       mov       rdx,7FFEBD015950
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD015550
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,167C1C41028
       mov       rbp,[rcx]
       mov       [rsp+38],rbp
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M03_L00
       mov       rcx,[r14+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF537E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r9,167A1C417A0
       mov       r9,[r9]
       lea       r8,[rsp+38]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       r15,rax
       cmp       qword ptr [r14+18],0
       je        short M03_L02
       mov       r11,[r14+18]
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF53800
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       edi,eax
       mov       [rsp+30],rbp
       mov       rax,167A1C41A50
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L04:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       cmp       qword ptr [r14+28],0
       je        short M03_L05
       mov       r11,[r14+28]
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF539B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,r15
       mov       edx,edi
       mov       r8,rbx
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 310
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r8,[rsi+18]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rcx,[rsi+10]
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1404F1B3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1402F1BD9F8
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
       mov       rdx,7FFEBD023550
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
       mov       rdx,7FFEBD023AB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD0236B0
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,1404F1B3020
       mov       rbp,[rcx]
       mov       [rsp+38],rbp
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M03_L00
       mov       rcx,[r14+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF63848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r9,1404F1B5BA8
       mov       r9,[r9]
       lea       r8,[rsp+38]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       r15,rax
       cmp       qword ptr [r14+18],0
       je        short M03_L02
       mov       r11,[r14+18]
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF63868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       edi,eax
       mov       [rsp+30],rbp
       mov       rax,1404F1B5E58
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L04:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       cmp       qword ptr [r14+28],0
       je        short M03_L05
       mov       r11,[r14+28]
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF63A20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,r15
       mov       edx,edi
       mov       r8,rbx
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 310
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r8,[rsi+18]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rcx,[rsi+10]
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1F3CAF91028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1F39AF915C8
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
       mov       rdx,7FFEBD045470
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
       mov       rdx,7FFEBD0459D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD0455D0
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,1F3CAF91028
       mov       rbp,[rcx]
       mov       [rsp+38],rbp
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M03_L00
       mov       rcx,[r14+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF83848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r9,1F39AF92FD0
       mov       r9,[r9]
       lea       r8,[rsp+38]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       r15,rax
       cmp       qword ptr [r14+18],0
       je        short M03_L02
       mov       r11,[r14+18]
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF83868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       edi,eax
       mov       [rsp+30],rbp
       mov       rax,1F39AF93280
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L04:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       cmp       qword ptr [r14+28],0
       je        short M03_L05
       mov       r11,[r14+28]
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF83A20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,r15
       mov       edx,edi
       mov       r8,rbx
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 310
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r8,[rsi+18]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rcx,[rsi+10]
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,20C6EE93020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,20C6EE959D0
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
       mov       rdx,7FFEBD013350
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
       mov       rdx,7FFEBD0138B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD0134B0
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,20C6EE93020
       mov       rbp,[rcx]
       mov       [rsp+38],rbp
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M03_L00
       mov       rcx,[r14+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF537E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r9,20C9EE927B8
       mov       r9,[r9]
       lea       r8,[rsp+38]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       r15,rax
       cmp       qword ptr [r14+18],0
       je        short M03_L02
       mov       r11,[r14+18]
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF53800
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       edi,eax
       mov       [rsp+30],rbp
       mov       rax,20C9EE92A68
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L04:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       cmp       qword ptr [r14+28],0
       je        short M03_L05
       mov       r11,[r14+28]
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF539B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,r15
       mov       edx,edi
       mov       r8,rbx
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 310
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r8,[rsi+18]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rcx,[rsi+10]
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,26C82631028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,26C526315C8
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
       mov       rdx,7FFEBD033390
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
       mov       rdx,7FFEBD0338F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD0334F0
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,26C82631028
       mov       rbp,[rcx]
       mov       [rsp+38],rbp
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M03_L00
       mov       rcx,[r14+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF737F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r9,26C52631FB8
       mov       r9,[r9]
       lea       r8,[rsp+38]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       r15,rax
       cmp       qword ptr [r14+18],0
       je        short M03_L02
       mov       r11,[r14+18]
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF73818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       edi,eax
       mov       [rsp+30],rbp
       mov       rax,26C52632268
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L04:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       cmp       qword ptr [r14+28],0
       je        short M03_L05
       mov       r11,[r14+28]
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF739D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,r15
       mov       edx,edi
       mov       r8,rbx
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 310
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.AddLastToList()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r8,[rsi+18]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.AddLast(System.Collections.Generic.IList`1<!!0>, !!0)
       call      DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rcx,[rsi+10]
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1C721253020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1C7012535C0
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
       mov       rdx,7FFEBD04EB70
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
       mov       rdx,7FFEBD04F0D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD04ECD0
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,1C721253020
       mov       rbp,[rcx]
       mov       [rsp+38],rbp
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M03_L00
       mov       rcx,[r14+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBD0117F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r9,1C721254BC8
       mov       r9,[r9]
       lea       r8,[rsp+38]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       r15,rax
       cmp       qword ptr [r14+18],0
       je        short M03_L02
       mov       r11,[r14+18]
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBD011818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       edi,eax
       mov       [rsp+30],rbp
       mov       rax,1C721254E78
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L04:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       cmp       qword ptr [r14+28],0
       je        short M03_L05
       mov       r11,[r14+28]
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBD0119D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,r15
       mov       edx,edi
       mov       r8,rbx
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 310
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
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
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
       cmp       qword ptr [rbp+18],0
       je        short M01_L00
       cmp       qword ptr [rbp+20],0
       jne       short M01_L01
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
; Total bytes of code 210
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
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
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
       cmp       qword ptr [rbp+18],0
       je        short M01_L00
       cmp       qword ptr [rbp+20],0
       jne       short M01_L01
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
; Total bytes of code 210
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
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
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
       cmp       qword ptr [rbp+18],0
       je        short M01_L00
       cmp       qword ptr [rbp+20],0
       jne       short M01_L01
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
; Total bytes of code 210
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
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
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
       cmp       qword ptr [rbp+18],0
       je        short M01_L00
       cmp       qword ptr [rbp+20],0
       jne       short M01_L01
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
; Total bytes of code 210
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
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
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
       cmp       qword ptr [rbp+18],0
       je        short M01_L00
       cmp       qword ptr [rbp+20],0
       jne       short M01_L01
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
; Total bytes of code 210
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
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
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
       cmp       qword ptr [rbp+18],0
       je        short M01_L00
       cmp       qword ptr [rbp+20],0
       jne       short M01_L01
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
; Total bytes of code 210
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
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
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
       cmp       qword ptr [rbp+18],0
       je        short M01_L00
       cmp       qword ptr [rbp+20],0
       jne       short M01_L01
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
; Total bytes of code 210
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
       mov       rdx,[rsi+100]
       mov       r8,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
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
       cmp       qword ptr [rbp+18],0
       je        short M01_L00
       cmp       qword ptr [rbp+20],0
       jne       short M01_L01
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
; Total bytes of code 210
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
       mov       rdx,[rsi+100]
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
       mov       rdx,[rsi+10]
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,21136851028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,211368539D8
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
       mov       rdx,7FFEBD053658
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
       mov       rdx,7FFEBD053BB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD0537B8
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
       mov       rdx,7FFEBCF93E90
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
       mov       rdx,7FFEBCF93E90
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
       mov       rdx,7FFEBCF943E0
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
       mov       rdx,7FFEBCF93E90
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
       mov       rdx,[rsi+100]
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
       mov       rdx,[rsi+10]
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,24AA54B3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,24A854B15C8
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
       mov       rdx,7FFEBD033618
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
       mov       rdx,7FFEBD033B78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD033778
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
       mov       rdx,7FFEBCF73E90
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
       mov       rdx,7FFEBCF73E90
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
       mov       rdx,7FFEBCF743E0
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
       mov       rdx,7FFEBCF73E90
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
       mov       rdx,[rsi+100]
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
       mov       rdx,[rsi+10]
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,25F96E91028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,25F96E939D8
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
       mov       rdx,7FFEBD045E68
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
       mov       rdx,7FFEBD0463C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD045FC8
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
       mov       rdx,7FFEBCF83EF8
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
       mov       rdx,7FFEBCF83EF8
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
       mov       rdx,7FFEBCF84448
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
       mov       rdx,7FFEBCF83EF8
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
       mov       rdx,[rsi+100]
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
       mov       rdx,[rsi+10]
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,225FF0B1028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,225FF0B39D8
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
       mov       rdx,7FFEBD015850
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
       mov       rdx,7FFEBD015DB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD0159B0
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
       mov       rdx,7FFEBCF53EF8
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
       mov       rdx,7FFEBCF53EF8
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
       mov       rdx,7FFEBCF54448
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
       mov       rdx,7FFEBCF53EF8
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
       mov       rdx,[rsi+100]
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
       mov       rdx,[rsi+10]
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2027C253020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2027C261E00
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
       mov       rdx,7FFEBD025E68
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
       mov       rdx,7FFEBD0263C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD025FC8
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
       mov       rdx,7FFEBCF63EF8
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
       mov       rdx,7FFEBCF63EF8
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
       mov       rdx,7FFEBCF64448
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
       mov       rdx,7FFEBCF63EF8
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
       mov       rdx,[rsi+100]
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
       mov       rdx,[rsi+10]
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2AC03FE1028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2ABD3FE15C8
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
       mov       rdx,7FFEBD033CE8
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
       mov       rdx,7FFEBD034248
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD033E48
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
       mov       rdx,7FFEBCF73EF8
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
       mov       rdx,7FFEBCF73EF8
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
       mov       rdx,7FFEBCF74448
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
       mov       rdx,7FFEBCF73EF8
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
       mov       rdx,[rsi+100]
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
       mov       rdx,[rsi+10]
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2507D511028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2507D5139D8
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
       mov       rdx,7FFEBD026628
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
       mov       rdx,7FFEBD026B88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD026788
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
       mov       rdx,7FFEBCF63F10
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
       mov       rdx,7FFEBCF63F10
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
       mov       rdx,7FFEBCF64460
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
       mov       rdx,7FFEBCF63F10
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
       mov       rdx,[rsi+100]
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
       mov       rdx,[rsi+10]
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,17AFFAC3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,17AFFAD1E00
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
       mov       rdx,7FFEBD01EFC8
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
       mov       rdx,7FFEBD01F528
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD01F128
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
       mov       rdx,7FFEBCFE1F10
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
       mov       rdx,7FFEBCFE1F10
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
       mov       rdx,7FFEBCFE2460
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
       mov       rdx,7FFEBCFE1F10
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
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
       mov       rdx,7FFEBCF16390
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
       mov       rdx,7FFEBCF168F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF164F0
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
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,257C5A83020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF120E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,257E5A817A0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF12520
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rdi,rdi
       je        short M02_L04
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 180
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
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
       mov       rdx,7FFEBCF06390
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
       mov       rdx,7FFEBCF068F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF064F0
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
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,23A4BF23020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF020E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,23A4BF31FD8
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02520
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rdi,rdi
       je        short M02_L04
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 180
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
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
       mov       rdx,7FFEBCF16390
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
       mov       rdx,7FFEBCF168F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF164F0
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
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,1E805333020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF120E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,1E805342FF0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF12520
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rdi,rdi
       je        short M02_L04
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 180
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
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
       mov       rdx,7FFEBCF06390
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
       mov       rdx,7FFEBCF068F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF064F0
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
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,21875D23020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF020E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,21875D263C0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02520
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rdi,rdi
       je        short M02_L04
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 180
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
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
       mov       rdx,7FFEBCF16390
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
       mov       rdx,7FFEBCF168F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF164F0
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
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,27101513020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF120E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,270E1512FD0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF12520
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rdi,rdi
       je        short M02_L04
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 180
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
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
       mov       rdx,7FFEBCEF6390
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
       mov       rdx,7FFEBCEF68F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF64F0
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
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,2378ACA3020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF20E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,237AACAEBE8
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF2520
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rdi,rdi
       je        short M02_L04
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 180
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
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
       mov       rdx,7FFEBCF062D8
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
       mov       rdx,7FFEBCF06838
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCF06438
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
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,15AE68C3020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF020C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,15AE68D3808
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rdi,rdi
       je        short M02_L04
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 180
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.CopyToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
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
       mov       rdx,7FFEBCFB10D0
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
       mov       rdx,7FFEBCFB1630
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCFB1230
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
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,11E12223020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF9B1F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,11E12232FF0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF9B630
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rdi,rdi
       je        short M02_L04
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       ecx,14
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 180
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
       mov       rcx,[rsi+100]
       cmp       [rcx],ecx
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       rdx,[rsi+10]
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
       mov       rcx,[rsi+100]
       cmp       [rcx],ecx
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       rdx,[rsi+10]
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
       mov       rcx,[rsi+100]
       cmp       [rcx],ecx
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       rdx,[rsi+10]
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
       mov       rcx,[rsi+100]
       cmp       [rcx],ecx
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       rdx,[rsi+10]
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
       mov       rcx,[rsi+100]
       cmp       [rcx],ecx
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       rdx,[rsi+10]
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
       mov       rcx,[rsi+100]
       cmp       [rcx],ecx
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       rdx,[rsi+10]
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
       mov       rcx,[rsi+100]
       cmp       [rcx],ecx
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       rdx,[rsi+10]
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
       mov       rcx,[rsi+100]
       cmp       [rcx],ecx
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       rdx,[rsi+10]
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
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rsi,[rsi+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 82
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
       mov       rax,28B55193020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,28B351915C8
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
       mov       rdx,7FFEBD022D68
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
       mov       rdx,7FFEBD0232C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD022EC8
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
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rcx
       mov       rsi,rdx
       mov       rdx,28B55193020
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rdx,7FFEBCF63C68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M03_L01:
       lea       r8,[rsp+30]
       lea       r9,[rsp+28]
       mov       rcx,rdx
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M03_L02
       xor       eax,eax
       add       rsp,40
       pop       rsi
       ret
M03_L02:
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 126
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems01()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rsi,[rsi+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 82
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
       mov       rax,1DEB6E63020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1DE96E615C8
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
       mov       rdx,7FFEBD056278
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
       mov       rdx,7FFEBD0567D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD0563D8
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
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rcx
       mov       rsi,rdx
       mov       rdx,1DEB6E63020
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rdx,7FFEBCF93C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M03_L01:
       lea       r8,[rsp+30]
       lea       r9,[rsp+28]
       mov       rcx,rdx
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M03_L02
       xor       eax,eax
       add       rsp,40
       pop       rsi
       ret
M03_L02:
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 126
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems01()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rsi,[rsi+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 82
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
       mov       rax,23B544E1028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,23B344E35C0
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
       mov       rdx,7FFEBD043318
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
       mov       rdx,7FFEBD043878
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD043478
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
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rcx
       mov       rsi,rdx
       mov       rdx,23B544E1028
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rdx,7FFEBCF83C68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M03_L01:
       lea       r8,[rsp+30]
       lea       r9,[rsp+28]
       mov       rcx,rdx
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M03_L02
       xor       eax,eax
       add       rsp,40
       pop       rsi
       ret
M03_L02:
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 126
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems01()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rsi,[rsi+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 82
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
       mov       rax,279B1EF1028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,279B1EFFE08
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
       mov       rdx,7FFEBD015400
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
       mov       rdx,7FFEBD015960
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD015560
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
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rcx
       mov       rsi,rdx
       mov       rdx,279B1EF1028
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rdx,7FFEBCF53C68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M03_L01:
       lea       r8,[rsp+30]
       lea       r9,[rsp+28]
       mov       rcx,rdx
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M03_L02
       xor       eax,eax
       add       rsp,40
       pop       rsi
       ret
M03_L02:
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 126
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems01()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rsi,[rsi+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 82
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
       mov       rax,244D2693020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,244B26915C8
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
       mov       rdx,7FFEBD023338
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
       mov       rdx,7FFEBD023898
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD023498
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
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rcx
       mov       rsi,rdx
       mov       rdx,244D2693020
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rdx,7FFEBCF63C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M03_L01:
       lea       r8,[rsp+30]
       lea       r9,[rsp+28]
       mov       rcx,rdx
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M03_L02
       xor       eax,eax
       add       rsp,40
       pop       rsi
       ret
M03_L02:
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 126
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems01()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rsi,[rsi+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 82
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
       mov       rax,1ECBBC73020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1ECBBC759D0
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
       mov       rdx,7FFEBD0232F8
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
       mov       rdx,7FFEBD023858
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD023458
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
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rcx
       mov       rsi,rdx
       mov       rdx,1ECBBC73020
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rdx,7FFEBCF63C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M03_L01:
       lea       r8,[rsp+30]
       lea       r9,[rsp+28]
       mov       rcx,rdx
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M03_L02
       xor       eax,eax
       add       rsp,40
       pop       rsi
       ret
M03_L02:
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 126
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems01()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rsi,[rsi+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 82
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
       mov       rax,1B925B61028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1B925B6FE08
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
       mov       rdx,7FFEBD0137E8
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
       mov       rdx,7FFEBD013D48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD013948
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
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rcx
       mov       rsi,rdx
       mov       rdx,1B925B61028
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rdx,7FFEBCF53C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M03_L01:
       lea       r8,[rsp+30]
       lea       r9,[rsp+28]
       mov       rcx,rdx
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M03_L02
       xor       eax,eax
       add       rsp,40
       pop       rsi
       ret
M03_L02:
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 126
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark.HasItems01()
; 			var people = base.GetPersonProperArray().ToList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rsi,[rsi+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 82
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
       mov       rax,21F96FF3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,21F96FF59D0
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
       mov       rdx,7FFEBD02E688
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
       mov       rdx,7FFEBD02EBE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L03
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD02E7E8
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
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rcx
       mov       rsi,rdx
       mov       rdx,21F96FF3020
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rdx,7FFEBCFF1C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M03_L01:
       lea       r8,[rsp+30]
       lea       r9,[rsp+28]
       mov       rcx,rdx
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M03_L02
       xor       eax,eax
       add       rsp,40
       pop       rsi
       ret
M03_L02:
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 126
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
       mov       rdi,[rsi+100]
       mov       rdx,[rsi+100]
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
       mov       rdx,[rsi+10]
       mov       [rdx+40],eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 116
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
       mov       rax,2BC30DE1028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2BC30DEFE08
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
       mov       rdx,7FFEBD056EB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L00
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBD057400
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
       mov       r11,7FFEBC9A0700
       call      qword ptr [7FFEBCFC0700]
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
       mov       rdx,7FFEBD0571F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC9A0708
       call      qword ptr [7FFEBCFC0708]
       test      eax,eax
       jne       short M02_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC9A0710
       call      qword ptr [7FFEBCFC0710]
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
       mov       rdx,7FFEBD0570A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBD0573D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L06
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBD0573E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBD0571D8
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
       mov       r11,7FFEBC9A0710
       call      qword ptr [7FFEBCFC0710]
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,2BC30DE1028
       mov       rbp,[rcx]
       mov       [rsp+40],rbp
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF937A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r9,2BC30DF07F8
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       [rsp+38],rbp
       mov       rax,2BC30DF0AA8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M03_L03
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF93970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rbp,rax
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF93A10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L06:
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9,rbp
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 303
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
       mov       rdi,[rsi+100]
       mov       rdx,[rsi+100]
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
       mov       rdx,[rsi+10]
       mov       [rdx+40],eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 116
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
       mov       rax,249AA293020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,249AA2959D0
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
       mov       rdx,7FFEBD0391C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L00
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBD039710
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
       mov       r11,7FFEBC980700
       call      qword ptr [7FFEBCFA0700]
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
       mov       rdx,7FFEBD039500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC980708
       call      qword ptr [7FFEBCFA0708]
       test      eax,eax
       jne       short M02_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC980710
       call      qword ptr [7FFEBCFA0710]
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
       mov       rdx,7FFEBD0393B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBD0396E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L06
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBD0396F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBD0394E8
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
       mov       r11,7FFEBC980710
       call      qword ptr [7FFEBCFA0710]
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,249AA293020
       mov       rbp,[rcx]
       mov       [rsp+40],rbp
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF737A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r9,249CA2927B8
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       [rsp+38],rbp
       mov       rax,249CA292A68
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M03_L03
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF73970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rbp,rax
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF73A10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L06:
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9,rbp
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 303
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
       mov       rdi,[rsi+100]
       mov       rdx,[rsi+100]
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
       mov       rdx,[rsi+10]
       mov       [rdx+40],eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 116
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
       mov       rax,25B011F1028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,25AE11F35C0
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
       mov       rdx,7FFEBD027508
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L00
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBD027A50
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
       mov       r11,7FFEBC970718
       call      qword ptr [7FFEBCF90718]
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
       mov       rdx,7FFEBD027840
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC970720
       call      qword ptr [7FFEBCF90720]
       test      eax,eax
       jne       short M02_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC970728
       call      qword ptr [7FFEBCF90728]
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
       mov       rdx,7FFEBD0276F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBD027A20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L06
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBD027A38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBD027828
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
       mov       r11,7FFEBC970728
       call      qword ptr [7FFEBCF90728]
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,25B011F1028
       mov       rbp,[rcx]
       mov       [rsp+40],rbp
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF63810
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r9,25B011FFFE0
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       [rsp+38],rbp
       mov       rax,25B01200290
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M03_L03
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF639D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rbp,rax
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF63A78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L06:
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9,rbp
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 303
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
       mov       rdi,[rsi+100]
       mov       rdx,[rsi+100]
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
       mov       rdx,[rsi+10]
       mov       [rdx+40],eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 116
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
       mov       rax,1BBC97B3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1BBD97B15C8
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
       mov       rdx,7FFEBD017570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L00
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBD017AB8
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
       mov       r11,7FFEBC960710
       call      qword ptr [7FFEBCF80710]
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
       mov       rdx,7FFEBD0178A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC960718
       call      qword ptr [7FFEBCF80718]
       test      eax,eax
       jne       short M02_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC960720
       call      qword ptr [7FFEBCF80720]
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
       mov       rdx,7FFEBD017760
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBD017A88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L06
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBD017AA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBD017890
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
       mov       r11,7FFEBC960720
       call      qword ptr [7FFEBCF80720]
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,1BBC97B3020
       mov       rbp,[rcx]
       mov       [rsp+40],rbp
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF53810
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r9,1BBC97B5BA8
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       [rsp+38],rbp
       mov       rax,1BBC97B5E58
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M03_L03
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF539D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rbp,rax
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF53A78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L06:
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9,rbp
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 303
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
       mov       rdi,[rsi+100]
       mov       rdx,[rsi+100]
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
       mov       rdx,[rsi+10]
       mov       [rdx+40],eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 116
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
       mov       rax,1A8F14C3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1A8D14C15C8
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
       mov       rdx,7FFEBD04A510
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L00
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBD04AA58
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
       mov       r11,7FFEBC990730
       call      qword ptr [7FFEBCFB0730]
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
       mov       rdx,7FFEBD04A848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC990738
       call      qword ptr [7FFEBCFB0738]
       test      eax,eax
       jne       short M02_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC990740
       call      qword ptr [7FFEBCFB0740]
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
       mov       rdx,7FFEBD04A700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBD04AA28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L06
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBD04AA40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBD04A830
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
       mov       r11,7FFEBC990740
       call      qword ptr [7FFEBCFB0740]
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,1A8F14C3020
       mov       rbp,[rcx]
       mov       [rsp+40],rbp
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF83810
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r9,1A8F14D2FF0
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       [rsp+38],rbp
       mov       rax,1A8F14D32A0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M03_L03
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF839D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rbp,rax
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF83A78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L06:
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9,rbp
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 303
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
       mov       rdi,[rsi+100]
       mov       rdx,[rsi+100]
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
       mov       rdx,[rsi+10]
       mov       [rdx+40],eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 116
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
       mov       rax,163453B1028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,163153B15C8
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
       mov       rdx,7FFEBD059680
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L00
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBD059BC8
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
       mov       r11,7FFEBC9A0718
       call      qword ptr [7FFEBCFC0718]
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
       mov       rdx,7FFEBD0599B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC9A0720
       call      qword ptr [7FFEBCFC0720]
       test      eax,eax
       jne       short M02_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC9A0728
       call      qword ptr [7FFEBCFC0728]
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
       mov       rdx,7FFEBD059870
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBD059B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L06
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBD059BB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBD0599A0
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
       mov       r11,7FFEBC9A0728
       call      qword ptr [7FFEBCFC0728]
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,163453B1028
       mov       rbp,[rcx]
       mov       [rsp+40],rbp
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF93810
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r9,163353BFBC8
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       [rsp+38],rbp
       mov       rax,163353BFE78
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M03_L03
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF939D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rbp,rax
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF93A78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L06:
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9,rbp
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 303
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
       mov       rdi,[rsi+100]
       mov       rdx,[rsi+100]
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
       mov       rdx,[rsi+10]
       mov       [rdx+40],eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 116
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
       mov       rax,1C17C2C1028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1C17C2C39D8
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
       mov       rdx,7FFEBD04A7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L00
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBD04AD08
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
       mov       r11,7FFEBC990730
       call      qword ptr [7FFEBCFB0730]
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
       mov       rdx,7FFEBD04AAF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC990738
       call      qword ptr [7FFEBCFB0738]
       test      eax,eax
       jne       short M02_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC990740
       call      qword ptr [7FFEBCFB0740]
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
       mov       rdx,7FFEBD04A9B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBD04ACD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L06
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBD04ACF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBD04AAE0
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
       mov       r11,7FFEBC990740
       call      qword ptr [7FFEBCFB0740]
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,1C17C2C1028
       mov       rbp,[rcx]
       mov       [rsp+40],rbp
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF83828
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r9,1C17C2C43C8
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       [rsp+38],rbp
       mov       rax,1C17C2C4678
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M03_L03
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF839F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rbp,rax
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBCF83A90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L06:
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9,rbp
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 303
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
       mov       rdi,[rsi+100]
       mov       rdx,[rsi+100]
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
       mov       rdx,[rsi+10]
       mov       [rdx+40],eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 116
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
       mov       rax,245B11B3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,245B11B59D0
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
       mov       rdx,7FFEBD052B48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L00
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBD053090
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
       mov       r11,7FFEBC980888
       call      qword ptr [7FFEBCF60888]
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
       mov       rdx,7FFEBD052E80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC980890
       call      qword ptr [7FFEBCF60890]
       test      eax,eax
       jne       short M02_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC980898
       call      qword ptr [7FFEBCF60898]
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
       mov       rdx,7FFEBD052D38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBD053060
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L06
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBD053078
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L07
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBD052E68
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
       mov       r11,7FFEBC980898
       call      qword ptr [7FFEBCF60898]
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,245B11B3020
       mov       rbp,[rcx]
       mov       [rsp+40],rbp
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBD001828
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       r9,245E11BDBD0
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       [rsp+38],rbp
       mov       rax,245E11BDE80
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M03_L03
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBD0019F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rbp,rax
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFEBD001A90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L06:
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9,rbp
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IndexOf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 303
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
       mov       rbx,[rsi+100]
       mov       rdx,[rsi+108]
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
       mov       rdx,[rsi+10]
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
       mov       rdx,7FFEBCF29BB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF2A100
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
       mov       r11,7FFEBC990688
       call      qword ptr [7FFEBCF40688]
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
       mov       rdx,7FFEBCF29EF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC990690
       call      qword ptr [7FFEBCF40690]
       test      eax,eax
       jne       short M01_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC990698
       call      qword ptr [7FFEBCF40698]
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
       mov       rdx,7FFEBCF29DA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCF2A0D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCF2A0E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCF29ED8
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
       mov       r11,7FFEBC990698
       call      qword ptr [7FFEBCF40698]
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
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
       mov       rdx,7FFEBCF221E8
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
       mov       rcx,1F25DF13020
       mov       rbx,[rcx]
       mov       [rsp+48],rbx
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF22210
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,1F23DF11FB8
       mov       r9,[r9]
       lea       r8,[rsp+48]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rbp,[r15+10]
       mov       [rsp+48],rbx
       mov       rax,1F23DF12258
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L04:
       xor       edx,edx
       mov       [rsp+38],rdx
       lea       rcx,[r15+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[r15+8]
       mov       [rsp+48],rbx
       mov       rax,1F23DF12260
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L05:
       xor       edx,edx
       mov       [rsp+28],rdx
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
       mov       rdx,7FFEBCF226B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass17_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
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
       mov       rdx,7FFEBCF22820
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
       mov       rdx,7FFEBCF22B80
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
       mov       rdx,7FFEBCF22B80
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__17`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__17_1(Int32)
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
       mov       rdx,7FFEBCF22B80
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
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L17:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 788
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
       mov       rbx,[rsi+100]
       mov       rdx,[rsi+108]
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
       mov       rdx,[rsi+10]
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
       mov       rdx,7FFEBCF19BB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF1A100
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
       mov       r11,7FFEBC980688
       call      qword ptr [7FFEBCF30688]
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
       mov       rdx,7FFEBCF19EF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC980690
       call      qword ptr [7FFEBCF30690]
       test      eax,eax
       jne       short M01_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC980698
       call      qword ptr [7FFEBCF30698]
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
       mov       rdx,7FFEBCF19DA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCF1A0D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCF1A0E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCF19ED8
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
       mov       r11,7FFEBC980698
       call      qword ptr [7FFEBCF30698]
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
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
       mov       rdx,7FFEBCF121E8
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
       mov       rcx,1C73F273020
       mov       rbx,[rcx]
       mov       [rsp+48],rbx
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF12210
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,1C73F282FF0
       mov       r9,[r9]
       lea       r8,[rsp+48]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rbp,[r15+10]
       mov       [rsp+48],rbx
       mov       rax,1C73F283290
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L04:
       xor       edx,edx
       mov       [rsp+38],rdx
       lea       rcx,[r15+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[r15+8]
       mov       [rsp+48],rbx
       mov       rax,1C73F283298
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L05:
       xor       edx,edx
       mov       [rsp+28],rdx
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
       mov       rdx,7FFEBCF126B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass17_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
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
       mov       rdx,7FFEBCF12820
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
       mov       rdx,7FFEBCF12B80
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
       mov       rdx,7FFEBCF12B80
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__17`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__17_1(Int32)
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
       mov       rdx,7FFEBCF12B80
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
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L17:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 788
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
       mov       rbx,[rsi+100]
       mov       rdx,[rsi+108]
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
       mov       rdx,[rsi+10]
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
       mov       rdx,7FFEBCEF97E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF9D28
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
       mov       r11,7FFEBC960688
       call      qword ptr [7FFEBCF10688]
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
       mov       rdx,7FFEBCEF9B18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC960690
       call      qword ptr [7FFEBCF10690]
       test      eax,eax
       jne       short M01_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC960698
       call      qword ptr [7FFEBCF10698]
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
       mov       rdx,7FFEBCEF99D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF9CF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF9D10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF9B00
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
       mov       r11,7FFEBC960698
       call      qword ptr [7FFEBCF10698]
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
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
       mov       rdx,7FFEBCEF21E8
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
       mov       rcx,1F5283D3020
       mov       rbx,[rcx]
       mov       [rsp+48],rbx
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF2210
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,1F5483D17A0
       mov       r9,[r9]
       lea       r8,[rsp+48]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rbp,[r15+10]
       mov       [rsp+48],rbx
       mov       rax,1F5483D1A40
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L04:
       xor       edx,edx
       mov       [rsp+38],rdx
       lea       rcx,[r15+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[r15+8]
       mov       [rsp+48],rbx
       mov       rax,1F5483D1A48
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L05:
       xor       edx,edx
       mov       [rsp+28],rdx
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
       mov       rdx,7FFEBCEF26B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass17_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
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
       mov       rdx,7FFEBCEF2820
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
       mov       rdx,7FFEBCEF2B80
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
       mov       rdx,7FFEBCEF2B80
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__17`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__17_1(Int32)
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
       mov       rdx,7FFEBCEF2B80
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
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L17:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 788
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
       mov       rbx,[rsi+100]
       mov       rdx,[rsi+108]
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
       mov       rdx,[rsi+10]
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
       mov       rdx,7FFEBCEF9780
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF9CC8
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
       mov       r11,7FFEBC960688
       call      qword ptr [7FFEBCF10688]
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
       mov       rdx,7FFEBCEF9AB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC960690
       call      qword ptr [7FFEBCF10690]
       test      eax,eax
       jne       short M01_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC960698
       call      qword ptr [7FFEBCF10698]
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
       mov       rdx,7FFEBCEF9970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF9C98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF9CB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF9AA0
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
       mov       r11,7FFEBC960698
       call      qword ptr [7FFEBCF10698]
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
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
       mov       rdx,7FFEBCEF21E8
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
       mov       rcx,1FB33943020
       mov       rbx,[rcx]
       mov       [rsp+48],rbx
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF2210
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,1FB439427B8
       mov       r9,[r9]
       lea       r8,[rsp+48]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rbp,[r15+10]
       mov       [rsp+48],rbx
       mov       rax,1FB43942A58
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L04:
       xor       edx,edx
       mov       [rsp+38],rdx
       lea       rcx,[r15+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[r15+8]
       mov       [rsp+48],rbx
       mov       rax,1FB43942A60
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L05:
       xor       edx,edx
       mov       [rsp+28],rdx
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
       mov       rdx,7FFEBCEF26B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass17_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
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
       mov       rdx,7FFEBCEF2820
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
       mov       rdx,7FFEBCEF2B80
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
       mov       rdx,7FFEBCEF2B80
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__17`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__17_1(Int32)
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
       mov       rdx,7FFEBCEF2B80
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
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L17:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 788
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
       mov       rbx,[rsi+100]
       mov       rdx,[rsi+108]
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
       mov       rdx,[rsi+10]
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
       mov       rdx,7FFEBCF397E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF39D28
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
       mov       r11,7FFEBC9A0688
       call      qword ptr [7FFEBCF50688]
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
       mov       rdx,7FFEBCF39B18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC9A0690
       call      qword ptr [7FFEBCF50690]
       test      eax,eax
       jne       short M01_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC9A0698
       call      qword ptr [7FFEBCF50698]
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
       mov       rdx,7FFEBCF399D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCF39CF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCF39D10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCF39B00
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
       mov       r11,7FFEBC9A0698
       call      qword ptr [7FFEBCF50698]
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
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
       mov       rdx,7FFEBCF321E8
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
       mov       rcx,237202F3020
       mov       rbx,[rcx]
       mov       [rsp+48],rbx
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF32210
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,237402FEBE8
       mov       r9,[r9]
       lea       r8,[rsp+48]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rbp,[r15+10]
       mov       [rsp+48],rbx
       mov       rax,237402FEE88
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L04:
       xor       edx,edx
       mov       [rsp+38],rdx
       lea       rcx,[r15+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[r15+8]
       mov       [rsp+48],rbx
       mov       rax,237402FEE90
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L05:
       xor       edx,edx
       mov       [rsp+28],rdx
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
       mov       rdx,7FFEBCF326B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass17_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
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
       mov       rdx,7FFEBCF32820
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
       mov       rdx,7FFEBCF32B80
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
       mov       rdx,7FFEBCF32B80
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__17`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__17_1(Int32)
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
       mov       rdx,7FFEBCF32B80
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
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L17:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 788
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
       mov       rbx,[rsi+100]
       mov       rdx,[rsi+108]
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
       mov       rdx,[rsi+10]
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
       mov       rdx,7FFEBCF09780
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF09CC8
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
       mov       r11,7FFEBC970688
       call      qword ptr [7FFEBCF20688]
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
       mov       rdx,7FFEBCF09AB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC970690
       call      qword ptr [7FFEBCF20690]
       test      eax,eax
       jne       short M01_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC970698
       call      qword ptr [7FFEBCF20698]
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
       mov       rdx,7FFEBCF09970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCF09C98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCF09CB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCF09AA0
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
       mov       r11,7FFEBC970698
       call      qword ptr [7FFEBCF20698]
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
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
       mov       rdx,7FFEBCF021E8
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
       mov       rcx,1D47CC23020
       mov       rbx,[rcx]
       mov       [rsp+48],rbx
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02210
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,1D45CC21FB8
       mov       r9,[r9]
       lea       r8,[rsp+48]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rbp,[r15+10]
       mov       [rsp+48],rbx
       mov       rax,1D45CC22258
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L04:
       xor       edx,edx
       mov       [rsp+38],rdx
       lea       rcx,[r15+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[r15+8]
       mov       [rsp+48],rbx
       mov       rax,1D45CC22260
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L05:
       xor       edx,edx
       mov       [rsp+28],rdx
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
       mov       rdx,7FFEBCF026B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass17_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
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
       mov       rdx,7FFEBCF02820
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
       mov       rdx,7FFEBCF02B80
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
       mov       rdx,7FFEBCF02B80
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__17`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__17_1(Int32)
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
       mov       rdx,7FFEBCF02B80
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
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L17:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 788
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
       mov       rbx,[rsi+100]
       mov       rdx,[rsi+108]
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
       mov       rdx,[rsi+10]
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
       mov       rdx,7FFEBCF19760
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCF19CA8
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
       mov       r11,7FFEBC980688
       call      qword ptr [7FFEBCF30688]
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
       mov       rdx,7FFEBCF19A98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC980690
       call      qword ptr [7FFEBCF30690]
       test      eax,eax
       jne       short M01_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC980698
       call      qword ptr [7FFEBCF30698]
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
       mov       rdx,7FFEBCF19950
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCF19C78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCF19C90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCF19A80
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
       mov       r11,7FFEBC980698
       call      qword ptr [7FFEBCF30698]
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
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
       mov       rdx,7FFEBCF121C8
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
       mov       rcx,1594D613020
       mov       rbx,[rcx]
       mov       [rsp+48],rbx
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF121F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,1596D6147B0
       mov       r9,[r9]
       lea       r8,[rsp+48]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rbp,[r15+10]
       mov       [rsp+48],rbx
       mov       rax,1596D614A50
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L04:
       xor       edx,edx
       mov       [rsp+38],rdx
       lea       rcx,[r15+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[r15+8]
       mov       [rsp+48],rbx
       mov       rax,1596D614A58
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L05:
       xor       edx,edx
       mov       [rsp+28],rdx
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
       mov       rdx,7FFEBCF12698
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass17_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
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
       mov       rdx,7FFEBCF12800
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
       mov       rdx,7FFEBCF12B60
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
       mov       rdx,7FFEBCF12B60
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__17`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__17_1(Int32)
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
       mov       rdx,7FFEBCF12B60
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
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L17:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 788
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
       mov       rbx,[rsi+100]
       mov       rdx,[rsi+108]
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
       mov       rdx,[rsi+10]
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
       mov       rdx,7FFEBCFD4D98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCFD52E0
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
       mov       r11,7FFEBC9907C8
       call      qword ptr [7FFEBCF507C8]
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
       mov       rdx,7FFEBCFD50D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC9907D0
       call      qword ptr [7FFEBCF507D0]
       test      eax,eax
       jne       short M01_L10
       mov       rdx,[rbp+20]
       mov       byte ptr [rdx],1
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFEBC9907D8
       call      qword ptr [7FFEBCF507D8]
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
       mov       rdx,7FFEBCFD4F88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCFD52B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCFD52C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCFD50B8
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
       mov       r11,7FFEBC9907D8
       call      qword ptr [7FFEBCF507D8]
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
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
       mov       rdx,7FFEBCFBB2F8
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
       mov       rcx,28A197A3020
       mov       rbx,[rcx]
       mov       [rsp+48],rbx
       cmp       qword ptr [r14+18],0
       je        short M02_L02
       mov       rcx,[r14+18]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCFBB320
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,289F97A1FB8
       mov       r9,[r9]
       lea       r8,[rsp+48]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rbp,[r15+10]
       mov       [rsp+48],rbx
       mov       rax,289F97A2258
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L04:
       xor       edx,edx
       mov       [rsp+38],rdx
       lea       rcx,[r15+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[r15+8]
       mov       [rsp+48],rbx
       mov       rax,289F97A2260
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L05:
       xor       edx,edx
       mov       [rsp+28],rdx
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
       mov       rdx,7FFEBCFBB7C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass17_0`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__0(System.__Canon, Int32)
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
       mov       rdx,7FFEBCFBB930
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
       mov       rdx,7FFEBCFBBC90
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
       mov       rdx,7FFEBCFBBC90
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__17`1[[System.__Canon, System.Private.CoreLib]].<IndexOf>b__17_1(Int32)
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
       mov       rdx,7FFEBCFBBC90
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
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L17:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 788
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
       mov       rdi,[rsi+100]
       mov       rcx,14C17E42F70
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,14C17E42F60
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,14C17E42F70
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
       mov       rdx,14C37E42F30
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,[rsi+10]
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
       mov       rdi,[rsi+100]
       mov       rcx,2E97343B3F8
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2E97343B3E8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2E97343B3F8
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
       mov       rdx,2E973432F30
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,[rsi+10]
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
       mov       rdi,[rsi+100]
       mov       rcx,28013C97408
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,28013C973F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,28013C97408
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
       mov       rdx,27FE3C92F30
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,[rsi+10]
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
       mov       rdi,[rsi+100]
       mov       rcx,2533A927378
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2533A927368
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2533A927378
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
       mov       rdx,2533A922F30
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,[rsi+10]
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
       mov       rdi,[rsi+100]
       mov       rcx,2B7E6959818
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2B7E6959808
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2B7E6959818
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
       mov       rdx,2B7C6952F30
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,[rsi+10]
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
       mov       rdi,[rsi+100]
       mov       rcx,21BBD727408
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,21BBD7273F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,21BBD727408
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
       mov       rdx,21BAD722F30
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,[rsi+10]
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
       mov       rdi,[rsi+100]
       mov       rcx,2CF380E7408
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2CF380E73F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2CF380E7408
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
       mov       rdx,2CF180E2F30
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,[rsi+10]
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
       mov       rdi,[rsi+100]
       mov       rcx,17E50A07378
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,17E50A07368
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderBy>b__11_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,17E50A07378
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
       mov       rdx,17E50A02F30
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       rcx,[rsi+10]
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
       mov       rdi,[rsi+100]
       mov       rcx,210FB259408
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,210FB2593F0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,210FB259408
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,System.String>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
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
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
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
       mov       rax,210DB253020
       mov       rbx,[rax]
       mov       [rsp+50],rbx
       mov       rbp,[rsi+10]
       mov       r14,rdx
       mov       rax,210EB2517A0
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      r14,r14
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rbx
       mov       rax,210EB251A40
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L01:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,210DB2513D0
       mov       rbx,[rcx]
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF024A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,r14
       mov       r8,rdi
       mov       r9,rbx
       call      System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 297
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
       mov       rdi,[rsi+100]
       mov       rcx,213A278B818
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,213A278B800
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,213A278B818
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,System.String>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
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
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
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
       mov       rax,213A2783020
       mov       rbx,[rax]
       mov       [rsp+50],rbx
       mov       rbp,[rsi+10]
       mov       r14,rdx
       mov       rax,213827817A0
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      r14,r14
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rbx
       mov       rax,21382781A40
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L01:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,213A27813D0
       mov       rbx,[rcx]
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF224A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,r14
       mov       r8,rdi
       mov       r9,rbx
       call      System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 297
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
       mov       rdi,[rsi+100]
       mov       rcx,2B94050B818
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2B94050B800
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2B94050B818
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,System.String>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
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
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
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
       mov       rax,2B940503020
       mov       rbx,[rax]
       mov       [rsp+50],rbx
       mov       rbp,[rsi+10]
       mov       r14,rdx
       mov       rax,2B920501FB8
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      r14,r14
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rbx
       mov       rax,2B920502258
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L01:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,2B9405013D0
       mov       rbx,[rcx]
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF024A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,r14
       mov       r8,rdi
       mov       r9,rbx
       call      System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 297
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
       mov       rdi,[rsi+100]
       mov       rcx,185F47C9408
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,185F47C93F0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,185F47C9408
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,System.String>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
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
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
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
       mov       rax,185D47C1028
       mov       rbx,[rax]
       mov       [rsp+50],rbx
       mov       rbp,[rsi+10]
       mov       r14,rdx
       mov       rax,185D47C53E0
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      r14,r14
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rbx
       mov       rax,185D47C5680
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L01:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,185F47C13D0
       mov       rbx,[rcx]
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF124A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,r14
       mov       r8,rdi
       mov       r9,rbx
       call      System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 297
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
       mov       rdi,[rsi+100]
       mov       rcx,22818FCB818
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,22818FCB800
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,22818FCB818
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,System.String>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
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
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
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
       mov       rax,22818FC3020
       mov       rbx,[rax]
       mov       [rsp+50],rbx
       mov       rbp,[rsi+10]
       mov       r14,rdx
       mov       rax,22818FD1FD8
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      r14,r14
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rbx
       mov       rax,22818FD2278
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L01:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,22818FC13D0
       mov       rbx,[rcx]
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF324A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,r14
       mov       r8,rdi
       mov       r9,rbx
       call      System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 297
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
       mov       rdi,[rsi+100]
       mov       rcx,1D152DF9408
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1D152DF93F0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1D152DF9408
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,System.String>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
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
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
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
       mov       rax,1D132DF1028
       mov       rbx,[rax]
       mov       [rsp+50],rbx
       mov       rbp,[rsi+10]
       mov       r14,rdx
       mov       rax,1D152DFFBC8
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      r14,r14
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rbx
       mov       rax,1D152DFFE68
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L01:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,1D152DF13D0
       mov       rbx,[rcx]
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF224A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,r14
       mov       r8,rdi
       mov       r9,rbx
       call      System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 297
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
       mov       rdi,[rsi+100]
       mov       rcx,1B31AF92F78
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1B31AF92F60
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1B31AF92F78
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,System.String>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
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
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
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
       mov       rax,1B2FAF93020
       mov       rbx,[rax]
       mov       [rsp+50],rbx
       mov       rbp,[rsi+10]
       mov       r14,rdx
       mov       rax,1B31AF99738
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      r14,r14
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rbx
       mov       rax,1B31AF999D8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L01:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,1B2FAF913D0
       mov       rbx,[rcx]
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF2488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,r14
       mov       r8,rdi
       mov       r9,rbx
       call      System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 297
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
       mov       rdi,[rsi+100]
       mov       rcx,2575C04B818
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2575C04B800
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark+<>c.<OrderByOrdinal>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2575C04B818
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,System.String>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
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
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.OrderByOrdinal[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.String>)
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
       mov       rax,2575C043020
       mov       rbx,[rax]
       mov       [rsp+50],rbx
       mov       rbp,[rsi+10]
       mov       r14,rdx
       mov       rax,2573C042FD0
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      r14,r14
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+48],rbx
       mov       rax,2573C043270
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L01:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,2575C0413D0
       mov       rbx,[rcx]
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCFAB5B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,r14
       mov       r8,rdi
       mov       r9,rbx
       call      System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 297
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
       mov       rdi,[rsi+100]
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
       mov       r11,7FFEBC9A0608
       call      qword ptr [7FFEBCDA0608]
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rcx,rdi
       mov       r11,7FFEBC9A0610
       call      qword ptr [7FFEBCDA0610]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,rdi
       mov       r11,7FFEBC9A0618
       call      qword ptr [7FFEBCDA0618]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFEBC9A0620
       call      qword ptr [7FFEBCDA0620]
       mov       [rbp+0FFD8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFEBC9A0630
       call      qword ptr [7FFEBCDA0630]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFEBC9A0628
       call      qword ptr [7FFEBCDA0628]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFEBC9A0638
       call      qword ptr [7FFEBCDA0638]
       mov       rcx,rdi
       mov       r11,7FFEBC9A0610
       call      qword ptr [7FFEBCDA0610]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,rdi
       mov       r11,7FFEBC9A0640
       call      qword ptr [7FFEBCDA0640]
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
       mov       r11,7FFEBC9A0638
       call      qword ptr [7FFEBCDA0638]
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
       mov       r11,7FFEBC9A0640
       call      qword ptr [7FFEBCDA0640]
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
       mov       rdi,[rsi+100]
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
       mov       r11,7FFEBC980608
       call      qword ptr [7FFEBCD80608]
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rcx,rdi
       mov       r11,7FFEBC980610
       call      qword ptr [7FFEBCD80610]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,rdi
       mov       r11,7FFEBC980618
       call      qword ptr [7FFEBCD80618]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFEBC980620
       call      qword ptr [7FFEBCD80620]
       mov       [rbp+0FFD8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFEBC980630
       call      qword ptr [7FFEBCD80630]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFEBC980628
       call      qword ptr [7FFEBCD80628]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFEBC980638
       call      qword ptr [7FFEBCD80638]
       mov       rcx,rdi
       mov       r11,7FFEBC980610
       call      qword ptr [7FFEBCD80610]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,rdi
       mov       r11,7FFEBC980640
       call      qword ptr [7FFEBCD80640]
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
       mov       r11,7FFEBC980638
       call      qword ptr [7FFEBCD80638]
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
       mov       r11,7FFEBC980640
       call      qword ptr [7FFEBCD80640]
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
       mov       rdi,[rsi+100]
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
       mov       r11,7FFEBC990608
       call      qword ptr [7FFEBCD90608]
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rcx,rdi
       mov       r11,7FFEBC990610
       call      qword ptr [7FFEBCD90610]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,rdi
       mov       r11,7FFEBC990618
       call      qword ptr [7FFEBCD90618]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFEBC990620
       call      qword ptr [7FFEBCD90620]
       mov       [rbp+0FFD8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFEBC990630
       call      qword ptr [7FFEBCD90630]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFEBC990628
       call      qword ptr [7FFEBCD90628]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFEBC990638
       call      qword ptr [7FFEBCD90638]
       mov       rcx,rdi
       mov       r11,7FFEBC990610
       call      qword ptr [7FFEBCD90610]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,rdi
       mov       r11,7FFEBC990640
       call      qword ptr [7FFEBCD90640]
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
       mov       r11,7FFEBC990638
       call      qword ptr [7FFEBCD90638]
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
       mov       r11,7FFEBC990640
       call      qword ptr [7FFEBCD90640]
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
       mov       rdi,[rsi+100]
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
       mov       r11,7FFEBC990608
       call      qword ptr [7FFEBCD90608]
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rcx,rdi
       mov       r11,7FFEBC990610
       call      qword ptr [7FFEBCD90610]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,rdi
       mov       r11,7FFEBC990618
       call      qword ptr [7FFEBCD90618]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFEBC990620
       call      qword ptr [7FFEBCD90620]
       mov       [rbp+0FFD8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFEBC990630
       call      qword ptr [7FFEBCD90630]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFEBC990628
       call      qword ptr [7FFEBCD90628]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFEBC990638
       call      qword ptr [7FFEBCD90638]
       mov       rcx,rdi
       mov       r11,7FFEBC990610
       call      qword ptr [7FFEBCD90610]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,rdi
       mov       r11,7FFEBC990640
       call      qword ptr [7FFEBCD90640]
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
       mov       r11,7FFEBC990638
       call      qword ptr [7FFEBCD90638]
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
       mov       r11,7FFEBC990640
       call      qword ptr [7FFEBCD90640]
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
       mov       rdi,[rsi+100]
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
       mov       r11,7FFEBC960608
       call      qword ptr [7FFEBCD60608]
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rcx,rdi
       mov       r11,7FFEBC960610
       call      qword ptr [7FFEBCD60610]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,rdi
       mov       r11,7FFEBC960618
       call      qword ptr [7FFEBCD60618]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFEBC960620
       call      qword ptr [7FFEBCD60620]
       mov       [rbp+0FFD8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFEBC960630
       call      qword ptr [7FFEBCD60630]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFEBC960628
       call      qword ptr [7FFEBCD60628]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFEBC960638
       call      qword ptr [7FFEBCD60638]
       mov       rcx,rdi
       mov       r11,7FFEBC960610
       call      qword ptr [7FFEBCD60610]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,rdi
       mov       r11,7FFEBC960640
       call      qword ptr [7FFEBCD60640]
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
       mov       r11,7FFEBC960638
       call      qword ptr [7FFEBCD60638]
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
       mov       r11,7FFEBC960640
       call      qword ptr [7FFEBCD60640]
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
       mov       rdi,[rsi+100]
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
       mov       r11,7FFEBC990608
       call      qword ptr [7FFEBCD90608]
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rcx,rdi
       mov       r11,7FFEBC990610
       call      qword ptr [7FFEBCD90610]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,rdi
       mov       r11,7FFEBC990618
       call      qword ptr [7FFEBCD90618]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFEBC990620
       call      qword ptr [7FFEBCD90620]
       mov       [rbp+0FFD8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFEBC990630
       call      qword ptr [7FFEBCD90630]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFEBC990628
       call      qword ptr [7FFEBCD90628]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFEBC990638
       call      qword ptr [7FFEBCD90638]
       mov       rcx,rdi
       mov       r11,7FFEBC990610
       call      qword ptr [7FFEBCD90610]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,rdi
       mov       r11,7FFEBC990640
       call      qword ptr [7FFEBCD90640]
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
       mov       r11,7FFEBC990638
       call      qword ptr [7FFEBCD90638]
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
       mov       r11,7FFEBC990640
       call      qword ptr [7FFEBCD90640]
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
       mov       rdi,[rsi+100]
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
       mov       r11,7FFEBC990608
       call      qword ptr [7FFEBCD90608]
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rcx,rdi
       mov       r11,7FFEBC990610
       call      qword ptr [7FFEBCD90610]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,rdi
       mov       r11,7FFEBC990618
       call      qword ptr [7FFEBCD90618]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFEBC990620
       call      qword ptr [7FFEBCD90620]
       mov       [rbp+0FFD8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFEBC990630
       call      qword ptr [7FFEBCD90630]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFEBC990628
       call      qword ptr [7FFEBCD90628]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFEBC990638
       call      qword ptr [7FFEBCD90638]
       mov       rcx,rdi
       mov       r11,7FFEBC990610
       call      qword ptr [7FFEBCD90610]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,rdi
       mov       r11,7FFEBC990640
       call      qword ptr [7FFEBCD90640]
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
       mov       r11,7FFEBC990638
       call      qword ptr [7FFEBCD90638]
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
       mov       r11,7FFEBC990640
       call      qword ptr [7FFEBCD90640]
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
       mov       rdi,[rsi+100]
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
       mov       r11,7FFEBC970608
       call      qword ptr [7FFEBCF20608]
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rcx,rdi
       mov       r11,7FFEBC970610
       call      qword ptr [7FFEBCF20610]
       test      eax,eax
       je        near ptr M00_L03
M00_L00:
       mov       rcx,rdi
       mov       r11,7FFEBC970618
       call      qword ptr [7FFEBCF20618]
       mov       rcx,rax
; 				foreach (var person in people)
; 				                       ^^^^^^
       mov       r11,7FFEBC970620
       call      qword ptr [7FFEBCF20620]
       mov       [rbp+0FFD8],rax
       jmp       short M00_L02
M00_L01:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFEBC970630
       call      qword ptr [7FFEBCF20630]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L02:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFEBC970628
       call      qword ptr [7FFEBCF20628]
       test      eax,eax
       jne       short M00_L01
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFEBC970638
       call      qword ptr [7FFEBCF20638]
       mov       rcx,rdi
       mov       r11,7FFEBC970610
       call      qword ptr [7FFEBCF20610]
       test      eax,eax
       jne       near ptr M00_L00
M00_L03:
       mov       rcx,rdi
       mov       r11,7FFEBC970640
       call      qword ptr [7FFEBCF20640]
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
       mov       r11,7FFEBC970638
       call      qword ptr [7FFEBCF20638]
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
       mov       r11,7FFEBC970640
       call      qword ptr [7FFEBCF20640]
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
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,16C4D083020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,[rsi+10]
       mov       rbx,rdx
       mov       rax,16C4D091FD8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
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
       mov       rdx,7FFEBCEF2008
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rbx
       mov       r8d,ebp
       call      System.Linq.Enumerable.ElementAt[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 212
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
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2725C3C3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,[rsi+10]
       mov       rbx,rdx
       mov       rax,2725C3D2FF0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
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
       mov       rdx,7FFEBCF22008
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rbx
       mov       r8d,ebp
       call      System.Linq.Enumerable.ElementAt[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 212
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
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,267A70F3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,[rsi+10]
       mov       rbx,rdx
       mov       rax,267A7102FF0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
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
       mov       rdx,7FFEBCF22008
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rbx
       mov       r8d,ebp
       call      System.Linq.Enumerable.ElementAt[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 212
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
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,26530703020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,[rsi+10]
       mov       rbx,rdx
       mov       rax,265307063C0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
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
       mov       rdx,7FFEBCF02008
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rbx
       mov       r8d,ebp
       call      System.Linq.Enumerable.ElementAt[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 212
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
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,24A6BBC3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,[rsi+10]
       mov       rbx,rdx
       mov       rax,24A4BBC1FB8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
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
       mov       rdx,7FFEBCF22008
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rbx
       mov       r8d,ebp
       call      System.Linq.Enumerable.ElementAt[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 212
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
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2479AB53020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,[rsi+10]
       mov       rbx,rdx
       mov       rax,2479AB543C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
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
       mov       rdx,7FFEBCF12008
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rbx
       mov       r8d,ebp
       call      System.Linq.Enumerable.ElementAt[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 212
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
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2238BA53020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,[rsi+10]
       mov       rbx,rdx
       mov       rax,2236BA51FB8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
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
       mov       rdx,7FFEBCF02008
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rbx
       mov       r8d,ebp
       call      System.Linq.Enumerable.ElementAt[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 212
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
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,22335DF3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,[rsi+10]
       mov       rbx,rdx
       mov       rax,22335E01FD8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
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
       mov       rdx,7FFEBCF9B118
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rbx
       mov       r8d,ebp
       call      System.Linq.Enumerable.ElementAt[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 212
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rcx,2038AD83020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02ED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,2038AD91FD8
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF03118
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
       mov       rdx,7FFEBCF03118
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
       mov       rdx,7FFEBCF03298
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
       mov       rdx,7FFEBCF03118
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
       mov       rdx,7FFEBCF03158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,rdi
       mov       r8,rbp
       call      System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 388
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rcx,1B9BB8F3020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF2ED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1B9DB8F27B8
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF3118
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
       mov       rdx,7FFEBCEF3118
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
       mov       rdx,7FFEBCEF3298
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
       mov       rdx,7FFEBCEF3118
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
       mov       rdx,7FFEBCEF3158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,rdi
       mov       r8,rbp
       call      System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 388
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rcx,2C51CD51028
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF2ED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,2C53CD613F8
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF3118
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
       mov       rdx,7FFEBCEF3118
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
       mov       rdx,7FFEBCEF3298
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
       mov       rdx,7FFEBCEF3118
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
       mov       rdx,7FFEBCEF3158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,rdi
       mov       r8,rbp
       call      System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 388
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rcx,225AF573020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCED2ED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,225AF582FF0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCED3118
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
       mov       rdx,7FFEBCED3118
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
       mov       rdx,7FFEBCED3298
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
       mov       rdx,7FFEBCED3118
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
       mov       rdx,7FFEBCED3158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,rdi
       mov       r8,rbp
       call      System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 388
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rcx,218DC781028
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02ED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,218BC783FB0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF03118
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
       mov       rdx,7FFEBCF03118
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
       mov       rdx,7FFEBCF03298
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
       mov       rdx,7FFEBCF03118
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
       mov       rdx,7FFEBCF03158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,rdi
       mov       r8,rbp
       call      System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 388
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rcx,1BDEFC23020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCEE2F20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1BDCFC22FD0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCEE3160
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
       mov       rdx,7FFEBCEE3160
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
       mov       rdx,7FFEBCEE32E0
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
       mov       rdx,7FFEBCEE3160
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
       mov       rdx,7FFEBCEE31A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,rdi
       mov       r8,rbp
       call      System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 388
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rcx,2145AE03020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF12ED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,2144AE017A0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF13118
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
       mov       rdx,7FFEBCF13118
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
       mov       rdx,7FFEBCF13298
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
       mov       rdx,7FFEBCF13118
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
       mov       rdx,7FFEBCF13158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,rdi
       mov       r8,rbp
       call      System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 388
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rcx,1E2C7393020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF184E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1E2A7391FB8
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       cmp       qword ptr [rbx+18],0
       je        short M01_L02
       mov       rcx,[rbx+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF18728
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
       mov       rdx,7FFEBCF18728
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
       mov       rdx,7FFEBCF188A8
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
       mov       rdx,7FFEBCF18728
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
       mov       rdx,7FFEBCF18768
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,rdi
       mov       r8,rbp
       call      System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 388
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,1F94B1C3020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF04040
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1F94B1C73D8
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF04510
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
; Total bytes of code 163
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,1804B621028
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF4040
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1804B630FF8
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF4510
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
; Total bytes of code 163
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,1BAEAB71028
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF24040
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1BADAB717A0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF24510
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
; Total bytes of code 163
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,1FEDF4E3020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF04040
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1FEDF4F2FF0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF04510
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
; Total bytes of code 163
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,1D6E7503020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF14040
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1D6E7512FF0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF14510
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
; Total bytes of code 163
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,1838FF73020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF04040
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1838FF82FF0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF04510
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
; Total bytes of code 163
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,2195C881028
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF4020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,2195C8907F8
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF44F0
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
; Total bytes of code 163
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToObservableCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,29A2E421028
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF9D150
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,29A2E4253E0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF9D620
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
; Total bytes of code 163
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,1E7D6BA3020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF12700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1E7B6BA2FD0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF12B38
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
; Total bytes of code 180
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,253C8313020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF22700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,253C8322FF0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF22B38
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
; Total bytes of code 180
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,1C831A71028
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1C831A7FFE0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02B38
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
; Total bytes of code 180
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,22F96163020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,22FB616FBC8
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02B38
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
; Total bytes of code 180
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,14C0A923020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF12700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,14C0A926BC0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF12B38
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
; Total bytes of code 180
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,20A52AC3020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF2700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,20A32AC1FB8
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF2B38
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
; Total bytes of code 180
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,24129A11028
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF226E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,24149A13FB0
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF22B18
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
; Total bytes of code 180
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
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,16D9FB71028
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF9B810
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,16D8FB7EBE8
       mov       r9,[r9]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFEBCF9BC48
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
; Total bytes of code 180
```

