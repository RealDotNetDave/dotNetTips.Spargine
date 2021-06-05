## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+138]
       mov       r9,[rsi+30]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.Dictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 71
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,196ACF43020
       mov       r8,[r8]
       mov       rdx,1968CF417F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,196ACF43020
       mov       r8,[r8]
       mov       rdx,1968CF413C8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,196ACF43020
       mov       r8,[r8]
       mov       rdx,1969CF410D0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFA7EF8CD18]
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 161
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+138]
       mov       r9,[rsi+30]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.Dictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 71
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,2154B6F3020
       mov       r8,[r8]
       mov       rdx,2153B6F17F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,2154B6F3020
       mov       r8,[r8]
       mov       rdx,2153B6F13C8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,2154B6F3020
       mov       r8,[r8]
       mov       rdx,2154B701448
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFA7EF8CD18]
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 161
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+138]
       mov       r9,[rsi+30]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.Dictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 71
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,248DF241028
       mov       r8,[r8]
       mov       rdx,248DF24FB70
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,248DF241028
       mov       r8,[r8]
       mov       rdx,248DF24F748
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,248DF241028
       mov       r8,[r8]
       mov       rdx,248DF24FC68
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFA7EF9CD18]
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 161
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+138]
       mov       r9,[rsi+30]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.Dictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 71
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,28AE21C3020
       mov       r8,[r8]
       mov       rdx,28B021CF758
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,28AE21C3020
       mov       r8,[r8]
       mov       rdx,28B021CF330
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,28AE21C3020
       mov       r8,[r8]
       mov       rdx,28B021CF850
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFA7EF9CD18]
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 161
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+138]
       mov       r9,[rsi+30]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.Dictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 71
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,1262B873020
       mov       r8,[r8]
       mov       rdx,1262B881B68
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1262B873020
       mov       r8,[r8]
       mov       rdx,1262B881740
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1262B873020
       mov       r8,[r8]
       mov       rdx,1261B8710D0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFA7EF5CD18]
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 161
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+138]
       mov       r9,[rsi+30]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.Dictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 71
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,24B37C43020
       mov       r8,[r8]
       mov       rdx,24B17C417F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,24B37C43020
       mov       r8,[r8]
       mov       rdx,24B17C413C8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,24B37C43020
       mov       r8,[r8]
       mov       rdx,24B17C418E8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFA7EF6CD18]
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 161
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+138]
       mov       r9,[rsi+30]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.Dictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 71
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,19D333A3020
       mov       r8,[r8]
       mov       rdx,19D133AD760
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,19D333A3020
       mov       r8,[r8]
       mov       rdx,19D133AD338
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,19D333A3020
       mov       r8,[r8]
       mov       rdx,19D333A54D8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFA7EF8CD18]
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 161
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = base.PersonProperDictionary.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+138]
       mov       rdi,r8
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r8,[rsp+28]
       mov       r9,[rsp+30]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 105
```
```assembly
; System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rdx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       mov       [rsp+20],rcx
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFA7F0B0340
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L01:
       lea       rcx,[rsp+30]
       lea       r9,[rsp+28]
       mov       rdx,[rsp+20]
       mov       r8,rdi
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+28],0
       je        short M01_L02
       mov       rdx,[rsp+30]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 145
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r8,21478DB3020
       mov       r8,[r8]
       mov       rdx,21478DC1B68
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r14,[rdi+10]
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFA7F0B0CC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,21478DB3020
       mov       r9,[r9]
       mov       r8,21478DC1B68
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,21478DB3020
       mov       r8,[r8]
       mov       rdx,21478DC1740
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,21478DB3020
       mov       r8,[r8]
       mov       rdx,21458DB10D0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFA7F0B0F50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       lea       r8,[rsp+20]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L06
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,7FFA7F0B0FF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L05:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8,rbp
       call      qword ptr [r11]
       mov       [rsp+20],rbp
M02_L06:
       mov       rax,[rsp+20]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 342
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = base.PersonProperDictionary.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+138]
       mov       rdi,r8
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r8,[rsp+28]
       mov       r9,[rsp+30]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 105
