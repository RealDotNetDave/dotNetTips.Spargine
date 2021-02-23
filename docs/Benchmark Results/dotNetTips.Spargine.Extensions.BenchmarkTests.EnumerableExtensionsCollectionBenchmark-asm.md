## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
; 			var result = base.PersonProperCollection.FirstOrDefault(alternate: this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
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
; Total bytes of code 76
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r8,28C02473060
       mov       r8,[r8]
       mov       rdx,28C02473E28
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFB37010750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rbx
       mov       r8,rdi
       call      System.Linq.Enumerable.DefaultIfEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB37010800
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.First[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
; Total bytes of code 172
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
; 			var result = base.PersonProperCollection.FirstOrDefault(alternate: this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
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
; Total bytes of code 76
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r8,23528163060
       mov       r8,[r8]
       mov       rdx,235381611A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFB36FE07D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rbx
       mov       r8,rdi
       call      System.Linq.Enumerable.DefaultIfEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0880
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.First[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
; Total bytes of code 172
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
; 			var result = base.PersonProperCollection.FirstOrDefault(alternate: this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
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
; Total bytes of code 76
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r8,1EC8C381048
       mov       r8,[r8]
       mov       rdx,1EC9C3811A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rbx
       mov       r8,rdi
       call      System.Linq.Enumerable.DefaultIfEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0800
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.First[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
; Total bytes of code 172
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
; 			var result = base.PersonProperCollection.FirstOrDefault(alternate: this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
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
; Total bytes of code 76
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r8,1C662843060
       mov       r8,[r8]
       mov       rdx,1C6928411A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFB37010940
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rbx
       mov       r8,rdi
       call      System.Linq.Enumerable.DefaultIfEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB370109F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.First[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
; Total bytes of code 172
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
; 			var result = base.PersonProperCollection.FirstOrDefault(alternate: this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
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
; Total bytes of code 76
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r8,2769E1A3060
       mov       r8,[r8]
       mov       rdx,2768E1A11A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rbx
       mov       r8,rdi
       call      System.Linq.Enumerable.DefaultIfEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0800
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.First[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
; Total bytes of code 172
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
; 			var result = base.PersonProperCollection.FirstOrDefault(alternate: this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
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
; Total bytes of code 76
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r8,23B7F383060
       mov       r8,[r8]
       mov       rdx,23B6F38DBC8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFB37010BC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rbx
       mov       r8,rdi
       call      System.Linq.Enumerable.DefaultIfEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB37010C70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.First[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
; Total bytes of code 172
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
; 			var result = base.PersonProperCollection.FirstOrDefault(alternate: this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
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
; Total bytes of code 76
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r8,13FD7853060
       mov       r8,[r8]
       mov       rdx,13FC78511A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFB37010BC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rbx
       mov       r8,rdi
       call      System.Linq.Enumerable.DefaultIfEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB37010C70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.First[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
; Total bytes of code 172
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
; 			var result = base.PersonProperCollection.FirstOrDefault(alternate: this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
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
; Total bytes of code 76
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r8,2788AFA3060
       mov       r8,[r8]
       mov       rdx,2788AFA35F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFB36FF09E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rbx
       mov       r8,rdi
       call      System.Linq.Enumerable.DefaultIfEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0A90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.First[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
; Total bytes of code 172
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate01()
; 			var result = base.PersonProperCollection.FirstOrDefault(alternate: this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, !!0)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
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
; Total bytes of code 76
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r8,2CB568A3060
       mov       r8,[r8]
       mov       rdx,2CB4691E1D8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFB370009E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rbx
       mov       r8,rdi
       call      System.Linq.Enumerable.DefaultIfEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB37000A90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.First[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
; Total bytes of code 172
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
; 			var result = this.PersonProperCollection.FirstOrDefault(p => p.Id == this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+98]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rbx
       mov       r8,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
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
; Total bytes of code 125
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = this.PersonProperCollection.FirstOrDefault(p => p.Id == this.PersonProper.Id, this.PersonProper);
; 			                                                             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rdx+48]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,[rax+48]
       mov       rcx,rsi
       add       rsp,20
       pop       rsi
       jmp       near ptr System.String.Equals(System.String, System.String)
; Total bytes of code 36
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbp,r8
       mov       rsi,r9
       mov       r8,20432743060
       mov       r8,[r8]
       mov       rdx,204627411A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,20432743060
       mov       r8,[r8]
       mov       rdx,204627411A8
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       r14,[rdi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37000788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       mov       rdx,rbx
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L05
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L05
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFB370008E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L04:
       mov       rdx,rbx
       mov       r8,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
M02_L05:
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 256
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
; 			var result = this.PersonProperCollection.FirstOrDefault(p => p.Id == this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+98]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rbx
       mov       r8,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
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
; Total bytes of code 125
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = this.PersonProperCollection.FirstOrDefault(p => p.Id == this.PersonProper.Id, this.PersonProper);
; 			                                                             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rdx+48]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,[rax+48]
       mov       rcx,rsi
       add       rsp,20
       pop       rsi
       jmp       near ptr System.String.Equals(System.String, System.String)
; Total bytes of code 36
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbp,r8
       mov       rsi,r9
       mov       r8,1F3C6F51048
       mov       r8,[r8]
       mov       rdx,1F3A6F531B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1F3C6F51048
       mov       r8,[r8]
       mov       rdx,1F3A6F531C0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       r14,[rdi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37000708
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       mov       rdx,rbx
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L05
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L05
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFB37000868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L04:
       mov       rdx,rbx
       mov       r8,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
M02_L05:
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 256
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
; 			var result = this.PersonProperCollection.FirstOrDefault(p => p.Id == this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+98]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rbx
       mov       r8,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
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
; Total bytes of code 125
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = this.PersonProperCollection.FirstOrDefault(p => p.Id == this.PersonProper.Id, this.PersonProper);
; 			                                                             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rdx+48]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,[rax+48]
       mov       rcx,rsi
       add       rsp,20
       pop       rsi
       jmp       near ptr System.String.Equals(System.String, System.String)
; Total bytes of code 36
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbp,r8
       mov       rsi,r9
       mov       r8,1FE1EAE3060
       mov       r8,[r8]
       mov       rdx,1FE2EAE11A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1FE1EAE3060
       mov       r8,[r8]
       mov       rdx,1FE2EAE11A8
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       r14,[rdi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37010768
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       mov       rdx,rbx
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L05
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L05
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFB370108C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L04:
       mov       rdx,rbx
       mov       r8,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
M02_L05:
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 256
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
; 			var result = this.PersonProperCollection.FirstOrDefault(p => p.Id == this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+98]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rbx
       mov       r8,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
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
; Total bytes of code 125
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = this.PersonProperCollection.FirstOrDefault(p => p.Id == this.PersonProper.Id, this.PersonProper);
; 			                                                             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rdx+48]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,[rax+48]
       mov       rcx,rsi
       add       rsp,20
       pop       rsi
       jmp       near ptr System.String.Equals(System.String, System.String)
; Total bytes of code 36
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbp,r8
       mov       rsi,r9
       mov       r8,214FC241048
       mov       r8,[r8]
       mov       rdx,2150C24FBE0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,214FC241048
       mov       r8,[r8]
       mov       rdx,2150C24FBE8
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       r14,[rdi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FE08F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       mov       rdx,rbx
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L05
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L05
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0A50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L04:
       mov       rdx,rbx
       mov       r8,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
M02_L05:
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 256
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
; 			var result = this.PersonProperCollection.FirstOrDefault(p => p.Id == this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+98]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rbx
       mov       r8,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
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
; Total bytes of code 125
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = this.PersonProperCollection.FirstOrDefault(p => p.Id == this.PersonProper.Id, this.PersonProper);
; 			                                                             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rdx+48]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,[rax+48]
       mov       rcx,rsi
       add       rsp,20
       pop       rsi
       jmp       near ptr System.String.Equals(System.String, System.String)
; Total bytes of code 36
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbp,r8
       mov       rsi,r9
       mov       r8,24C58693060
       mov       r8,[r8]
       mov       rdx,24C886911A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,24C58693060
       mov       r8,[r8]
       mov       rdx,24C886911A8
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       r14,[rdi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FF08F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       mov       rdx,rbx
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L05
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L05
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0A50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L04:
       mov       rdx,rbx
       mov       r8,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
M02_L05:
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 256
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
; 			var result = this.PersonProperCollection.FirstOrDefault(p => p.Id == this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+98]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rbx
       mov       r8,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
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
; Total bytes of code 125
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = this.PersonProperCollection.FirstOrDefault(p => p.Id == this.PersonProper.Id, this.PersonProper);
; 			                                                             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rdx+48]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,[rax+48]
       mov       rcx,rsi
       add       rsp,20
       pop       rsi
       jmp       near ptr System.String.Equals(System.String, System.String)
; Total bytes of code 36
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbp,r8
       mov       rsi,r9
       mov       r8,1F6E3193060
       mov       r8,[r8]
       mov       rdx,1F6F319DBC8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1F6E3193060
       mov       r8,[r8]
       mov       rdx,1F6F319DBD0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       r14,[rdi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FF08F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       mov       rdx,rbx
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L05
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L05
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0A50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L04:
       mov       rdx,rbx
       mov       r8,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
M02_L05:
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 256
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
; 			var result = this.PersonProperCollection.FirstOrDefault(p => p.Id == this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+98]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rbx
       mov       r8,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
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
; Total bytes of code 125
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = this.PersonProperCollection.FirstOrDefault(p => p.Id == this.PersonProper.Id, this.PersonProper);
; 			                                                             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rdx+48]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,[rax+48]
       mov       rcx,rsi
       add       rsp,20
       pop       rsi
       jmp       near ptr System.String.Equals(System.String, System.String)
; Total bytes of code 36
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbp,r8
       mov       rsi,r9
       mov       r8,1E257713060
       mov       r8,[r8]
       mov       rdx,1E2677131B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1E257713060
       mov       r8,[r8]
       mov       rdx,1E2677131C0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       r14,[rdi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37010708
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       mov       rdx,rbx
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L05
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L05
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFB37010868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L04:
       mov       rdx,rbx
       mov       r8,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
M02_L05:
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 256
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
; 			var result = this.PersonProperCollection.FirstOrDefault(p => p.Id == this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+98]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rbx
       mov       r8,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
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
; Total bytes of code 125
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = this.PersonProperCollection.FirstOrDefault(p => p.Id == this.PersonProper.Id, this.PersonProper);
; 			                                                             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rdx+48]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,[rax+48]
       mov       rcx,rsi
       add       rsp,20
       pop       rsi
       jmp       near ptr System.String.Equals(System.String, System.String)
; Total bytes of code 36
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbp,r8
       mov       rsi,r9
       mov       r8,210B2CC3060
       mov       r8,[r8]
       mov       rdx,210B2CC5608
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,210B2CC3060
       mov       r8,[r8]
       mov       rdx,210B2CC5610
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       r14,[rdi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0B78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       mov       rdx,rbx
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L05
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L05
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0CD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L04:
       mov       rdx,rbx
       mov       r8,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
M02_L05:
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 256
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrDefaultAlternate02()
; 			var result = this.PersonProperCollection.FirstOrDefault(p => p.Id == this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+98]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rbx
       mov       r8,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, !!0)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
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
; Total bytes of code 125
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrDefaultAlternate02>b__4_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = this.PersonProperCollection.FirstOrDefault(p => p.Id == this.PersonProper.Id, this.PersonProper);
; 			                                                             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rdx+48]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,[rax+48]
       mov       rcx,rsi
       add       rsp,20
       pop       rsi
       jmp       near ptr System.String.Equals(System.String, System.String)
; Total bytes of code 36
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbp,r8
       mov       rsi,r9
       mov       r8,145FC943060
       mov       r8,[r8]
       mov       rdx,145FC945608
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,145FC943060
       mov       r8,[r8]
       mov       rdx,145FC945610
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       r14,[rdi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0998
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       mov       rdx,rbx
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       test      rbx,rbx
       je        short M02_L05
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L05
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0AF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L04:
       mov       rdx,rbx
       mov       r8,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.__Canon)
M02_L05:
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 256
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableDictionary01()
; 			var result = base.PersonProperDictionary.ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
; dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1E253F51048
       mov       r8,[r8]
       mov       rdx,1E263F511A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37012AA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Immutable.ImmutableDictionary.CreateRange[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
; Total bytes of code 101
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableDictionary01()
; 			var result = base.PersonProperDictionary.ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
; dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,23EC42C3060
       mov       r8,[r8]
       mov       rdx,23EF42C11A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37002AC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Immutable.ImmutableDictionary.CreateRange[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
; Total bytes of code 101
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableDictionary01()
; 			var result = base.PersonProperDictionary.ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
; dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,28889243060
       mov       r8,[r8]
       mov       rdx,288992411A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE2AA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Immutable.ImmutableDictionary.CreateRange[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
; Total bytes of code 101
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableDictionary01()
; 			var result = base.PersonProperDictionary.ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
; dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,209973D3060
       mov       r8,[r8]
       mov       rdx,209973E0018
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FD2AC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Immutable.ImmutableDictionary.CreateRange[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
; Total bytes of code 101
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableDictionary01()
; 			var result = base.PersonProperDictionary.ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
; dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,2366AB03060
       mov       r8,[r8]
       mov       rdx,2367AB031B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF2CD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Immutable.ImmutableDictionary.CreateRange[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
; Total bytes of code 101
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableDictionary01()
; 			var result = base.PersonProperDictionary.ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
; dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,25796E43060
       mov       r8,[r8]
       mov       rdx,25796E52868
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF2EB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Immutable.ImmutableDictionary.CreateRange[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
; Total bytes of code 101
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableDictionary01()
; 			var result = base.PersonProperDictionary.ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
; dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,17BE0C13060
       mov       r8,[r8]
       mov       rdx,17BF0C111A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF2EB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Immutable.ImmutableDictionary.CreateRange[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
; Total bytes of code 101
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableDictionary01()
; 			var result = base.PersonProperDictionary.ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
; dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,195939D3060
       mov       r8,[r8]
       mov       rdx,195939D35F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE2EB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Immutable.ImmutableDictionary.CreateRange[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
; Total bytes of code 101
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableDictionary01()
; 			var result = base.PersonProperDictionary.ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
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
; dotNetTips.Spargine.Extensions.DictionaryExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,181515F3060
       mov       r8,[r8]
       mov       rdx,181515F5608
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37012AA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Immutable.ImmutableDictionary.CreateRange[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
; Total bytes of code 101
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableList01()
; 			var result = base.PersonProperCollection.ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1DDD3813060
       mov       r8,[r8]
       mov       rdx,1DDE38111A0
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
       mov       rdx,7FFB37010980
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Immutable.ImmutableList.CreateRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
; Total bytes of code 101
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableList01()
; 			var result = base.PersonProperCollection.ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1499EE93060
       mov       r8,[r8]
       mov       rdx,1498EE911A0
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
       mov       rdx,7FFB36FE0980
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Immutable.ImmutableList.CreateRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
; Total bytes of code 101
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableList01()
; 			var result = base.PersonProperCollection.ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,29C51893060
       mov       r8,[r8]
       mov       rdx,29C318911A0
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
       mov       rdx,7FFB36FF0980
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Immutable.ImmutableList.CreateRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
; Total bytes of code 101
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableList01()
; 			var result = base.PersonProperCollection.ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,28B3FD23060
       mov       r8,[r8]
       mov       rdx,28B3FD25E40
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
       mov       rdx,7FFB36FF0B10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Immutable.ImmutableList.CreateRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
; Total bytes of code 101
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableList01()
; 			var result = base.PersonProperCollection.ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,2BB9AB43060
       mov       r8,[r8]
       mov       rdx,2BBAAB411A0
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
       mov       rdx,7FFB370009A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Immutable.ImmutableList.CreateRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
; Total bytes of code 101
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableList01()
; 			var result = base.PersonProperCollection.ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,2C8F2AF3060
       mov       r8,[r8]
       mov       rdx,2C922AF11A0
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
       mov       rdx,7FFB37000D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Immutable.ImmutableList.CreateRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
; Total bytes of code 101
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableList01()
; 			var result = base.PersonProperCollection.ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,17522793060
       mov       r8,[r8]
       mov       rdx,175427931B8
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
       mov       rdx,7FFB36FE0D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Immutable.ImmutableList.CreateRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
; Total bytes of code 101
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableList01()
; 			var result = base.PersonProperCollection.ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,17643F23060
       mov       r8,[r8]
       mov       rdx,17633F211A0
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
       mov       rdx,7FFB36FF0D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Immutable.ImmutableList.CreateRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
; Total bytes of code 101
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToImmutableList01()
; 			var result = base.PersonProperCollection.ToImmutable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToImmutable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,208284C3060
       mov       r8,[r8]
       mov       rdx,208384C11A0
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
       mov       rdx,7FFB36FE0D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Immutable.ImmutableList.CreateRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
; Total bytes of code 101
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Count01()
; 			var result = base.PersonProperCollection.Count();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+98]
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L01
       mov       rcx,rax
       mov       r11,7FFB36B203A8
       mov       rax,[7FFB36F203A8]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L01:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB36B20398
       call      qword ptr [7FFB36F20398]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FFB36B203A0
       call      qword ptr [7FFB36F203A0]
       test      eax,eax
       je        short M01_L03
M01_L02:
       inc       edi
       mov       rcx,rsi
       mov       r11,7FFB36B203A0
       call      qword ptr [7FFB36F203A0]
       test      eax,eax
       jne       short M01_L02
M01_L03:
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 164
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Count01()
; 			var result = base.PersonProperCollection.Count();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+98]
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L01
       mov       rcx,rax
       mov       r11,7FFB36B003A8
       mov       rax,[7FFB36F003A8]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L01:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB36B00398
       call      qword ptr [7FFB36F00398]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FFB36B003A0
       call      qword ptr [7FFB36F003A0]
       test      eax,eax
       je        short M01_L03
M01_L02:
       inc       edi
       mov       rcx,rsi
       mov       r11,7FFB36B003A0
       call      qword ptr [7FFB36F003A0]
       test      eax,eax
       jne       short M01_L02
M01_L03:
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 164
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Count01()
; 			var result = base.PersonProperCollection.Count();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+98]
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L01
       mov       rcx,rax
       mov       r11,7FFB36B203A8
       mov       rax,[7FFB36F203A8]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L01:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB36B20398
       call      qword ptr [7FFB36F20398]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FFB36B203A0
       call      qword ptr [7FFB36F203A0]
       test      eax,eax
       je        short M01_L03
M01_L02:
       inc       edi
       mov       rcx,rsi
       mov       r11,7FFB36B203A0
       call      qword ptr [7FFB36F203A0]
       test      eax,eax
       jne       short M01_L02
M01_L03:
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 164
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Count01()
; 			var result = base.PersonProperCollection.Count();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+98]
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L01
       mov       rcx,rax
       mov       r11,7FFB36AF03A8
       mov       rax,[7FFB36EF03A8]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L01:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB36AF0398
       call      qword ptr [7FFB36EF0398]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FFB36AF03A0
       call      qword ptr [7FFB36EF03A0]
       test      eax,eax
       je        short M01_L03
M01_L02:
       inc       edi
       mov       rcx,rsi
       mov       r11,7FFB36AF03A0
       call      qword ptr [7FFB36EF03A0]
       test      eax,eax
       jne       short M01_L02
M01_L03:
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 164
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Count01()
; 			var result = base.PersonProperCollection.Count();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+98]
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L01
       mov       rcx,rax
       mov       r11,7FFB36B003A8
       mov       rax,[7FFB36F003A8]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L01:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB36B00398
       call      qword ptr [7FFB36F00398]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FFB36B003A0
       call      qword ptr [7FFB36F003A0]
       test      eax,eax
       je        short M01_L03
M01_L02:
       inc       edi
       mov       rcx,rsi
       mov       r11,7FFB36B003A0
       call      qword ptr [7FFB36F003A0]
       test      eax,eax
       jne       short M01_L02
M01_L03:
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 164
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Count01()
; 			var result = base.PersonProperCollection.Count();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+98]
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L01
       mov       rcx,rax
       mov       r11,7FFB36B003A8
       mov       rax,[7FFB36F003A8]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L01:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB36B00398
       call      qword ptr [7FFB36F00398]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FFB36B003A0
       call      qword ptr [7FFB36F003A0]
       test      eax,eax
       je        short M01_L03
M01_L02:
       inc       edi
       mov       rcx,rsi
       mov       r11,7FFB36B003A0
       call      qword ptr [7FFB36F003A0]
       test      eax,eax
       jne       short M01_L02
M01_L03:
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 164
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Count01()
; 			var result = base.PersonProperCollection.Count();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+98]
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L01
       mov       rcx,rax
       mov       r11,7FFB36B003A8
       mov       rax,[7FFB36F003A8]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L01:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB36B00398
       call      qword ptr [7FFB36F00398]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FFB36B003A0
       call      qword ptr [7FFB36F003A0]
       test      eax,eax
       je        short M01_L03
M01_L02:
       inc       edi
       mov       rcx,rsi
       mov       r11,7FFB36B003A0
       call      qword ptr [7FFB36F003A0]
       test      eax,eax
       jne       short M01_L02
M01_L03:
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 164
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Count01()
; 			var result = base.PersonProperCollection.Count();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+98]
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L01
       mov       rcx,rax
       mov       r11,7FFB36B203A8
       mov       rax,[7FFB36F203A8]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L01:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB36B20398
       call      qword ptr [7FFB36F20398]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FFB36B203A0
       call      qword ptr [7FFB36F203A0]
       test      eax,eax
       je        short M01_L03
M01_L02:
       inc       edi
       mov       rcx,rsi
       mov       r11,7FFB36B203A0
       call      qword ptr [7FFB36F203A0]
       test      eax,eax
       jne       short M01_L02
M01_L03:
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 164
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.Count01()
; 			var result = base.PersonProperCollection.Count();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+98]
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L01
       mov       rcx,rax
       mov       r11,7FFB36B103A8
       mov       rax,[7FFB36F103A8]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L01:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFB36B10398
       call      qword ptr [7FFB36F10398]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FFB36B103A0
       call      qword ptr [7FFB36F103A0]
       test      eax,eax
       je        short M01_L03
M01_L02:
       inc       edi
       mov       rcx,rsi
       mov       r11,7FFB36B103A0
       call      qword ptr [7FFB36F103A0]
       test      eax,eax
       jne       short M01_L02
M01_L03:
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 164
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
; 			var result = base.PersonProperCollection.FastAny(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,23B8627BDA8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,23B8627BDA0
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,23B8627BDA8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.FastAny(p => p.City.Contains("SAN"));
; 			                                                      ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,23B962711B0
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       r8,23B86273060
       mov       r8,[r8]
       mov       rdx,23B962711A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       test      rbx,rbx
       setne     dl
       movzx     edx,dl
       mov       r9,23B86273060
       mov       r9,[r9]
       mov       r8,23B962711A8
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37000900
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       test      rax,rax
       setne     al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 169
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
; 			var result = base.PersonProperCollection.FastAny(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,23E35CBBDA8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,23E35CBBDA0
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,23E35CBBDA8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.FastAny(p => p.City.Contains("SAN"));
; 			                                                      ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,23E45CB11B0
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       r8,23E35CB3060
       mov       r8,[r8]
       mov       rdx,23E45CB11A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       test      rbx,rbx
       setne     dl
       movzx     edx,dl
       mov       r9,23E35CB3060
       mov       r9,[r9]
       mov       r8,23E45CB11A8
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37010900
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       test      rax,rax
       setne     al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 169
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
; 			var result = base.PersonProperCollection.FastAny(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,246565E9D90
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,246565E9D88
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,246565E9D90
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.FastAny(p => p.City.Contains("SAN"));
; 			                                                      ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,246465E11B0
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       r8,246565E1048
       mov       r8,[r8]
       mov       rdx,246465E11A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       test      rbx,rbx
       setne     dl
       movzx     edx,dl
       mov       r9,246565E1048
       mov       r9,[r9]
       mov       r8,246465E11A8
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0980
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       test      rax,rax
       setne     al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 169
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
; 			var result = base.PersonProperCollection.FastAny(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,1E86E8E9958
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1E86E8E9950
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1E86E8E9958
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.FastAny(p => p.City.Contains("SAN"));
; 			                                                      ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,1E85E8E19E8
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       r8,1E84E8E3060
       mov       r8,[r8]
       mov       rdx,1E85E8E19D8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       test      rbx,rbx
       setne     dl
       movzx     edx,dl
       mov       r9,1E84E8E3060
       mov       r9,[r9]
       mov       r8,1E85E8E19E0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37000B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       test      rax,rax
       setne     al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 169
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
; 			var result = base.PersonProperCollection.FastAny(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,1CFE3A99958
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1CFE3A99950
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1CFE3A99958
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.FastAny(p => p.City.Contains("SAN"));
; 			                                                      ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,1CFF3A911B0
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       r8,1CFC3A93060
       mov       r8,[r8]
       mov       rdx,1CFF3A911A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       test      rbx,rbx
       setne     dl
       movzx     edx,dl
       mov       r9,1CFC3A93060
       mov       r9,[r9]
       mov       r8,1CFF3A911A8
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0960
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       test      rax,rax
       setne     al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 169
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
; 			var result = base.PersonProperCollection.FastAny(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,280EE3E9958
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,280EE3E9950
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,280EE3E9958
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.FastAny(p => p.City.Contains("SAN"));
; 			                                                      ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,280CE3E3600
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       r8,280CE3E3060
       mov       r8,[r8]
       mov       rdx,280CE3E35F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       test      rbx,rbx
       setne     dl
       movzx     edx,dl
       mov       r9,280CE3E3060
       mov       r9,[r9]
       mov       r8,280CE3E35F8
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       test      rax,rax
       setne     al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 169
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
; 			var result = base.PersonProperCollection.FastAny(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,19F7FAE9958
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,19F7FAE9950
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,19F7FAE9958
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.FastAny(p => p.City.Contains("SAN"));
; 			                                                      ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,19F6FB02A38
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       r8,19F6FAE3060
       mov       r8,[r8]
       mov       rdx,19F6FB02A28
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       test      rbx,rbx
       setne     dl
       movzx     edx,dl
       mov       r9,19F6FAE3060
       mov       r9,[r9]
       mov       r8,19F6FB02A30
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37000D70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       test      rax,rax
       setne     al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 169
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
; 			var result = base.PersonProperCollection.FastAny(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,261408F9958
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,261408F9950
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,261408F9958
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.FastAny(p => p.City.Contains("SAN"));
; 			                                                      ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,2613092F9E8
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       r8,261208F3060
       mov       r8,[r8]
       mov       rdx,2613092F9D8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       test      rbx,rbx
       setne     dl
       movzx     edx,dl
       mov       r9,261208F3060
       mov       r9,[r9]
       mov       r8,2613092F9E0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0AE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       test      rax,rax
       setne     al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 169
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastAny01()
; 			var result = base.PersonProperCollection.FastAny(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,1F69D327940
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1F69D327938
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1F69D327940
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastAny01>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.FastAny(p => p.City.Contains("SAN"));
; 			                                                      ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,1F6BD323E38
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       r8,1F6BD323060
       mov       r8,[r8]
       mov       rdx,1F6BD323E28
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       test      rbx,rbx
       setne     dl
       movzx     edx,dl
       mov       r9,1F6BD323060
       mov       r9,[r9]
       mov       r8,1F6BD323E30
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37010D70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       test      rax,rax
       setne     al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 169
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
; 			var result = base.PersonProperCollection.FastCount(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,18ED7FABDB0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,18ED7FABDA0
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,18ED7FABDB0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.FastCount(p => p.City.Contains("SAN"));
; 			                                                        ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,18EB7FA19E0
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       r8,18ED7FA3060
       mov       r8,[r8]
       mov       rdx,18EB7FA19D8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rdi,rdi
       sete      al
       movzx     eax,al
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
       mov       rbp,[rsi+10]
       mov       r14,[rbp+10]
       test      r14,r14
       je        short M02_L01
       mov       rcx,r14
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0740
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M02_L07
       test      r14,r14
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0740
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M02_L04:
       mov       rcx,r14
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       rdi,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0C08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M02_L07:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0C08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
; Total bytes of code 284
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
; 			var result = base.PersonProperCollection.FastCount(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,19B830E7948
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,19B830E7938
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,19B830E7948
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.FastCount(p => p.City.Contains("SAN"));
; 			                                                        ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,19BB30E11A8
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       r8,19BA30E3060
       mov       r8,[r8]
       mov       rdx,19BB30E11A0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rdi,rdi
       sete      al
       movzx     eax,al
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
       mov       rbp,[rsi+10]
       mov       r14,[rbp+10]
       test      r14,r14
       je        short M02_L01
       mov       rcx,r14
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB370107C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M02_L07
       test      r14,r14
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB370107C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M02_L04:
       mov       rcx,r14
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       rdi,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37010C88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M02_L07:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37010C88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
; Total bytes of code 284
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
; 			var result = base.PersonProperCollection.FastCount(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,1D374D99960
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1D374D99950
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1D374D99960
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.FastCount(p => p.City.Contains("SAN"));
; 			                                                        ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,1D384D911A8
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       r8,1D354D93060
       mov       r8,[r8]
       mov       rdx,1D384D911A0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rdi,rdi
       sete      al
       movzx     eax,al
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
       mov       rbp,[rsi+10]
       mov       r14,[rbp+10]
       test      r14,r14
       je        short M02_L01
       mov       rcx,r14
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0740
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M02_L07
       test      r14,r14
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0740
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M02_L04:
       mov       rcx,r14
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       rdi,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0C08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M02_L07:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0C08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
; Total bytes of code 284
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
; 			var result = base.PersonProperCollection.FastCount(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,2F579BE7948
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2F579BE7938
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2F579BE7948
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.FastCount(p => p.City.Contains("SAN"));
; 			                                                        ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,2F579BEDBD0
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       r8,2F589BE1048
       mov       r8,[r8]
       mov       rdx,2F579BEDBC8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rdi,rdi
       sete      al
       movzx     eax,al
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
       mov       rbp,[rsi+10]
       mov       r14,[rbp+10]
       test      r14,r14
       je        short M02_L01
       mov       rcx,r14
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB36FF09D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M02_L07
       test      r14,r14
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB36FF09D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M02_L04:
       mov       rcx,r14
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       rdi,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0E98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M02_L07:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0E98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
; Total bytes of code 284
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
; 			var result = base.PersonProperCollection.FastCount(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,21269EE9960
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,21269EE9950
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,21269EE9960
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.FastCount(p => p.City.Contains("SAN"));
; 			                                                        ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,21269EEFBE8
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       r8,21249EE3060
       mov       r8,[r8]
       mov       rdx,21269EEFBE0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rdi,rdi
       sete      al
       movzx     eax,al
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
       mov       rbp,[rsi+10]
       mov       r14,[rbp+10]
       test      r14,r14
       je        short M02_L01
       mov       rcx,r14
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB36FF09D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M02_L07
       test      r14,r14
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB36FF09D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M02_L04:
       mov       rcx,r14
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       rdi,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0E98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M02_L07:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0E98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
; Total bytes of code 284
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
; 			var result = base.PersonProperCollection.FastCount(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,23DC2C47948
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,23DC2C47938
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,23DC2C47948
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.FastCount(p => p.City.Contains("SAN"));
; 			                                                        ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,23DB2C411A8
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       r8,23DD2C43060
       mov       r8,[r8]
       mov       rdx,23DB2C411A0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rdi,rdi
       sete      al
       movzx     eax,al
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
       mov       rbp,[rsi+10]
       mov       r14,[rbp+10]
       test      r14,r14
       je        short M02_L01
       mov       rcx,r14
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB37000928
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M02_L07
       test      r14,r14
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB37000928
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M02_L04:
       mov       rcx,r14
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       rdi,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37000DF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M02_L07:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37000DF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
; Total bytes of code 284
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
; 			var result = base.PersonProperCollection.FastCount(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,1F123267D80
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1F123267D70
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1F123267D80
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.FastCount(p => p.City.Contains("SAN"));
; 			                                                        ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,1F1132805E0
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       r8,1F123261048
       mov       r8,[r8]
       mov       rdx,1F1132805D8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rdi,rdi
       sete      al
       movzx     eax,al
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
       mov       rbp,[rsi+10]
       mov       r14,[rbp+10]
       test      r14,r14
       je        short M02_L01
       mov       rcx,r14
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0BB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M02_L07
       test      r14,r14
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0BB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M02_L04:
       mov       rcx,r14
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       rdi,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1078
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M02_L07:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1078
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
; Total bytes of code 284
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
; 			var result = base.PersonProperCollection.FastCount(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,252434D9D98
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,252434D9D88
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,252434D9D98
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.FastCount(p => p.City.Contains("SAN"));
; 			                                                        ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,2525350F9E0
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       r8,252434D1048
       mov       r8,[r8]
       mov       rdx,2525350F9D8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rdi,rdi
       sete      al
       movzx     eax,al
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
       mov       rbp,[rsi+10]
       mov       r14,[rbp+10]
       test      r14,r14
       je        short M02_L01
       mov       rcx,r14
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0BB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M02_L07
       test      r14,r14
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0BB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M02_L04:
       mov       rcx,r14
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       rdi,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1078
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M02_L07:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1078
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
; Total bytes of code 284
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FastCount01()
; 			var result = base.PersonProperCollection.FastCount(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,26DBAFF9960
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,26DBAFF9950
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,26DBAFF9960
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+10]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<FastCount01>b__2_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.FastCount(p => p.City.Contains("SAN"));
; 			                                                        ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,26DCAFF11A8
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       r8,26D9AFF3060
       mov       r8,[r8]
       mov       rdx,26DCAFF11A0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       test      rdi,rdi
       sete      al
       movzx     eax,al
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
       mov       rbp,[rsi+10]
       mov       r14,[rbp+10]
       test      r14,r14
       je        short M02_L01
       mov       rcx,r14
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,7FFB37010930
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M02_L07
       test      r14,r14
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB37010930
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M02_L04:
       mov       rcx,r14
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       rdi,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37010DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M02_L07:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37010DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
; Total bytes of code 284
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrNull01()
; 			var result = base.CoordinateArray.FirstOrNull(p => p.X == this.Coordinate.X);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+78]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__5_0(dotNetTips.Spargine.Tester.Models.CoordinateProper)
       mov       [rdi+18],rcx
       lea       rcx,[rsp+20]
       mov       rdx,rbx
       mov       r8,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>, System.Func`2<dotNetTips.Spargine.Tester.Models.CoordinateProper,Boolean>)
       mov       rsi,[rsi+10]
       cmp       [rsi],esi
       lea       rdx,[rsp+20]
       mov       rcx,offset MT_System.Nullable`1[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]]
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
; Total bytes of code 133
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__5_0(dotNetTips.Spargine.Tester.Models.CoordinateProper)
; 			var result = base.CoordinateArray.FirstOrNull(p => p.X == this.Coordinate.X);
; 			                                                   ^^^^^^^^^^^^^^^^^^^^^^^^
       mov       [rsp+10],rdx
       mov       eax,[rsp+10]
       add       rcx,60
       mov       edx,[rcx]
       mov       ecx,[rcx+4]
       cmp       eax,edx
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 27
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>, System.Func`2<dotNetTips.Spargine.Tester.Models.CoordinateProper,Boolean>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       jne       short M02_L00
       xor       eax,eax
       mov       [rdi],rax
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       r8,1D7BACA3060
       mov       r8,[r8]
       mov       rdx,1D7CACA11A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rbx
       call      System.Linq.Enumerable.ToList[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>)
       mov       rbx,rax
       xor       ebp,ebp
       cmp       dword ptr [rbx+10],0
       jle       short M02_L03
M02_L01:
       cmp       ebp,[rbx+10]
       jae       near ptr M02_L05
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M02_L06
       movsxd    rdx,ebp
       lea       rcx,[rcx+rdx*8+10]
       mov       r14d,[rcx]
       mov       r15d,[rcx+4]
       test      rsi,rsi
       je        short M02_L02
       lea       rcx,[rsp+20]
       mov       [rcx],r14d
       mov       [rcx+4],r15d
       mov       rax,rsi
       mov       rcx,[rax+8]
       mov       rdx,[rsp+20]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L04
M02_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M02_L01
M02_L03:
       xor       eax,eax
       mov       [rdi],rax
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],eax
       lea       rax,[rsp+2C]
       mov       [rax],r14d
       mov       [rax+4],r15d
       mov       byte ptr [rsp+28],1
       mov       rax,[rsp+28]
       mov       [rdi],rax
       mov       eax,[rsp+30]
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M02_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 278
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrNull01()
; 			var result = base.CoordinateArray.FirstOrNull(p => p.X == this.Coordinate.X);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+78]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__5_0(dotNetTips.Spargine.Tester.Models.CoordinateProper)
       mov       [rdi+18],rcx
       lea       rcx,[rsp+20]
       mov       rdx,rbx
       mov       r8,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>, System.Func`2<dotNetTips.Spargine.Tester.Models.CoordinateProper,Boolean>)
       mov       rsi,[rsi+10]
       cmp       [rsi],esi
       lea       rdx,[rsp+20]
       mov       rcx,offset MT_System.Nullable`1[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]]
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
; Total bytes of code 133
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__5_0(dotNetTips.Spargine.Tester.Models.CoordinateProper)
; 			var result = base.CoordinateArray.FirstOrNull(p => p.X == this.Coordinate.X);
; 			                                                   ^^^^^^^^^^^^^^^^^^^^^^^^
       mov       [rsp+10],rdx
       mov       eax,[rsp+10]
       add       rcx,60
       mov       edx,[rcx]
       mov       ecx,[rcx+4]
       cmp       eax,edx
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 27
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>, System.Func`2<dotNetTips.Spargine.Tester.Models.CoordinateProper,Boolean>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       jne       short M02_L00
       xor       eax,eax
       mov       [rdi],rax
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       r8,1B8EA333060
       mov       r8,[r8]
       mov       rdx,1B8FA33B170
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rbx
       call      System.Linq.Enumerable.ToList[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>)
       mov       rbx,rax
       xor       ebp,ebp
       cmp       dword ptr [rbx+10],0
       jle       short M02_L03
M02_L01:
       cmp       ebp,[rbx+10]
       jae       near ptr M02_L05
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M02_L06
       movsxd    rdx,ebp
       lea       rcx,[rcx+rdx*8+10]
       mov       r14d,[rcx]
       mov       r15d,[rcx+4]
       test      rsi,rsi
       je        short M02_L02
       lea       rcx,[rsp+20]
       mov       [rcx],r14d
       mov       [rcx+4],r15d
       mov       rax,rsi
       mov       rcx,[rax+8]
       mov       rdx,[rsp+20]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L04
M02_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M02_L01
M02_L03:
       xor       eax,eax
       mov       [rdi],rax
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],eax
       lea       rax,[rsp+2C]
       mov       [rax],r14d
       mov       [rax+4],r15d
       mov       byte ptr [rsp+28],1
       mov       rax,[rsp+28]
       mov       [rdi],rax
       mov       eax,[rsp+30]
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M02_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 278
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrNull01()
; 			var result = base.CoordinateArray.FirstOrNull(p => p.X == this.Coordinate.X);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+78]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__5_0(dotNetTips.Spargine.Tester.Models.CoordinateProper)
       mov       [rdi+18],rcx
       lea       rcx,[rsp+20]
       mov       rdx,rbx
       mov       r8,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>, System.Func`2<dotNetTips.Spargine.Tester.Models.CoordinateProper,Boolean>)
       mov       rsi,[rsi+10]
       cmp       [rsi],esi
       lea       rdx,[rsp+20]
       mov       rcx,offset MT_System.Nullable`1[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]]
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
; Total bytes of code 133
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__5_0(dotNetTips.Spargine.Tester.Models.CoordinateProper)
; 			var result = base.CoordinateArray.FirstOrNull(p => p.X == this.Coordinate.X);
; 			                                                   ^^^^^^^^^^^^^^^^^^^^^^^^
       mov       [rsp+10],rdx
       mov       eax,[rsp+10]
       add       rcx,60
       mov       edx,[rcx]
       mov       ecx,[rcx+4]
       cmp       eax,edx
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 27
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>, System.Func`2<dotNetTips.Spargine.Tester.Models.CoordinateProper,Boolean>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       jne       short M02_L00
       xor       eax,eax
       mov       [rdi],rax
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       r8,2BCCE001048
       mov       r8,[r8]
       mov       rdx,2BCAE0039F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rbx
       call      System.Linq.Enumerable.ToList[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>)
       mov       rbx,rax
       xor       ebp,ebp
       cmp       dword ptr [rbx+10],0
       jle       short M02_L03
M02_L01:
       cmp       ebp,[rbx+10]
       jae       near ptr M02_L05
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M02_L06
       movsxd    rdx,ebp
       lea       rcx,[rcx+rdx*8+10]
       mov       r14d,[rcx]
       mov       r15d,[rcx+4]
       test      rsi,rsi
       je        short M02_L02
       lea       rcx,[rsp+20]
       mov       [rcx],r14d
       mov       [rcx+4],r15d
       mov       rax,rsi
       mov       rcx,[rax+8]
       mov       rdx,[rsp+20]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L04
M02_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M02_L01
M02_L03:
       xor       eax,eax
       mov       [rdi],rax
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],eax
       lea       rax,[rsp+2C]
       mov       [rax],r14d
       mov       [rax+4],r15d
       mov       byte ptr [rsp+28],1
       mov       rax,[rsp+28]
       mov       [rdi],rax
       mov       eax,[rsp+30]
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M02_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 278
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrNull01()
; 			var result = base.CoordinateArray.FirstOrNull(p => p.X == this.Coordinate.X);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+78]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__5_0(dotNetTips.Spargine.Tester.Models.CoordinateProper)
       mov       [rdi+18],rcx
       lea       rcx,[rsp+20]
       mov       rdx,rbx
       mov       r8,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>, System.Func`2<dotNetTips.Spargine.Tester.Models.CoordinateProper,Boolean>)
       mov       rsi,[rsi+10]
       cmp       [rsi],esi
       lea       rdx,[rsp+20]
       mov       rcx,offset MT_System.Nullable`1[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]]
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
; Total bytes of code 133
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__5_0(dotNetTips.Spargine.Tester.Models.CoordinateProper)
; 			var result = base.CoordinateArray.FirstOrNull(p => p.X == this.Coordinate.X);
; 			                                                   ^^^^^^^^^^^^^^^^^^^^^^^^
       mov       [rsp+10],rdx
       mov       eax,[rsp+10]
       add       rcx,60
       mov       edx,[rcx]
       mov       ecx,[rcx+4]
       cmp       eax,edx
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 27
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>, System.Func`2<dotNetTips.Spargine.Tester.Models.CoordinateProper,Boolean>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       jne       short M02_L00
       xor       eax,eax
       mov       [rdi],rax
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       r8,1A1DF1F1048
       mov       r8,[r8]
       mov       rdx,1A1EF1F11A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rbx
       call      System.Linq.Enumerable.ToList[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>)
       mov       rbx,rax
       xor       ebp,ebp
       cmp       dword ptr [rbx+10],0
       jle       short M02_L03
M02_L01:
       cmp       ebp,[rbx+10]
       jae       near ptr M02_L05
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M02_L06
       movsxd    rdx,ebp
       lea       rcx,[rcx+rdx*8+10]
       mov       r14d,[rcx]
       mov       r15d,[rcx+4]
       test      rsi,rsi
       je        short M02_L02
       lea       rcx,[rsp+20]
       mov       [rcx],r14d
       mov       [rcx+4],r15d
       mov       rax,rsi
       mov       rcx,[rax+8]
       mov       rdx,[rsp+20]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L04
M02_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M02_L01
M02_L03:
       xor       eax,eax
       mov       [rdi],rax
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],eax
       lea       rax,[rsp+2C]
       mov       [rax],r14d
       mov       [rax+4],r15d
       mov       byte ptr [rsp+28],1
       mov       rax,[rsp+28]
       mov       [rdi],rax
       mov       eax,[rsp+30]
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M02_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 278
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrNull01()
; 			var result = base.CoordinateArray.FirstOrNull(p => p.X == this.Coordinate.X);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+78]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__5_0(dotNetTips.Spargine.Tester.Models.CoordinateProper)
       mov       [rdi+18],rcx
       lea       rcx,[rsp+20]
       mov       rdx,rbx
       mov       r8,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>, System.Func`2<dotNetTips.Spargine.Tester.Models.CoordinateProper,Boolean>)
       mov       rsi,[rsi+10]
       cmp       [rsi],esi
       lea       rdx,[rsp+20]
       mov       rcx,offset MT_System.Nullable`1[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]]
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
; Total bytes of code 133
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__5_0(dotNetTips.Spargine.Tester.Models.CoordinateProper)
; 			var result = base.CoordinateArray.FirstOrNull(p => p.X == this.Coordinate.X);
; 			                                                   ^^^^^^^^^^^^^^^^^^^^^^^^
       mov       [rsp+10],rdx
       mov       eax,[rsp+10]
       add       rcx,60
       mov       edx,[rcx]
       mov       ecx,[rcx+4]
       cmp       eax,edx
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 27
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>, System.Func`2<dotNetTips.Spargine.Tester.Models.CoordinateProper,Boolean>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       jne       short M02_L00
       xor       eax,eax
       mov       [rdi],rax
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       r8,287AAF83060
       mov       r8,[r8]
       mov       rdx,2879AF8E400
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rbx
       call      System.Linq.Enumerable.ToList[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>)
       mov       rbx,rax
       xor       ebp,ebp
       cmp       dword ptr [rbx+10],0
       jle       short M02_L03
M02_L01:
       cmp       ebp,[rbx+10]
       jae       near ptr M02_L05
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M02_L06
       movsxd    rdx,ebp
       lea       rcx,[rcx+rdx*8+10]
       mov       r14d,[rcx]
       mov       r15d,[rcx+4]
       test      rsi,rsi
       je        short M02_L02
       lea       rcx,[rsp+20]
       mov       [rcx],r14d
       mov       [rcx+4],r15d
       mov       rax,rsi
       mov       rcx,[rax+8]
       mov       rdx,[rsp+20]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L04
M02_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M02_L01
M02_L03:
       xor       eax,eax
       mov       [rdi],rax
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],eax
       lea       rax,[rsp+2C]
       mov       [rax],r14d
       mov       [rax+4],r15d
       mov       byte ptr [rsp+28],1
       mov       rax,[rsp+28]
       mov       [rdi],rax
       mov       eax,[rsp+30]
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M02_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 278
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrNull01()
; 			var result = base.CoordinateArray.FirstOrNull(p => p.X == this.Coordinate.X);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+78]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__5_0(dotNetTips.Spargine.Tester.Models.CoordinateProper)
       mov       [rdi+18],rcx
       lea       rcx,[rsp+20]
       mov       rdx,rbx
       mov       r8,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>, System.Func`2<dotNetTips.Spargine.Tester.Models.CoordinateProper,Boolean>)
       mov       rsi,[rsi+10]
       cmp       [rsi],esi
       lea       rdx,[rsp+20]
       mov       rcx,offset MT_System.Nullable`1[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]]
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
; Total bytes of code 133
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__5_0(dotNetTips.Spargine.Tester.Models.CoordinateProper)
; 			var result = base.CoordinateArray.FirstOrNull(p => p.X == this.Coordinate.X);
; 			                                                   ^^^^^^^^^^^^^^^^^^^^^^^^
       mov       [rsp+10],rdx
       mov       eax,[rsp+10]
       add       rcx,60
       mov       edx,[rcx]
       mov       ecx,[rcx+4]
       cmp       eax,edx
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 27
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>, System.Func`2<dotNetTips.Spargine.Tester.Models.CoordinateProper,Boolean>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       jne       short M02_L00
       xor       eax,eax
       mov       [rdi],rax
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       r8,29BB5243060
       mov       r8,[r8]
       mov       rdx,29BC52411A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rbx
       call      System.Linq.Enumerable.ToList[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>)
       mov       rbx,rax
       xor       ebp,ebp
       cmp       dword ptr [rbx+10],0
       jle       short M02_L03
M02_L01:
       cmp       ebp,[rbx+10]
       jae       near ptr M02_L05
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M02_L06
       movsxd    rdx,ebp
       lea       rcx,[rcx+rdx*8+10]
       mov       r14d,[rcx]
       mov       r15d,[rcx+4]
       test      rsi,rsi
       je        short M02_L02
       lea       rcx,[rsp+20]
       mov       [rcx],r14d
       mov       [rcx+4],r15d
       mov       rax,rsi
       mov       rcx,[rax+8]
       mov       rdx,[rsp+20]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L04
M02_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M02_L01
M02_L03:
       xor       eax,eax
       mov       [rdi],rax
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],eax
       lea       rax,[rsp+2C]
       mov       [rax],r14d
       mov       [rax+4],r15d
       mov       byte ptr [rsp+28],1
       mov       rax,[rsp+28]
       mov       [rdi],rax
       mov       eax,[rsp+30]
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M02_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 278
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrNull01()
; 			var result = base.CoordinateArray.FirstOrNull(p => p.X == this.Coordinate.X);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+78]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__5_0(dotNetTips.Spargine.Tester.Models.CoordinateProper)
       mov       [rdi+18],rcx
       lea       rcx,[rsp+20]
       mov       rdx,rbx
       mov       r8,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>, System.Func`2<dotNetTips.Spargine.Tester.Models.CoordinateProper,Boolean>)
       mov       rsi,[rsi+10]
       cmp       [rsi],esi
       lea       rdx,[rsp+20]
       mov       rcx,offset MT_System.Nullable`1[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]]
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
; Total bytes of code 133
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__5_0(dotNetTips.Spargine.Tester.Models.CoordinateProper)
; 			var result = base.CoordinateArray.FirstOrNull(p => p.X == this.Coordinate.X);
; 			                                                   ^^^^^^^^^^^^^^^^^^^^^^^^
       mov       [rsp+10],rdx
       mov       eax,[rsp+10]
       add       rcx,60
       mov       edx,[rcx]
       mov       ecx,[rcx+4]
       cmp       eax,edx
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 27
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>, System.Func`2<dotNetTips.Spargine.Tester.Models.CoordinateProper,Boolean>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       jne       short M02_L00
       xor       eax,eax
       mov       [rdi],rax
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       r8,27092373060
       mov       r8,[r8]
       mov       rdx,27072390E10
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rbx
       call      System.Linq.Enumerable.ToList[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>)
       mov       rbx,rax
       xor       ebp,ebp
       cmp       dword ptr [rbx+10],0
       jle       short M02_L03
M02_L01:
       cmp       ebp,[rbx+10]
       jae       near ptr M02_L05
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M02_L06
       movsxd    rdx,ebp
       lea       rcx,[rcx+rdx*8+10]
       mov       r14d,[rcx]
       mov       r15d,[rcx+4]
       test      rsi,rsi
       je        short M02_L02
       lea       rcx,[rsp+20]
       mov       [rcx],r14d
       mov       [rcx+4],r15d
       mov       rax,rsi
       mov       rcx,[rax+8]
       mov       rdx,[rsp+20]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L04
M02_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M02_L01
M02_L03:
       xor       eax,eax
       mov       [rdi],rax
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],eax
       lea       rax,[rsp+2C]
       mov       [rax],r14d
       mov       [rax+4],r15d
       mov       byte ptr [rsp+28],1
       mov       rax,[rsp+28]
       mov       [rdi],rax
       mov       eax,[rsp+30]
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M02_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 278
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrNull01()
; 			var result = base.CoordinateArray.FirstOrNull(p => p.X == this.Coordinate.X);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+78]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__5_0(dotNetTips.Spargine.Tester.Models.CoordinateProper)
       mov       [rdi+18],rcx
       lea       rcx,[rsp+20]
       mov       rdx,rbx
       mov       r8,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>, System.Func`2<dotNetTips.Spargine.Tester.Models.CoordinateProper,Boolean>)
       mov       rsi,[rsi+10]
       cmp       [rsi],esi
       lea       rdx,[rsp+20]
       mov       rcx,offset MT_System.Nullable`1[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]]
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
; Total bytes of code 133
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__5_0(dotNetTips.Spargine.Tester.Models.CoordinateProper)
; 			var result = base.CoordinateArray.FirstOrNull(p => p.X == this.Coordinate.X);
; 			                                                   ^^^^^^^^^^^^^^^^^^^^^^^^
       mov       [rsp+10],rdx
       mov       eax,[rsp+10]
       add       rcx,60
       mov       edx,[rcx]
       mov       ecx,[rcx+4]
       cmp       eax,edx
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 27
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>, System.Func`2<dotNetTips.Spargine.Tester.Models.CoordinateProper,Boolean>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       jne       short M02_L00
       xor       eax,eax
       mov       [rdi],rax
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       r8,1B1A5973060
       mov       r8,[r8]
       mov       rdx,1B1B59731B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rbx
       call      System.Linq.Enumerable.ToList[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>)
       mov       rbx,rax
       xor       ebp,ebp
       cmp       dword ptr [rbx+10],0
       jle       short M02_L03
M02_L01:
       cmp       ebp,[rbx+10]
       jae       near ptr M02_L05
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M02_L06
       movsxd    rdx,ebp
       lea       rcx,[rcx+rdx*8+10]
       mov       r14d,[rcx]
       mov       r15d,[rcx+4]
       test      rsi,rsi
       je        short M02_L02
       lea       rcx,[rsp+20]
       mov       [rcx],r14d
       mov       [rcx+4],r15d
       mov       rax,rsi
       mov       rcx,[rax+8]
       mov       rdx,[rsp+20]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L04
M02_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M02_L01
M02_L03:
       xor       eax,eax
       mov       [rdi],rax
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],eax
       lea       rax,[rsp+2C]
       mov       [rax],r14d
       mov       [rax+4],r15d
       mov       byte ptr [rsp+28],1
       mov       rax,[rsp+28]
       mov       [rdi],rax
       mov       eax,[rsp+30]
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M02_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 278
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.FirstOrNull01()
; 			var result = base.CoordinateArray.FirstOrNull(p => p.X == this.Coordinate.X);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+78]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__5_0(dotNetTips.Spargine.Tester.Models.CoordinateProper)
       mov       [rdi+18],rcx
       lea       rcx,[rsp+20]
       mov       rdx,rbx
       mov       r8,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>, System.Func`2<dotNetTips.Spargine.Tester.Models.CoordinateProper,Boolean>)
       mov       rsi,[rsi+10]
       cmp       [rsi],esi
       lea       rdx,[rsp+20]
       mov       rcx,offset MT_System.Nullable`1[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]]
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
; Total bytes of code 133
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.<FirstOrNull01>b__5_0(dotNetTips.Spargine.Tester.Models.CoordinateProper)
; 			var result = base.CoordinateArray.FirstOrNull(p => p.X == this.Coordinate.X);
; 			                                                   ^^^^^^^^^^^^^^^^^^^^^^^^
       mov       [rsp+10],rdx
       mov       eax,[rsp+10]
       add       rcx,60
       mov       edx,[rcx]
       mov       ecx,[rcx+4]
       cmp       eax,edx
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 27
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.FirstOrNull[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>, System.Func`2<dotNetTips.Spargine.Tester.Models.CoordinateProper,Boolean>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       jne       short M02_L00
       xor       eax,eax
       mov       [rdi],rax
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       r8,2E429593060
       mov       r8,[r8]
       mov       rdx,2E4095919D8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rbx
       call      System.Linq.Enumerable.ToList[[dotNetTips.Spargine.Tester.Models.CoordinateProper, dotNetTips.Spargine.5.Tester]](System.Collections.Generic.IEnumerable`1<dotNetTips.Spargine.Tester.Models.CoordinateProper>)
       mov       rbx,rax
       xor       ebp,ebp
       cmp       dword ptr [rbx+10],0
       jle       short M02_L03
M02_L01:
       cmp       ebp,[rbx+10]
       jae       near ptr M02_L05
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M02_L06
       movsxd    rdx,ebp
       lea       rcx,[rcx+rdx*8+10]
       mov       r14d,[rcx]
       mov       r15d,[rcx+4]
       test      rsi,rsi
       je        short M02_L02
       lea       rcx,[rsp+20]
       mov       [rcx],r14d
       mov       [rcx+4],r15d
       mov       rax,rsi
       mov       rcx,[rax+8]
       mov       rdx,[rsp+20]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L04
M02_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M02_L01
M02_L03:
       xor       eax,eax
       mov       [rdi],rax
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],eax
       lea       rax,[rsp+2C]
       mov       [rax],r14d
       mov       [rax+4],r15d
       mov       byte ptr [rsp+28],1
       mov       rax,[rsp+28]
       mov       [rdi],rax
       mov       eax,[rsp+30]
       mov       [rdi+8],eax
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M02_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 278
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StartsWith01()
; 			var result = base.PersonProperArrayFull.StartsWith(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
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
       mov       rdx,7FFB36FD0700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFD0],rax
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FD0700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       jmp       short M01_L12
M01_L07:
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36AE0590
       call      qword ptr [7FFB36EF0590]
       test      eax,eax
       je        near ptr M01_L13
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FD07D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FD07D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Object.Equals(System.Object, System.Object)
       test      eax,eax
       je        short M01_L13
M01_L12:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36AE0588
       call      qword ptr [7FFB36EF0588]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36AE0598
       call      qword ptr [7FFB36EF0598]
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
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36AE05A0
       call      qword ptr [7FFB36EF05A0]
M01_L16:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L17:
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L18:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L19
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36AE0598
       call      qword ptr [7FFB36EF0598]
M01_L19:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L21
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36AE05A0
       call      qword ptr [7FFB36EF05A0]
M01_L21:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 546
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StartsWith01()
; 			var result = base.PersonProperArrayFull.StartsWith(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
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
       mov       rdx,7FFB37000720
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFD0],rax
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37000720
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       jmp       short M01_L12
M01_L07:
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B10590
       call      qword ptr [7FFB36F20590]
       test      eax,eax
       je        near ptr M01_L13
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB370007F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB370007F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Object.Equals(System.Object, System.Object)
       test      eax,eax
       je        short M01_L13
M01_L12:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B10588
       call      qword ptr [7FFB36F20588]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B10598
       call      qword ptr [7FFB36F20598]
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
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B105A0
       call      qword ptr [7FFB36F205A0]
M01_L16:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L17:
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L18:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L19
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B10598
       call      qword ptr [7FFB36F20598]
M01_L19:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L21
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B105A0
       call      qword ptr [7FFB36F205A0]
M01_L21:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 546
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StartsWith01()
; 			var result = base.PersonProperArrayFull.StartsWith(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
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
       mov       rdx,7FFB36FF0700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFD0],rax
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       jmp       short M01_L12
M01_L07:
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B00590
       call      qword ptr [7FFB36F10590]
       test      eax,eax
       je        near ptr M01_L13
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FF07D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FF07D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Object.Equals(System.Object, System.Object)
       test      eax,eax
       je        short M01_L13
M01_L12:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B00588
       call      qword ptr [7FFB36F10588]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B00598
       call      qword ptr [7FFB36F10598]
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
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B005A0
       call      qword ptr [7FFB36F105A0]
M01_L16:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L17:
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L18:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L19
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B00598
       call      qword ptr [7FFB36F10598]
M01_L19:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L21
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B005A0
       call      qword ptr [7FFB36F105A0]
M01_L21:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 546
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StartsWith01()
; 			var result = base.PersonProperArrayFull.StartsWith(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
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
       mov       rdx,7FFB36FE0700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFD0],rax
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       jmp       short M01_L12
M01_L07:
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36AF0590
       call      qword ptr [7FFB36F00590]
       test      eax,eax
       je        near ptr M01_L13
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FE07D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FE07D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Object.Equals(System.Object, System.Object)
       test      eax,eax
       je        short M01_L13
M01_L12:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36AF0588
       call      qword ptr [7FFB36F00588]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36AF0598
       call      qword ptr [7FFB36F00598]
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
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36AF05A0
       call      qword ptr [7FFB36F005A0]
M01_L16:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L17:
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L18:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L19
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36AF0598
       call      qword ptr [7FFB36F00598]
M01_L19:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L21
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36AF05A0
       call      qword ptr [7FFB36F005A0]
M01_L21:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 546
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StartsWith01()
; 			var result = base.PersonProperArrayFull.StartsWith(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
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
       mov       rdx,7FFB36FE0930
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFD0],rax
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0930
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       jmp       short M01_L12
M01_L07:
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36AF0590
       call      qword ptr [7FFB36F00590]
       test      eax,eax
       je        near ptr M01_L13
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0A08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0A08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Object.Equals(System.Object, System.Object)
       test      eax,eax
       je        short M01_L13
M01_L12:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36AF0588
       call      qword ptr [7FFB36F00588]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36AF0598
       call      qword ptr [7FFB36F00598]
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
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36AF05A0
       call      qword ptr [7FFB36F005A0]
M01_L16:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L17:
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L18:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L19
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36AF0598
       call      qword ptr [7FFB36F00598]
M01_L19:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L21
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36AF05A0
       call      qword ptr [7FFB36F005A0]
M01_L21:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 546
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StartsWith01()
; 			var result = base.PersonProperArrayFull.StartsWith(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
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
       mov       rdx,7FFB37000B10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFD0],rax
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37000B10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       jmp       short M01_L12
M01_L07:
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B10590
       call      qword ptr [7FFB36F20590]
       test      eax,eax
       je        near ptr M01_L13
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37000BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB37000BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Object.Equals(System.Object, System.Object)
       test      eax,eax
       je        short M01_L13
M01_L12:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B10588
       call      qword ptr [7FFB36F20588]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B10598
       call      qword ptr [7FFB36F20598]
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
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B105A0
       call      qword ptr [7FFB36F205A0]
M01_L16:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L17:
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L18:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L19
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B10598
       call      qword ptr [7FFB36F20598]
M01_L19:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L21
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B105A0
       call      qword ptr [7FFB36F205A0]
M01_L21:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 546
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StartsWith01()
; 			var result = base.PersonProperArrayFull.StartsWith(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
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
       mov       rdx,7FFB36FF0930
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFD0],rax
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0930
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       jmp       short M01_L12
M01_L07:
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B00590
       call      qword ptr [7FFB36F10590]
       test      eax,eax
       je        near ptr M01_L13
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0A08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0A08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Object.Equals(System.Object, System.Object)
       test      eax,eax
       je        short M01_L13
M01_L12:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B00588
       call      qword ptr [7FFB36F10588]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B00598
       call      qword ptr [7FFB36F10598]
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
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B005A0
       call      qword ptr [7FFB36F105A0]
M01_L16:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L17:
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L18:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L19
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B00598
       call      qword ptr [7FFB36F10598]
M01_L19:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L21
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B005A0
       call      qword ptr [7FFB36F105A0]
M01_L21:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 546
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StartsWith01()
; 			var result = base.PersonProperArrayFull.StartsWith(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
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
       mov       rdx,7FFB37000B10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFD0],rax
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37000B10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       jmp       short M01_L12
M01_L07:
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B10590
       call      qword ptr [7FFB36F20590]
       test      eax,eax
       je        near ptr M01_L13
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37000BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB37000BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Object.Equals(System.Object, System.Object)
       test      eax,eax
       je        short M01_L13
M01_L12:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B10588
       call      qword ptr [7FFB36F20588]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B10598
       call      qword ptr [7FFB36F20598]
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
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B105A0
       call      qword ptr [7FFB36F205A0]
M01_L16:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L17:
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L18:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L19
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B10598
       call      qword ptr [7FFB36F20598]
M01_L19:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L21
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B105A0
       call      qword ptr [7FFB36F205A0]
M01_L21:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 546
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StartsWith01()
; 			var result = base.PersonProperArrayFull.StartsWith(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.StartsWith[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
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
       mov       rdx,7FFB36FE0B10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFD0],rax
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0B10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       jmp       short M01_L12
M01_L07:
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36AF0590
       call      qword ptr [7FFB36F00590]
       test      eax,eax
       je        near ptr M01_L13
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Object.Equals(System.Object, System.Object)
       test      eax,eax
       je        short M01_L13
M01_L12:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36AF0588
       call      qword ptr [7FFB36F00588]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36AF0598
       call      qword ptr [7FFB36F00598]
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
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36AF05A0
       call      qword ptr [7FFB36F005A0]
M01_L16:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L17:
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L18:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L19
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36AF0598
       call      qword ptr [7FFB36F00598]
M01_L19:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L21
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36AF05A0
       call      qword ptr [7FFB36F005A0]
M01_L21:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 546
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StructuralSequenceEqual01()
; 			var result = base.PersonProperArrayFull.StructuralSequenceEqual(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
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
       mov       rdx,7FFB370006A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFD0],rax
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB370006A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B10588
       call      qword ptr [7FFB36F20588]
       test      eax,eax
       je        near ptr M01_L12
M01_L07:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B10590
       call      qword ptr [7FFB36F20590]
       test      eax,eax
       je        near ptr M01_L13
       call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
       mov       rdi,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37000808
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB37000808
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r11,7FFB36B10598
       call      qword ptr [7FFB36F20598]
       test      eax,eax
       je        short M01_L13
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B10588
       call      qword ptr [7FFB36F20588]
       test      eax,eax
       jne       near ptr M01_L07
M01_L12:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B105A0
       call      qword ptr [7FFB36F205A0]
       test      eax,eax
       sete      sil
       movzx     esi,sil
       jmp       short M01_L14
M01_L13:
       xor       esi,esi
M01_L14:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B105A8
       call      qword ptr [7FFB36F205A8]
       nop
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B105B0
       call      qword ptr [7FFB36F205B0]
       mov       eax,esi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L15
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B105A8
       call      qword ptr [7FFB36F205A8]
M01_L15:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B105B0
       call      qword ptr [7FFB36F205B0]
M01_L16:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 584
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StructuralSequenceEqual01()
; 			var result = base.PersonProperArrayFull.StructuralSequenceEqual(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
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
       mov       rdx,7FFB36FE0700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFD0],rax
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36AF0588
       call      qword ptr [7FFB36F00588]
       test      eax,eax
       je        near ptr M01_L12
M01_L07:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36AF0590
       call      qword ptr [7FFB36F00590]
       test      eax,eax
       je        near ptr M01_L13
       call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
       mov       rdi,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r11,7FFB36AF0598
       call      qword ptr [7FFB36F00598]
       test      eax,eax
       je        short M01_L13
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36AF0588
       call      qword ptr [7FFB36F00588]
       test      eax,eax
       jne       near ptr M01_L07
M01_L12:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36AF05A0
       call      qword ptr [7FFB36F005A0]
       test      eax,eax
       sete      sil
       movzx     esi,sil
       jmp       short M01_L14
M01_L13:
       xor       esi,esi
M01_L14:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36AF05A8
       call      qword ptr [7FFB36F005A8]
       nop
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36AF05B0
       call      qword ptr [7FFB36F005B0]
       mov       eax,esi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L15
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36AF05A8
       call      qword ptr [7FFB36F005A8]
M01_L15:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36AF05B0
       call      qword ptr [7FFB36F005B0]
M01_L16:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 584
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StructuralSequenceEqual01()
; 			var result = base.PersonProperArrayFull.StructuralSequenceEqual(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
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
       mov       rdx,7FFB370006A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFD0],rax
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB370006A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B10588
       call      qword ptr [7FFB36F20588]
       test      eax,eax
       je        near ptr M01_L12
M01_L07:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B10590
       call      qword ptr [7FFB36F20590]
       test      eax,eax
       je        near ptr M01_L13
       call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
       mov       rdi,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37000808
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB37000808
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r11,7FFB36B10598
       call      qword ptr [7FFB36F20598]
       test      eax,eax
       je        short M01_L13
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B10588
       call      qword ptr [7FFB36F20588]
       test      eax,eax
       jne       near ptr M01_L07
M01_L12:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B105A0
       call      qword ptr [7FFB36F205A0]
       test      eax,eax
       sete      sil
       movzx     esi,sil
       jmp       short M01_L14
M01_L13:
       xor       esi,esi
M01_L14:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B105A8
       call      qword ptr [7FFB36F205A8]
       nop
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B105B0
       call      qword ptr [7FFB36F205B0]
       mov       eax,esi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L15
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B105A8
       call      qword ptr [7FFB36F205A8]
M01_L15:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B105B0
       call      qword ptr [7FFB36F205B0]
M01_L16:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 584
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StructuralSequenceEqual01()
; 			var result = base.PersonProperArrayFull.StructuralSequenceEqual(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
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
       mov       rdx,7FFB37010930
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFD0],rax
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37010930
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B20588
       call      qword ptr [7FFB36F30588]
       test      eax,eax
       je        near ptr M01_L12
M01_L07:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B20590
       call      qword ptr [7FFB36F30590]
       test      eax,eax
       je        near ptr M01_L13
       call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
       mov       rdi,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37010A98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB37010A98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r11,7FFB36B20598
       call      qword ptr [7FFB36F30598]
       test      eax,eax
       je        short M01_L13
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B20588
       call      qword ptr [7FFB36F30588]
       test      eax,eax
       jne       near ptr M01_L07
M01_L12:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B205A0
       call      qword ptr [7FFB36F305A0]
       test      eax,eax
       sete      sil
       movzx     esi,sil
       jmp       short M01_L14
M01_L13:
       xor       esi,esi
M01_L14:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B205A8
       call      qword ptr [7FFB36F305A8]
       nop
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B205B0
       call      qword ptr [7FFB36F305B0]
       mov       eax,esi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L15
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B205A8
       call      qword ptr [7FFB36F305A8]
M01_L15:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B205B0
       call      qword ptr [7FFB36F305B0]
M01_L16:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 584
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StructuralSequenceEqual01()
; 			var result = base.PersonProperArrayFull.StructuralSequenceEqual(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
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
       mov       rdx,7FFB37000930
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFD0],rax
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37000930
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B10588
       call      qword ptr [7FFB36F20588]
       test      eax,eax
       je        near ptr M01_L12
M01_L07:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B10590
       call      qword ptr [7FFB36F20590]
       test      eax,eax
       je        near ptr M01_L13
       call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
       mov       rdi,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37000A98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB37000A98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r11,7FFB36B10598
       call      qword ptr [7FFB36F20598]
       test      eax,eax
       je        short M01_L13
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B10588
       call      qword ptr [7FFB36F20588]
       test      eax,eax
       jne       near ptr M01_L07
M01_L12:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B105A0
       call      qword ptr [7FFB36F205A0]
       test      eax,eax
       sete      sil
       movzx     esi,sil
       jmp       short M01_L14
M01_L13:
       xor       esi,esi
M01_L14:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B105A8
       call      qword ptr [7FFB36F205A8]
       nop
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B105B0
       call      qword ptr [7FFB36F205B0]
       mov       eax,esi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L15
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B105A8
       call      qword ptr [7FFB36F205A8]
M01_L15:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B105B0
       call      qword ptr [7FFB36F205B0]
M01_L16:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 584
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StructuralSequenceEqual01()
; 			var result = base.PersonProperArrayFull.StructuralSequenceEqual(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
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
       mov       rdx,7FFB36FF06A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFD0],rax
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FF06A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B00588
       call      qword ptr [7FFB36F10588]
       test      eax,eax
       je        near ptr M01_L12
M01_L07:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B00590
       call      qword ptr [7FFB36F10590]
       test      eax,eax
       je        near ptr M01_L13
       call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
       mov       rdi,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0808
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0808
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r11,7FFB36B00598
       call      qword ptr [7FFB36F10598]
       test      eax,eax
       je        short M01_L13
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B00588
       call      qword ptr [7FFB36F10588]
       test      eax,eax
       jne       near ptr M01_L07
M01_L12:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B005A0
       call      qword ptr [7FFB36F105A0]
       test      eax,eax
       sete      sil
       movzx     esi,sil
       jmp       short M01_L14
M01_L13:
       xor       esi,esi
M01_L14:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B005A8
       call      qword ptr [7FFB36F105A8]
       nop
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B005B0
       call      qword ptr [7FFB36F105B0]
       mov       eax,esi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L15
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B005A8
       call      qword ptr [7FFB36F105A8]
M01_L15:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B005B0
       call      qword ptr [7FFB36F105B0]
M01_L16:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 584
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StructuralSequenceEqual01()
; 			var result = base.PersonProperArrayFull.StructuralSequenceEqual(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
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
       mov       rdx,7FFB36FE0B10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFD0],rax
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0B10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36AF0588
       call      qword ptr [7FFB36F00588]
       test      eax,eax
       je        near ptr M01_L12
M01_L07:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36AF0590
       call      qword ptr [7FFB36F00590]
       test      eax,eax
       je        near ptr M01_L13
       call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
       mov       rdi,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0C78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0C78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r11,7FFB36AF0598
       call      qword ptr [7FFB36F00598]
       test      eax,eax
       je        short M01_L13
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36AF0588
       call      qword ptr [7FFB36F00588]
       test      eax,eax
       jne       near ptr M01_L07
M01_L12:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36AF05A0
       call      qword ptr [7FFB36F005A0]
       test      eax,eax
       sete      sil
       movzx     esi,sil
       jmp       short M01_L14
M01_L13:
       xor       esi,esi
M01_L14:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36AF05A8
       call      qword ptr [7FFB36F005A8]
       nop
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36AF05B0
       call      qword ptr [7FFB36F005B0]
       mov       eax,esi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L15
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36AF05A8
       call      qword ptr [7FFB36F005A8]
M01_L15:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36AF05B0
       call      qword ptr [7FFB36F005B0]
M01_L16:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 584
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StructuralSequenceEqual01()
; 			var result = base.PersonProperArrayFull.StructuralSequenceEqual(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
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
       mov       rdx,7FFB37010B10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFD0],rax
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37010B10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B20588
       call      qword ptr [7FFB36F30588]
       test      eax,eax
       je        near ptr M01_L12
M01_L07:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B20590
       call      qword ptr [7FFB36F30590]
       test      eax,eax
       je        near ptr M01_L13
       call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
       mov       rdi,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37010C78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB37010C78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r11,7FFB36B20598
       call      qword ptr [7FFB36F30598]
       test      eax,eax
       je        short M01_L13
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B20588
       call      qword ptr [7FFB36F30588]
       test      eax,eax
       jne       near ptr M01_L07
M01_L12:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B205A0
       call      qword ptr [7FFB36F305A0]
       test      eax,eax
       sete      sil
       movzx     esi,sil
       jmp       short M01_L14
M01_L13:
       xor       esi,esi
M01_L14:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B205A8
       call      qword ptr [7FFB36F305A8]
       nop
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B205B0
       call      qword ptr [7FFB36F305B0]
       mov       eax,esi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L15
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36B205A8
       call      qword ptr [7FFB36F305A8]
M01_L15:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36B205B0
       call      qword ptr [7FFB36F305B0]
M01_L16:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 584
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.StructuralSequenceEqual01()
; 			var result = base.PersonProperArrayFull.StructuralSequenceEqual(base.PersonProperArrayHalf);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       r8,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.StructuralSequenceEqual[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L01:
       cmp       rdi,rbx
       jne       short M01_L02
       mov       eax,1
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
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
       mov       rdx,7FFB36FD0700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFD0],rax
       mov       r11,[r14+10]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FD0700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36AE0588
       call      qword ptr [7FFB36EF0588]
       test      eax,eax
       je        near ptr M01_L12
M01_L07:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36AE0590
       call      qword ptr [7FFB36EF0590]
       test      eax,eax
       je        near ptr M01_L13
       call      System.Collections.StructuralComparisons.get_StructuralEqualityComparer()
       mov       rdi,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FD0868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L09:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FD0868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r11,7FFB36AE0598
       call      qword ptr [7FFB36EF0598]
       test      eax,eax
       je        short M01_L13
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36AE0588
       call      qword ptr [7FFB36EF0588]
       test      eax,eax
       jne       near ptr M01_L07
M01_L12:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36AE05A0
       call      qword ptr [7FFB36EF05A0]
       test      eax,eax
       sete      sil
       movzx     esi,sil
       jmp       short M01_L14
M01_L13:
       xor       esi,esi
M01_L14:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36AE05A8
       call      qword ptr [7FFB36EF05A8]
       nop
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36AE05B0
       call      qword ptr [7FFB36EF05B0]
       mov       eax,esi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L15
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFB36AE05A8
       call      qword ptr [7FFB36EF05A8]
M01_L15:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FFB36AE05B0
       call      qword ptr [7FFB36EF05B0]
M01_L16:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 584
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
; 			var result = base.PersonProperCollection.ToDelimitedString(',');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
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
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0720
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L02
       mov       rax,238241F3060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       call      dotNetTips.Spargine.Core.TypeHelper.CreateStringBuilder()
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0748
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0768
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass14_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFB36F19498]
       mov       r8d,[rax+8]
       dec       r8d
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
; Total bytes of code 295
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
; 			var result = base.PersonProperCollection.ToDelimitedString(',');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
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
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0740
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L02
       mov       rax,17E7C623060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       call      dotNetTips.Spargine.Core.TypeHelper.CreateStringBuilder()
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0768
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass14_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFB36F09498]
       mov       r8d,[rax+8]
       dec       r8d
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
; Total bytes of code 295
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
; 			var result = base.PersonProperCollection.ToDelimitedString(',');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
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
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0740
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L02
       mov       rax,1C039DB3060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       call      dotNetTips.Spargine.Core.TypeHelper.CreateStringBuilder()
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0768
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass14_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFB36F19498]
       mov       r8d,[rax+8]
       dec       r8d
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
; Total bytes of code 295
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
; 			var result = base.PersonProperCollection.ToDelimitedString(',');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
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
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB370106C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L02
       mov       rax,1468A653060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       call      dotNetTips.Spargine.Core.TypeHelper.CreateStringBuilder()
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB370106E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37010708
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass14_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFB36F39498]
       mov       r8d,[rax+8]
       dec       r8d
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
; Total bytes of code 295
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
; 			var result = base.PersonProperCollection.ToDelimitedString(',');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
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
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB370108B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L02
       mov       rax,2092E893060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       call      dotNetTips.Spargine.Core.TypeHelper.CreateStringBuilder()
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB370108D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB370108F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass14_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFB36F39498]
       mov       r8d,[rax+8]
       dec       r8d
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
; Total bytes of code 295
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
; 			var result = base.PersonProperCollection.ToDelimitedString(',');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
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
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FD0B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L02
       mov       rax,249ED073060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       call      dotNetTips.Spargine.Core.TypeHelper.CreateStringBuilder()
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB36FD0B58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FD0B78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass14_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFB36EF9498]
       mov       r8d,[rax+8]
       dec       r8d
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
; Total bytes of code 295
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
; 			var result = base.PersonProperCollection.ToDelimitedString(',');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
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
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L02
       mov       rax,28B7FC13060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       call      dotNetTips.Spargine.Core.TypeHelper.CreateStringBuilder()
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0B58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0B78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass14_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFB36F09498]
       mov       r8d,[rax+8]
       dec       r8d
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
; Total bytes of code 295
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
; 			var result = base.PersonProperCollection.ToDelimitedString(',');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
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
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37010B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L02
       mov       rax,175BF203060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       call      dotNetTips.Spargine.Core.TypeHelper.CreateStringBuilder()
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB37010B58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37010B78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass14_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFB36F39498]
       mov       r8d,[rax+8]
       dec       r8d
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
; Total bytes of code 295
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDelimitedString01()
; 			var result = base.PersonProperCollection.ToDelimitedString(',');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
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
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37000B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L02
       mov       rax,19EB7483060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       call      dotNetTips.Spargine.Core.TypeHelper.CreateStringBuilder()
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB37000B58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37000B78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass14_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFB36F29498]
       mov       r8d,[rax+8]
       dec       r8d
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
; Total bytes of code 295
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
; 			var result = base.PersonProperCollection.ToDictionary(p => p.Email);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,1FA1DA99968
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1FA1DA99950
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__10_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1FA1DA99968
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       xor       r9d,r9d
       call      System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
; Total bytes of code 169
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__10_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.ToDictionary(p => p.Email);
; 			                                                           ^^^^^^^
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14,r9
       test      rbx,rbx
       je        near ptr M02_L27
       test      rdi,rdi
       je        near ptr M02_L28
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L00
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB370031E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rbx
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r12,rax
       test      r12,r12
       je        near ptr M02_L18
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],60
       jle       short M02_L02
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB37003B00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,r12
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       jne       short M02_L06
       mov       r15,[rsi+10]
       mov       rbx,[r15+10]
       cmp       rbx,48
       jle       short M02_L04
       mov       rcx,[r15+48]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB370037D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,r14
       xor       edx,edx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rax,rsi
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
M02_L06:
       mov       rcx,[rsi+10]
       mov       r13,rcx
       mov       rcx,r13
       mov       rdx,[rcx+10]
       mov       rax,rdx
       mov       [rbp+0FFB8],rax
       cmp       rax,68
       jle       short M02_L07
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB37003B18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       mov       rdx,r12
       call      CORINFO_HELP_ISINSTANCEOFARRAY
       mov       [rbp+0FFB0],rax
       test      rax,rax
       je        short M02_L13
       mov       rax,[rbp+0FFB0]
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],80
       jle       short M02_L10
       mov       rcx,[rcx+80]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L12
M02_L09:
       mov       [rbp+0FFB0],rax
       jmp       short M02_L11
M02_L10:
       mov       [rbp+0FFB0],rax
       jmp       short M02_L11
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFB37003F08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       mov       rax,[rbp+0FFB0]
M02_L12:
       mov       rdx,rax
       mov       r8,rdi
       mov       r9,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       near ptr System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
M02_L13:
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],70
       jle       short M02_L14
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFB37003B40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L15:
       mov       rdx,r12
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       r12,rax
       test      r12,r12
       je        short M02_L18
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],78
       jle       short M02_L16
       mov       rcx,[rcx+78]
       test      rcx,rcx
       je        short M02_L16
       jmp       short M02_L17
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFB37003E58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L17:
       mov       rdx,r12
       mov       r8,rdi
       mov       r9,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       near ptr System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
M02_L18:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],48
       jle       short M02_L19
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M02_L19
       jmp       short M02_L20
