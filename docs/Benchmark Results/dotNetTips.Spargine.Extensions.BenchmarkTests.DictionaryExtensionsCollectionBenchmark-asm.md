## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.Upsert(this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+0A0]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rbx,[rax+48]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.Dictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 98
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,26CB5043060
       mov       r8,[r8]
       mov       rdx,26CE50411A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,26CB5043060
       mov       r8,[r8]
       mov       rdx,26CD504FDF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,26CB5043060
       mov       r8,[r8]
       mov       rdx,26CD5050280
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB36F0CD20]
       test      eax,eax
       jne       short M01_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       [rsp+28],rbx
M01_L00:
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 186
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.Upsert(this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+0A0]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rbx,[rax+48]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.Dictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 98
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,2F97E643060
       mov       r8,[r8]
       mov       rdx,2F9AE6411A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,2F97E643060
       mov       r8,[r8]
       mov       rdx,2F99E64B388
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,2F97E643060
       mov       r8,[r8]
       mov       rdx,2F99E64B810
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB36F0CD20]
       test      eax,eax
       jne       short M01_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       [rsp+28],rbx
M01_L00:
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 186
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.Upsert(this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+0A0]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rbx,[rax+48]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.Dictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 98
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,178640C3060
       mov       r8,[r8]
       mov       rdx,178940C11A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,178640C3060
       mov       r8,[r8]
       mov       rdx,178640C3808
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,178640C3060
       mov       r8,[r8]
       mov       rdx,178640C3C90
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB36F2CD20]
       test      eax,eax
       jne       short M01_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       [rsp+28],rbx
M01_L00:
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 186
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.Upsert(this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+0A0]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rbx,[rax+48]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.Dictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 98
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,160E0523060
       mov       r8,[r8]
       mov       rdx,160F05211A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,160E0523060
       mov       r8,[r8]
       mov       rdx,160E0532248
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,160E0523060
       mov       r8,[r8]
       mov       rdx,160E05326D0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB36F0CD20]
       test      eax,eax
       jne       short M01_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       [rsp+28],rbx
M01_L00:
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 186
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.Upsert(this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+0A0]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rbx,[rax+48]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.Dictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 98
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,294C8DD3060
       mov       r8,[r8]
       mov       rdx,294C8DD3E28
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,294C8DD3060
       mov       r8,[r8]
       mov       rdx,294C8DD3808
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,294C8DD3060
       mov       r8,[r8]
       mov       rdx,294C8DD3C90
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB36F0CD20]
       test      eax,eax
       jne       short M01_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       [rsp+28],rbx
M01_L00:
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 186
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.Upsert(this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+0A0]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rbx,[rax+48]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.Dictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 98
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,244FCA43060
       mov       r8,[r8]
       mov       rdx,244FCA435F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,244FCA43060
       mov       r8,[r8]
       mov       rdx,2451CA4FDF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,244FCA43060
       mov       r8,[r8]
       mov       rdx,2451CA50280
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB36EFCD20]
       test      eax,eax
       jne       short M01_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       [rsp+28],rbx
M01_L00:
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 186
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.Upsert(this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+0A0]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rbx,[rax+48]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.Dictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 98
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,1F08E833060
       mov       r8,[r8]
       mov       rdx,1F09E8319D8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1F08E833060
       mov       r8,[r8]
       mov       rdx,1F09E8313B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1F08E833060
       mov       r8,[r8]
       mov       rdx,1F09E831840
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB36F1CD20]
       test      eax,eax
       jne       short M01_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       [rsp+28],rbx
M01_L00:
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 186
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.Upsert(this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+0A0]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rbx,[rax+48]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.Dictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 98
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,1C95DEA3060
       mov       r8,[r8]
       mov       rdx,1C96DEA11A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1C95DEA3060
       mov       r8,[r8]
       mov       rdx,1C95DEA3808
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1C95DEA3060
       mov       r8,[r8]
       mov       rdx,1C95DEA3C90
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB36EECD20]
       test      eax,eax
       jne       short M01_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       [rsp+28],rbx
M01_L00:
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 186
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.Upsert(this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+0A0]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rbx,[rax+48]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.Dictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 98
```
```assembly
; dotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,1A8077B3060
       mov       r8,[r8]
       mov       rdx,1A8177B11A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1A8077B3060
       mov       r8,[r8]
       mov       rdx,1A8277B7E40
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1A8077B3060
       mov       r8,[r8]
       mov       rdx,1A8277B82C8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB36F2CD20]
       test      eax,eax
       jne       short M01_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       [rsp+28],rbx