```
```assembly
; System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rdx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       mov       [rsp+20],rcx
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFA7F0907F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L01:
       lea       rcx,[rsp+30]
       lea       r9,[rsp+28]
       mov       rdx,[rsp+20]
       mov       r8,rdi
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+28],0
       je        short M01_L02
       mov       rdx,[rsp+30]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 145
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r8,1BBA3961028
       mov       r8,[r8]
       mov       rdx,1BBA3961C08
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r14,[rdi+10]
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFA7F091178
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1BBA3961028
       mov       r9,[r9]
       mov       r8,1BBA3961C08
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,1BBA3961028
       mov       r8,[r8]
       mov       rdx,1BBA39617E0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1BBA3961028
       mov       r8,[r8]
       mov       rdx,1BB939610D0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFA7F091408
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       lea       r8,[rsp+20]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L06
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,7FFA7F0914B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L05:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8,rbp
       call      qword ptr [r11]
       mov       [rsp+20],rbp
M02_L06:
       mov       rax,[rsp+20]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 342
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = base.PersonProperDictionary.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+138]
       mov       rdi,r8
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r8,[rsp+28]
       mov       r9,[rsp+30]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 105
```
```assembly
; System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rdx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       mov       [rsp+20],rcx
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFA7F090858
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L01:
       lea       rcx,[rsp+30]
       lea       r9,[rsp+28]
       mov       rdx,[rsp+20]
       mov       r8,rdi
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+28],0
       je        short M01_L02
       mov       rdx,[rsp+30]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 145
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r8,1AC3EBB3020
       mov       r8,[r8]
       mov       rdx,1AC2EBB17F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r14,[rdi+10]
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFA7F0911D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1AC3EBB3020
       mov       r9,[r9]
       mov       r8,1AC2EBB17F0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,1AC3EBB3020
       mov       r8,[r8]
       mov       rdx,1AC2EBB13C8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1AC3EBB3020
       mov       r8,[r8]
       mov       rdx,1AC3EBB34E0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFA7F091468
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       lea       r8,[rsp+20]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L06
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,7FFA7F091510
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L05:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8,rbp
       call      qword ptr [r11]
       mov       [rsp+20],rbp
M02_L06:
       mov       rax,[rsp+20]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 342
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = base.PersonProperDictionary.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+138]
       mov       rdi,r8
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r8,[rsp+28]
       mov       r9,[rsp+30]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 105
```
```assembly
; System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rdx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       mov       [rsp+20],rcx
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFA7F090810
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L01:
       lea       rcx,[rsp+30]
       lea       r9,[rsp+28]
       mov       rdx,[rsp+20]
       mov       r8,rdi
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+28],0
       je        short M01_L02
       mov       rdx,[rsp+30]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 145
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r8,279D3DA1028
       mov       r8,[r8]
       mov       rdx,279D3DAFB70
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r14,[rdi+10]
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFA7F091190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,279D3DA1028
       mov       r9,[r9]
       mov       r8,279D3DAFB70
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,279D3DA1028
       mov       r8,[r8]
       mov       rdx,279D3DAF748
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,279D3DA1028
       mov       r8,[r8]
       mov       rdx,279D3DAFC68
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFA7F091420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       lea       r8,[rsp+20]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L06
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,7FFA7F0914C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L05:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8,rbp
       call      qword ptr [r11]
       mov       [rsp+20],rbp
M02_L06:
       mov       rax,[rsp+20]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 342
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = base.PersonProperDictionary.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+138]
       mov       rdi,r8
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r8,[rsp+28]
       mov       r9,[rsp+30]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 105