M02_L19:
       mov       rcx,rsi
       mov       rdx,7FFB370037D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L20:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,r15d
       mov       r8,r14
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],50
       jle       short M02_L21
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L21
       jmp       short M02_L22
M02_L21:
       mov       rcx,rsi
       mov       rdx,7FFB370037E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L22:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFA8],rax
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36B105B0
       call      qword ptr [7FFB36F205B0]
       test      eax,eax
       je        short M02_L26
M02_L23:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],58
       jle       short M02_L24
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M02_L24
       jmp       short M02_L25
M02_L24:
       mov       rcx,rsi
       mov       rdx,7FFB37003908
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L25:
       mov       rcx,[rbp+0FFA8]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       mov       rdx,rbx
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rcx,r12
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36B105B0
       call      qword ptr [7FFB36F205B0]
       test      eax,eax
       jne       short M02_L23
M02_L26:
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36B105B8
       call      qword ptr [7FFB36F205B8]
       mov       rax,r12
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
M02_L27:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L28:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFA8],0
       je        short M02_L29
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36B105B8
       call      qword ptr [7FFB36F205B8]
M02_L29:
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
; Total bytes of code 967
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
; 			var result = base.PersonProperCollection.ToDictionary(p => p.Email);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,2DFD6BE2EE0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2DFD6BE2EC8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__10_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2DFD6BE2EE0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       xor       r9d,r9d
       call      System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