M01_L00:
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 186
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
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
       mov       r8,[rsi+0A0]
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
       mov       rdx,7FFB37010AF8
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
       mov       r8,278B8AA3060
       mov       r8,[r8]
       mov       rdx,278B8AB2868
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
       mov       rdx,7FFB370114C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,278B8AA3060
       mov       r9,[r9]
       mov       r8,278B8AB2868
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,278B8AA3060
       mov       r8,[r8]
       mov       rdx,278B8AB2248
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,278B8AA3060
       mov       r8,[r8]
       mov       rdx,278B8AB26D0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFB37011750
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
       mov       rdx,7FFB370117F8
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
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
       mov       r8,[rsi+0A0]
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
       mov       rdx,7FFB36FE0AF8
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
       mov       r8,19BB0183060
       mov       r8,[r8]
       mov       rdx,19BC01811A0
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
       mov       rdx,7FFB36FE14C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,19BB0183060
       mov       r9,[r9]
       mov       r8,19BC01811A0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,19BB0183060
       mov       r8,[r8]
       mov       rdx,19BB0183808
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,19BB0183060
       mov       r8,[r8]
       mov       rdx,19BB0183C90
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFB36FE1750
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
       mov       rdx,7FFB36FE17F8
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
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
       mov       r8,[rsi+0A0]
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
       mov       rdx,7FFB36FE0AF8
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
       mov       r8,16358F63060
       mov       r8,[r8]
       mov       rdx,16378F6FBE0
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
       mov       rdx,7FFB36FE14C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,16358F63060
       mov       r9,[r9]
       mov       r8,16378F6FBE0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,16358F63060
       mov       r8,[r8]
       mov       rdx,16358F63808
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,16358F63060
       mov       r8,[r8]
       mov       rdx,16358F63C90
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFB36FE1750
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
       mov       rdx,7FFB36FE17F8
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
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
       mov       r8,[rsi+0A0]
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
       mov       rdx,7FFB36FF0CE0
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
       mov       r8,20F15A73060
       mov       r8,[r8]
       mov       rdx,20F15A82868
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
       mov       rdx,7FFB36FF16A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,20F15A73060
       mov       r9,[r9]
       mov       r8,20F15A82868
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,20F15A73060
       mov       r8,[r8]
       mov       rdx,20F15A82248
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,20F15A73060
       mov       r8,[r8]
       mov       rdx,20F15A826D0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFB36FF1938
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
       mov       rdx,7FFB36FF19E0
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
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
       mov       r8,[rsi+0A0]
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
       mov       rdx,7FFB37000CE0
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
       mov       r8,1D67FD01048
       mov       r8,[r8]
       mov       rdx,1D67FD10018
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
       mov       rdx,7FFB370016A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1D67FD01048
       mov       r9,[r9]
       mov       r8,1D67FD10018
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,1D67FD01048
       mov       r8,[r8]
       mov       rdx,1D69FD013B8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1D67FD01048
       mov       r8,[r8]
       mov       rdx,1D69FD01840
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFB37001938
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
       mov       rdx,7FFB370019E0
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
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
       mov       r8,[rsi+0A0]
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
       mov       rdx,7FFB37000D88
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
       mov       r8,20AF5603060
       mov       r8,[r8]
       mov       rdx,20B256011A0
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
       mov       rdx,7FFB37001750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,20AF5603060
       mov       r9,[r9]
       mov       r8,20B256011A0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,20AF5603060
       mov       r8,[r8]
       mov       rdx,20AF5603808
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,20AF5603060
       mov       r8,[r8]
       mov       rdx,20AF5603C90
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFB370019E0
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
       mov       rdx,7FFB37001A88
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
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
       mov       r8,[rsi+0A0]
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
       mov       rdx,7FFB36FF0F68
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
       mov       r8,1E1EBAF3060
       mov       r8,[r8]
       mov       rdx,1E1FBAF11A0
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
       mov       rdx,7FFB36FF1930
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1E1EBAF3060
       mov       r9,[r9]
       mov       r8,1E1FBAF11A0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,1E1EBAF3060
       mov       r8,[r8]
       mov       rdx,1E1EBB02248
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1E1EBAF3060
       mov       r8,[r8]
       mov       rdx,1E1EBB026D0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFB36FF1BC0
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
       mov       rdx,7FFB36FF1C68
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
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
       mov       r8,[rsi+0A0]
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
       mov       rdx,7FFB36FF0F68
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
       mov       r8,1CED2B73060
       mov       r8,[r8]
       mov       rdx,1CED2BB1E28
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
       mov       rdx,7FFB36FF1930
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1CED2B73060
       mov       r9,[r9]
       mov       r8,1CED2BB1E28
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,1CED2B73060
       mov       r8,[r8]
       mov       rdx,1CEC2B713B8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1CED2B73060
       mov       r8,[r8]
       mov       rdx,1CEC2B71840
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFB36FF1BC0
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
       mov       rdx,7FFB36FF1C68
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
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
       mov       r8,[rsi+0A0]
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
       mov       rdx,7FFB36FE0AF8
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
       mov       r8,16299553060
       mov       r8,[r8]
       mov       rdx,162B955FBE0
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
       mov       rdx,7FFB36FE14C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,16299553060
       mov       r9,[r9]
       mov       r8,162B955FBE0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,16299553060
       mov       r8,[r8]
       mov       rdx,16299553808
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,16299553060
       mov       r8,[r8]
       mov       rdx,16299553C90
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFB36FE1750
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
       mov       rdx,7FFB36FE17F8
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+0A0]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rbx,[rax+48]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 98
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
       mov       r8,136AEA33060
       mov       r8,[r8]
       mov       rdx,136BEA3FBE0
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
       mov       rdx,7FFB37000A88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,136AEA33060
       mov       r9,[r9]
       mov       r8,136BEA3FBE0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,136AEA33060
       mov       r8,[r8]
       mov       rdx,136AEA33808
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,136AEA33060
       mov       r8,[r8]
       mov       rdx,136AEA33C90
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB37000D18
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
       mov       rdx,7FFB37000DC0
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+0A0]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rbx,[rax+48]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 98
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
       mov       r8,1D67CDB3060
       mov       r8,[r8]
       mov       rdx,1D68CDB11A0
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
       mov       rdx,7FFB36FF0AE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1D67CDB3060
       mov       r9,[r9]
       mov       r8,1D68CDB11A0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,1D67CDB3060
       mov       r8,[r8]
       mov       rdx,1D67CDB5820
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1D67CDB3060
       mov       r8,[r8]
       mov       rdx,1D67CDB5CA8
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0D78
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
       mov       rdx,7FFB36FF0E20
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+0A0]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rbx,[rax+48]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 98
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
       mov       r8,1E0A3CC3060
       mov       r8,[r8]
       mov       rdx,1E0B3CC11A0
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
       mov       rdx,7FFB37010B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1E0A3CC3060
       mov       r9,[r9]
       mov       r8,1E0B3CC11A0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,1E0A3CC3060
       mov       r8,[r8]
       mov       rdx,1E0A3CD2248
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1E0A3CC3060
       mov       r8,[r8]
       mov       rdx,1E0A3CD26D0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB37010D98
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
       mov       rdx,7FFB37010E40
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+0A0]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rbx,[rax+48]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 98
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
       mov       r8,2DEEF533060
       mov       r8,[r8]
       mov       rdx,2DF1F5311A0
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
       mov       rdx,7FFB36FF0EF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,2DEEF533060
       mov       r9,[r9]
       mov       r8,2DF1F5311A0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,2DEEF533060
       mov       r8,[r8]
       mov       rdx,2DEEF542248
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,2DEEF533060
       mov       r8,[r8]
       mov       rdx,2DEEF5426D0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB36FF1188
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
       mov       rdx,7FFB36FF1230
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+0A0]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rbx,[rax+48]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 98
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
       mov       r8,21245543060
       mov       r8,[r8]
       mov       rdx,212755411A0
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
       mov       rdx,7FFB37010C70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,21245543060
       mov       r9,[r9]
       mov       r8,212755411A0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,21245543060
       mov       r8,[r8]
       mov       rdx,2126554FDF8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,21245543060
       mov       r8,[r8]
       mov       rdx,21265550280
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB37010F00
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
       mov       rdx,7FFB37010FA8
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+0A0]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rbx,[rax+48]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 98
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
       mov       r8,23B01401048
       mov       r8,[r8]
       mov       rdx,23AF14031B8
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
       mov       rdx,7FFB36FE0EF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,23B01401048
       mov       r9,[r9]
       mov       r8,23AF14031B8
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,23B01401048
       mov       r8,[r8]
       mov       rdx,23AE14013B8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,23B01401048
       mov       r8,[r8]
       mov       rdx,23AE1401840
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB36FE1188
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
       mov       rdx,7FFB36FE1230
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+0A0]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rbx,[rax+48]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 98
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
       mov       r8,2B4D6133060
       mov       r8,[r8]
       mov       rdx,2B4D6152A28
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
       mov       rdx,7FFB37000EF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,2B4D6133060
       mov       r9,[r9]
       mov       r8,2B4D6152A28
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,2B4D6133060
       mov       r8,[r8]
       mov       rdx,2B4F613FDF8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,2B4D6133060
       mov       r8,[r8]
       mov       rdx,2B4F6140280
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB37001188
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
       mov       rdx,7FFB37001230
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+0A0]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rbx,[rax+48]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 98
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
       mov       r8,14FC2D13060
       mov       r8,[r8]
       mov       rdx,14FD2D111A0
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
       mov       rdx,7FFB36FF0EF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,14FC2D13060
       mov       r9,[r9]
       mov       r8,14FD2D111A0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,14FC2D13060
       mov       r8,[r8]
       mov       rdx,14FE2D1FDF8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,14FC2D13060
       mov       r8,[r8]
       mov       rdx,14FE2D20280
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB36FF1188
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
       mov       rdx,7FFB36FF1230
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionaryNew()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper.Id, this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+0A0]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rbx,[rax+48]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      dotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 98
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
       mov       r8,204C1841048
       mov       r8,[r8]
       mov       rdx,204D18419D8
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
       mov       rdx,7FFB36FF0AE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,204C1841048
       mov       r9,[r9]
       mov       r8,204D18419D8
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r8,204C1841048
       mov       r8,[r8]
       mov       rdx,204D18413B8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,204C1841048
       mov       r8,[r8]
       mov       rdx,204D1841840
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0D78
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
       mov       rdx,7FFB36FF0E20
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
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
       mov       rdx,[rsi+0A0]
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       mov       [rbp+0FF80],rsp
       mov       [rbp+0FFE0],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       rsi,rdx
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,24AB8143060
       mov       rax,[rax]
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFB36F751E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24AD814A030
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FF90],rax
       lea       rdx,[rbp+0FFB8]
       mov       rcx,rsi
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       short M01_L02
M01_L01:
       lea       rax,[rbp+0FFD0]
       mov       rsi,[rax]
       mov       rdi,[rax+8]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       movzx     ebx,word ptr [rbp+20]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],bx
       mov       r8,24AB8141368
       mov       r8,[r8]
       mov       rbx,[rbp+0FF90]
       mov       rdx,24AC81419D8
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF98]
       mov       [rcx],rsi
       mov       [rcx+8],rdi
       mov       [rcx+10],rax
       mov       [rcx+18],r8
       lea       r8,[rbp+0FF98]
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
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
       mov       rdx,7FFB37000D10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       lea       rcx,[rbp+0FFB8]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB37000E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB8]
       call      rax
       mov       r8,[rbp+0FF90]
       mov       r8d,[r8+1C]
       mov       rcx,[rbp+0FF90]
       mov       ecx,[rcx+18]
       lea       r8d,[r8+rcx+0FFFF]
       mov       rcx,[rbp+0FF90]
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       mov       rsi,rax
       mov       rcx,24AD814A030
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       lea       rsp,[rbp+0FFE8]
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
       lea       rbp,[rbp+0A0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+28],0
       je        short M01_L07
       mov       rax,[rsi+28]
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB37000E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       lea       rcx,[rbp+0FFB8]
       call      rax
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
       lea       rbp,[rbp+0A0]
       mov       rcx,7FFB36F751E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24AD814A030
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 594
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
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
       mov       rdx,[rsi+0A0]
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       mov       [rbp+0FF80],rsp
       mov       [rbp+0FFE0],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       rsi,rdx
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,1690F541048
       mov       rax,[rax]
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFB36F851E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1691F54A030
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FF90],rax
       lea       rdx,[rbp+0FFB8]
       mov       rcx,rsi
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       short M01_L02
M01_L01:
       lea       rax,[rbp+0FFD0]
       mov       rsi,[rax]
       mov       rdi,[rax+8]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       movzx     ebx,word ptr [rbp+20]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],bx
       mov       r8,168FF541368
       mov       r8,[r8]
       mov       rbx,[rbp+0FF90]
       mov       rdx,1690F5415D8
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF98]
       mov       [rcx],rsi
       mov       [rcx+8],rdi
       mov       [rcx+10],rax
       mov       [rcx+18],r8
       lea       r8,[rbp+0FF98]
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
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
       mov       rdx,7FFB37010FA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       lea       rcx,[rbp+0FFB8]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB37011090
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB8]
       call      rax
       mov       r8,[rbp+0FF90]
       mov       r8d,[r8+1C]
       mov       rcx,[rbp+0FF90]
       mov       ecx,[rcx+18]
       lea       r8d,[r8+rcx+0FFFF]
       mov       rcx,[rbp+0FF90]
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       mov       rsi,rax
       mov       rcx,1691F54A030
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       lea       rsp,[rbp+0FFE8]
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
       lea       rbp,[rbp+0A0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+28],0
       je        short M01_L07
       mov       rax,[rsi+28]
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB37011090
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       lea       rcx,[rbp+0FFB8]
       call      rax
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
       lea       rbp,[rbp+0A0]
       mov       rcx,7FFB36F851E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1691F54A030
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 594
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
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
       mov       rdx,[rsi+0A0]
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       mov       [rbp+0FF80],rsp
       mov       [rbp+0FFE0],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       rsi,rdx
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,16E78B33060
       mov       rax,[rax]
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFB36F851E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,16E78B3C480
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FF90],rax
       lea       rdx,[rbp+0FFB8]
       mov       rcx,rsi
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       short M01_L02
M01_L01:
       lea       rax,[rbp+0FFD0]
       mov       rsi,[rax]
       mov       rdi,[rax+8]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       movzx     ebx,word ptr [rbp+20]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],bx
       mov       r8,16E78B31368
       mov       r8,[r8]
       mov       rbx,[rbp+0FF90]
       mov       rdx,16E78B42030
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF98]
       mov       [rcx],rsi
       mov       [rcx+8],rdi
       mov       [rcx+10],rax
       mov       [rcx+18],r8
       lea       r8,[rbp+0FF98]
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
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
       mov       rdx,7FFB37010D70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       lea       rcx,[rbp+0FFB8]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB37010E60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB8]
       call      rax
       mov       r8,[rbp+0FF90]
       mov       r8d,[r8+1C]
       mov       rcx,[rbp+0FF90]
       mov       ecx,[rcx+18]
       lea       r8d,[r8+rcx+0FFFF]
       mov       rcx,[rbp+0FF90]
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       mov       rsi,rax
       mov       rcx,16E78B3C480
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       lea       rsp,[rbp+0FFE8]
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
       lea       rbp,[rbp+0A0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+28],0
       je        short M01_L07
       mov       rax,[rsi+28]
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB37010E60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       lea       rcx,[rbp+0FFB8]
       call      rax
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
       lea       rbp,[rbp+0A0]
       mov       rcx,7FFB36F851E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,16E78B3C480
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 594
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
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
       mov       rdx,[rsi+0A0]
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       mov       [rbp+0FF80],rsp
       mov       [rbp+0FFE0],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       rsi,rdx
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,26933C53060
       mov       rax,[rax]
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFB36F551E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,26953C5A030
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FF90],rax
       lea       rdx,[rbp+0FFB8]
       mov       rcx,rsi
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       short M01_L02
M01_L01:
       lea       rax,[rbp+0FFD0]
       mov       rsi,[rax]
       mov       rdi,[rax+8]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       movzx     ebx,word ptr [rbp+20]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],bx
       mov       r8,26933C51368
       mov       r8,[r8]
       mov       rbx,[rbp+0FF90]
       mov       rdx,26943C519D8
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF98]
       mov       [rcx],rsi
       mov       [rcx+8],rdi
       mov       [rcx+10],rax
       mov       [rcx+18],r8
       lea       r8,[rbp+0FF98]
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
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
       mov       rdx,7FFB36FE0D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       lea       rcx,[rbp+0FFB8]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FE0E80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB8]
       call      rax
       mov       r8,[rbp+0FF90]
       mov       r8d,[r8+1C]
       mov       rcx,[rbp+0FF90]
       mov       ecx,[rcx+18]
       lea       r8d,[r8+rcx+0FFFF]
       mov       rcx,[rbp+0FF90]
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       mov       rsi,rax
       mov       rcx,26953C5A030
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       lea       rsp,[rbp+0FFE8]
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
       lea       rbp,[rbp+0A0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+28],0
       je        short M01_L07
       mov       rax,[rsi+28]
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FE0E80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       lea       rcx,[rbp+0FFB8]
       call      rax
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
       lea       rbp,[rbp+0A0]
       mov       rcx,7FFB36F551E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,26953C5A030
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 594
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
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
       mov       rdx,[rsi+0A0]
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       mov       [rbp+0FF80],rsp
       mov       [rbp+0FFE0],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       rsi,rdx
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,22AE54F3060
       mov       rax,[rax]
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFB36F851E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,22AF54FA030
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FF90],rax
       lea       rdx,[rbp+0FFB8]
       mov       rcx,rsi
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       short M01_L02
M01_L01:
       lea       rax,[rbp+0FFD0]
       mov       rsi,[rax]
       mov       rdi,[rax+8]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       movzx     ebx,word ptr [rbp+20]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],bx
       mov       r8,22AE54F1368
       mov       r8,[r8]
       mov       rbx,[rbp+0FF90]
       mov       rdx,22B054F11A0
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF98]
       mov       [rcx],rsi
       mov       [rcx+8],rdi
       mov       [rcx+10],rax
       mov       [rcx+18],r8
       lea       r8,[rbp+0FF98]
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
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
       mov       rdx,7FFB37010D10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       lea       rcx,[rbp+0FFB8]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB37010E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB8]
       call      rax
       mov       r8,[rbp+0FF90]
       mov       r8d,[r8+1C]
       mov       rcx,[rbp+0FF90]
       mov       ecx,[rcx+18]
       lea       r8d,[r8+rcx+0FFFF]
       mov       rcx,[rbp+0FF90]
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       mov       rsi,rax
       mov       rcx,22AF54FA030
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       lea       rsp,[rbp+0FFE8]
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
       lea       rbp,[rbp+0A0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+28],0
       je        short M01_L07
       mov       rax,[rsi+28]
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB37010E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       lea       rcx,[rbp+0FFB8]
       call      rax
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
       lea       rbp,[rbp+0A0]
       mov       rcx,7FFB36F851E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,22AF54FA030
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 594
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
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
       mov       rdx,[rsi+0A0]
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       mov       [rbp+0FF80],rsp
       mov       [rbp+0FFE0],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       rsi,rdx
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,256798E3060
       mov       rax,[rax]
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFB36F651E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,256698E8018
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FF90],rax
       lea       rdx,[rbp+0FFB8]
       mov       rcx,rsi
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       short M01_L02
M01_L01:
       lea       rax,[rbp+0FFD0]
       mov       rsi,[rax]
       mov       rdi,[rax+8]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       movzx     ebx,word ptr [rbp+20]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],bx
       mov       r8,256798E1368
       mov       r8,[r8]
       mov       rbx,[rbp+0FF90]
       mov       rdx,256898E11A0
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF98]
       mov       [rcx],rsi
       mov       [rcx+8],rdi
       mov       [rcx+10],rax
       mov       [rcx+18],r8
       lea       r8,[rbp+0FF98]
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
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
       mov       rdx,7FFB36FF1180
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       lea       rcx,[rbp+0FFB8]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF1270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB8]
       call      rax
       mov       r8,[rbp+0FF90]
       mov       r8d,[r8+1C]
       mov       rcx,[rbp+0FF90]
       mov       ecx,[rcx+18]
       lea       r8d,[r8+rcx+0FFFF]
       mov       rcx,[rbp+0FF90]
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       mov       rsi,rax
       mov       rcx,256698E8018
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       lea       rsp,[rbp+0FFE8]
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
       lea       rbp,[rbp+0A0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+28],0
       je        short M01_L07
       mov       rax,[rsi+28]
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF1270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       lea       rcx,[rbp+0FFB8]
       call      rax
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
       lea       rbp,[rbp+0A0]
       mov       rcx,7FFB36F651E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,256698E8018
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 594
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
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
       mov       rdx,[rsi+0A0]
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       mov       [rbp+0FF80],rsp
       mov       [rbp+0FFE0],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       rsi,rdx
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,1A185A23060
       mov       rax,[rax]
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFB36F651E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1A1A5A2A030
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FF90],rax
       lea       rdx,[rbp+0FFB8]
       mov       rcx,rsi
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       short M01_L02
M01_L01:
       lea       rax,[rbp+0FFD0]
       mov       rsi,[rax]
       mov       rdi,[rax+8]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       movzx     ebx,word ptr [rbp+20]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],bx
       mov       r8,1A185A21368
       mov       r8,[r8]
       mov       rbx,[rbp+0FF90]
       mov       rdx,1A195A211A0
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF98]
       mov       [rcx],rsi
       mov       [rcx+8],rdi
       mov       [rcx+10],rax
       mov       [rcx+18],r8
       lea       r8,[rbp+0FF98]
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
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
       mov       rdx,7FFB36FF0D10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       lea       rcx,[rbp+0FFB8]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF0E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB8]
       call      rax
       mov       r8,[rbp+0FF90]
       mov       r8d,[r8+1C]
       mov       rcx,[rbp+0FF90]
       mov       ecx,[rcx+18]
       lea       r8d,[r8+rcx+0FFFF]
       mov       rcx,[rbp+0FF90]
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       mov       rsi,rax
       mov       rcx,1A1A5A2A030
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       lea       rsp,[rbp+0FFE8]
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
       lea       rbp,[rbp+0A0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+28],0
       je        short M01_L07
       mov       rax,[rsi+28]
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB36FF0E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       lea       rcx,[rbp+0FFB8]
       call      rax
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
       lea       rbp,[rbp+0A0]
       mov       rcx,7FFB36F651E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1A1A5A2A030
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 594
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
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
       mov       rdx,[rsi+0A0]
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       mov       [rbp+0FF80],rsp
       mov       [rbp+0FFE0],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       rsi,rdx
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,23301E63060
       mov       rax,[rax]
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFB36F851E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23331E6A030
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FF90],rax
       lea       rdx,[rbp+0FFB8]
       mov       rcx,rsi
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       short M01_L02
M01_L01:
       lea       rax,[rbp+0FFD0]
       mov       rsi,[rax]
       mov       rdi,[rax+8]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       movzx     ebx,word ptr [rbp+20]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],bx
       mov       r8,23301E61368
       mov       r8,[r8]
       mov       rbx,[rbp+0FF90]
       mov       rdx,23311E611A0
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF98]
       mov       [rcx],rsi
       mov       [rcx+8],rdi
       mov       [rcx+10],rax
       mov       [rcx+18],r8
       lea       r8,[rbp+0FF98]
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
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
       mov       rdx,7FFB37010D10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       lea       rcx,[rbp+0FFB8]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB37010E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB8]
       call      rax
       mov       r8,[rbp+0FF90]
       mov       r8d,[r8+1C]
       mov       rcx,[rbp+0FF90]
       mov       ecx,[rcx+18]
       lea       r8d,[r8+rcx+0FFFF]
       mov       rcx,[rbp+0FF90]
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       mov       rsi,rax
       mov       rcx,23331E6A030
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       lea       rsp,[rbp+0FFE8]
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
       lea       rbp,[rbp+0A0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+28],0
       je        short M01_L07
       mov       rax,[rsi+28]
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB37010E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       lea       rcx,[rbp+0FFB8]
       call      rax
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
       lea       rbp,[rbp+0A0]
       mov       rcx,7FFB36F851E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23331E6A030
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 594
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
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
       mov       rdx,[rsi+0A0]
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       mov       [rbp+0FF80],rsp
       mov       [rbp+0FFE0],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       rsi,rdx
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,15AEA763060
       mov       rax,[rax]
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFB36F851E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,15B0A76A030
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FF90],rax
       lea       rdx,[rbp+0FFB8]
       mov       rcx,rsi
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       short M01_L02
M01_L01:
       lea       rax,[rbp+0FFD0]
       mov       rsi,[rax]
       mov       rdi,[rax+8]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       movzx     ebx,word ptr [rbp+20]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],bx
       mov       r8,15AEA761368
       mov       r8,[r8]
       mov       rbx,[rbp+0FF90]
       mov       rdx,15AFA7611A0
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF98]
       mov       [rcx],rsi
       mov       [rcx+8],rdi
       mov       [rcx+10],rax
       mov       [rcx+18],r8
       lea       r8,[rbp+0FF98]
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
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
       mov       rdx,7FFB37010FA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       lea       rcx,[rbp+0FFB8]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB37011090
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB8]
       call      rax
       mov       r8,[rbp+0FF90]
       mov       r8d,[r8+1C]
       mov       rcx,[rbp+0FF90]
       mov       ecx,[rcx+18]
       lea       r8d,[r8+rcx+0FFFF]
       mov       rcx,[rbp+0FF90]
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       mov       rsi,rax
       mov       rcx,15B0A76A030
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       lea       rsp,[rbp+0FFE8]
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
       lea       rbp,[rbp+0A0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+28],0
       je        short M01_L07
       mov       rax,[rsi+28]
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB37011090
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       lea       rcx,[rbp+0FFB8]
       call      rax
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
       lea       rbp,[rbp+0A0]
       mov       rcx,7FFB36F851E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,15B0A76A030
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 594
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = base.PersonProperDictionary.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.Upsert(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+0A0]
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
       mov       rdx,7FFB36FF0AF8
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
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,1C3CA0A3060
       mov       r8,[r8]
       mov       rdx,1C3DA0A11A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1C3CA0A3060
       mov       r8,[r8]
       mov       rdx,1C3CA0A5820
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1C3CA0A3060
       mov       r8,[r8]
       mov       rdx,1C3CA0A5CA8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB36F0CD20]
       test      eax,eax
       jne       short M02_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       [rsp+28],rbx