```
```assembly
; System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rdx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       mov       [rsp+20],rcx
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFA7F0A0810
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L01:
       lea       rcx,[rsp+30]
       lea       r9,[rsp+28]
       mov       rdx,[rsp+20]
       mov       r8,rdi
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+28],0
       je        short M01_L02
       mov       rdx,[rsp+30]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 145
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r8,1FBFA323020
       mov       r8,[r8]
       mov       rdx,1FBDA3217F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r14,[rdi+10]
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFA7F0A1190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1FBFA323020
       mov       r9,[r9]
       mov       r8,1FBDA3217F0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,1FBFA323020
       mov       r8,[r8]
       mov       rdx,1FBDA3213C8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1FBFA323020
       mov       r8,[r8]
       mov       rdx,1FBFA331448
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFA7F0A1420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       lea       r8,[rsp+20]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L06
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,7FFA7F0A14C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L05:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8,rbp
       call      qword ptr [r11]
       mov       [rsp+20],rbp
M02_L06:
       mov       rax,[rsp+20]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 342
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = base.PersonProperDictionary.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+138]
       mov       rdi,r8
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r8,[rsp+28]
       mov       r9,[rsp+30]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 105
```
```assembly
; System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rdx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       mov       [rsp+20],rcx
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFA7F0A0810
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L01:
       lea       rcx,[rsp+30]
       lea       r9,[rsp+28]
       mov       rdx,[rsp+20]
       mov       r8,rdi
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+28],0
       je        short M01_L02
       mov       rdx,[rsp+30]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 145
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r8,1E698403020
       mov       r8,[r8]
       mov       rdx,1E6784017F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r14,[rdi+10]
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFA7F0A1190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1E698403020
       mov       r9,[r9]
       mov       r8,1E6784017F0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,1E698403020
       mov       r8,[r8]
       mov       rdx,1E6784013C8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1E698403020
       mov       r8,[r8]
       mov       rdx,1E6A84010D0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFA7F0A1420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       lea       r8,[rsp+20]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L06
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,7FFA7F0A14C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L05:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8,rbp
       call      qword ptr [r11]
       mov       [rsp+20],rbp
M02_L06:
       mov       rax,[rsp+20]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 342
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = base.PersonProperDictionary.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+138]
       mov       rdi,r8
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r8,[rsp+28]
       mov       r9,[rsp+30]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 105
```
```assembly
; System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rdx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       mov       [rsp+20],rcx
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFA7F0C07F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L01:
       lea       rcx,[rsp+30]
       lea       r9,[rsp+28]
       mov       rdx,[rsp+20]
       mov       r8,rdi
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+28],0
       je        short M01_L02
       mov       rdx,[rsp+30]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 145
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r8,20B719D3020
       mov       r8,[r8]
       mov       rdx,20B519D17F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r14,[rdi+10]
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFA7F0C1178
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,20B719D3020
       mov       r9,[r9]
       mov       r8,20B519D17F0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,20B719D3020
       mov       r8,[r8]
       mov       rdx,20B519D13C8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,20B719D3020
       mov       r8,[r8]
       mov       rdx,20B719E1448
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFA7F0C1408
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       lea       r8,[rsp+20]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L06
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,7FFA7F0C14B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L05:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8,rbp
       call      qword ptr [r11]
       mov       [rsp+20],rbp
M02_L06:
       mov       rax,[rsp+20]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 342
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+138]
       mov       r9,[rsi+30]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r8,22D499C1028
       mov       r8,[r8]
       mov       rdx,22D499CFB70
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r14,[rdi+10]
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA7F0B02E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,22D499C1028
       mov       r9,[r9]
       mov       r8,22D499CFB70
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,22D499C1028
       mov       r8,[r8]
       mov       rdx,22D499CF748
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,22D499C1028
       mov       r8,[r8]
       mov       rdx,22D499CFC68
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFA7F0B0578
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       lea       r8,[rsp+20]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L06
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA7F0B0620
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8,rbp
       call      qword ptr [r11]
       mov       [rsp+20],rbp
M01_L06:
       mov       rax,[rsp+20]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 342
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+138]
       mov       r9,[rsi+30]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r8,221EE603020
       mov       r8,[r8]
       mov       rdx,221EE611B68
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r14,[rdi+10]
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA7F0A07C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,221EE603020
       mov       r9,[r9]
       mov       r8,221EE611B68
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,221EE603020
       mov       r8,[r8]
       mov       rdx,221EE611740
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,221EE603020
       mov       r8,[r8]
       mov       rdx,221FE6010D0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFA7F0A0A58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       lea       r8,[rsp+20]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L06
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA7F0A0B00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8,rbp
       call      qword ptr [r11]
       mov       [rsp+20],rbp