; Total bytes of code 169
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__10_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.ToDictionary(p => p.Email);
; 			                                                           ^^^^^^^
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14,r9
       test      rbx,rbx
       je        near ptr M02_L27
       test      rdi,rdi
       je        near ptr M02_L28
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L00
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF3160
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rbx
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r12,rax
       test      r12,r12
       je        near ptr M02_L18
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],60
       jle       short M02_L02
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FF3A80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,r12
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       jne       short M02_L06
       mov       r15,[rsi+10]
       mov       rbx,[r15+10]
       cmp       rbx,48
       jle       short M02_L04
       mov       rcx,[r15+48]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FF3750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,r14
       xor       edx,edx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rax,rsi
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
M02_L06:
       mov       rcx,[rsi+10]
       mov       r13,rcx
       mov       rcx,r13
       mov       rdx,[rcx+10]
       mov       rax,rdx
       mov       [rbp+0FFB8],rax
       cmp       rax,68
       jle       short M02_L07
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB36FF3A98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       mov       rdx,r12
       call      CORINFO_HELP_ISINSTANCEOFARRAY
       mov       [rbp+0FFB0],rax
       test      rax,rax
       je        short M02_L13
       mov       rax,[rbp+0FFB0]
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],80
       jle       short M02_L10
       mov       rcx,[rcx+80]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L12