M02_L00:
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 186
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = base.PersonProperDictionary.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.Upsert(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+0A0]
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
       mov       rdx,7FFB36FE0D88
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
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,27798DF3060
       mov       r8,[r8]
       mov       rdx,27798DF5608
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,27798DF3060
       mov       r8,[r8]
       mov       rdx,277A8DF13B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,27798DF3060
       mov       r8,[r8]
       mov       rdx,277A8DF1840
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB36EFCD20]
       test      eax,eax
       jne       short M02_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       [rsp+28],rbx
M02_L00:
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 186
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = base.PersonProperDictionary.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.Upsert(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+0A0]
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
       mov       rdx,7FFB36FE0B78
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
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,251A0173060
       mov       r8,[r8]
       mov       rdx,251B01711A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,251A0173060
       mov       r8,[r8]
       mov       rdx,251A0173808
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,251A0173060
       mov       r8,[r8]
       mov       rdx,251A0173C90
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB36EFCD20]
       test      eax,eax
       jne       short M02_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       [rsp+28],rbx
M02_L00:
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 186
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = base.PersonProperDictionary.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.Upsert(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+0A0]
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
       mov       rdx,7FFB36FF0CE0
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
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,2E655311048
       mov       r8,[r8]
       mov       rdx,2E6553115D8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,2E655311048
       mov       r8,[r8]
       mov       rdx,2E6453113B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,2E655311048
       mov       r8,[r8]
       mov       rdx,2E645311840
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB36F0CD20]
       test      eax,eax
       jne       short M02_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       [rsp+28],rbx