M01_L06:
       mov       rax,[rsp+20]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 342
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+138]
       mov       r9,[rsi+30]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r8,2826BAC3020
       mov       r8,[r8]
       mov       rdx,2825BAC17F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r14,[rdi+10]
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA7F090770
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,2826BAC3020
       mov       r9,[r9]
       mov       r8,2825BAC17F0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,2826BAC3020
       mov       r8,[r8]
       mov       rdx,2825BAC13C8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,2826BAC3020
       mov       r8,[r8]
       mov       rdx,2828BAC10D0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFA7F090A00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       lea       r8,[rsp+20]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L06
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA7F090AA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8,rbp
       call      qword ptr [r11]
       mov       [rsp+20],rbp
M01_L06:
       mov       rax,[rsp+20]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 342
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+138]
       mov       r9,[rsi+30]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r8,1ECED363020
       mov       r8,[r8]
       mov       rdx,1ECED371B68
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r14,[rdi+10]
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA7F090748
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1ECED363020
       mov       r9,[r9]
       mov       r8,1ECED371B68
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,1ECED363020
       mov       r8,[r8]
       mov       rdx,1ECED371740
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1ECED363020
       mov       r8,[r8]
       mov       rdx,1ECCD3610D0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFA7F0909D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       lea       r8,[rsp+20]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L06
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA7F090A80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8,rbp
       call      qword ptr [r11]
       mov       [rsp+20],rbp
M01_L06:
       mov       rax,[rsp+20]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 342
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+138]
       mov       r9,[rsi+30]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r8,19AF8323020
       mov       r8,[r8]
       mov       rdx,19AF8325BF8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r14,[rdi+10]
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA7F0B0788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,19AF8323020
       mov       r9,[r9]
       mov       r8,19AF8325BF8
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,19AF8323020
       mov       r8,[r8]
       mov       rdx,19AF83257D0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,19AF8323020
       mov       r8,[r8]
       mov       rdx,19AE83210D0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFA7F0B0A18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       lea       r8,[rsp+20]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L06
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA7F0B0AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8,rbp
       call      qword ptr [r11]
       mov       [rsp+20],rbp
M01_L06:
       mov       rax,[rsp+20]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 342
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+138]
       mov       r9,[rsi+30]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r8,1735D4B3020
       mov       r8,[r8]
       mov       rdx,1733D4B17F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r14,[rdi+10]
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA7F090788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1735D4B3020
       mov       r9,[r9]
       mov       r8,1733D4B17F0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,1735D4B3020
       mov       r8,[r8]
       mov       rdx,1733D4B13C8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1735D4B3020
       mov       r8,[r8]
       mov       rdx,1733D4B18E8
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFA7F090A18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       lea       r8,[rsp+20]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L06
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA7F090AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8,rbp
       call      qword ptr [r11]
       mov       [rsp+20],rbp
M01_L06:
       mov       rax,[rsp+20]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 342
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+138]
       mov       r9,[rsi+30]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r8,27CF4731028
       mov       r8,[r8]
       mov       rdx,27CD47337E8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r14,[rdi+10]
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA7F0C07D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,27CF4731028
       mov       r9,[r9]
       mov       r8,27CD47337E8
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,27CF4731028
       mov       r8,[r8]
       mov       rdx,27CD47333C0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,27CF4731028
       mov       r8,[r8]
       mov       rdx,27D047310D0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFA7F0C0A60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       lea       r8,[rsp+20]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L06
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA7F0C0B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8,rbp
       call      qword ptr [r11]
       mov       [rsp+20],rbp