M02_L09:
       mov       [rbp+0FFB0],rax
       jmp       short M02_L11
M02_L10:
       mov       [rbp+0FFB0],rax
       jmp       short M02_L11
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFB36FF3E88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       mov       rax,[rbp+0FFB0]
M02_L12:
       mov       rdx,rax
       mov       r8,rdi
       mov       r9,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       near ptr System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
M02_L13:
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],70
       jle       short M02_L14
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFB36FF3AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L15:
       mov       rdx,r12
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       r12,rax
       test      r12,r12
       je        short M02_L18
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],78
       jle       short M02_L16
       mov       rcx,[rcx+78]
       test      rcx,rcx
       je        short M02_L16
       jmp       short M02_L17
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFB36FF3DD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L17:
       mov       rdx,r12
       mov       r8,rdi
       mov       r9,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       near ptr System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
M02_L18:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],48
       jle       short M02_L19
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M02_L19
       jmp       short M02_L20
M02_L19:
       mov       rcx,rsi
       mov       rdx,7FFB36FF3750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L20:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,r15d
       mov       r8,r14
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],50
       jle       short M02_L21
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L21
       jmp       short M02_L22
M02_L21:
       mov       rcx,rsi
       mov       rdx,7FFB36FF3768
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L22:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFA8],rax
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36B005B0
       call      qword ptr [7FFB36F105B0]
       test      eax,eax
       je        short M02_L26
