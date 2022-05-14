## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
; 			var result = base.GetPersonProperArray(Tristate.False).ToCollection().HasItems(5);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,1CDB9BD1028
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1CDD9BD3798
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
       mov       rdx,7FFEBCF02B40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rdx,1CDB9BD1028
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFEBCF03550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       r9,1CDD9BD3798
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
; 			var result = base.GetPersonProperArray(Tristate.False).ToCollection().HasItems(5);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,220EACB3020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF22670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,220EACC2FF0
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
       mov       rdx,7FFEBCF22B40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rdx,220EACB3020
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFEBCF23550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       r9,220EACC2FF0
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
; 			var result = base.GetPersonProperArray(Tristate.False).ToCollection().HasItems(5);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,1C5F0663020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF22670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1C5F06673D8
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
       mov       rdx,7FFEBCF22B40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rdx,1C5F0663020
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFEBCF23550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       r9,1C5F06673D8
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
; 			var result = base.GetPersonProperArray(Tristate.False).ToCollection().HasItems(5);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,2A727F93020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF22670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,2A727F953E0
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
       mov       rdx,7FFEBCF22B40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rdx,2A727F93020
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFEBCF23550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       r9,2A727F953E0
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
; 			var result = base.GetPersonProperArray(Tristate.False).ToCollection().HasItems(5);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,20F67123020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF22670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,20F87125C38
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
       mov       rdx,7FFEBCF22B40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rdx,20F67123020
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFEBCF23550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       r9,20F87125C38
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
; 			var result = base.GetPersonProperArray(Tristate.False).ToCollection().HasItems(5);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,22405591028
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF2670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,223E559BF48
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
       mov       rdx,7FFEBCEF2B40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rdx,22405591028
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFEBCEF3550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       r9,223E559BF48
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
; 			var result = base.GetPersonProperArray(Tristate.False).ToCollection().HasItems(5);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,1ACDFAD1028
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF22650
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1ACFFAD47B0
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
       mov       rdx,7FFEBCF22B20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rdx,1ACDFAD1028
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFEBCF23530
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       r9,1ACFFAD47B0
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems02()
; 			var result = base.GetPersonProperArray(Tristate.False).ToCollection().HasItems(5);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,1E89AB93020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCFCB300
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1E89ABA1FD8
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
       mov       rdx,7FFEBCFCB7D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rdx,1E89AB93020
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFEBCFCC1E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       r9,1E89ABA1FD8
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
; 			var people = base.GetPersonProperArray(Tristate.False).ToCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = people.AddRange(base.GetPersonProperArray(collectionSize: CollectionSize.Half).Take(Count / 2), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rbx,rax
       mov       ebp,[rsi+124]
       mov       r14d,ebp
       shr       r14d,1F
       add       ebp,r14d
       sar       ebp,1
       test      rbx,rbx
       je        short M00_L01
       test      ebp,ebp
       jle       short M00_L02
       mov       rcx,offset MT_System.Linq.Enumerable+ListPartition`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [r14+20],r8d
       dec       ebp
       mov       [r14+24],ebp
       mov       r8,r14
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       rcx,7FFEBCC54000
       mov       edx,2
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,1D9A4FC2FE8
       mov       r8,[rax]
       jmp       short M00_L00
; Total bytes of code 245
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,1D9A4FC3020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF22B68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1D9A4FC5BA8
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
       mov       rdx,7FFEBCF23038
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
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
       mov       rax,1D9A4FC3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1D984FC5A60
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE300A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
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
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M03_L00
       mov       rcx,[r14+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBD004958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       [r15+10],ebp
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[r15+8]
       mov       rax,1D9A4FC3020
       mov       rbp,[rax]
       mov       [rsp+48],rbp
       mov       rax,1D9A4FC5E60
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+40],rbp
       cmp       qword ptr [r14+20],0
       je        short M03_L03
       mov       rcx,[r14+20]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBD004BA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       mov       r9,1D9A4FC5E68
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String ByRef, System.String)
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+48],rbp
       mov       rax,1D9A4FC5E48
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L05:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rsi+10]
       lea       rbx,[r15+8]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L06
       mov       rbp,[rcx+30]
       test      rbp,rbp
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD004D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M03_L07:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       mov       rdx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r14+8],al
       mov       rcx,r14
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       byte ptr [r15+14],0
       test      rdi,rdi
       je        near ptr M03_L12
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M03_L12
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L08
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBD0066D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L09:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],40
       jle       short M03_L10
       mov       rcx,[rbx+40]
       test      rcx,rcx
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBD006818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass5_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
M03_L12:
       movzx     eax,byte ptr [r15+14]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 657
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
; 			var people = base.GetPersonProperArray(Tristate.False).ToCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = people.AddRange(base.GetPersonProperArray(collectionSize: CollectionSize.Half).Take(Count / 2), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rbx,rax
       mov       ebp,[rsi+124]
       mov       r14d,ebp
       shr       r14d,1F
       add       ebp,r14d
       sar       ebp,1
       test      rbx,rbx
       je        short M00_L01
       test      ebp,ebp
       jle       short M00_L02
       mov       rcx,offset MT_System.Linq.Enumerable+ListPartition`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [r14+20],r8d
       dec       ebp
       mov       [r14+24],ebp
       mov       r8,r14
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       rcx,7FFEBCC54000
       mov       edx,2
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,27F0B5C2FF0
       mov       r8,[rax]
       jmp       short M00_L00
; Total bytes of code 245
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,27F0B5C3020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF22B68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,27F0B5C73D8
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
       mov       rdx,7FFEBCF23038
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
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
       mov       rax,27F0B5C3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,27F0B5C59D0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE300A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
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
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M03_L00
       mov       rcx,[r14+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBD004958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       [r15+10],ebp
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[r15+8]
       mov       rax,27F0B5C3020
       mov       rbp,[rax]
       mov       [rsp+48],rbp
       mov       rax,27F0B5C7690
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+40],rbp
       cmp       qword ptr [r14+20],0
       je        short M03_L03
       mov       rcx,[r14+20]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBD004BA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       mov       r9,27F0B5C7698
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String ByRef, System.String)
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+48],rbp
       mov       rax,27F0B5C7678
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L05:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rsi+10]
       lea       rbx,[r15+8]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L06
       mov       rbp,[rcx+30]
       test      rbp,rbp
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD004D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M03_L07:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       mov       rdx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r14+8],al
       mov       rcx,r14
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       byte ptr [r15+14],0
       test      rdi,rdi
       je        near ptr M03_L12
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M03_L12
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L08
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBD0066D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L09:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],40
       jle       short M03_L10
       mov       rcx,[rbx+40]
       test      rcx,rcx
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBD006818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass5_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
M03_L12:
       movzx     eax,byte ptr [r15+14]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 657
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
; 			var people = base.GetPersonProperArray(Tristate.False).ToCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = people.AddRange(base.GetPersonProperArray(collectionSize: CollectionSize.Half).Take(Count / 2), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rbx,rax
       mov       ebp,[rsi+124]
       mov       r14d,ebp
       shr       r14d,1F
       add       ebp,r14d
       sar       ebp,1
       test      rbx,rbx
       je        short M00_L01
       test      ebp,ebp
       jle       short M00_L02
       mov       rcx,offset MT_System.Linq.Enumerable+ListPartition`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [r14+20],r8d
       dec       ebp
       mov       [r14+24],ebp
       mov       r8,r14
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       rcx,7FFEBCC34000
       mov       edx,2
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,217C38A2FF0
       mov       r8,[rax]
       jmp       short M00_L00
; Total bytes of code 245
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,217C38A3020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02B68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,217C38B2FF0
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
       mov       rdx,7FFEBCF03038
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
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
       mov       rax,217C38A3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,217A38A15C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE100A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
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
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M03_L00
       mov       rcx,[r14+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCFE4B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       [r15+10],ebp
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[r15+8]
       mov       rax,217C38A3020
       mov       rbp,[rax]
       mov       [rsp+48],rbp
       mov       rax,217C38B32A8
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+40],rbp
       cmp       qword ptr [r14+20],0
       je        short M03_L03
       mov       rcx,[r14+20]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCFE4DD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       mov       r9,217C38B32B0
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String ByRef, System.String)
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+48],rbp
       mov       rax,217C38B3290
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L05:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rsi+10]
       lea       rbx,[r15+8]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L06
       mov       rbp,[rcx+30]
       test      rbp,rbp
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCFE4F50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M03_L07:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       mov       rdx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r14+8],al
       mov       rcx,r14
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       byte ptr [r15+14],0
       test      rdi,rdi
       je        near ptr M03_L12
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M03_L12
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L08
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCFE6910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L09:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],40
       jle       short M03_L10
       mov       rcx,[rbx+40]
       test      rcx,rcx
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCFE6A50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass5_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
M03_L12:
       movzx     eax,byte ptr [r15+14]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 657
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
; 			var people = base.GetPersonProperArray(Tristate.False).ToCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = people.AddRange(base.GetPersonProperArray(collectionSize: CollectionSize.Half).Take(Count / 2), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rbx,rax
       mov       ebp,[rsi+124]
       mov       r14d,ebp
       shr       r14d,1F
       add       ebp,r14d
       sar       ebp,1
       test      rbx,rbx
       je        short M00_L01
       test      ebp,ebp
       jle       short M00_L02
       mov       rcx,offset MT_System.Linq.Enumerable+ListPartition`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [r14+20],r8d
       dec       ebp
       mov       [r14+24],ebp
       mov       r8,r14
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       rcx,7FFEBCC34000
       mov       edx,2
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,247E2FC2FF0
       mov       r8,[rax]
       jmp       short M00_L00
; Total bytes of code 245
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,247E2FC3020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02B68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,24802FC27B8
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
       mov       rdx,7FFEBCF03038
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
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
       mov       rax,247E2FC3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,247E2FC59D0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE100A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
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
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M03_L00
       mov       rcx,[r14+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCFE4B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       [r15+10],ebp
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[r15+8]
       mov       rax,247E2FC3020
       mov       rbp,[rax]
       mov       [rsp+48],rbp
       mov       rax,24802FC2A70
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+40],rbp
       cmp       qword ptr [r14+20],0
       je        short M03_L03
       mov       rcx,[r14+20]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCFE4DD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       mov       r9,24802FC2A78
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String ByRef, System.String)
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+48],rbp
       mov       rax,24802FC2A58
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L05:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rsi+10]
       lea       rbx,[r15+8]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L06
       mov       rbp,[rcx+30]
       test      rbp,rbp
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCFE4F50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M03_L07:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       mov       rdx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r14+8],al
       mov       rcx,r14
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       byte ptr [r15+14],0
       test      rdi,rdi
       je        near ptr M03_L12
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M03_L12
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L08
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCFE6910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L09:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],40
       jle       short M03_L10
       mov       rcx,[rbx+40]
       test      rcx,rcx
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCFE6A50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass5_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
M03_L12:
       movzx     eax,byte ptr [r15+14]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 657
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
; 			var people = base.GetPersonProperArray(Tristate.False).ToCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = people.AddRange(base.GetPersonProperArray(collectionSize: CollectionSize.Half).Take(Count / 2), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rbx,rax
       mov       ebp,[rsi+124]
       mov       r14d,ebp
       shr       r14d,1F
       add       ebp,r14d
       sar       ebp,1
       test      rbx,rbx
       je        short M00_L01
       test      ebp,ebp
       jle       short M00_L02
       mov       rcx,offset MT_System.Linq.Enumerable+ListPartition`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [r14+20],r8d
       dec       ebp
       mov       [r14+24],ebp
       mov       r8,r14
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       rcx,7FFEBCC34000
       mov       edx,2
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,1DA75D52FF0
       mov       r8,[rax]
       jmp       short M00_L00
; Total bytes of code 245
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,1DA85D51028
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02B68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1DA75D53FB0
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
       mov       rdx,7FFEBCF03038
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
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
       mov       rax,1DA85D51028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1DA75D535C0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE100A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
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
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M03_L00
       mov       rcx,[r14+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCFE4958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       [r15+10],ebp
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[r15+8]
       mov       rax,1DA85D51028
       mov       rbp,[rax]
       mov       [rsp+48],rbp
       mov       rax,1DA75D54268
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+40],rbp
       cmp       qword ptr [r14+20],0
       je        short M03_L03
       mov       rcx,[r14+20]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCFE4BA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       mov       r9,1DA75D54270
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String ByRef, System.String)
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+48],rbp
       mov       rax,1DA75D54250
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L05:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rsi+10]
       lea       rbx,[r15+8]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L06
       mov       rbp,[rcx+30]
       test      rbp,rbp
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCFE4D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M03_L07:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       mov       rdx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r14+8],al
       mov       rcx,r14
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       byte ptr [r15+14],0
       test      rdi,rdi
       je        near ptr M03_L12
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M03_L12
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L08
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCFE66D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L09:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],40
       jle       short M03_L10
       mov       rcx,[rbx+40]
       test      rcx,rcx
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCFE6818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass5_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
M03_L12:
       movzx     eax,byte ptr [r15+14]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 657
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
; 			var people = base.GetPersonProperArray(Tristate.False).ToCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = people.AddRange(base.GetPersonProperArray(collectionSize: CollectionSize.Half).Take(Count / 2), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rbx,rax
       mov       ebp,[rsi+124]
       mov       r14d,ebp
       shr       r14d,1F
       add       ebp,r14d
       sar       ebp,1
       test      rbx,rbx
       je        short M00_L01
       test      ebp,ebp
       jle       short M00_L02
       mov       rcx,offset MT_System.Linq.Enumerable+ListPartition`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [r14+20],r8d
       dec       ebp
       mov       [r14+24],ebp
       mov       r8,r14
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       rcx,7FFEBCC34000
       mov       edx,2
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,23FEB7E2FF0
       mov       r8,[rax]
       jmp       short M00_L00
; Total bytes of code 245
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,23FEB7E3020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02B68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,23FEB7F3808
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
       mov       rdx,7FFEBCF03038
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
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
       mov       rax,23FEB7E3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,23FEB7F1E00
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE100A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
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
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M03_L00
       mov       rcx,[r14+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCFE4958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       [r15+10],ebp
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[r15+8]
       mov       rax,23FEB7E3020
       mov       rbp,[rax]
       mov       [rsp+48],rbp
       mov       rax,23FEB7F3AC0
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+40],rbp
       cmp       qword ptr [r14+20],0
       je        short M03_L03
       mov       rcx,[r14+20]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCFE4BA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       mov       r9,23FEB7F3AC8
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String ByRef, System.String)
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+48],rbp
       mov       rax,23FEB7F3AA8
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L05:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rsi+10]
       lea       rbx,[r15+8]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L06
       mov       rbp,[rcx+30]
       test      rbp,rbp
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCFE4D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M03_L07:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       mov       rdx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r14+8],al
       mov       rcx,r14
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       byte ptr [r15+14],0
       test      rdi,rdi
       je        near ptr M03_L12
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M03_L12
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L08
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCFE66D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L09:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],40
       jle       short M03_L10
       mov       rcx,[rbx+40]
       test      rcx,rcx
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCFE6818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass5_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
M03_L12:
       movzx     eax,byte ptr [r15+14]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 657
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
; 			var people = base.GetPersonProperArray(Tristate.False).ToCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = people.AddRange(base.GetPersonProperArray(collectionSize: CollectionSize.Half).Take(Count / 2), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rbx,rax
       mov       ebp,[rsi+124]
       mov       r14d,ebp
       shr       r14d,1F
       add       ebp,r14d
       sar       ebp,1
       test      rbx,rbx
       je        short M00_L01
       test      ebp,ebp
       jle       short M00_L02
       mov       rcx,offset MT_System.Linq.Enumerable+ListPartition`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [r14+20],r8d
       dec       ebp
       mov       [r14+24],ebp
       mov       r8,r14
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       rcx,7FFEBCC24000
       mov       edx,2
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,21A175E2FF0
       mov       r8,[rax]
       jmp       short M00_L00
; Total bytes of code 245
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,21A175E3020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCEF2B48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,21A175E5BA8
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
       mov       rdx,7FFEBCEF3018
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
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
       mov       rax,21A175E3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,219F75E15C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE000A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
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
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M03_L00
       mov       rcx,[r14+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCFD4958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       [r15+10],ebp
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[r15+8]
       mov       rax,21A175E3020
       mov       rbp,[rax]
       mov       [rsp+48],rbp
       mov       rax,21A175E5E60
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+40],rbp
       cmp       qword ptr [r14+20],0
       je        short M03_L03
       mov       rcx,[r14+20]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBCFD4BA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       mov       r9,21A175E5E68
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String ByRef, System.String)
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+48],rbp
       mov       rax,21A175E5E48
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L05:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rsi+10]
       lea       rbx,[r15+8]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L06
       mov       rbp,[rcx+30]
       test      rbp,rbp
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCFD4D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M03_L07:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       mov       rdx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r14+8],al
       mov       rcx,r14
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       byte ptr [r15+14],0
       test      rdi,rdi
       je        near ptr M03_L12
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M03_L12
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L08
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCFD66D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L09:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],40
       jle       short M03_L10
       mov       rcx,[rbx+40]
       test      rcx,rcx
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCFD6818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass5_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
M03_L12:
       movzx     eax,byte ptr [r15+14]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 657
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
; 			var people = base.GetPersonProperArray(Tristate.False).ToCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = people.AddRange(base.GetPersonProperArray(collectionSize: CollectionSize.Half).Take(Count / 2), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rbx,rax
       mov       ebp,[rsi+124]
       mov       r14d,ebp
       shr       r14d,1F
       add       ebp,r14d
       sar       ebp,1
       test      rbx,rbx
       je        short M00_L01
       test      ebp,ebp
       jle       short M00_L02
       mov       rcx,offset MT_System.Linq.Enumerable+ListPartition`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       r8d,r8d
       mov       [r14+20],r8d
       dec       ebp
       mov       [r14+24],ebp
       mov       r8,r14
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       rcx,7FFEBCC54000
       mov       edx,2
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,22A6DFB2FF0
       mov       r8,[rax]
       jmp       short M00_L00
; Total bytes of code 245
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,22A7DFB1028
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCFBBA60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,22A6DFB47B0
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
       mov       rdx,7FFEBCFBBF30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
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
       mov       rax,22A7DFB1028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,22A4DFB15C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFEBCE300A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
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
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M03_L00
       mov       rcx,[r14+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBD021DE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       [r15+10],ebp
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[r15+8]
       mov       rax,22A7DFB1028
       mov       rbp,[rax]
       mov       [rsp+48],rbp
       mov       rax,22A6DFB4A68
       mov       rax,[rax]
       mov       [rsp+38],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+30],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+40],rbp
       cmp       qword ptr [r14+20],0
       je        short M03_L03
       mov       rcx,[r14+20]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFEBD022030
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       mov       r9,22A6DFB4A70
       mov       r9,[r9]
       lea       r8,[rsp+40]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String ByRef, System.String)
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+48],rbp
       mov       rax,22A6DFB4A50
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L05:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rsi+10]
       lea       rbx,[r15+8]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L06
       mov       rbp,[rcx+30]
       test      rbp,rbp
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBD0221A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M03_L07:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       mov       rdx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r14+8],al
       mov       rcx,r14
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       byte ptr [r15+14],0
       test      rdi,rdi
       je        near ptr M03_L12
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M03_L12
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L08
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBD023B68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L09:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],40
       jle       short M03_L10
       mov       rcx,[rbx+40]
       test      rcx,rcx
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBD023CA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass5_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
M03_L12:
       movzx     eax,byte ptr [r15+14]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 657
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToCollection().HasItems();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,1348AA63020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF22670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,1348AA663C0
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
       mov       rdx,7FFEBCF22B40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rcx
       mov       rsi,rdx
       mov       rdx,1348AA63020
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFEBCF239E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       lea       r8,[rsp+30]
       lea       r9,[rsp+28]
       mov       rcx,rdx
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M02_L02
       xor       eax,eax
       add       rsp,40
       pop       rsi
       ret