M02_L00:
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 186
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = base.PersonProperDictionary.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.Upsert(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+0A0]
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
       mov       rdx,7FFB37010CE0
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
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,163DA383060
       mov       r8,[r8]
       mov       rdx,163DA383E28
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,163DA383060
       mov       r8,[r8]
       mov       rdx,163DA383808
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,163DA383060
       mov       r8,[r8]
       mov       rdx,163DA383C90
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB36F2CD20]
       test      eax,eax
       jne       short M02_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       [rsp+28],rbx
M02_L00:
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 186
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = base.PersonProperDictionary.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.Upsert(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+0A0]
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
       mov       rdx,7FFB37010CE8
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
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,1B5D4333060
       mov       r8,[r8]
       mov       rdx,1B5D43335F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1B5D4333060
       mov       r8,[r8]
       mov       rdx,1B5F433FDF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1B5D4333060
       mov       r8,[r8]
       mov       rdx,1B5F4340280
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB36F2CD20]
       test      eax,eax
       jne       short M02_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       [rsp+28],rbx
M02_L00:
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 186
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = base.PersonProperDictionary.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.Upsert(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+0A0]
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
       mov       rdx,7FFB36FD0F68
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
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,20DC0033060
       mov       r8,[r8]
       mov       rdx,20DD00319D8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,20DC0033060
       mov       r8,[r8]
       mov       rdx,20DD00313B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,20DC0033060
       mov       r8,[r8]
       mov       rdx,20DD0031840
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB36EECD20]
       test      eax,eax
       jne       short M02_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       [rsp+28],rbx
M02_L00:
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 186
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = base.PersonProperDictionary.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.Upsert(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+0A0]
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
       mov       rdx,7FFB37000F68
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
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,2655B593060
       mov       r8,[r8]
       mov       rdx,2656B5919D8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,2655B593060
       mov       r8,[r8]
       mov       rdx,2656B5913B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,2655B593060
       mov       r8,[r8]
       mov       rdx,2656B591840
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB36F1CD20]
       test      eax,eax
       jne       short M02_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       [rsp+28],rbx
M02_L00:
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 186
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = base.PersonProperDictionary.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.Upsert(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+0A0]
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
       mov       rdx,7FFB37010D88
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
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r8,16398943060
       mov       r8,[r8]
       mov       rdx,16398945608
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,16398943060
       mov       r8,[r8]
       mov       rdx,163A89413B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,16398943060
       mov       r8,[r8]
       mov       rdx,163A8941840
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB36F2CD20]
       test      eax,eax
       jne       short M02_L00
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       [rsp+28],rbx
M02_L00:
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 186
```