M02_L23:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],58
       jle       short M02_L24
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M02_L24
       jmp       short M02_L25
M02_L24:
       mov       rcx,rsi
       mov       rdx,7FFB36FF3888
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L25:
       mov       rcx,[rbp+0FFA8]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       mov       rdx,rbx
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rcx,r12
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36B005B0
       call      qword ptr [7FFB36F105B0]
       test      eax,eax
       jne       short M02_L23
M02_L26:
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36B005B8
       call      qword ptr [7FFB36F105B8]
       mov       rax,r12
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
M02_L27:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L28:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFA8],0
       je        short M02_L29
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36B005B8
       call      qword ptr [7FFB36F105B8]
M02_L29:
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
; Total bytes of code 967
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
; 			var result = base.PersonProperCollection.ToDictionary(p => p.Email);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,22683D99968
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,22683D99950
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__10_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,22683D99968
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       xor       r9d,r9d
       call      System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
; Total bytes of code 169
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__10_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.ToDictionary(p => p.Email);
; 			                                                           ^^^^^^^
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14,r9
       test      rbx,rbx
       je        near ptr M02_L27
       test      rdi,rdi
       je        near ptr M02_L28
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L00
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB370131C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rbx
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r12,rax
       test      r12,r12
       je        near ptr M02_L18
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],60
       jle       short M02_L02
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB37013AE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,r12
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       jne       short M02_L06
       mov       r15,[rsi+10]
       mov       rbx,[r15+10]
       cmp       rbx,48
       jle       short M02_L04
       mov       rcx,[r15+48]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB370137B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,r14
       xor       edx,edx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rax,rsi
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
M02_L06:
       mov       rcx,[rsi+10]
       mov       r13,rcx
       mov       rcx,r13
       mov       rdx,[rcx+10]
       mov       rax,rdx
       mov       [rbp+0FFB8],rax
       cmp       rax,68
       jle       short M02_L07
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB37013AF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       mov       rdx,r12
       call      CORINFO_HELP_ISINSTANCEOFARRAY
       mov       [rbp+0FFB0],rax
       test      rax,rax
       je        short M02_L13
       mov       rax,[rbp+0FFB0]
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],80
       jle       short M02_L10
       mov       rcx,[rcx+80]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L12