M02_L02:
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToCollection().HasItems();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,2ADE29F1028
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF22670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,2ADE29F53E0
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
       mov       rdx,7FFEBCF22B40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rcx
       mov       rsi,rdx
       mov       rdx,2ADE29F1028
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFEBCF239E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       lea       r8,[rsp+30]
       lea       r9,[rsp+28]
       mov       rcx,rdx
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M02_L02
       xor       eax,eax
       add       rsp,40
       pop       rsi
       ret
M02_L02:
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToCollection().HasItems();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,24155223020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF22670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,241652217A0
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
       mov       rdx,7FFEBCF22B40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rcx
       mov       rsi,rdx
       mov       rdx,24155223020
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFEBCF239E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       lea       r8,[rsp+30]
       lea       r9,[rsp+28]
       mov       rcx,rdx
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M02_L02
       xor       eax,eax
       add       rsp,40
       pop       rsi
       ret
M02_L02:
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToCollection().HasItems();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,24B40453020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF22670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,24B2045F400
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
       mov       rdx,7FFEBCF22B40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rcx
       mov       rsi,rdx
       mov       rdx,24B40453020
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFEBCF239E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       lea       r8,[rsp+30]
       lea       r9,[rsp+28]
       mov       rcx,rdx
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M02_L02
       xor       eax,eax
       add       rsp,40
       pop       rsi
       ret
