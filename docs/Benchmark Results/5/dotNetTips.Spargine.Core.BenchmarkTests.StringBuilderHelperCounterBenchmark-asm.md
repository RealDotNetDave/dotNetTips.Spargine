## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var people = base.PersonProperDictionary.AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+138]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
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
       mov       rdx,7FFA7F03F388
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
       mov       rax,20D48B83020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       lea       edx,[rax+rax*4]
       add       edx,edx
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFA7F03F970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFA7F03FAE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass18_0`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].<ToDelimitedString>b__0(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ForEach(System.Action`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFA7EF431E8]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
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
; Total bytes of code 345
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var people = base.PersonProperDictionary.AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+138]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
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
       mov       rdx,7FFA7F05F808
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
       mov       rax,18878793020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       lea       edx,[rax+rax*4]
       add       edx,edx
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFA7F05FDF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFA7F05FF68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass18_0`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].<ToDelimitedString>b__0(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ForEach(System.Action`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFA7EF631E8]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
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
; Total bytes of code 345
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var people = base.PersonProperDictionary.AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+138]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
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
       mov       rdx,7FFA7F02F848
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
       mov       rax,1F1E8643020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       lea       edx,[rax+rax*4]
       add       edx,edx
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFA7F02FE30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFA7F02FFA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass18_0`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].<ToDelimitedString>b__0(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ForEach(System.Action`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFA7EF331E8]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
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
; Total bytes of code 345
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var people = base.PersonProperDictionary.AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+138]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
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
       mov       rdx,7FFA7F02F860
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
       mov       rax,21D58F23020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       lea       edx,[rax+rax*4]
       add       edx,edx
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFA7F02FE48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFA7F02FFC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass18_0`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].<ToDelimitedString>b__0(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ForEach(System.Action`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFA7EF331E8]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
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
; Total bytes of code 345
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var people = base.PersonProperDictionary.AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+138]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
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
       mov       rdx,7FFA7F01F8A0
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
       mov       rax,1B786403020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       lea       edx,[rax+rax*4]
       add       edx,edx
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFA7F01FE88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFA7F030020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass18_0`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].<ToDelimitedString>b__0(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ForEach(System.Action`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFA7EF231E8]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
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
; Total bytes of code 345
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var people = base.PersonProperDictionary.AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+138]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
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
       mov       rdx,7FFA7F01F8A0
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
       mov       rax,25AFEAF1028
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       lea       edx,[rax+rax*4]
       add       edx,edx
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFA7F01FE88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFA7F030020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass18_0`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].<ToDelimitedString>b__0(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ForEach(System.Action`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFA7EF231E8]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
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
; Total bytes of code 345
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var people = base.PersonProperDictionary.AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+138]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
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
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
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
       mov       rdx,7FFA7F04F860
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
       mov       rax,12F4F893020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       lea       edx,[rax+rax*4]
       add       edx,edx
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFA7F04FE48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFA7F04FFC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass18_0`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].<ToDelimitedString>b__0(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ForEach(System.Action`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFA7EF531E8]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
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
; Total bytes of code 345
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString02()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = StringBuilderHelper.ToDelimitedString(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+138]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
; dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,80
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FF80],rsp
       mov       [rbp+0FFD8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       rsi,rdx
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,237ED7E1028
       mov       rax,[rax]
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L00:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdx,[rbp+0FFB0]
       mov       rcx,rsi
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       short M01_L02
M01_L01:
       lea       rax,[rbp+0FFC8]
       mov       rsi,[rax]
       mov       rbx,[rax+8]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       movzx     r14d,word ptr [rbp+20]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],r14w
       mov       r8,237DD7E1348
       mov       r8,[r8]
       mov       rdx,237CD7E1230
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF90]
       mov       [rcx],rsi
       mov       [rcx+8],rbx
       mov       [rcx+10],rax
       mov       [rcx+18],r8
       lea       r8,[rbp+0FF90]
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L02:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA7F04F8C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       lea       rcx,[rbp+0FFB0]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA7F04F9B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB0]
       call      rax
       mov       r8d,[rdi+1C]
       mov       ecx,[rdi+18]
       lea       r8d,[r8+rcx+0FFFF]
       mov       rcx,rdi
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       nop
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
       lea       rbp,[rbp+0A0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+28],0
       je        short M01_L07
       mov       rax,[rsi+28]
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA7F04F9B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       lea       rcx,[rbp+0FFB0]
       call      rax
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 489
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString02()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = StringBuilderHelper.ToDelimitedString(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+138]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
; dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,80
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FF80],rsp
       mov       [rbp+0FFD8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       rsi,rdx
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,23BFEC43020
       mov       rax,[rax]
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L00:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdx,[rbp+0FFB0]
       mov       rcx,rsi
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       short M01_L02
M01_L01:
       lea       rax,[rbp+0FFC8]
       mov       rsi,[rax]
       mov       rbx,[rax+8]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       movzx     r14d,word ptr [rbp+20]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],r14w
       mov       r8,23BFEC41348
       mov       r8,[r8]
       mov       rdx,23C1EC47200
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF90]
       mov       [rcx],rsi
       mov       [rcx+8],rbx
       mov       [rcx+10],rax
       mov       [rcx+18],r8
       lea       r8,[rbp+0FF90]
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L02:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA7F04FDD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       lea       rcx,[rbp+0FFB0]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA7F04FEC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB0]
       call      rax
       mov       r8d,[rdi+1C]
       mov       ecx,[rdi+18]
       lea       r8d,[r8+rcx+0FFFF]
       mov       rcx,rdi
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       nop
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
       lea       rbp,[rbp+0A0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+28],0
       je        short M01_L07
       mov       rax,[rsi+28]
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA7F04FEC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       lea       rcx,[rbp+0FFB0]
       call      rax
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 489
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString02()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = StringBuilderHelper.ToDelimitedString(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+138]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
; dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,80
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FF80],rsp
       mov       [rbp+0FFD8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       rsi,rdx
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,1F276EF1028
       mov       rax,[rax]
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L00:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdx,[rbp+0FFB0]
       mov       rcx,rsi
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       short M01_L02
M01_L01:
       lea       rax,[rbp+0FFC8]
       mov       rsi,[rax]
       mov       rbx,[rax+8]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       movzx     r14d,word ptr [rbp+20]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],r14w
       mov       r8,1F266EF1348
       mov       r8,[r8]
       mov       rdx,1F276EF7E30
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF90]
       mov       [rcx],rsi
       mov       [rcx+8],rbx
       mov       [rcx+10],rax
       mov       [rcx+18],r8
       lea       r8,[rbp+0FF90]
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L02:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA7F02FDD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       lea       rcx,[rbp+0FFB0]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA7F02FEC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB0]
       call      rax
       mov       r8d,[rdi+1C]
       mov       ecx,[rdi+18]
       lea       r8d,[r8+rcx+0FFFF]
       mov       rcx,rdi
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       nop
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
       lea       rbp,[rbp+0A0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+28],0
       je        short M01_L07
       mov       rax,[rsi+28]
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA7F02FEC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       lea       rcx,[rbp+0FFB0]
       call      rax
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 489
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString02()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = StringBuilderHelper.ToDelimitedString(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+138]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
; dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,80
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FF80],rsp
       mov       [rbp+0FFD8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       rsi,rdx
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,28496B41028
       mov       rax,[rax]
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L00:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdx,[rbp+0FFB0]
       mov       rcx,rsi
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       short M01_L02
M01_L01:
       lea       rax,[rbp+0FFC8]
       mov       rsi,[rax]
       mov       rbx,[rax+8]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       movzx     r14d,word ptr [rbp+20]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],r14w
       mov       r8,28476B41348
       mov       r8,[r8]
       mov       rdx,28476B43228
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF90]
       mov       [rcx],rsi
       mov       [rcx+8],rbx
       mov       [rcx+10],rax
       mov       [rcx+18],r8
       lea       r8,[rbp+0FF90]
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L02:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA7F05FD98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       lea       rcx,[rbp+0FFB0]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA7F05FE88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB0]
       call      rax
       mov       r8d,[rdi+1C]
       mov       ecx,[rdi+18]
       lea       r8d,[r8+rcx+0FFFF]
       mov       rcx,rdi
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       nop
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
       lea       rbp,[rbp+0A0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+28],0
       je        short M01_L07
       mov       rax,[rsi+28]
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA7F05FE88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       lea       rcx,[rbp+0FFB0]
       call      rax
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 489
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString02()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = StringBuilderHelper.ToDelimitedString(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+138]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
; dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,80
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FF80],rsp
       mov       [rbp+0FFD8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       rsi,rdx
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,2132F363020
       mov       rax,[rax]
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L00:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdx,[rbp+0FFB0]
       mov       rcx,rsi
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       short M01_L02
M01_L01:
       lea       rax,[rbp+0FFC8]
       mov       rsi,[rax]
       mov       rbx,[rax+8]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       movzx     r14d,word ptr [rbp+20]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],r14w
       mov       r8,2132F361348
       mov       r8,[r8]
       mov       rdx,2130F361A48
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF90]
       mov       [rcx],rsi
       mov       [rcx+8],rbx
       mov       [rcx+10],rax
       mov       [rcx+18],r8
       lea       r8,[rbp+0FF90]
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L02:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA7F05FD98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       lea       rcx,[rbp+0FFB0]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA7F05FE88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB0]
       call      rax
       mov       r8d,[rdi+1C]
       mov       ecx,[rdi+18]
       lea       r8d,[r8+rcx+0FFFF]
       mov       rcx,rdi
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       nop
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
       lea       rbp,[rbp+0A0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+28],0
       je        short M01_L07
       mov       rax,[rsi+28]
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA7F05FE88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       lea       rcx,[rbp+0FFB0]
       call      rax
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 489
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString02()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = StringBuilderHelper.ToDelimitedString(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+138]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
; dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,80
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FF80],rsp
       mov       [rbp+0FFD8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       rsi,rdx
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,1C67B653020
       mov       rax,[rax]
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L00:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdx,[rbp+0FFB0]
       mov       rcx,rsi
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       short M01_L02
M01_L01:
       lea       rax,[rbp+0FFC8]
       mov       rsi,[rax]
       mov       rbx,[rax+8]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       movzx     r14d,word ptr [rbp+20]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],r14w
       mov       r8,1C67B651348
       mov       r8,[r8]
       mov       rdx,1C68B651230
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF90]
       mov       [rcx],rsi
       mov       [rcx+8],rbx
       mov       [rcx+10],rax
       mov       [rcx+18],r8
       lea       r8,[rbp+0FF90]
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L02:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA7F04FD80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       lea       rcx,[rbp+0FFB0]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA7F04FE70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB0]
       call      rax
       mov       r8d,[rdi+1C]
       mov       ecx,[rdi+18]
       lea       r8d,[r8+rcx+0FFFF]
       mov       rcx,rdi
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       nop
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
       lea       rbp,[rbp+0A0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+28],0
       je        short M01_L07
       mov       rax,[rsi+28]
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA7F04FE70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       lea       rcx,[rbp+0FFB0]
       call      rax
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 489
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString02()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = StringBuilderHelper.ToDelimitedString(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+138]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
; dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,80
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FF80],rsp
       mov       [rbp+0FFD8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       rsi,rdx
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,1BF22E23020
       mov       rax,[rax]
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L00:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdx,[rbp+0FFB0]
       mov       rcx,rsi
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       short M01_L02
M01_L01:
       lea       rax,[rbp+0FFC8]
       mov       rsi,[rax]
       mov       rbx,[rax+8]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       movzx     r14d,word ptr [rbp+20]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],r14w
       mov       r8,1BF22E21348
       mov       r8,[r8]
       mov       rdx,1BF22E25E50
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF90]
       mov       [rcx],rsi
       mov       [rcx+8],rbx
       mov       [rcx+10],rax
       mov       [rcx+18],r8
       lea       r8,[rbp+0FF90]
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L02:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA7F04FD80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       lea       rcx,[rbp+0FFB0]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA7F04FE70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB0]
       call      rax
       mov       r8d,[rdi+1C]
       mov       ecx,[rdi+18]
       lea       r8d,[r8+rcx+0FFFF]
       mov       rcx,rdi
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       nop
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
       lea       rbp,[rbp+0A0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+28],0
       je        short M01_L07
       mov       rax,[rsi+28]
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA7F04FE70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       lea       rcx,[rbp+0FFB0]
       call      rax
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 489
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,2F85D9B3020
       mov       r8,[r8]
       mov       rdx,2F85D9B33B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2F87D9B7200
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,2F85D9B1508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,2F87D9B7208
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       mov       rcx,rdi
       mov       rax,[7FFA7EF231E8]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 237
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,289205A1028
       mov       r8,[r8]
       mov       rdx,289205A13C0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,289205A7618
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,289105A1508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,289205A7620
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       mov       rcx,rdi
       mov       rax,[7FFA7EF531E8]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 237
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,20AB1C73020
       mov       r8,[r8]
       mov       rdx,20AB1C733B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,20AA1C71230
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,20AB1C71508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,20AA1C71238
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       mov       rcx,rdi
       mov       rax,[7FFA7EF431E8]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 237
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,1D48E123020
       mov       r8,[r8]
       mov       rdx,1D48E1233B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1D48E125638
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,1D48E121508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1D48E125640
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       mov       rcx,rdi
       mov       rax,[7FFA7EF231E8]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 237
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,2AA176A1028
       mov       r8,[r8]
       mov       rdx,2AA176A13C0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2AA076A1230
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,2A9F76A1508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,2AA076A1238
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       mov       rcx,rdi
       mov       rax,[7FFA7EF331E8]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 237
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,1C364103020
       mov       r8,[r8]
       mov       rdx,1C3641033B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1C374101230
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,1C364101508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1C374101238
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       mov       rcx,rdi
       mov       rax,[7FFA7EF131E8]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 237
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,157BBA23020
       mov       r8,[r8]
       mov       rdx,157BBA233B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,157BBA29E28
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,157BBA21508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,157BBA29E30
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       mov       rcx,rdi
       mov       rax,[7FFA7EF231E8]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 237
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ConcatToString01()
; 			var result = StringBuilderHelper.ConcatToString(this.CommaDelimitedString, ",", Tristate.True, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rdi,rax
       mov       rcx,20932823158
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 98
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,20932823020
       mov       r8,[r8]
       mov       rdx,209228251A0
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       movsxd    rcx,r15d
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       esi,0FFFFFFFE
       jne       short M01_L02
M01_L01:
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,rbp
       mov       rax,[7FFA7EF431E8]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
; Total bytes of code 225
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ConcatToString01()
; 			var result = StringBuilderHelper.ConcatToString(this.CommaDelimitedString, ",", Tristate.True, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rdi,rax
       mov       rcx,25109931160
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 98
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,25109931028
       mov       r8,[r8]
       mov       rdx,250E99331C0
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       movsxd    rcx,r15d
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       esi,0FFFFFFFE
       jne       short M01_L02
M01_L01:
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,rbp
       mov       rax,[7FFA7EF531E8]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
; Total bytes of code 225
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ConcatToString01()
; 			var result = StringBuilderHelper.ConcatToString(this.CommaDelimitedString, ",", Tristate.True, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rdi,rax
       mov       rcx,17359B71160
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 98
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,17359B71028
       mov       r8,[r8]
       mov       rdx,17339B711C8
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       movsxd    rcx,r15d
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       esi,0FFFFFFFE
       jne       short M01_L02
M01_L01:
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,rbp
       mov       rax,[7FFA7EF431E8]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
; Total bytes of code 225
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ConcatToString01()
; 			var result = StringBuilderHelper.ConcatToString(this.CommaDelimitedString, ",", Tristate.True, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rdi,rax
       mov       rcx,29DC0FD1160
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 98
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,29DC0FD1028
       mov       r8,[r8]
       mov       rdx,29DC0FD75B0
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       movsxd    rcx,r15d
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       esi,0FFFFFFFE
       jne       short M01_L02
M01_L01:
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,rbp
       mov       rax,[7FFA7EF231E8]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
; Total bytes of code 225
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ConcatToString01()
; 			var result = StringBuilderHelper.ConcatToString(this.CommaDelimitedString, ",", Tristate.True, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rdi,rax
       mov       rcx,1A8BDDB1160
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 98
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,1A8BDDB1028
       mov       r8,[r8]
       mov       rdx,1A89DDB11C8
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       movsxd    rcx,r15d
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       esi,0FFFFFFFE
       jne       short M01_L02
M01_L01:
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,rbp
       mov       rax,[7FFA7EF231E8]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
; Total bytes of code 225
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ConcatToString01()
; 			var result = StringBuilderHelper.ConcatToString(this.CommaDelimitedString, ",", Tristate.True, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rdi,rax
       mov       rcx,1D9A9493158
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 98
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,1D9A9493020
       mov       r8,[r8]
       mov       rdx,1D9A94995A8
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       movsxd    rcx,r15d
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       esi,0FFFFFFFE
       jne       short M01_L02
M01_L01:
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,rbp
       mov       rax,[7FFA7EF231E8]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
; Total bytes of code 225
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ConcatToString01()
; 			var result = StringBuilderHelper.ConcatToString(this.CommaDelimitedString, ",", Tristate.True, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rdi,rax
       mov       rcx,24BB9631160
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 98
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,24BB9631028
       mov       r8,[r8]
       mov       rdx,24B996331C0
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       movsxd    rcx,r15d
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       esi,0FFFFFFFE
       jne       short M01_L02
M01_L01:
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,rbp
       mov       rax,[7FFA7EF531E8]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
; Total bytes of code 225
```