M02_L09:
       mov       [rbp+0FFB0],rax
       jmp       short M02_L11
M02_L10:
       mov       [rbp+0FFB0],rax
       jmp       short M02_L11
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFB37013EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       mov       rax,[rbp+0FFB0]
M02_L12:
       mov       rdx,rax
       mov       r8,rdi
       mov       r9,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       near ptr System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
M02_L13:
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],70
       jle       short M02_L14
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFB37013B20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L15:
       mov       rdx,r12
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       r12,rax
       test      r12,r12
       je        short M02_L18
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],78
       jle       short M02_L16
       mov       rcx,[rcx+78]
       test      rcx,rcx
       je        short M02_L16
       jmp       short M02_L17
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFB37013E38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L17:
       mov       rdx,r12
       mov       r8,rdi
       mov       r9,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       near ptr System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
M02_L18:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],48
       jle       short M02_L19
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M02_L19
       jmp       short M02_L20
M02_L19:
       mov       rcx,rsi
       mov       rdx,7FFB370137B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L20:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,r15d
       mov       r8,r14
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],50
       jle       short M02_L21
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L21
       jmp       short M02_L22
M02_L21:
       mov       rcx,rsi
       mov       rdx,7FFB370137C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L22:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFA8],rax
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36B205B0
       call      qword ptr [7FFB36F305B0]
       test      eax,eax
       je        short M02_L26