M02_L02:
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToCollection().HasItems();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,165B2751028
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF02670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,165B2760FF8
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
       mov       rdx,7FFEBCF02B40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rcx
       mov       rsi,rdx
       mov       rdx,165B2751028
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFEBCF039E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       lea       r8,[rsp+30]
       lea       r9,[rsp+28]
       mov       rcx,rdx
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M02_L02
       xor       eax,eax
       add       rsp,40
       pop       rsi
       ret
M02_L02:
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToCollection().HasItems();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,12BAE461028
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF22670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,12B8E46FBC8
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
       mov       rdx,7FFEBCF22B40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rcx
       mov       rsi,rdx
       mov       rdx,12BAE461028
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFEBCF239E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       lea       r8,[rsp+30]
       lea       r9,[rsp+28]
       mov       rcx,rdx
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M02_L02
       xor       eax,eax
       add       rsp,40
       pop       rsi
       ret
M02_L02:
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToCollection().HasItems();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,25596E93020
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCF12650
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,25596EA27F0
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
       mov       rdx,7FFEBCF12B20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rcx
       mov       rsi,rdx
       mov       rdx,25596E93020
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFEBCF139C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       lea       r8,[rsp+30]
       lea       r9,[rsp+28]
       mov       rcx,rdx
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M02_L02
       xor       eax,eax
       add       rsp,40
       pop       rsi
       ret
M02_L02:
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems01()
; 			var result = base.GetPersonProperArray(Tristate.False).ToCollection().HasItems();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToCollection(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.ToCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,22187151028
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCFBB300
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       r9,221A71547B0
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
       mov       rdx,7FFEBCFBB7D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rcx
       mov       rsi,rdx
       mov       rdx,22187151028
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFEBCFBC678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       lea       r8,[rsp+30]
       lea       r9,[rsp+28]
       mov       rcx,rdx
       mov       rdx,rsi
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M02_L02
       xor       eax,eax
       add       rsp,40
       pop       rsi
       ret
M02_L02:
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