M01_L06:
       mov       rax,[rsp+20]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 342
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToDelimitedString01()
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
       mov       rax,1C5D8593020
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
       mov       r8,1C5D8591348
       mov       r8,[r8]
       mov       rdx,1C5B859D1A0
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
       mov       rdx,7FFA7F0908C0
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
       mov       rdx,7FFA7F0909B0
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
       mov       rdx,7FFA7F0909B0
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
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToDelimitedString01()
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
       mov       rax,23385A33020
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
       mov       r8,23385A31348
       mov       r8,[r8]
       mov       rdx,23365A31230
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
       mov       rdx,7FFA7F090908
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
       mov       rdx,7FFA7F0909F8
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
       mov       rdx,7FFA7F0909F8
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
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToDelimitedString01()
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
       mov       rax,21B390F3020
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
       mov       r8,21B390F1348
       mov       r8,[r8]
       mov       rdx,21B490F1230
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
       mov       rdx,7FFA7F090D78
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
       mov       rdx,7FFA7F090E68
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
       mov       rdx,7FFA7F090E68
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
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToDelimitedString01()
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
       mov       rax,1E9325E1028
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
       mov       r8,1E9125E1348
       mov       r8,[r8]
       mov       rdx,1E9325EF5B0
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
       mov       rdx,7FFA7F0B0DD8
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
       mov       rdx,7FFA7F0B0EC8
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
       mov       rdx,7FFA7F0B0EC8
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
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToDelimitedString01()
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
       mov       rax,143724A1028
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
       mov       r8,143524A1348
       mov       r8,[r8]
       mov       rdx,143524A3228
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
       mov       rdx,7FFA7F0C0D90
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
       mov       rdx,7FFA7F0C0E80
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
       mov       rdx,7FFA7F0C0E80
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
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToDelimitedString01()
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
       mov       rax,1E87DFB3020
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
       mov       r8,1E87DFB1348
       mov       r8,[r8]
       mov       rdx,1E87DFB5638
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
       mov       rdx,7FFA7F0B0D90
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
       mov       rdx,7FFA7F0B0E80
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
       mov       rdx,7FFA7F0B0E80
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
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToDelimitedString01()
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
       mov       rax,2B356D91028
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
       mov       r8,2B366D91348
       mov       r8,[r8]
       mov       rdx,2B346D91A48
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
       mov       rdx,7FFA7F0A0D78
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
       mov       rdx,7FFA7F0A0E68
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
       mov       rdx,7FFA7F0A0E68
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
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = base.PersonProperDictionary.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+138]
       mov       rdi,r8
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r8,[rsp+28]
       mov       r9,[rsp+30]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.Dictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 105
```
```assembly
; System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rdx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       mov       [rsp+20],rcx
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFA7F0A0338
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L01:
       lea       rcx,[rsp+30]
       lea       r9,[rsp+28]
       mov       rdx,[rsp+20]
       mov       r8,rdi
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+28],0
       je        short M01_L02
       mov       rdx,[rsp+30]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 145
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,281EA6C3020
       mov       r8,[r8]
       mov       rdx,281EA6D1B68
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,281EA6C3020
       mov       r8,[r8]
       mov       rdx,281EA6D1740
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,281EA6C3020
       mov       r8,[r8]
       mov       rdx,281CA6C10D0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFA7EF7CD18]
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 161
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = base.PersonProperDictionary.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+138]
       mov       rdi,r8
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r8,[rsp+28]
       mov       r9,[rsp+30]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.Dictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 105
```
```assembly
; System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rdx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       mov       [rsp+20],rcx
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFA7F0A0850
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L01:
       lea       rcx,[rsp+30]
       lea       r9,[rsp+28]
       mov       rdx,[rsp+20]
       mov       r8,rdi
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+28],0
       je        short M01_L02
       mov       rdx,[rsp+30]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 145
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,1CAC33B3020
       mov       r8,[r8]
       mov       rdx,1CAA33B17F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1CAC33B3020
       mov       r8,[r8]
       mov       rdx,1CAA33B13C8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1CAC33B3020
       mov       r8,[r8]
       mov       rdx,1CAA33B18E8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFA7EF7CD18]
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 161
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = base.PersonProperDictionary.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+138]
       mov       rdi,r8
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r8,[rsp+28]
       mov       r9,[rsp+30]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.Dictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 105