M02_L23:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],58
       jle       short M02_L24
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M02_L24
       jmp       short M02_L25
M02_L24:
       mov       rcx,rsi
       mov       rdx,7FFB370138E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L25:
       mov       rcx,[rbp+0FFA8]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       mov       rdx,rbx
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rcx,r12
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36B205B0
       call      qword ptr [7FFB36F305B0]
       test      eax,eax
       jne       short M02_L23
M02_L26:
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36B205B8
       call      qword ptr [7FFB36F305B8]
       mov       rax,r12
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
M02_L27:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L28:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFA8],0
       je        short M02_L29
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36B205B8
       call      qword ptr [7FFB36F305B8]
M02_L29:
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
; Total bytes of code 967
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
; 			var result = base.PersonProperCollection.ToDictionary(p => p.Email);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,250A1F57950
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,250A1F57938
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__10_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,250A1F57950
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       xor       r9d,r9d
       call      System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
; Total bytes of code 169
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__10_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.ToDictionary(p => p.Email);
; 			                                                           ^^^^^^^
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14,r9
       test      rbx,rbx
       je        near ptr M02_L27
       test      rdi,rdi
       je        near ptr M02_L28
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L00
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE30B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rbx
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r12,rax
       test      r12,r12
       je        near ptr M02_L18
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],60
       jle       short M02_L02
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FE39D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,r12
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       jne       short M02_L06
       mov       r15,[rsi+10]
       mov       rbx,[r15+10]
       cmp       rbx,48
       jle       short M02_L04
       mov       rcx,[r15+48]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FE36A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,r14
       xor       edx,edx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rax,rsi
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
M02_L06:
       mov       rcx,[rsi+10]
       mov       r13,rcx
       mov       rcx,r13
       mov       rdx,[rcx+10]
       mov       rax,rdx
       mov       [rbp+0FFB8],rax
       cmp       rax,68
       jle       short M02_L07
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB36FE39E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       mov       rdx,r12
       call      CORINFO_HELP_ISINSTANCEOFARRAY
       mov       [rbp+0FFB0],rax
       test      rax,rax
       je        short M02_L13
       mov       rax,[rbp+0FFB0]
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],80
       jle       short M02_L10
       mov       rcx,[rcx+80]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L12
M02_L09:
       mov       [rbp+0FFB0],rax
       jmp       short M02_L11
M02_L10:
       mov       [rbp+0FFB0],rax
       jmp       short M02_L11
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFB36FE3DD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       mov       rax,[rbp+0FFB0]
M02_L12:
       mov       rdx,rax
       mov       r8,rdi
       mov       r9,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       near ptr System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
M02_L13:
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],70
       jle       short M02_L14
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFB36FE3A10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L15:
       mov       rdx,r12
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       r12,rax
       test      r12,r12
       je        short M02_L18
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],78
       jle       short M02_L16
       mov       rcx,[rcx+78]
       test      rcx,rcx
       je        short M02_L16
       jmp       short M02_L17
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFB36FE3D28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L17:
       mov       rdx,r12
       mov       r8,rdi
       mov       r9,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       near ptr System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
M02_L18:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],48
       jle       short M02_L19
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M02_L19
       jmp       short M02_L20
M02_L19:
       mov       rcx,rsi
       mov       rdx,7FFB36FE36A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L20:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,r15d
       mov       r8,r14
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],50
       jle       short M02_L21
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L21
       jmp       short M02_L22
M02_L21:
       mov       rcx,rsi
       mov       rdx,7FFB36FE36B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L22:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFA8],rax
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36AF05B0
       call      qword ptr [7FFB36F005B0]
       test      eax,eax
       je        short M02_L26
M02_L23:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],58
       jle       short M02_L24
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M02_L24
       jmp       short M02_L25
M02_L24:
       mov       rcx,rsi
       mov       rdx,7FFB36FE37D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L25:
       mov       rcx,[rbp+0FFA8]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       mov       rdx,rbx
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rcx,r12
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36AF05B0
       call      qword ptr [7FFB36F005B0]
       test      eax,eax
       jne       short M02_L23
M02_L26:
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36AF05B8
       call      qword ptr [7FFB36F005B8]
       mov       rax,r12
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
M02_L27:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L28:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFA8],0
       je        short M02_L29
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36AF05B8
       call      qword ptr [7FFB36F005B8]
M02_L29:
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
; Total bytes of code 967
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
; 			var result = base.PersonProperCollection.ToDictionary(p => p.Email);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,2D97E0A7950
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2D97E0A7938
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__10_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2D97E0A7950
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       xor       r9d,r9d
       call      System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
; Total bytes of code 169
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__10_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.ToDictionary(p => p.Email);
; 			                                                           ^^^^^^^
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14,r9
       test      rbx,rbx
       je        near ptr M02_L27
       test      rdi,rdi
       je        near ptr M02_L28
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L00
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE32E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rbx
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r12,rax
       test      r12,r12
       je        near ptr M02_L18
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],60
       jle       short M02_L02
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FE3C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,r12
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       jne       short M02_L06
       mov       r15,[rsi+10]
       mov       rbx,[r15+10]
       cmp       rbx,48
       jle       short M02_L04
       mov       rcx,[r15+48]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FE38D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,r14
       xor       edx,edx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rax,rsi
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
M02_L06:
       mov       rcx,[rsi+10]
       mov       r13,rcx
       mov       rcx,r13
       mov       rdx,[rcx+10]
       mov       rax,rdx
       mov       [rbp+0FFB8],rax
       cmp       rax,68
       jle       short M02_L07
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB36FE3C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       mov       rdx,r12
       call      CORINFO_HELP_ISINSTANCEOFARRAY
       mov       [rbp+0FFB0],rax
       test      rax,rax
       je        short M02_L13
       mov       rax,[rbp+0FFB0]
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],80
       jle       short M02_L10
       mov       rcx,[rcx+80]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L12
M02_L09:
       mov       [rbp+0FFB0],rax
       jmp       short M02_L11
M02_L10:
       mov       [rbp+0FFB0],rax
       jmp       short M02_L11
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFB36FE4008
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       mov       rax,[rbp+0FFB0]
M02_L12:
       mov       rdx,rax
       mov       r8,rdi
       mov       r9,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       near ptr System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
M02_L13:
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],70
       jle       short M02_L14
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFB36FE3C40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L15:
       mov       rdx,r12
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       r12,rax
       test      r12,r12
       je        short M02_L18
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],78
       jle       short M02_L16
       mov       rcx,[rcx+78]
       test      rcx,rcx
       je        short M02_L16
       jmp       short M02_L17
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFB36FE3F58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L17:
       mov       rdx,r12
       mov       r8,rdi
       mov       r9,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       near ptr System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
M02_L18:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],48
       jle       short M02_L19
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M02_L19
       jmp       short M02_L20
M02_L19:
       mov       rcx,rsi
       mov       rdx,7FFB36FE38D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L20:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,r15d
       mov       r8,r14
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],50
       jle       short M02_L21
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L21
       jmp       short M02_L22
M02_L21:
       mov       rcx,rsi
       mov       rdx,7FFB36FE38E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L22:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFA8],rax
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36AF05B0
       call      qword ptr [7FFB36F005B0]
       test      eax,eax
       je        short M02_L26
M02_L23:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],58
       jle       short M02_L24
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M02_L24
       jmp       short M02_L25
M02_L24:
       mov       rcx,rsi
       mov       rdx,7FFB36FE3A08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L25:
       mov       rcx,[rbp+0FFA8]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       mov       rdx,rbx
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rcx,r12
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36AF05B0
       call      qword ptr [7FFB36F005B0]
       test      eax,eax
       jne       short M02_L23
M02_L26:
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36AF05B8
       call      qword ptr [7FFB36F005B8]
       mov       rax,r12
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
M02_L27:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L28:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFA8],0
       je        short M02_L29
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36AF05B8
       call      qword ptr [7FFB36F005B8]
M02_L29:
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
; Total bytes of code 967
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
; 			var result = base.PersonProperCollection.ToDictionary(p => p.Email);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,14D1ACE9968
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,14D1ACE9950
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__10_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,14D1ACE9968
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       xor       r9d,r9d
       call      System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
; Total bytes of code 169
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__10_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.ToDictionary(p => p.Email);
; 			                                                           ^^^^^^^
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14,r9
       test      rbx,rbx
       je        near ptr M02_L27
       test      rdi,rdi
       je        near ptr M02_L28
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L00
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB370031B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rbx
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r12,rax
       test      r12,r12
       je        near ptr M02_L18
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],60
       jle       short M02_L02
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB37003AD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,r12
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       jne       short M02_L06
       mov       r15,[rsi+10]
       mov       rbx,[r15+10]
       cmp       rbx,48
       jle       short M02_L04
       mov       rcx,[r15+48]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB370037A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,r14
       xor       edx,edx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rax,rsi
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
M02_L06:
       mov       rcx,[rsi+10]
       mov       r13,rcx
       mov       rcx,r13
       mov       rdx,[rcx+10]
       mov       rax,rdx
       mov       [rbp+0FFB8],rax
       cmp       rax,68
       jle       short M02_L07
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB37003AE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       mov       rdx,r12
       call      CORINFO_HELP_ISINSTANCEOFARRAY
       mov       [rbp+0FFB0],rax
       test      rax,rax
       je        short M02_L13
       mov       rax,[rbp+0FFB0]
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],80
       jle       short M02_L10
       mov       rcx,[rcx+80]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L12
M02_L09:
       mov       [rbp+0FFB0],rax
       jmp       short M02_L11
M02_L10:
       mov       [rbp+0FFB0],rax
       jmp       short M02_L11
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFB37003ED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       mov       rax,[rbp+0FFB0]
M02_L12:
       mov       rdx,rax
       mov       r8,rdi
       mov       r9,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       near ptr System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
M02_L13:
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],70
       jle       short M02_L14
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFB37003B10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L15:
       mov       rdx,r12
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       r12,rax
       test      r12,r12
       je        short M02_L18
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],78
       jle       short M02_L16
       mov       rcx,[rcx+78]
       test      rcx,rcx
       je        short M02_L16
       jmp       short M02_L17
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFB37003E28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L17:
       mov       rdx,r12
       mov       r8,rdi
       mov       r9,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       near ptr System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
M02_L18:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],48
       jle       short M02_L19
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M02_L19
       jmp       short M02_L20
M02_L19:
       mov       rcx,rsi
       mov       rdx,7FFB370037A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L20:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,r15d
       mov       r8,r14
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],50
       jle       short M02_L21
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L21
       jmp       short M02_L22
M02_L21:
       mov       rcx,rsi
       mov       rdx,7FFB370037B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L22:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFA8],rax
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36B105B0
       call      qword ptr [7FFB36F205B0]
       test      eax,eax
       je        short M02_L26
M02_L23:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],58
       jle       short M02_L24
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M02_L24
       jmp       short M02_L25
M02_L24:
       mov       rcx,rsi
       mov       rdx,7FFB370038D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L25:
       mov       rcx,[rbp+0FFA8]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       mov       rdx,rbx
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rcx,r12
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36B105B0
       call      qword ptr [7FFB36F205B0]
       test      eax,eax
       jne       short M02_L23
M02_L26:
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36B105B8
       call      qword ptr [7FFB36F205B8]
       mov       rax,r12
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
M02_L27:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L28:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFA8],0
       je        short M02_L29
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36B105B8
       call      qword ptr [7FFB36F205B8]
M02_L29:
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
; Total bytes of code 967
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
; 			var result = base.PersonProperCollection.ToDictionary(p => p.Email);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,261AF9A2EE0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,261AF9A2EC8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__10_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,261AF9A2EE0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       xor       r9d,r9d
       call      System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
; Total bytes of code 169
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__10_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.ToDictionary(p => p.Email);
; 			                                                           ^^^^^^^
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14,r9
       test      rbx,rbx
       je        near ptr M02_L27
       test      rdi,rdi
       je        near ptr M02_L28
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L00
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB370134C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rbx
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r12,rax
       test      r12,r12
       je        near ptr M02_L18
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],60
       jle       short M02_L02
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB37013DE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,r12
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       jne       short M02_L06
       mov       r15,[rsi+10]
       mov       rbx,[r15+10]
       cmp       rbx,48
       jle       short M02_L04
       mov       rcx,[r15+48]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB37013AB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,r14
       xor       edx,edx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rax,rsi
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
M02_L06:
       mov       rcx,[rsi+10]
       mov       r13,rcx
       mov       rcx,r13
       mov       rdx,[rcx+10]
       mov       rax,rdx
       mov       [rbp+0FFB8],rax
       cmp       rax,68
       jle       short M02_L07
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB37013DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       mov       rdx,r12
       call      CORINFO_HELP_ISINSTANCEOFARRAY
       mov       [rbp+0FFB0],rax
       test      rax,rax
       je        short M02_L13
       mov       rax,[rbp+0FFB0]
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],80
       jle       short M02_L10
       mov       rcx,[rcx+80]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L12
M02_L09:
       mov       [rbp+0FFB0],rax
       jmp       short M02_L11
M02_L10:
       mov       [rbp+0FFB0],rax
       jmp       short M02_L11
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFB370141E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       mov       rax,[rbp+0FFB0]
M02_L12:
       mov       rdx,rax
       mov       r8,rdi
       mov       r9,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       near ptr System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
M02_L13:
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],70
       jle       short M02_L14
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFB37013E20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L15:
       mov       rdx,r12
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       r12,rax
       test      r12,r12
       je        short M02_L18
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],78
       jle       short M02_L16
       mov       rcx,[rcx+78]
       test      rcx,rcx
       je        short M02_L16
       jmp       short M02_L17
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFB37014138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L17:
       mov       rdx,r12
       mov       r8,rdi
       mov       r9,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       near ptr System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
M02_L18:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],48
       jle       short M02_L19
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M02_L19
       jmp       short M02_L20
M02_L19:
       mov       rcx,rsi
       mov       rdx,7FFB37013AB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L20:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,r15d
       mov       r8,r14
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],50
       jle       short M02_L21
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L21
       jmp       short M02_L22
M02_L21:
       mov       rcx,rsi
       mov       rdx,7FFB37013AC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L22:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFA8],rax
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36B205B0
       call      qword ptr [7FFB36F305B0]
       test      eax,eax
       je        short M02_L26
M02_L23:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],58
       jle       short M02_L24
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M02_L24
       jmp       short M02_L25
M02_L24:
       mov       rcx,rsi
       mov       rdx,7FFB37013BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L25:
       mov       rcx,[rbp+0FFA8]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       mov       rdx,rbx
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rcx,r12
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36B205B0
       call      qword ptr [7FFB36F305B0]
       test      eax,eax
       jne       short M02_L23
M02_L26:
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36B205B8
       call      qword ptr [7FFB36F305B8]
       mov       rax,r12
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
M02_L27:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L28:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFA8],0
       je        short M02_L29
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36B205B8
       call      qword ptr [7FFB36F305B8]
M02_L29:
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
; Total bytes of code 967
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
; 			var result = base.PersonProperCollection.ToDictionary(p => p.Email);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,1E0B30C9968
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1E0B30C9950
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__10_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1E0B30C9968
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       xor       r9d,r9d
       call      System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
; Total bytes of code 169
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__10_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.ToDictionary(p => p.Email);
; 			                                                           ^^^^^^^
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14,r9
       test      rbx,rbx
       je        near ptr M02_L27
       test      rdi,rdi
       je        near ptr M02_L28
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L00
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF2FC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rbx
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r12,rax
       test      r12,r12
       je        near ptr M02_L18
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],60
       jle       short M02_L02
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FF38E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,r12
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       jne       short M02_L06
       mov       r15,[rsi+10]
       mov       rbx,[r15+10]
       cmp       rbx,48
       jle       short M02_L04
       mov       rcx,[r15+48]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FF35B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,r14
       xor       edx,edx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rax,rsi
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
M02_L06:
       mov       rcx,[rsi+10]
       mov       r13,rcx
       mov       rcx,r13
       mov       rdx,[rcx+10]
       mov       rax,rdx
       mov       [rbp+0FFB8],rax
       cmp       rax,68
       jle       short M02_L07
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB36FF3900
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       mov       rdx,r12
       call      CORINFO_HELP_ISINSTANCEOFARRAY
       mov       [rbp+0FFB0],rax
       test      rax,rax
       je        short M02_L13
       mov       rax,[rbp+0FFB0]
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],80
       jle       short M02_L10
       mov       rcx,[rcx+80]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L12
M02_L09:
       mov       [rbp+0FFB0],rax
       jmp       short M02_L11
M02_L10:
       mov       [rbp+0FFB0],rax
       jmp       short M02_L11
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFB36FF3CF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       mov       rax,[rbp+0FFB0]
M02_L12:
       mov       rdx,rax
       mov       r8,rdi
       mov       r9,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       near ptr System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
M02_L13:
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],70
       jle       short M02_L14
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFB36FF3928
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L15:
       mov       rdx,r12
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       r12,rax
       test      r12,r12
       je        short M02_L18
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],78
       jle       short M02_L16
       mov       rcx,[rcx+78]
       test      rcx,rcx
       je        short M02_L16
       jmp       short M02_L17
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFB36FF3C40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L17:
       mov       rdx,r12
       mov       r8,rdi
       mov       r9,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       near ptr System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
M02_L18:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],48
       jle       short M02_L19
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M02_L19
       jmp       short M02_L20
M02_L19:
       mov       rcx,rsi
       mov       rdx,7FFB36FF35B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L20:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,r15d
       mov       r8,r14
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],50
       jle       short M02_L21
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L21
       jmp       short M02_L22
M02_L21:
       mov       rcx,rsi
       mov       rdx,7FFB36FF35D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L22:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFA8],rax
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36B005B0
       call      qword ptr [7FFB36F105B0]
       test      eax,eax
       je        short M02_L26
M02_L23:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],58
       jle       short M02_L24
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M02_L24
       jmp       short M02_L25
M02_L24:
       mov       rcx,rsi
       mov       rdx,7FFB36FF36F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L25:
       mov       rcx,[rbp+0FFA8]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       mov       rdx,rbx
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rcx,r12
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36B005B0
       call      qword ptr [7FFB36F105B0]
       test      eax,eax
       jne       short M02_L23
M02_L26:
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36B005B8
       call      qword ptr [7FFB36F105B8]
       mov       rax,r12
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
M02_L27:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L28:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFA8],0
       je        short M02_L29
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36B005B8
       call      qword ptr [7FFB36F105B8]
M02_L29:
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
; Total bytes of code 967
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToDictionary01()
; 			var result = base.PersonProperCollection.ToDictionary(p => p.Email);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,213BDEE7950
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,213BDEE7938
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__10_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,213BDEE7950
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       xor       r9d,r9d
       call      System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
; Total bytes of code 169
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark+<>c.<ToDictionary01>b__10_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.ToDictionary(p => p.Email);
; 			                                                           ^^^^^^^
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14,r9
       test      rbx,rbx
       je        near ptr M02_L27
       test      rdi,rdi
       je        near ptr M02_L28
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L00
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE3438
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rbx
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r12,rax
       test      r12,r12
       je        near ptr M02_L18
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],60
       jle       short M02_L02
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FE3D58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,r12
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       jne       short M02_L06
       mov       r15,[rsi+10]
       mov       rbx,[r15+10]
       cmp       rbx,48
       jle       short M02_L04
       mov       rcx,[r15+48]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FE3A28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,r14
       xor       edx,edx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rax,rsi
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
M02_L06:
       mov       rcx,[rsi+10]
       mov       r13,rcx
       mov       rcx,r13
       mov       rdx,[rcx+10]
       mov       rax,rdx
       mov       [rbp+0FFB8],rax
       cmp       rax,68
       jle       short M02_L07
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB36FE3D70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       mov       rdx,r12
       call      CORINFO_HELP_ISINSTANCEOFARRAY
       mov       [rbp+0FFB0],rax
       test      rax,rax
       je        short M02_L13
       mov       rax,[rbp+0FFB0]
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],80
       jle       short M02_L10
       mov       rcx,[rcx+80]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L12
M02_L09:
       mov       [rbp+0FFB0],rax
       jmp       short M02_L11
M02_L10:
       mov       [rbp+0FFB0],rax
       jmp       short M02_L11
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFB36FE4160
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       mov       rax,[rbp+0FFB0]
M02_L12:
       mov       rdx,rax
       mov       r8,rdi
       mov       r9,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       near ptr System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
M02_L13:
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],70
       jle       short M02_L14
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFB36FE3D98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L15:
       mov       rdx,r12
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       r12,rax
       test      r12,r12
       je        short M02_L18
       mov       rcx,r13
       cmp       qword ptr [rbp+0FFB8],78
       jle       short M02_L16
       mov       rcx,[rcx+78]
       test      rcx,rcx
       je        short M02_L16
       jmp       short M02_L17
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFB36FE40B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L17:
       mov       rdx,r12
       mov       r8,rdi
       mov       r9,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       near ptr System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
M02_L18:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],48
       jle       short M02_L19
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M02_L19
       jmp       short M02_L20
M02_L19:
       mov       rcx,rsi
       mov       rdx,7FFB36FE3A28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L20:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,r15d
       mov       r8,r14
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],50
       jle       short M02_L21
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L21
       jmp       short M02_L22
M02_L21:
       mov       rcx,rsi
       mov       rdx,7FFB36FE3A40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L22:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFA8],rax
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36AF05B0
       call      qword ptr [7FFB36F005B0]
       test      eax,eax
       je        short M02_L26
M02_L23:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],58
       jle       short M02_L24
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M02_L24
       jmp       short M02_L25
M02_L24:
       mov       rcx,rsi
       mov       rdx,7FFB36FE3B60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L25:
       mov       rcx,[rbp+0FFA8]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       mov       rdx,rbx
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rcx,r12
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36AF05B0
       call      qword ptr [7FFB36F005B0]
       test      eax,eax
       jne       short M02_L23
M02_L26:
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36AF05B8
       call      qword ptr [7FFB36F005B8]
       mov       rax,r12
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
M02_L27:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L28:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFA8],0
       je        short M02_L29
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB36AF05B8
       call      qword ptr [7FFB36F005B8]
M02_L29:
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
; Total bytes of code 967
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToLinkedList01()
; 			var result = base.PersonProperCollection.ToLinkedList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1EE5C483060
       mov       r8,[r8]
       mov       rdx,1EE4C4811A0
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
       mov       rdx,7FFB37010E70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.LinkedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToLinkedList01()
; 			var result = base.PersonProperCollection.ToLinkedList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,22C92933060
       mov       r8,[r8]
       mov       rdx,22C7293DBC8
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
       mov       rdx,7FFB36FF0ED0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.LinkedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToLinkedList01()
; 			var result = base.PersonProperCollection.ToLinkedList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,195EB2F3060
       mov       r8,[r8]
       mov       rdx,195FB2F11A0
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
       mov       rdx,7FFB36FE0ED0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.LinkedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToLinkedList01()
; 			var result = base.PersonProperCollection.ToLinkedList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,189F25E3060
       mov       r8,[r8]
       mov       rdx,18A025EDBC8
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
       mov       rdx,7FFB37011058
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.LinkedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToLinkedList01()
; 			var result = base.PersonProperCollection.ToLinkedList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1F891761048
       mov       r8,[r8]
       mov       rdx,1F8A17611A0
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
       mov       rdx,7FFB36FE1060
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.LinkedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToLinkedList01()
; 			var result = base.PersonProperCollection.ToLinkedList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,17874F01048
       mov       r8,[r8]
       mov       rdx,17864F09158
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
       mov       rdx,7FFB36FE1060
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.LinkedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToLinkedList01()
; 			var result = base.PersonProperCollection.ToLinkedList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1A688F33060
       mov       r8,[r8]
       mov       rdx,1A698F3DBC8
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
       mov       rdx,7FFB36FF12E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.LinkedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToLinkedList01()
; 			var result = base.PersonProperCollection.ToLinkedList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,2121F253060
       mov       r8,[r8]
       mov       rdx,2124F2511A0
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
       mov       rdx,7FFB36FE12E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.LinkedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark.ToLinkedList01()
; 			var result = base.PersonProperCollection.ToLinkedList();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+98]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToLinkedList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,18B9D541048
       mov       r8,[r8]
       mov       rdx,18BAD5411A0
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
       mov       rdx,7FFB36FF12E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Collections.Generic.LinkedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```