```
```assembly
; System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rdx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       mov       [rsp+20],rcx
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFA7F0B0848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L01:
       lea       rcx,[rsp+30]
       lea       r9,[rsp+28]
       mov       rdx,[rsp+20]
       mov       r8,rdi
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+28],0
       je        short M01_L02
       mov       rdx,[rsp+30]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 145
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,1D048E33020
       mov       r8,[r8]
       mov       rdx,1D058E3F758
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1D048E33020
       mov       r8,[r8]
       mov       rdx,1D058E3F330
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1D048E33020
       mov       r8,[r8]
       mov       rdx,1D058E3F850
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFA7EF8CD18]
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 161
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = base.PersonProperDictionary.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+138]
       mov       rdi,r8
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r8,[rsp+28]
       mov       r9,[rsp+30]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.Dictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 105
```
```assembly
; System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rdx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       mov       [rsp+20],rcx
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFA7F0A0850
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L01:
       lea       rcx,[rsp+30]
       lea       r9,[rsp+28]
       mov       rdx,[rsp+20]
       mov       r8,rdi
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+28],0
       je        short M01_L02
       mov       rdx,[rsp+30]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 145
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,21CDFB33020
       mov       r8,[r8]
       mov       rdx,21CBFB317F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,21CDFB33020
       mov       r8,[r8]
       mov       rdx,21CBFB313C8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,21CDFB33020
       mov       r8,[r8]
       mov       rdx,21CDFB41448
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFA7EF7CD18]
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 161
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = base.PersonProperDictionary.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+138]
       mov       rdi,r8
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r8,[rsp+28]
       mov       r9,[rsp+30]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.Dictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 105
```
```assembly
; System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rdx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       mov       [rsp+20],rcx
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFA7F0C0850
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L01:
       lea       rcx,[rsp+30]
       lea       r9,[rsp+28]
       mov       rdx,[rsp+20]
       mov       r8,rdi
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+28],0
       je        short M01_L02
       mov       rdx,[rsp+30]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 145
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,1B160003020
       mov       r8,[r8]
       mov       rdx,1B160011B68
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1B160003020
       mov       r8,[r8]
       mov       rdx,1B160011740
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1B160003020
       mov       r8,[r8]
       mov       rdx,1B1400010D0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFA7EF9CD18]
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 161
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = base.PersonProperDictionary.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+138]
       mov       rdi,r8
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r8,[rsp+28]
       mov       r9,[rsp+30]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.Dictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 105
```
```assembly
; System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rdx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       mov       [rsp+20],rcx
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFA7F0A0808
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L01:
       lea       rcx,[rsp+30]
       lea       r9,[rsp+28]
       mov       rdx,[rsp+20]
       mov       r8,rdi
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+28],0
       je        short M01_L02
       mov       rdx,[rsp+30]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 145
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,2B1D42C3020
       mov       r8,[r8]
       mov       rdx,2B1D42D1B68
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,2B1D42C3020
       mov       r8,[r8]
       mov       rdx,2B1D42D1740
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,2B1D42C3020
       mov       r8,[r8]
       mov       rdx,2B1D42D1C60
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFA7EF7CD18]
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 161
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = base.PersonProperDictionary.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+138]
       mov       rdi,r8
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r8,[rsp+28]
       mov       r9,[rsp+30]
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.Dictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 105
```
```assembly
; System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rdx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       mov       [rsp+20],rcx
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFA7F0A0808
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rsp+20],rax
M01_L01:
       lea       rcx,[rsp+30]
       lea       r9,[rsp+28]
       mov       rdx,[rsp+20]
       mov       r8,rdi
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+28],0
       je        short M01_L02
       mov       rdx,[rsp+30]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 145
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,1EEF3093020
       mov       r8,[r8]
       mov       rdx,1EEE30917F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1EEF3093020
       mov       r8,[r8]
       mov       rdx,1EEE30913C8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1EEF3093020
       mov       r8,[r8]
       mov       rdx,1EEF30954D8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFA7EF7CD18]
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 161
```

